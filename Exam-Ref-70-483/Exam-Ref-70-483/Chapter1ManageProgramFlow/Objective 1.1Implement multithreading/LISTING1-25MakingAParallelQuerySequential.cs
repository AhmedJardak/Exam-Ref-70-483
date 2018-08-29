using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective_1._1Implement_multithreading
{
	public class LISTING1_25MakingAParallelQuerySequential
	{
		public static void Execute()
		{
			var numbers = Enumerable.Range(0, 20);

			var parallelResult = numbers.AsParallel().Where(i => i % 2 == 0).AsSequential();

			foreach (int i in parallelResult.Take(5))
			{
				Console.WriteLine(i);
			}

		}
	}
}
