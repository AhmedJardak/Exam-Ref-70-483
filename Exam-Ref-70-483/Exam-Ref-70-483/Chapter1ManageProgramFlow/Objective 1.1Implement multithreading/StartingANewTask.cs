using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective_1._1Implement_multithreading
{
    public class StartingANewTask
    {
        public static void Execute()
        {           
            Task task = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.Write("*");
                }      
            });
       
        }
    }
}
