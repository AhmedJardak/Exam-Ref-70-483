using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective_1._1Implement_multithreading
{
	public class LISTING1_26UsingForAll
	{
		public void Execute()
		{
			var numbers = Enumerable.Range(0, 2000);

			var parallelResult = numbers.AsParallel().Where(i => i % 2 == 0);

			parallelResult.ForAll(e => Console.WriteLine(e));

		}
	}
}
