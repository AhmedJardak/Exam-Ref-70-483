using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective_1._1Implement_multithreading
{
	public class LISTING_1_27CatchingAggregateException
	{
		public static bool IsEven(int i)
		{
			if (i % 10 == 0)
			{
				throw new ArgumentException("i");
			}
			return i % 2 == 0;
		}

		public static void Execute()
		{
			IEnumerable<int> numbers = Enumerable.Range(0, 20);
			try
			{
				var parallelResult = numbers.AsParallel().Where(i => IsEven(i));
				parallelResult.ForAll(e => Console.WriteLine(e));
			}
			catch (AggregateException e)
			{
				Console.WriteLine("There where{0} exceptions", e.InnerExceptions.Count);
			}
		}
	}
}