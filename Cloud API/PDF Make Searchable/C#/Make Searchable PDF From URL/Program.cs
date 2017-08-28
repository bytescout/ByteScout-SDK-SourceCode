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
		const string SourceFileUrl = "https://github.com/bytescout/ByteScout-SDK-SourceCode/raw/master/PDF%20Extractor%20SDK/sample_ocr.pdf";
		const string Pages = "";
		// PDF document password. Leave empty for unportected documents.
		const string Password = "";
		// OCR language. "eng", "fra", "deu", "spa"  supported currently. Ley us know if you need more.
		const string Language = "eng";
		// Destination PDF file name
		const string DestinationFile = @".\result.pdf";

		static void Main(string[] args)
		{
			// Create standard .NET web client instance
			WebClient webClient = new WebClient();

			// Set API Key
			webClient.Headers.Add("x-api-key", API_KEY);

			// Prepare URL for `Make Searchable PDF` API call
			string query = Uri.EscapeUriString(string.Format(
				"https://bytescout.io/v1/pdf/makesearchable?name={0}&password={1}&pages={2}&lang={3}&url={4}",
				Path.GetFileName(DestinationFile),
				Password,
				Pages,
				Language,
				SourceFileUrl));

			try
			{
				// Execute request
				string response = webClient.DownloadString(query);

				// Parse JSON response
				JObject json = JObject.Parse(response);

				if (json["error"].ToObject<bool>() == false)
				{
					// Get URL of generated PDF file
					string resultFileUrl = json["url"].ToString();

					// Download PDF file
					webClient.DownloadFile(resultFileUrl, DestinationFile);

					Console.WriteLine("Generated PDF file saved as \"{0}\" file.", DestinationFile);
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
