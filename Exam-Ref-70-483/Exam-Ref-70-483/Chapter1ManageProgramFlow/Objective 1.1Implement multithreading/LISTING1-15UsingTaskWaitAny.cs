using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective_1._1Implement_multithreading
{
	internal class LISTING1_15UsingTaskWaitAny
	{
		public static void Execute()
		{
			Task<int>[] tasks = new Task<int>[3];
			tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 1; });
			tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 2; });
			tasks[2] = Task.Run(() => { Thread.Sleep(3000); return 3; });
			while (tasks.Length > 0)
			{
				int i = Task.WaitAny(tasks);
				Task<int> completedTask = tasks[i];
				Console.WriteLine(completedTask.Result);
				var temp = tasks.ToList();
				temp.RemoveAt(i);
				tasks = temp.ToArray();
			}
		}
	}
}
