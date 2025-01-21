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
		static void Main(string[] args)
		{
			// HTML template
			string template = File.ReadAllText(@".\invoice_template.html");
			// Data to fill the template
			string templateData = File.ReadAllText(@".\invoice_data.json");
			// Destination PDF file name
			string destinationFile = @".\result.pdf";

			// Create standard .NET web client instance
			WebClient webClient = new WebClient();

            try
            {
                // Prepare URL for `HTML to PDF` API call
				string request = Uri.EscapeUriString(string.Format(
					"https://localhost/pdf/convert/from/html?name={0}", 
					Path.GetFileName(destinationFile)));

                // Prepare request body in JSON format
                JObject jsonObject = new JObject(
                    new JProperty("html", template),
                    new JProperty("templateData", templateData));

                webClient.Headers.Add("Content-Type", "application/json");

                // Execute request
				string response = webClient.UploadString(request, jsonObject.ToString());

	            // Parse JSON response
	            JObject json = JObject.Parse(response);

	            if (json["error"].ToObject<bool>() == false)
	            {
		            // Get URL of generated PDF file
		            string resultFileUrl = json["url"].ToString();

		            webClient.Headers.Remove("Content-Type"); // remove the header required for only the previous request

		            // Download the PDF file
					webClient.DownloadFile(resultFileUrl, destinationFile);

					Console.WriteLine("Generated PDF document saved as \"{0}\" file.", destinationFile);
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
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
		}
	}
}
