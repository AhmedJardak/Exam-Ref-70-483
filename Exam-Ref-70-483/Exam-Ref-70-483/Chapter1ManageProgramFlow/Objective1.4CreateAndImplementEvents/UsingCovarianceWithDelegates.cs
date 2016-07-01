using System;
using System.IO;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._4CreateAndImplementEvents
{
	public class UsingCovarianceWithDelegates
	{
		private delegate TextWriter CovarianceDel();

		private static StreamWriter MethodStream()
		{
			Console.WriteLine("InvokeMethodWithStreamWriter");
			return null;
		}

		private static StringWriter MethodString()
		{
			Console.WriteLine("InvokeMethodWithStringWriter");
			return null;
		}

		public static void Execute()
		{
			CovarianceDel del = MethodStream;
			del.Invoke();
			del = MethodString;
			del.Invoke();
		}

	}
}