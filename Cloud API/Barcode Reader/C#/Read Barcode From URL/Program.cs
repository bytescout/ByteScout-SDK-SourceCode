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
		
		// Direct URL of source file to search barcodes in.
		const string SourceFileURL = "https://github.com/bytescout/ByteScout-SDK-SourceCode/raw/master/BarCode%20Reader%20SDK/C%23/Export%20Results%20to%20XML%2C%20CSV%2C%20TXT/barcodes.pdf";
		// Comma-separated list of barcode types to search. 
		// See valid barcode types in the documentation https://secure.bytescout.com/cloudapi.html#api-Default-barcodeReadFromUrlGet
		const string BarcodeTypes = "Code128,Code39,Interleaved2of5,EAN13";
		// Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
		const string pages = "";

		static void Main(string[] args)
		{
			// Create standard .NET web client instance
			WebClient webClient = new WebClient();

			// Set API Key
			webClient.Headers.Add("x-api-key", API_KEY);

			// Prepare URL for `Barcode Reader` API call
			string query = Uri.EscapeUriString(string.Format("https://bytescout.io/v1/barcode/read/from/url?types={0}&pages={1}&url={2}", 
				BarcodeTypes,
				pages,
				SourceFileURL));

			try
			{
				// Execute request
				string response = webClient.DownloadString(query);

				// Parse JSON response
				JObject json = JObject.Parse(response);

				if (json["error"].ToObject<bool>() == false)
				{
					// Display found barcodes in console
					foreach (JToken token in json["barcodes"])
					{
						Console.WriteLine("Found barcode:");
						Console.WriteLine("  Type: " + token["TypeName"]);
						Console.WriteLine("  Value: " + token["Value"]);
						Console.WriteLine("  Document Page Index: " + token["Page"]);
						Console.WriteLine("  Rectangle: " + token["Rect"]);
						Console.WriteLine("  Confidence: " + token["Confidence"]);
						Console.WriteLine();
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


			Console.WriteLine();
			Console.WriteLine("Press any key...");
			Console.ReadKey();
		}
	}
}
