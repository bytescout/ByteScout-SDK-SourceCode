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
        // Direct URL of source PDF file.
        const string SourceFileUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-csv/sample.pdf";
		// Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
		const string Pages = "";
		// PDF document password. Leave empty for unprotected documents.
		const string Password = "";
		// Destination CSV file name
		const string DestinationFile = @".\result.csv";

        // Sample profile that sets advanced conversion options
        // Advanced options are properties of CSVExtractor class from ByteScout PDF Extractor SDK used in the back-end:
        // https://cdn.bytescout.com/help/BytescoutPDFExtractorSDK/html/87ce5fa6-3143-167d-abbd-bc7b5e160fe5.htm

        static string Profiles = File.ReadAllText("profile.json");

		static void Main(string[] args)
		{
			// Create standard .NET web client instance
			WebClient webClient = new WebClient();

			// Prepare URL for `PDF To CSV` API call
			string query = Uri.EscapeUriString(string.Format(
                "https://localhost/pdf/convert/to/csv?name={0}&password={1}&pages={2}&url={3}&profiles={4}", 
				Path.GetFileName(DestinationFile),
				Password,
				Pages,
				SourceFileUrl,
                Profiles));

			try
			{
				// Execute request
				string response = webClient.DownloadString(query);

				// Parse JSON response
				JObject json = JObject.Parse(response);

                if (json["status"].ToString() != "error")
                {
					// Get URL of generated CSV file
					string resultFileUrl = json["url"].ToString();

					// Download CSV file
					webClient.DownloadFile(resultFileUrl, DestinationFile);

					Console.WriteLine("Generated CSV file saved as \"{0}\" file.", DestinationFile);
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
