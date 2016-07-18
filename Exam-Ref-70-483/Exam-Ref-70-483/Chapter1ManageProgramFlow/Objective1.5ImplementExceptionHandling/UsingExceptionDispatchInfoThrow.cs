using System;
using System.Runtime.ExceptionServices;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._5ImplementExceptionHandling
{
	public class UsingExceptionDispatchInfoThrow
	{
		public void Execute()
		{
			ExceptionDispatchInfo possibleException = null;
			try
			{
				string s = Console.ReadLine();
				int.Parse(s);
			}
			catch (FormatException ex)
			{
				possibleException = ExceptionDispatchInfo.Capture(ex);
			}
			possibleException?.Throw();
		}
	}
}