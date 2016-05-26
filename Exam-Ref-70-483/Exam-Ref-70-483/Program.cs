using System;
using System.Reflection;
using Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._3ImplementProgramFlow;
using Exam_Ref_70_483.Chapter4ImplementDataAccess.Objective4._4SerializeaAndDeserializeData;

namespace Exam_Ref_70_483
{
	internal class Program
	{
	
		private static void Main(string[] args)
		{
			Executor(typeof(UsingJsonSerializer));
			Executor(typeof(UsingOrOperator));
			Executor(typeof(CodeBlockAndScoping));
			Executor(typeof(NullCohesingOperator));
			Executor(typeof(UsingSwitchWithLabel));
			Executor(typeof(UsingGoto));
			Console.Read();
		}
		static void Executor(Type type)
		{
			MethodInfo methodInfo = type.GetMethod("Execute");
			object classInstance = Activator.CreateInstance(type, null);
			Console.WriteLine("--------------------------------------");
			Console.WriteLine("Methode before  Execute:"+type.FullName);
			Console.WriteLine("--------------------------------------");
			methodInfo.Invoke(classInstance, null);
			Console.WriteLine("--------------------------------------");
			Console.WriteLine("Methode after  Execute:" + type.FullName);
			Console.WriteLine("--------------------------------------");
		}
	}
}