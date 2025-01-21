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
using System.Threading;

// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

// Cloud API asynchronous "Split PDF" job example.
// Allows to avoid timeout errors when processing huge or scanned PDF documents.
namespace ByteScoutWebApiExample
{
	class Program
	{
		// Source PDF file to split
		const string SourceFileUrl = @"https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf";
		// Comma-separated list of page numbers (or ranges) to process. Example: '1,3-5,7-'.
		const string Pages = "1-2,3-";
		// (!) Make asynchronous job
		const bool Async = true;

		static void Main(string[] args)
		{
			// Create standard .NET web client instance
			WebClient webClient = new WebClient();

			try
			{
				// Prepare URL for `Split PDF` API call
				string query = Uri.EscapeUriString(string.Format(
					"https://localhost/pdf/split?pages={0}&url={1}&async={2}",
					Pages,
					SourceFileUrl,
					Async));

				// Execute request
				string response = webClient.DownloadString(query);

				// Parse JSON response
				JObject json = JObject.Parse(response);

				if (json["error"].ToObject<bool>() == false)
				{
					// Asynchronous job ID
					string jobId = json["jobId"].ToString();
					// URL of generated JSON file available after the job completion; it will contain URLs of result PDF files.
					string resultJsonFileUrl = json["url"].ToString();

					// Check the job status in a loop. 
					// If you don't want to pause the main thread you can rework the code 
					// to use a separate thread for the status checking and completion.
					do
					{
						string status = CheckJobStatus(jobId); // Possible statuses: "working", "failed", "aborted", "success".

						// Display timestamp and status (for demo purposes)
						Console.WriteLine(DateTime.Now.ToLongTimeString() + ": " + status);

						if (status == "success")
						{
							// Download JSON file as string
							string jsonFileString = webClient.DownloadString(resultJsonFileUrl);

							JArray resultFilesUrls = JArray.Parse(jsonFileString);

							// Download generated PDF files
							int part = 1;
							foreach (JToken token in resultFilesUrls)
							{
								string resultFileUrl = token.ToString();
								string localFileName = String.Format(@".\part{0}.pdf", part);

								webClient.DownloadFile(resultFileUrl, localFileName);

								Console.WriteLine("Downloaded \"{0}\".", localFileName);
								part++;
							}
							break;
						}
						else if (status == "working")
						{
							// Pause for a few seconds
							Thread.Sleep(3000);
						}
						else
						{
							Console.WriteLine(status);
							break;
						}
					}
					while (true);
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

		static string CheckJobStatus(string jobId)
		{
			using (WebClient webClient = new WebClient())
			{
				string url = "https://localhost/job/check?jobid=" + jobId;

				string response = webClient.DownloadString(url);
				JObject json = JObject.Parse(response);

				return Convert.ToString(json["status"]);
			}
		}
	}
}
