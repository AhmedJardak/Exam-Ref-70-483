using System;
using System.Linq;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective_1._1Implement_multithreading
{
	public class Listing122UsingAsParallel
	{
		public static void Execute()
		{
			var numbers = Enumerable.Range(0, 10);
			int[] parallelResult = numbers.AsParallel().Where(i => i % 2 == 0).ToArray();
			foreach (int i in parallelResult)
			{
				Console.WriteLine(i);
			}
		}

	}
}
