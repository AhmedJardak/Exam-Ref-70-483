using System;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._4CreateAndImplementEvents
{
	

	public class UsingDelegates
	{
		private delegate int Calculate(int x, int y);

		private static int Add(int x, int y)
		{
			return x + y;
		}

		private static int Multiply(int x, int y)
		{
			return x*y;
		}

		public static void Execute()
		{
			Calculate calc = Add;
			Console.WriteLine(calc(3, 4)); // Displays 7
			calc = Multiply;
			Console.WriteLine(calc(3, 4)); // Displays 12
		}
	}
}