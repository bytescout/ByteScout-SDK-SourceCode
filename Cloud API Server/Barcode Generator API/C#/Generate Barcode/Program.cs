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
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

namespace ByteScoutWebApiExample
{
	class Program
	{
		// Result file name
		const string ResultFileName = @".\barcode.png";
		// Barcode type. See valid barcode types in the documentation https://secure.bytescout.com/cloudapi.html#api-Default-barcodeGenerateGet
		const string BarcodeType = "Code128";
		// Barcode value
		const string BarcodeValue = "qweasd123456";

		static void Main(string[] args)
		{
			// Create standard .NET web client instance
			WebClient webClient = new WebClient();

			// Prepare URL for `Barcode Generator` API call
			string query = Uri.EscapeUriString(string.Format(
				"https://localhost/barcode/generate?name={0}&type={1}&value={2}", 
				Path.GetFileName(ResultFileName), 
				BarcodeType, 
				BarcodeValue));

			try
			{
				// Execute request
				string response = webClient.DownloadString(query);

				// Parse JSON response
				JObject json = JObject.Parse(response);

				if (json["error"].ToObject<bool>() == false)
				{
					// Get URL of generated barcode image file
					string resultFileURI = json["url"].ToString();
					
					// Download the image file
					webClient.DownloadFile(resultFileURI, ResultFileName);

					Console.WriteLine("Generated barcode saved to \"{0}\" file.", ResultFileName);
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
