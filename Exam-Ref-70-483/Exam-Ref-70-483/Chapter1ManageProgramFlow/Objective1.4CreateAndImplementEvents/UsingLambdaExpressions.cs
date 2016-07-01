using System;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._4CreateAndImplementEvents
{
	public class UsingLambdaExpressions
	{
		public static void Execute()
		{
			Calculate calc = (x, y) => x + y;
			Console.WriteLine(calc(3, 4)); // Displays 7
			calc = (x, y) => x*y;
			Console.WriteLine(calc(3, 4)); // Displays 12
			calc = (x, y) =>
			{
				Console.WriteLine("Adding numbers");
				return x + y;
			};
			Console.WriteLine(calc(3, 4));
		}

		private delegate int Calculate(int x, int y);
	}
}