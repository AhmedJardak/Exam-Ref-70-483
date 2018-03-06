using System;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._4CreateAndImplementEvents
{
	public class Pub
	{
		public Action OnChange { get; set; }

		public void Raise()
		{
            if (OnChange != null)
            {
                OnChange.Invoke();
            }
		}
	
	}
	
	public class UsingEvents
	{
		public void CreateAndRaise()
		{
			Pub p = new Pub();
			p.OnChange += () => Console.WriteLine("Event raised to method 1");
			p.OnChange += () => Console.WriteLine("Event raised to method 2");
			p.Raise();
		}
		public static void Execute()
		{
			
		}
	}
}