using System;
using System.Threading;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective_1._1Implement_multithreading
{
    internal class UsingThreadLocal
    {
        public static ThreadLocal<int> _field = new ThreadLocal<int>(() => Thread.CurrentThread.ManagedThreadId);

        public static void Execute()
        {
            new Thread(() =>
            {
                for (var x = 0; x < _field.Value; x++) Console.WriteLine("ThreadA:{0}", x);
                Thread.Sleep(10000);
                Console.WriteLine("ThreadA Hash Code:{0}",Thread.CurrentThread.GetHashCode());
            }).Start();
            new Thread(() =>
            {
                for (var x = 0; x < _field.Value; x++) Console.WriteLine("ThreadB:{0}", x);
                Thread.Sleep(10000);
                Console.WriteLine("ThreadB Hash Code:{0}", Thread.CurrentThread.GetHashCode());
            }).Start();
            Console.ReadKey();
        }
    }
}