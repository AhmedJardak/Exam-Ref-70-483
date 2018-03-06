using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective_1._1Implement_multithreading
{
    internal class UsingAbackgroundThread
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc:{0}", i);
                Thread.Sleep(1000);
            }
        }

        public static void Execute()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod)) {IsBackground = true};
            t.Start();
        }
    }
}
