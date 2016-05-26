using System;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._3ImplementProgramFlow
{
	internal class UsingGoto
	{
		public static void Execute()
		{
			try
			{
				var x = 3;
				if (x == 3)
					goto customLabel;
				x++;
				customLabel:
				Console.WriteLine(x);
			}
			finally
			{
				Console.WriteLine("finally");
			}
		}
	}
}