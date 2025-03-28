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
						var client = new RestClient("<insert presignedUrl generated by https://localhost/file/upload/get-presigned-url >");
						client.Timeout = -1;
						var request = new RestRequest(Method.PUT);
						request.AddHeader("x-api-key", "{{x-api-key}}");
						request.AddFile("file", "/Users/em/Downloads/logo.png");
						IRestResponse response = client.Execute(request);
						Console.WriteLine(response.Content);
				}
		}
}
