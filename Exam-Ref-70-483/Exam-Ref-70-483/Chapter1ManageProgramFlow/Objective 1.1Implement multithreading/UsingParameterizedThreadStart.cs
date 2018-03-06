using System;
using System.Threading;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective_1._1Implement_multithreading
{
    internal class UsingParameterizedThreadStart
    {
        public static void ThreadMethod(object o)
        {
            for (var i = 0; i < (int) o; i++)
            {
                Console.WriteLine("ThreadProc:{0}", i);
                Thread.Sleep(1000);
            }
        }

        public static void Execute()
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(5);
            t.Join();
        }
    }
}