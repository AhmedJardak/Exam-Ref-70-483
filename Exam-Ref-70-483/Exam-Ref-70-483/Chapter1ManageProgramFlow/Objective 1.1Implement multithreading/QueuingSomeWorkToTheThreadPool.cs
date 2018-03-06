using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective_1._1Implement_multithreading
{
    internal class QueuingSomeWorkToTheThreadPool
    {
        public static void Execute()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Workingona thread from threadpool");
            });
        }
    }
}
