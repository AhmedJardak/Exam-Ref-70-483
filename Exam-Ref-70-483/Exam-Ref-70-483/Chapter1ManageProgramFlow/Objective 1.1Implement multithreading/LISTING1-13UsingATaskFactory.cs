using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective_1._1Implement_multithreading
{
    public class LISTING1_13UsingATaskFactory
    {
        public static void Execute()
        {

            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];
                TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent,
                    TaskContinuationOptions.ExecuteSynchronously);
                tf.StartNew(() => results[0] = 0);
                tf.StartNew(() => results[1] = 1);
                tf.StartNew(() => results[2] = 2);
                return results;
            });
            var finalTask = parent.ContinueWith(
                parentTask => {
	                foreach (int i in parentTask.Result)
	                {
		                Console.WriteLine(i);
	                }
                });
            finalTask.Wait();
        }
    }
}
