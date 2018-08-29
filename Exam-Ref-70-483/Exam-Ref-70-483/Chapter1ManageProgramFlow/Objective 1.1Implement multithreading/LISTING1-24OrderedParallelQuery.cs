using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective_1._1Implement_multithreading
{
	public class Listing124OrderedParallelQuery
	{
		public static void Execute()
		{
			var numbers = Enumerable.Range(0, 10);
			var parallelResult = numbers.AsParallel().AsOrdered().Where(i => i % 2 == 0).ToArray();
			foreach (int i in parallelResult)
			{
				Console.WriteLine(i);
			}
		}
	}
}
