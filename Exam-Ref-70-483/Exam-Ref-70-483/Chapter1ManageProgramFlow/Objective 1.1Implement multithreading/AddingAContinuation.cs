using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective_1._1Implement_multithreading
{
    public class AddingAContinuation
    {
        public static void Execute()
        {
            Task<int> t = Task.Run(() => 42).ContinueWith((i) => i.Result * 2);
            Console.WriteLine(t.Result); // Displays 84
        }
    }
}
