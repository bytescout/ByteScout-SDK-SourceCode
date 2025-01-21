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
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

namespace ByteScoutWebApiExample
{
    class Program
    {
        // Source PDF file
        const string SourceFileUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/document-parser/MultiPageTable.pdf";

        // Destination TXT file name
        const string DestinationFile = @".\result.json";

        static void Main(string[] args)
        {
            // Template text. Use Document Parser (https://pdf.co/document-parser, https://app.pdf.co/document-parser)
            // to create templates.
            // Read template from file:
            String templateText = File.ReadAllText(@".\MultiPageTable-template1.yml");

            // Create standard .NET web client instance
            WebClient webClient = new WebClient();

            try
            {
                // PARSE UPLOADED PDF DOCUMENT

                // URL for `Document Parser` API call
                string query = Uri.EscapeUriString(string.Format(
                    "https://localhost/pdf/documentparser?url={0}",
                    SourceFileUrl));

                Dictionary<string, string> requestBody = new Dictionary<string, string>();
                requestBody.Add("template", templateText);

                // Execute request
                string response = webClient.UploadString(query, "POST", JsonConvert.SerializeObject(requestBody));

                // Parse response
                JObject json = JObject.Parse(response);

                if (json["error"].ToObject<bool>() == false)
                {
                    // Get URL of generated JSON file
                    string resultFileUrl = json["url"].ToString();

                    // Download JSON file
                    webClient.DownloadFile(resultFileUrl, DestinationFile);

                    Console.WriteLine("Generated JSON file saved as \"{0}\" file.", DestinationFile);
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
