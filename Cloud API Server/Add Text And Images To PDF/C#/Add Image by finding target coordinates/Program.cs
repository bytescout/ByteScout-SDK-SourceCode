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
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace ByteScoutWebApiExample
{
    // Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
    // If it's not then please replace this with with your hosting url.
    class Program
    {
        // Direct URL of source PDF file.
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

            // Find Text coordinates to add image
            var oCoordinates = FindCoordinates(SourceFileUrl, "Your Company Name");
            var Y1 = oCoordinates.y;
            var X1 = 450;
            var Width1 = 119;
            var Height1 = 32;

            // * Add image *
            // Prepare URL for `PDF Edit` API call
            string query = Uri.EscapeUriString(string.Format(
                    "https://localhost/pdf/edit/add?name={0}&password={1}&pages={2}&url={3}&type={4}&x={5}&y={6}&width={7}&height={8}&urlimage={9}",
                    Path.GetFileName(DestinationFile),
                    Password,
                    Pages,
                    SourceFileUrl,
                    Type1,
                    X1,
                    Y1,
                    Width1,
                    Height1,
                    ImageUrl));

            try
            {
                // Execute request
                string response = webClient.DownloadString(query);

                // Parse JSON response
                JObject json = JObject.Parse(response);

                if (json["error"].ToObject<bool>() == false)
                {
                    // Get URL of generated PDF file
                    string resultFileUrl = json["url"].ToString();

                    // Download PDF file
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

            webClient.Dispose();

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }


        /// <summary>
        /// Find result coordinates
        /// </summary>
        public static ResultCoOrdinates FindCoordinates(string SourceFileUrl, string SearchString)
        {
            ResultCoOrdinates oResult = null;

            // Create standard .NET web client instance
            WebClient webClient = new WebClient();

            // Prepare URL for PDF text search API call.
            string query = Uri.EscapeUriString(string.Format(
                "https://localhost/pdf/find?url={0}&searchString={1}",
                SourceFileUrl,
                SearchString));

            try
            {
                // Execute request
                string response = webClient.DownloadString(query);

                // Parse JSON response
                JObject json = JObject.Parse(response);

                if (json["status"].ToString() != "error")
                {
                    JToken item = json["body"][0];

                    oResult = new ResultCoOrdinates
                    {
                        x = Convert.ToInt32(item["left"]),
                        y = Convert.ToInt32(item["top"]),
                        width = Convert.ToInt32(item["width"]),
                        height = Convert.ToInt32(item["height"])
                    };
                }
            }
            catch (WebException e)
            {
                Console.WriteLine(e.ToString());
            }

            webClient.Dispose();

            return oResult;
        }
    }

    public class ResultCoOrdinates
    {
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

}
