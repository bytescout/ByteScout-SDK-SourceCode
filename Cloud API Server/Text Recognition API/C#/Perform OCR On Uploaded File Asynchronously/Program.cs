//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// Cloud API asynchronous "PDF To Text" job example.
// Allows to avoid timeout errors when processing huge or scanned PDF documents.

// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.
namespace ByteScoutWebApiExample
{
	class Program
    {
        private const string BaseUrl = "http://localhost";

		// Source file for conversion
		const string SourceFile = @".\ocr-sample.pdf";
		
        // Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
		const string Pages = "";
		
        // PDF document password. Leave empty for unprotected documents.
		const string Password = "";
		
        // Destination TXT file name
		const string DestinationFile = @".\result.txt";
		
        // (!) Make asynchronous job to avoid web request timeouts as OCR requires significant time to process.
        const bool Async = true;


        // Text recognition specific options:

        // Keep text formatting
        private const bool KeepFormatting = true;
        
        // Unwrap paragraphs
        private const bool Unwrap = true;

        // Trim leading spaces
        private const bool Trim = true;

		// OCR errors correction
        private static string[] correctionSearch = new[] { "Oate", "|tem" };
        private static string[] correctionReplace = new[] { "Date", "Item" };
        
        
		static void Main(string[] args)
		{
			// Create standard .NET web client instance
			WebClient webClient = new WebClient();

            string uploadedFileUrl = UploadFile(webClient, SourceFile);

            // Prepare request body
            Dictionary<string, object> requestBody = new Dictionary<string, object>
            {
                { "url", uploadedFileUrl }, 
                { "name", Path.GetFileName(DestinationFile) }, 
                { "async", Async }, 
                { "pages", Pages }, 
                { "password", Password },
                { "keepFormatting", KeepFormatting },
                { "unwrap", Unwrap },
                { "trim", Trim },
                { "correctSearch", correctionSearch },
                { "correctReplace", correctionReplace }
            };

            // Convert body to JSON
            string jsonBody = JsonConvert.SerializeObject(requestBody);

            // URL for `/text/ocr` API endpoint
            string query = $"{BaseUrl}/text/ocr";

			try
			{
				// Execute request
				string response = webClient.UploadString(query, "POST", jsonBody);

				// Parse JSON response
				JObject json = JObject.Parse(response);

				if (json["error"].ToObject<bool>() == false)
				{
					// Asynchronous job ID
					string jobId = json["jobId"].ToString();
					// URL of generated TXT file that will be available after the job completion
					string resultFileUrl = json["url"].ToString();

					// Check the job status in a loop. 
					// If you don't want to pause the main thread you can rework the code 
					// to use a separate thread for the status checking and completion.
					do
					{
						string status = CheckJobStatus(webClient, jobId); // Possible statuses: "working", "failed", "aborted", "success".

						// Display timestamp and status (for demo purposes)
						Console.WriteLine(DateTime.Now.ToLongTimeString() + ": " + status);

						if (status == "success")
						{
							// Download text file
							webClient.DownloadFile(resultFileUrl, DestinationFile);

							Console.WriteLine("Generated TXT file saved as \"{0}\" file.", DestinationFile);
							break;
						}
						else if (status == "working")
						{
							// Pause for a few seconds
                            AutoResetEvent @event = new AutoResetEvent(false);
                            @event.WaitOne(3000);
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

        static string UploadFile(WebClient webClient, string sourceFileName)
        {
            // 1. RETRIEVE THE PRESIGNED URL TO UPLOAD THE FILE.
			
			// Prepare URL for `Get Presigned URL` API call
			string query = Uri.EscapeUriString(string.Format(
				"{0}/file/upload/get-presigned-url?contenttype=application/octet-stream&name={1}", 
                BaseUrl,
				Path.GetFileName(sourceFileName)));

			try
			{
				// Execute GET request
				string response = webClient.DownloadString(query);

				// Parse JSON response
				JObject json = JObject.Parse(response);

				if (json["error"].ToObject<bool>() == false)
				{
					// Get URL to use for the file upload
					string uploadUrl = json["presignedUrl"].ToString();
                    // Get file URL to use for processing
					string uploadedFileUrl = json["url"].ToString();

					// 2. UPLOAD FILE TO CLOUD.

					webClient.Headers.Add("content-type", "application/octet-stream");
					webClient.UploadFile(uploadUrl, "PUT", sourceFileName); // You can use UploadData() instead if your file is byte[] or Stream
					webClient.Headers.Remove("content-type");

                    return uploadedFileUrl;
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

            return null;
        }

		static string CheckJobStatus(WebClient webClient, string jobId)
		{
            string url = $"{BaseUrl}/job/check?jobid={jobId}";

            string response = webClient.DownloadString(url);
            JObject json = JObject.Parse(response);

            return Convert.ToString(json["status"]);
        }
	}
}
