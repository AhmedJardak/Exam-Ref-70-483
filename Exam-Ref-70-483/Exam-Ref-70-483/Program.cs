using System;
using Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._3ImplementProgramFlow;
using Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._4CreateAndImplementEvents;
using Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._5ImplementExceptionHandling;
using Exam_Ref_70_483.Chapter2CreateAndUseType.Objective2._1Createtypes;
using Exam_Ref_70_483.Chapter4ImplementDataAccess.Objective4._4SerializeaAndDeserializeData;

namespace Exam_Ref_70_483
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Type[] types =
			{
			//Chapter 1	
			//	typeof(UsingOrOperator),
			//	typeof(CodeBlockAndScoping),
			//	typeof(NullCohesingOperator),
			//	typeof(UsingSwitchWithLabel),
			//	typeof(UsingGoto),
			//	typeof(UsingDelegates),
			//	typeof(UsingMultiCastDelegates),
			//	typeof(UsingCovarianceWithDelegates),
			//	typeof(UsingContraVarianceWithDelegates),
			//	typeof(UsingLambdaExpressions),
         // typeof(UsingEnvironmentFailFast),
			//	typeof(UsingExceptionHandling),
			//	typeof(UsingExceptionData),
			//	typeof(UsingExceptionDispatchInfoThrow),
			//chapter 2
			typeof(UsingEnum),
			//Chapter 4
			//	typeof(UsingJsonSerializer),

			};
			new TypeExecutor(types).Execute();
			Console.WriteLine("--------------------Finish------------------");
			Console.Read();
		}
	}
}