using System;
using System.Threading;
using System.Threading.Tasks;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective_1._1Implement_multithreading
{
	public class Listing114UsingTaskWaitAll
	{
		public static void Execute()
		{
			Task[] tasks = new Task[3];

			tasks[0] = Task.Run(() =>
			{
				Thread.Sleep(1000);
				Console.WriteLine("1");
				return 1;
			});
			tasks[1] = Task.Run(() =>
			{
				Thread.Sleep(1000);
				Console.WriteLine("2");
				return 2;
			});
			tasks[2] = Task.Run(() =>
			{
				Thread.Sleep(1000);
				Console.WriteLine("3");
				return 3;
			});
			Task.WaitAll(tasks);
		}
	}
}