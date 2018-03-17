using System;
using System.Globalization;
using Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._3ImplementProgramFlow;
using Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._4CreateAndImplementEvents;
using Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._5ImplementExceptionHandling;
using Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective_1._1Implement_multithreading;
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
              //  typeof(CreatingAThread),
			 //   typeof(UsingAbackgroundThread),
             //   typeof(UsingParameterizedThreadStart),
              //  typeof(StoppingAThread),
               // typeof(UsingThreadStaticAttribute),
               // typeof(UsingThreadLocal),
               // typeof(QueuingSomeWorkToTheThreadPool),
               // typeof(StartingANewTask),
			//    typeof(UsingATaskThatReturnsAValue),
			  //  typeof(Listing111SchedulingDifferentContinuationTasks),
             //   typeof(Listing112AttachingChildTasksToAParentTask),
				//typeof(LISTING1_13UsingATaskFactory),
				//typeof(Listing114UsingTaskWaitAll),
			//	typeof(LISTING1_15UsingTaskWaitAny),
			//	typeof(Listing116UsingParallel),
			//typeof(Listing117UsingParallelBreak),
				typeof(LISTING1_18asyncAndAwait)
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
			//typeof(UsingEnum),
			//Chapter 4
			//	typeof(UsingJsonSerializer),

			};
			new TypeExecutor(types).Execute();
            //Console.WriteLine(string.Format(new DateTimeFormatInfo(), "Temprature at {0:hh:mm tt} on {0:MM/dd/yyyy} is {1:N2}", DateTime.Now, 45.98555));     
            Console.WriteLine("--------------------Finish------------------");
			Console.Read();
		}
	}
}