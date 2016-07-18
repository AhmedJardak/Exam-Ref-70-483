using System;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._5ImplementExceptionHandling
{
	public class UsingEnvironmentFailFast
	{
	
			public static void Execute()
			{
				string readLine = Console.ReadLine();
				try
				{
					if (string.IsNullOrEmpty(readLine)) return;
					var i = int.Parse(readLine);
					if (i != 42) return;
					Environment.FailFast("Special number entered");
				}
				finally
				{
					Console.WriteLine("Program complete.");
				}
			}
		
	}
}