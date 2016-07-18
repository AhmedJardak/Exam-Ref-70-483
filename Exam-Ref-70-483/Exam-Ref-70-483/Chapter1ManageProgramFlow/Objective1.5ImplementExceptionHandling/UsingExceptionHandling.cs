using System;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._5ImplementExceptionHandling
{
	public class UsingExceptionHandling
	{
		public void Execute()
		{
			while (true)
			{
				var s = Console.ReadLine();
				if (string.IsNullOrWhiteSpace(s))
					break;
				try
				{
					var i = int.Parse(s);
					break;
				}
				catch (FormatException)
				{
					Console.WriteLine("{0} is not a valid number.Please try again", s);
				}
			}
		}
	}
}