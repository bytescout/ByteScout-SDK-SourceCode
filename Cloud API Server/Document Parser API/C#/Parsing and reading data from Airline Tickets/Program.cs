//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;

// Cloud API asynchronous "Document Parser" job example.
// Allows to avoid timeout errors when processing huge or scanned PDF documents.

namespace ByteScoutWebApiExample
{
	// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
	// If it's not then please replace this with with your hosting url.
    class Program
	{
		// The authentication key (API Key).
		// Get your own by registering at https://app.pdf.co/documentation/api
		const String API_KEY = "***********************************";
		
		// Source PDF file
		const string SourceFile = @".\SampleTicket.pdf";

		// PDF document password. Leave empty for unprotected documents.
		const string Password = "";

		// Destination TXT file name
		const string DestinationFile = @".\result.json";

        // (!) Make asynchronous job
        const bool Async = true;


		static void Main(string[] args)
		{
			// Template text. Use Document Parser (https://pdf.co/document-parser, https://app.pdf.co/document-parser)
			// to create templates.
			// Read template from file:
			String templateText = File.ReadAllText(@".\SampleTicket.yml");

			// Create standard .NET web client instance
			WebClient webClient = new WebClient();

			// Set API Key
			webClient.Headers.Add("x-api-key", API_KEY);

			// 1. RETRIEVE THE PRESIGNED URL TO UPLOAD THE FILE.
			// * If you already have a direct file URL, skip to the step 3.
			
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
					string uploadedFileUrl = json["url"].ToString();

					// 2. UPLOAD THE FILE TO CLOUD.

					webClient.Headers.Add("content-type", "application/octet-stream");
					webClient.UploadFile(uploadUrl, "PUT", SourceFile); // You can use UploadData() instead if your file is byte[] or Stream
					webClient.Headers.Remove("content-type");

                    // 3. PARSE UPLOADED PDF DOCUMENT

                    // URL for `Document Parser` API call
                    string url = "https://localhost/pdf/documentparser";

                    Dictionary<string, object> requestBody = new Dictionary<string, object>();
                    requestBody.Add("template", templateText);
                    requestBody.Add("name", Path.GetFileName(DestinationFile));
                    requestBody.Add("url", uploadedFileUrl);
                    requestBody.Add("async", Async);

                    // Convert dictionary of params to JSON
                    string jsonPayload = JsonConvert.SerializeObject(requestBody);

                    // Execute request
                    response = webClient.UploadString(url, "POST", jsonPayload);
                    
                    // Parse JSON response
                    json = JObject.Parse(response);

                    if (json["error"].ToObject<bool>() == false)
                    {
                        // Asynchronous job ID
                        string jobId = json["jobId"].ToString();
                        // Get URL of generated JSON file
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
                                // Download JSON file
                                webClient.DownloadFile(resultFileUrl, DestinationFile);

                                Console.WriteLine("Generated JSON file saved as \"{0}\" file.", DestinationFile);
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

        static string CheckJobStatus(WebClient webClient, string jobId)
        {
            string url = "https://localhost/job/check?jobid=" + jobId;

            string response = webClient.DownloadString(url);
            JObject json = JObject.Parse(response);

            return Convert.ToString(json["status"]);
        }
	}
}
