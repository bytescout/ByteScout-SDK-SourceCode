//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace ByteScoutWebApiExample
{
    class Program
    {
        // The authentication key (API Key).
        // Get your own by registering at https://app.pdf.co
        const String API_KEY = "**************************";

        // Direct URL of source PDF file.
        // You can also upload your own file into PDF.co and use it as url. Check "Upload File" samples for code snippets: https://github.com/bytescout/pdf-co-api-samples/tree/master/File%20Upload/
        const string SourceFileUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-edit/sample.pdf";
        // Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
        const string Pages = "";
        // PDF document password. Leave empty for unprotected documents.
        const string Password = "";

        // Destination PDF file name
        const string DestinationFile = @".\result.pdf";

        // Image params
        private const string Type1 = "image";
        private const string ImageUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-edit/logo.png";

        static void Main(string[] args)
        {
            // Create standard .NET web client instance
            WebClient webClient = new WebClient();

            // Set API Key
            webClient.Headers.Add("x-api-key", API_KEY);

            // Find coordinates of key phrase to add image at the same Y coordinate
            var coordinates = FindCoordinates(API_KEY, SourceFileUrl, "Your Company Name");
            var y1 = coordinates.Y;
            var x1 = 450;
            var width1 = 119;
            var height1 = 32;

            // * Add image *

            // Prepare requests params as JSON
             string jsonPayload = $@"{{
    ""name"": ""{Path.GetFileName(DestinationFile)}"",
    ""url"": ""{SourceFileUrl}"",
    ""password"": ""{Password}"",
    ""images"": [
        {{
            ""url"": ""{ImageUrl}"",
            ""x"": {x1},
            ""y"": {y1},
            ""width"": {width1},
            ""height"": {height1},
            ""pages"": ""{Pages}""
        }}
    ]
}}";

            try
            {
                // URL of "PDF Edit" endpoint
                string url = "https://api.pdf.co/v1/pdf/edit/add";

                // Execute POST request with JSON payload
                string response = webClient.UploadString(url, jsonPayload);

                // Parse JSON response
                JObject json = JObject.Parse(response);

                if (json["error"].ToObject<bool>() == false)
                {
                    // Get URL of generated PDF file
                    string resultFileUrl = json["url"].ToString();

                    // Download generated PDF file
                    webClient.DownloadFile(resultFileUrl, DestinationFile);

                    Console.WriteLine("Generated PDF file saved as \"{0}\" file.", DestinationFile);
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
            finally
            {
                webClient.Dispose();
            }
            
            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }


        /// <summary>
        /// Find text coordinates
        /// </summary>
        public static ResultCoordinates FindCoordinates(string apiKey, string sourceFileUrl, string searchString)
        {
            ResultCoordinates result = null;

            // Create standard .NET web client instance
            WebClient webClient = new WebClient();

            // Set API Key
            webClient.Headers.Add("x-api-key", apiKey);

            // Prepare requests params as JSON
            // See documentation: https://apidocs.pdf.co/?#pdf-search-text
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("url", sourceFileUrl);
            parameters.Add("searchString", searchString);
            // Convert dictionary of params to JSON
            string jsonPayload = JsonConvert.SerializeObject(parameters);

            try
            {
                // URL of "PDF Find" endpoint
                string url = "https://api.pdf.co/v1/pdf/find";

                // Execute POST request with JSON payload
                string response = webClient.UploadString(url, jsonPayload);

                // Parse JSON response
                JObject json = JObject.Parse(response);

                if (json["status"].ToString() != "error")
                {
                    JToken item = json["body"][0];

                    result = new ResultCoordinates
                    {
                        X = Convert.ToInt32(item["left"]),
                        Y = Convert.ToInt32(item["top"]),
                        Width = Convert.ToInt32(item["width"]),
                        Height = Convert.ToInt32(item["height"])
                    };
                }
            }
            catch (WebException e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
            finally
            {
                webClient.Dispose();
            }

            return result;
        }
    }

    public class ResultCoordinates
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
