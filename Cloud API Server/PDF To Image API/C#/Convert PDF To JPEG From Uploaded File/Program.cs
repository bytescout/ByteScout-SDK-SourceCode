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
		// Source PDF file
		const string SourceFile = @".\sample.pdf";
		// Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
		const string Pages = "";
		// PDF document password. Leave empty for unprotected documents.
		const string Password = "";
		
		static void Main(string[] args)
		{
			// Create standard .NET web client instance
			WebClient webClient = new WebClient();

			// 1. RETRIEVE THE PRESIGNED URL TO UPLOAD THE FILE.
			// * If you already have the direct file URL, skip to the step 3.
			
			// Prepare URL for `Get Presigned URL` API call
			string query = Uri.EscapeUriString(string.Format(
				"https://localhost/file/upload/get-presigned-url?contenttype=application/octet-stream&name={0}", 
				Path.GetFileName(SourceFile)));

			try
			{
				// Execute request
				string response = webClient.DownloadString(query);

				// Parse JSON response
				JObject json = JObject.Parse(response);

				if (json["error"].ToObject<bool>() == false)
				{
					// Get URL to use for the file upload
					string uploadUrl = json["presignedUrl"].ToString();
					// Get URL of uploaded file to use with later API calls
					string uploadedFileUrl = json["url"].ToString();

					// 2. UPLOAD THE FILE TO CLOUD.

					webClient.Headers.Add("content-type", "application/octet-stream");
					webClient.UploadFile(uploadUrl, "PUT", SourceFile); // You can use UploadData() instead if your file is byte[] or Stream
					
					// 3. CONVERT UPLOADED PDF FILE TO JPEG

					// Prepare URL for `PDF To JPEG` API call
					query = Uri.EscapeUriString(string.Format(
						"https://localhost/pdf/convert/to/jpg?password={0}&pages={1}&url={2}",
						Password,
						Pages,
						uploadedFileUrl));

					// Execute request
					response = webClient.DownloadString(query);

					// Parse JSON response
					json = JObject.Parse(response);

					if (json["error"].ToObject<bool>() == false)
					{
						// Download generated JPEG files
						int page = 1;
						foreach (JToken token in json["urls"])
						{
							string resultFileUrl = token.ToString();
							string localFileName = String.Format(@".\page{0}.jpg", page);

							webClient.DownloadFile(resultFileUrl, localFileName);

							Console.WriteLine("Downloaded \"{0}\".", localFileName);
							page++;
						}
					}
					else
					{
						Console.WriteLine(json["message"].ToString());
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
