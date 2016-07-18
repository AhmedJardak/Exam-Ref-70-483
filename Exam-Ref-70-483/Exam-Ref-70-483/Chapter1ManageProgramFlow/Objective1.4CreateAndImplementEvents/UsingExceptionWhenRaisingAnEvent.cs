using System;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._4CreateAndImplementEvents
{
	public class UsingExceptionWhenRaisingAnEvent
	{
		public class Pub
		{
			public event EventHandler OnChange = delegate { };
			public void Raise()
			{
				OnChange(this, EventArgs.Empty);
			}
		}
		public void CreateAndRaise()
		{
			Pub p = new Pub();
			p.OnChange += (sender, e)
			=> Console.WriteLine("Subscriber 1 called");
			p.OnChange += (sender, e)
			=> { throw new Exception(); };
			p.OnChange += (sender, e)
			=> Console.WriteLine("Subscriber 3 called");
			p.Raise();
		}
		// Displays
		// Subscriber 1 called
	}
}