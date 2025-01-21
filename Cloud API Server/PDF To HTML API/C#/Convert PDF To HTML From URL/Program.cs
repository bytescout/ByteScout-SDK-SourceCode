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
		const string SourceFileUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-html/sample.pdf";
		// Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
		const string Pages = "";
		// PDF document password. Leave empty for unprotected documents.
		const string Password = "";
		// Destination HTML file name
		const string DestinationFile = @".\result.html";
		// Set to `true` to get simplified HTML without CSS. Default is the rich HTML keeping the document design.
		const bool PlainHtml = false;
		// Set to `true` if your document has the column layout like a newspaper.
		const bool ColumnLayout = false;

		static void Main(string[] args)
		{
			// Create standard .NET web client instance
			WebClient webClient = new WebClient();

			try
			{
				// Prepare URL for `PDF To HTML` API call
				String query = Uri.EscapeUriString(string.Format(
					"https://localhost/pdf/convert/to/html?name={0}&password={1}&pages={2}&simple={3}&columns={4}&url={5}",
					Path.GetFileName(DestinationFile),
					Password,
					Pages,
					PlainHtml,
					ColumnLayout,
					SourceFileUrl));

				// Execute request
				String response = webClient.DownloadString(query);

				// Parse JSON response
				JObject json = JObject.Parse(response);

				if (json["error"].ToObject<bool>() == false)
				{
					// Get URL of generated HTML file
					string resultFileUrl = json["url"].ToString();

					// Download HTML file
					webClient.DownloadFile(resultFileUrl, DestinationFile);

					Console.WriteLine("Generated HTML file saved as \"{0}\" file.", DestinationFile);
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
