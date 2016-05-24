namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._3ImplementProgramFlow
{
	internal class NullCohesingOperator
	{
		public static void Execute()
		{
			int? x = null;
			int? z = null;
			var y = x ?? z ?? -1;
		}
	}
}