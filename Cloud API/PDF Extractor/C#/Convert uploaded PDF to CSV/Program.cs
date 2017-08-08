using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using Bytescout.Api.Api;
using Bytescout.Api.Model;

namespace ByteScoutWebApiExample
{
	class Program
	{
		// The authentication key (API Key).
		// Get your own by registering at https://secure.bytescout.com/users/sign_up
		const String API_KEY = "***********************************";
		
		static void Main(string[] args)
		{
			string inputFile = "sample.pdf";
			string outputFile = "result.csv";

			// Set API Key
			Bytescout.Api.Client.Configuration.ApiKey.Add("x-api-key", API_KEY);

			var apiInstance = new DefaultApi();

			try
			{
				// 1. RETRIEVE THE PRESIGNED URL TO UPLOAD THE FILE.
				// * If you alredy have a direct PDF file link, go to the step 3.

				PresignedUrlResponseModel presignedUrlResponse = apiInstance.FileUploadGetPresignedUrlGet("binary/octet-stream", "sample.pdf");
				string uploadUrl = presignedUrlResponse.PresignedUrl;


				// 2. UPLOAD THE FILE TO CLOUD.

				// Use standard .NET WebClient to upload the file.
				// Note, you should set the "content-type" header and use PUT request method.
				WebClient webClient = new WebClient();
				webClient.Headers.Add("content-type", "binary/octet-stream");
				webClient.UploadFile(uploadUrl, "PUT", inputFile); // You can use UploadData() instead if your file is byte[] or Stream

				
				// 3. CONVERT UPLOADED PDF FILE TO CSV

				string uploadedFileAccessUrl = presignedUrlResponse.Url;
				String fileName = Path.GetFileName(outputFile);
				String pages = ""; // Comma-separated list of pages (or ranges) in form "0,3-4,6-" (leave empty for all pages)
				SingleResponseModel conversionResponse = apiInstance.PdfConvertToCsvGet(pages, fileName, uploadedFileAccessUrl);

				if (conversionResponse.Error == false)
				{
					// Download the converted file
					String resultUrl = conversionResponse.Url;
					webClient.DownloadFile(resultUrl, outputFile);

					// Open the result file in default application (just for demonstration purpose)
					Process.Start(outputFile);
				}
			}
			catch (Exception e)
			{
				Debug.Print("Exception when calling WebAPI: " + e.Message);
			}
		}
	}
}
