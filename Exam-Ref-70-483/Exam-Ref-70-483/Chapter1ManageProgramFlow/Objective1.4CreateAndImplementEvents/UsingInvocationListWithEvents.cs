using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._4CreateAndImplementEvents
{
	public class UsingInvocationListWithEvents
	{
		private void CreateAndRaise()
		{
			var p = new Pub();
			p.OnChange += (sender, e)
				=> Console.WriteLine("Subscriber 1 called");
			p.OnChange += (sender, e)
				=> { throw new Exception(); };
			p.OnChange += (sender, e)
				=> Console.WriteLine("Subscriber 3 called");
			try
			{
				p.Raise();
			}
			catch (AggregateException ex)
			{
				Console.WriteLine(ex.InnerExceptions.Count);
			}
		}

		private class Pub
		{
			public event EventHandler OnChange = delegate { };

			public void Raise()
			{
				var exceptions = new List<Exception>();
				foreach (var handler in OnChange.GetInvocationList())
				{
					try
					{
						handler.DynamicInvoke(this, EventArgs.Empty);
					}
					catch (Exception ex)
					{
						exceptions.Add(ex);
					}
				}
				if (exceptions.Any())
				{
					throw new AggregateException(exceptions);
				}
			}
		}

		// Subscriber 1 called
		// Displays
		// Subscriber 3 called
		// 1
	}
}