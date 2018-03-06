using System;
using System.Threading;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective_1._1Implement_multithreading
{
    public class CreatingAThread
    {
        public static void ThreadMethod()
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc:{0}", i);
                Thread.Sleep(0);
            }
        }

        public static void Execute()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Mainthread: Dosomework.");
                Thread.Sleep(0);
            }
            t.Join();
        }
    }
}