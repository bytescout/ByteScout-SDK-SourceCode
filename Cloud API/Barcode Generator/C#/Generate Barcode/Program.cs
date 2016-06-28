using System;
using System.Diagnostics;
using System.Net;

// This example demonstrates the using of Barcode Generator Web API

namespace BytescoutWebApiExample
{
    class Program
    {
        // The authentication key (API Key). 
        // Get your own by registering at https://secure.bytescout.com/users/sign_up
        const String API_KEY = "********************************";

        static void Main(string[] args)
        {
            String outputFile = "barcode.png";

            WebClient webClient = new WebClient();

            try
            {
                // Prepare URL for Barcode Generator API: /api/v1/barcode/generate
                String url = "https://bytescout.io/api/v1/barcode/generate" +
                    "?apiKey=" + API_KEY +
                    "&properties.symbology=qrCode" + // set barcode type
                    "&properties.outputFileType=png" + // set output image format
                    "&outputType=link" + // the result will contain download link to generated file
                    "&input=123456abcdef"; // set barcode value

                // Execute request
                string resultFileLink = webClient.DownloadString(url);

                // Download the result file
                webClient.DownloadFile(resultFileLink, outputFile);

				Console.WriteLine("Generated barcode image is saved to \"{0}\" file", outputFile);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
