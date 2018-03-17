using System;
using System.Threading.Tasks;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective_1._1Implement_multithreading
{
    public class Listing112AttachingChildTasksToAParentTask
    {
        public static void Execute()
        {
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];
                new Task(() => results[0] = 0,
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[1] = 1,
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[2] = 2,
                    TaskCreationOptions.AttachedToParent).Start();
                return results;
            });
            var finalTask = parent.ContinueWith(
                parentTask =>
                {
                    foreach (int i in parentTask.Result)
                    {
                        Console.WriteLine(i);
                    }
                });
            finalTask.Wait();
        }
    }
}