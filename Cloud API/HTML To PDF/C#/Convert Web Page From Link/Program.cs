using System;
using System.Diagnostics;
using System.Net;
using System.Text;

// This example demonstrates the using of HTML to PDF Web API

namespace BytescoutWebApiExample
{
    class Program
    {
        // The authentication key (API Key). 
        // Get your own by registering at https://secure.bytescout.com/users/sign_up
        const String API_KEY = "********************************";

        static void Main(string[] args)
        {
            String inputURL = "http://google.com";
            String outputFile = "result.pdf";

            WebClient webClient = new WebClient();

            try
            {
                // Prepare URL for HTML to PDF API: /api/v1/htmltopdf/convert
                String url = "https://bytescout.io//api/v1/htmltopdf/convert" +
                    "?apiKey=" + API_KEY +
                    "&properties.title=GOOGLE.COM" + // set PDF document title (optional)
                    "&properties.orientation=landscape" + // set page orientation (portrait/landscape)
                    "&properties.headerHTML=<div style=\"display: block; text-align: right;\">*** Header ***</div>" + // set header text for each PDF page (optional)
                    "&properties.footerHTML=*** Footer ***" + // set footer text for each PDF page (optional)
                    "&inputType=link" + // set input type to "link"
                    "&input=" + inputURL +
                    "&outputType=link"; // the result will contain download link to generated file
                    
                // Execute request
                string resultFileLink = webClient.DownloadString(url);

                // Download the result file
                webClient.DownloadFile(resultFileLink, outputFile);

                Console.WriteLine("Generated PDF document image is saved to \"{0}\" file", outputFile);
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
