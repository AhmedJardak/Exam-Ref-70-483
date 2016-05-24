using System;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._3ImplementProgramFlow
{
	internal class UsingOrOperator
	{
		private void OrShortCircuit()
		{
			var x = true;
			var result = x || GetY();
		}

		private void AndShortCircuit()
		{
			var x = false;
			var result = x && GetY();
		}

		private bool GetY()
		{
			Console.WriteLine("This method doesn't get called");
			return true;
		}

		public static void Execute()
		{
			UsingOrOperator usingOrOperator = new UsingOrOperator();
			usingOrOperator.OrShortCircuit();
			usingOrOperator.AndShortCircuit();
		}
	}
}