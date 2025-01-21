//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.
namespace ByteScoutWebApiExample
{
	class Program
	{
		// Source PDF file to split
		const string SourceFileUrl = @"https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf";
		// Comma-separated list of page numbers (or ranges) to process. Example: '1,3-5,7-'.
		const string Pages = "1-2,3-";
		
		static void Main(string[] args)
		{
			// Create standard .NET web client instance
			WebClient webClient = new WebClient();

			try
			{
				// Prepare URL for `Split PDF` API call
				string query = Uri.EscapeUriString(string.Format(
					"https://localhost/pdf/split?pages={0}&url={1}",
					Pages,
					SourceFileUrl));

				// Execute request
				string response = webClient.DownloadString(query);

				// Parse JSON response
				JObject json = JObject.Parse(response);

				if (json["error"].ToObject<bool>() == false)
				{
					// Download generated PDF files
					int part = 1;
					foreach (JToken token in json["urls"])
					{
						string resultFileUrl = token.ToString();
						string localFileName = String.Format(@".\part{0}.pdf", part);

						webClient.DownloadFile(resultFileUrl, localFileName);

						Console.WriteLine("Downloaded \"{0}\".", localFileName);
						part++;
					}
				}
				else
				{
					Console.WriteLine(json["message"].ToString());
				}
			}
			catch (WebException e)
			{
				Console.WriteLine(e.ToString());
			}

			webClient.Dispose();

			Console.WriteLine();
			Console.WriteLine("Press any key...");
			Console.ReadKey();
		}
	}
}
