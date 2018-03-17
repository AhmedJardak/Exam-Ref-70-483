using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective_1._1Implement_multithreading
{
	public class Listing116UsingParallel
    {
	    public static void Execute()
	    {
		    Parallel.For(0, 10, i => { Thread.Sleep(1000); });

		    var numbers = Enumerable.Range(0, 10);
		    Parallel.ForEach(numbers, i => { Thread.Sleep(1000); });

		}

	}
}
