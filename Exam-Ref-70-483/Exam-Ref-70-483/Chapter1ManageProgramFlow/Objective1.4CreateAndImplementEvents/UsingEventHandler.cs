using System;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._4CreateAndImplementEvents
{
	internal class UsingEventHandler
	{
		private class MyArgs : EventArgs
		{
			public MyArgs(int value)
			{
				Value = value;
			}

			internal int Value { get; set; }
		}

		private class Pub
		{
			public event EventHandler<MyArgs> OnChange = delegate { };
			public void Raise()
			{
				OnChange(this, new MyArgs(42));
			}
		}

		private void CreateAndRaise()
		{
			Pub p = new Pub();
			p.OnChange += (sender, e)
			=> Console.WriteLine("Event raised: {0}", e.Value);
			p.Raise();
		}
	}
}