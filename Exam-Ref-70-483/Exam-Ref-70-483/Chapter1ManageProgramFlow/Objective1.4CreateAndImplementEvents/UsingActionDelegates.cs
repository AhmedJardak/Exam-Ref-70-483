using System;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._4CreateAndImplementEvents
{
	public class UsingActionDelegates
	{
		void Execute()
		{
			Action<int, int> calc = (x, y) =>
			{
				Console.WriteLine(x + y);
			};
			calc(3, 4); // Displays 7
		}
	}
}