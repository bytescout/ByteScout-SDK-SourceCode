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


using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;

namespace ByteScoutWebApiExample
{
    class Program
	{
		// The authentication key (API Key).
		// Get your own by registering at https://app.pdf.co
		const String API_KEY = "***********************************";

		// Direct URL of source PDF file.
		const string SourceFileUrl = "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-info/sample.pdf";

		// Email Details
		const string From = "John Doe <john@example.com>";
		const string To = "Partner <partner@example.com>";
		const string Subject = "Check attached sample pdf";
		const string BodyText = "Please check the attached pdf";
		const string BodyHtml = "Please check the attached pdf";
		const string SmtpServer = "smtp.gmail.com";
		const string SmtpPort = "587";
		const string SmtpUserName = "my@gmail.com";
		const string SmtpPassword = "app specific password created as https://support.google.com/accounts/answer/185833";

		static void Main(string[] args)
		{
			// Create standard .NET web client instance
			WebClient webClient = new WebClient();

			// Set API Key
			webClient.Headers.Add("x-api-key", API_KEY);

			// URL for `Email Send` API call
			string url = "https://api.pdf.co/v1/email/send";

			// Prepare requests params as JSON
			Dictionary<string, object> parameters = new Dictionary<string, object>();
			parameters.Add("url", SourceFileUrl);

			parameters.Add("from", From);
			parameters.Add("to", To);
			parameters.Add("subject", Subject);
			parameters.Add("bodytext", BodyText);
			parameters.Add("bodyHtml", BodyHtml);
			parameters.Add("smtpserver", SmtpServer);
			parameters.Add("smtpport", SmtpPort);
			parameters.Add("smtpusername", SmtpUserName);
			parameters.Add("smtppassword", SmtpPassword);

			// Convert dictionary of params to JSON
			string jsonPayload = JsonConvert.SerializeObject(parameters);

			try
			{
				// Execute POST request with JSON payload
				string response = webClient.UploadString(url, jsonPayload);

				// Parse JSON response
				JObject json = JObject.Parse(response);

				if (json["error"].ToObject<bool>() == false)
				{
					Console.WriteLine("Email Sent Successfully!");
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
