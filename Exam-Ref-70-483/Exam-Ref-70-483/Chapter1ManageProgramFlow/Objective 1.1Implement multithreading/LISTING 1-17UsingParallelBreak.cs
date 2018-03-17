using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective_1._1Implement_multithreading
{
	public class Listing117UsingParallelBreak
	{
		public static void Execute()
		{
			ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) => {
				Console.WriteLine(i);
				if (i == 500)
				{
					Console.WriteLine("Breaking loop");
					loopState.Break();
				}
				return;
			});

		}
	}
}
