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
using RestSharp;
namespace HelloWorldApplication {
	// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
	// If it's not then please replace this with with your hosting url.
		class HelloWorld {
				static void Main(string[] args) {
						var client = new RestClient("https://localhost/email/decode");
						client.Timeout = -1;
						var request = new RestRequest(Method.POST);
						request.AddHeader("Content-Type", "application/json");
						request.AddHeader("x-api-key", "{{x-api-key}}");
						request.AlwaysMultipartFormData = true;
						request.AddParameter("url", "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/email-extractor/sample.eml");
						IRestResponse response = client.Execute(request);
						Console.WriteLine(response.Content);
				}
		}
}
