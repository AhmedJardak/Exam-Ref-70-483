using System;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._4CreateAndImplementEvents
{
	public class UsingMultiCastDelegates
	{
		private static void MethodOne()
		{
			Console.WriteLine("MethodOne");
		}

		private static void MethodTwo()
		{
			Console.WriteLine("MethodTwo");
		}

		private delegate void Del();
		public static void Execute()
		{
			Del d = MethodOne;
			d += MethodTwo;
			d();
		}
		// Displays
		// MethodOne
		// MethodTwo
	}
}