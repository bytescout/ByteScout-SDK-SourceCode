using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace ByteScoutWebApiExample
{
	class Program
	{
		// (!) If you are getting '(403) Forbidden' error please ensure you have set the correct API_KEY
		
		// The authentication key (API Key).
		// Get your own by registering at https://secure.bytescout.com/users/sign_up
		const String API_KEY = "***********************************";

		// Direct URL of source PDF file.
		const string SourceFileUrl = "https://github.com/bytescout/ByteScout-SDK-SourceCode/raw/master/PDF%20Extractor%20SDK/Invoice.pdf";
		// Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
		const string Pages = "";
		// PDF document password. Leave empty for unportected documents.
		const string Password = "";
		// Destination HTML file name
		const string DestinationFile = @".\result.html";
		// Set to `true` to get simplified HTML without CSS. Default is the rich HTML keeping the document design.
		const bool PlainHtml = false;
		// Set to `true` if your document has the column layout like a newpaper.
		const bool ColumnLayout = false;

		static void Main(string[] args)
		{
			// Create standard .NET web client instance
			WebClient webClient = new WebClient();

			// Set API Key
			webClient.Headers.Add("x-api-key", API_KEY);

			try
			{
				// Prepare URL for `PDF To HTML` API call
				String query = Uri.EscapeUriString(string.Format(
					"https://bytescout.io/v1/pdf/convert/to/html?name={0}&password={1}&pages={2}&simple={3}&columns={4}&url={5}",
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


			Console.WriteLine();
			Console.WriteLine("Press any key...");
			Console.ReadKey();
		}
	}
}
