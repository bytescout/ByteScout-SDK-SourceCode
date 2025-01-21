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
						var client = new RestClient("https://localhost/file/upload/get-presigned-url?name=test.pdf&encrypt=true");
						client.Timeout = -1;
						var request = new RestRequest(Method.GET);
						request.AddHeader("x-api-key", "{{x-api-key}}");
						request.AlwaysMultipartFormData = true;
						IRestResponse response = client.Execute(request);
						Console.WriteLine(response.Content);
				}
		}
}
