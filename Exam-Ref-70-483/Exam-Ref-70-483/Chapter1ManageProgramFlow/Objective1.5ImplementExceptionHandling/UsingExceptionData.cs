using System;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._5ImplementExceptionHandling
{
	public class UsingExceptionData
	{
		public void Execute()
		{
			try
			{
				string s = Console.ReadLine();
				int i = int.Parse(s);
				Console.WriteLine("Parsed: {0}", i);
			}
			catch (FormatException e)
			{
				Console.WriteLine("Message:{0}",e.Message);
				Console.WriteLine("StackTrace:{0}", e.StackTrace);
				Console.WriteLine("HelpLink:{0}", e.HelpLink);
				Console.WriteLine("InnerException:{0}", e.InnerException);
				Console.WriteLine("TargetSite:{0}", e.TargetSite);
				Console.WriteLine("Source:{0}", e.Source);
			}
		}
	}
}