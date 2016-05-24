using System;
using Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._3ImplementProgramFlow;
using Exam_Ref_70_483.Chapter4ImplementDataAccess.Objective4._4SerializeaAndDeserializeData;

namespace Exam_Ref_70_483
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			UsingJsonSerializer.Execute();
			UsingOrOperator.Execute();
			CodeBlockAndScoping.Execute();
			NullCohesingOperator.Execute();
			UsingSwitchWithLabel.Execute();
			Console.Read();
		}
	}
}