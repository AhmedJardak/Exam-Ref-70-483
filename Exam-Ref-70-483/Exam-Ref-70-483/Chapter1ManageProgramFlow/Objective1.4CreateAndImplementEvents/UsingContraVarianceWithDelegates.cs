using System;
using System.IO;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._4CreateAndImplementEvents
{
	public class UsingContraVarianceWithDelegates
	{
		private static void DoSomething(TextWriter tw)
		{
			Console.WriteLine("Invoke TextWriter");
		}

		private delegate void ContravarianceDel(StreamWriter tw);
		public static void Execute()
		{
			ContravarianceDel del = DoSomething;
			del.Invoke(StreamWriter.Null);
		}
		
	}
}