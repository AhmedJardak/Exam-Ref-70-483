using System;
using Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._3ImplementProgramFlow;
using Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._4CreateAndImplementEvents;
using Exam_Ref_70_483.Chapter4ImplementDataAccess.Objective4._4SerializeaAndDeserializeData;

namespace Exam_Ref_70_483
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Type[] types =
			{
				typeof(UsingJsonSerializer),
				typeof(UsingOrOperator),
				typeof(CodeBlockAndScoping),
				typeof(NullCohesingOperator),
				typeof(UsingSwitchWithLabel),
				typeof(UsingGoto),
				typeof(UsingDelegates),
				typeof(UsingMultiCastDelegates),
				typeof(UsingCovarianceWithDelegates),
				typeof(UsingContraVarianceWithDelegates),
				typeof(UsingLambdaExpressions),
			};
			new TypeExecutor(types).Execute();
			Console.Read();
		}
	}
}