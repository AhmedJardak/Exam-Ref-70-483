using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective_1._1Implement_multithreading
{
	public class LISTING1_18asyncAndAwait
	{
		public static async Task<string> DownloadContent()
		{
			using (HttpClient client = new HttpClient())
			{
				return await client.GetStringAsync("http://www.microsoft.com");
			}
		}

		public static async  Task Execute()
		{
			string result =await DownloadContent();
			Console.WriteLine(result);
		}
	}
}