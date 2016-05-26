using System;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._3ImplementProgramFlow
{
	internal class CodeBlockAndScoping
	{
		public static void Execute()
		{
			var b = true;
				var r = 42;
			if (b)
			{
				b = false;
			}
			// r is not accessible
			// b is now false
			Console.WriteLine(r);
			Console.WriteLine(b);
		}
	}
}