using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;

// This example demonstrates creation of PDF document from the HTML template and the template data in JSON form.

namespace BytescoutWebApiExample
{
    class Program
    {
        // The authentication key (API Key). 
        // Get your own by registering at https://secure.bytescout.com/users/sign_up
        const String API_KEY = "*********************************";

        static void Main(string[] args)
        {
            String template = File.ReadAllText("invoice_template.html");
            String templateData = File.ReadAllText("invoice_data.json");
            String outputFile = "result.pdf";

            WebClient webClient = new WebClient();

            try
            {
                // Prepare URL for HTML to PDF API: /api/v1/htmltopdf/convert
                String url = "https://bytescout.io//api/v1/htmltopdf/convert?apiKey=" + API_KEY;

                // Prepare request data in JSON format
                JObject jsonObject = new JObject(
                    new JProperty("properties", new JObject(
                        new JProperty("templateData", templateData))),
                    new JProperty("inputType", "value"),
                    new JProperty("input", template),
                    new JProperty("outputType", "link")
                    );

                webClient.Headers.Add("Content-Type", "application/json");

                // Execute request
                string resultFileLink = webClient.UploadString(url, jsonObject.ToString());

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
