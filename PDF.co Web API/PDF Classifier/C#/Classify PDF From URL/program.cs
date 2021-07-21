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
	class HelloWorld {
		static void Main(string[] args) {
			var client = new RestClient("https://api.pdf.co/v1/pdf/classifier");
			client.Timeout = -1;
			var request = new RestRequest(Method.POST);
			request.AddHeader("Content-Type", "application/json");
			request.AddHeader("x-api-key", "");

			// You can also upload your own file into PDF.co and use it as url. Check "Upload File" samples for code snippets: https://github.com/bytescout/pdf-co-api-samples/tree/master/File%20Upload/						
			var body = @"{" + "\n" +
			@"    ""url"": ""https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/document-parser/sample-invoice.pdf""," + "\n" +
			@"    ""rulescsv"": ""Amazon,Amazon Web Services Invoice|Amazon CloudFront\nDigital Ocean,DigitalOcean|DOInvoice\nAcme,ACME Inc.|1540 Long Street, Jacksonville, 32099""," + "\n" +
			@"    ""caseSensitive"": ""true""," + "\n" +
			@"    ""async"": false," + "\n" +
			@"    ""encrypt"": ""false""," + "\n" +
			@"    ""inline"": ""true""," + "\n" +
			@"    ""password"": """"," + "\n" +
			@"    ""profiles"": """"" + "\n" +
			@"} ";
			request.AddParameter("application/json", body,  ParameterType.RequestBody);
			IRestResponse response = client.Execute(request);
			Console.WriteLine(response.Content);
		}
	}
}

