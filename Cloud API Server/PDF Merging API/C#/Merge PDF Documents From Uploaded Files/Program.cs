//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.
namespace ByteScoutWebApiExample
{
	class Program
	{
		// Source PDF files
		static string[] SourceFiles = new string[] { @".\sample1.pdf", @".\sample2.pdf" };
		// Destination PDF file name
		const string DestinationFile = @".\result.pdf";

		static void Main(string[] args)
		{
			// Create standard .NET web client instance
			WebClient webClient = new WebClient();

			// 1. UPLOAD FILES TO CLOUD
			List<string> uploadedFiles = new List<string>();

			try
			{
				foreach (string pdfFile in SourceFiles)
				{
					// 1a. RETRIEVE THE PRESIGNED URL TO UPLOAD THE FILE.
					
					// Prepare URL for `Get Presigned URL` API call
					string query = Uri.EscapeUriString(string.Format(
						"https://localhost/file/upload/get-presigned-url?contenttype=application/octet-stream&name={0}",
						Path.GetFileName(pdfFile)));

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

						// 1b. UPLOAD THE FILE TO CLOUD.

						webClient.Headers.Add("content-type", "application/octet-stream");
						webClient.UploadFile(uploadUrl, "PUT", pdfFile); // You can use UploadData() instead if your file is byte[] or Stream
						
						uploadedFiles.Add(uploadedFileUrl);
					}
					else
					{
						Console.WriteLine(json["message"].ToString());
					}
				}

				if (uploadedFiles.Count > 0)
				{
					// 2. MERGE UPLOADED PDF DOCUMENTS

					// Prepare URL for `Merge PDF` API call
					string query = Uri.EscapeUriString(string.Format(
						"https://localhost/pdf/merge?name={0}&url={1}",
						Path.GetFileName(DestinationFile),
						string.Join(",", uploadedFiles)));

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
