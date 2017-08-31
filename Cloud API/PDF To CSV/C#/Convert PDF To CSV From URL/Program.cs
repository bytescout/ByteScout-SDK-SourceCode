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
		// PDF document password. Leave empty for unprotected documents.
		const string Password = "";
		// Destination CSV file name
		const string DestinationFile = @".\result.csv";

		static void Main(string[] args)
		{
			// Create standard .NET web client instance
			WebClient webClient = new WebClient();

			// Set API Key
			webClient.Headers.Add("x-api-key", API_KEY);

			// Prepare URL for `PDF To CSV` API call
			string query = Uri.EscapeUriString(string.Format(
				"https://bytescout.io/v1/pdf/convert/to/csv?name={0}&password={1}&pages={2}&url={3}", 
				Path.GetFileName(DestinationFile),
				Password,
				Pages,
				SourceFileUrl));

			try
			{
				// Execute request
				string response = webClient.DownloadString(query);

				// Parse JSON response
				JObject json = JObject.Parse(response);

				if (json["error"].ToObject<bool>() == false)
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


			Console.WriteLine();
			Console.WriteLine("Press any key...");
			Console.ReadKey();
		}
	}
}
