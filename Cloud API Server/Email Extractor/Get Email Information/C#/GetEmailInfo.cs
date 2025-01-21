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
