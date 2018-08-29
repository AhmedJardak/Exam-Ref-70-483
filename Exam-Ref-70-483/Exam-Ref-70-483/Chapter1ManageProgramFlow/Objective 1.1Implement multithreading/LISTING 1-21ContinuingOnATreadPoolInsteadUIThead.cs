using System.IO;
using System.Net.Http;
using System.Text;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective_1._1Implement_multithreading
{
	public class LISTING_1_21ContinuingOnATreadPoolInsteadUIThead
	{
		public static async void Execute()
		{
			HttpClient httpClient = new HttpClient();
			string content = await httpClient.GetStringAsync("http://www.microsoft.com").ConfigureAwait(false);
			using (FileStream sourceStream = new FileStream("temp.html", FileMode.Create, FileAccess.Write, FileShare.ReadWrite, 4096,
				useAsync: true))
			{
				byte[] encodedText = Encoding.Unicode.GetBytes(content);
				await sourceStream.WriteAsync(encodedText, 0, encodedText.Length).ConfigureAwait(false);
			}
		}
	}
}
