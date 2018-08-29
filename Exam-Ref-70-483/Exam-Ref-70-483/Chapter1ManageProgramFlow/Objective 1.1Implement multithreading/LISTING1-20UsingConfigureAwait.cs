using System;
using System.Net.Http;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective_1._1Implement_multithreading
{
	public class Listing120UsingConfigureAwait
	{
		public static async void Execute()
		{
			HttpClient httpClient = new HttpClient();

			string content = await httpClient.GetStringAsync("http://www.microsoft.com");
			;//.ConfigureAwait(false);

			Output.Content = content;
		}
	}

	public class Output
	{
		static Output()
		{
			Content = String.Empty;
		}

		public static string Content { get; set; }
	}
}