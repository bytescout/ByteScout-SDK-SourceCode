//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using ByteScout.DocumentParser;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;

namespace BloodTestResultsToJson
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample document containing blood test report
            // Report consists of sample patient information such as patinet name, DOB, patientID
            // Report information such as report type, collection date and time
            // Test components such as complete blood count, Hemoglobin, White Blood Cell (WBC), Red Blood Cell (RBC), etc.
            string sampleDocument = @".\SampleBloodReport.pdf";

            // Sample template which primarily extracts patient name, report date and test result table.
            string sampleTemplate = @".\SampleBloodReport.yml";

            // Perform parsing with SDK
            ParseWithSDK(sampleDocument, sampleTemplate);

            // Perform parsing with PDF.co api
            // ParseWithPDFCoApi(sampleDocument, sampleTemplate);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        /// <summary>
        /// Parse with Document Parser SDK
        /// </summary>
        static void ParseWithSDK(string sampleDocument, string sampleTemplate)
        {
            // Create DocumentParser instance
            using (DocumentParser documentParser = new DocumentParser("demo", "demo"))
            {
                // Add sample template
                documentParser.AddTemplate(sampleTemplate);

                // Parse document data in JSON format
                string jsonString = documentParser.ParseDocument(sampleDocument, OutputFormat.JSON);

                string resultFile = "result.json";

                // Write output file
                File.WriteAllText(resultFile, jsonString);

                Console.WriteLine($"Generated JSON file saved as {resultFile} file");
            }
        }

        /// <summary>
        /// Parse with PDF.Co API
        /// </summary>
        static void ParseWithPDFCoApi(string SourceFile, string sampleTemplate)
        {
            // The authentication key (API Key).
            // Get your own by registering at https://app.pdf.co/documentation/api
            const String API_KEY = "***********************************";

            // PDF document password. Leave empty for unprotected documents.
            const string Password = "";

            // Destination TXT file name
            const string DestinationFile = @".\result.json";

            // (!) Make asynchronous job
            const bool Async = true;

            // Template text. Use Document Parser SDK (https://bytescout.com/products/developer/documentparsersdk/index.html)
            // to create templates.
            // Read template from file:
            String templateText = File.ReadAllText(sampleTemplate);

            // Create standard .NET web client instance
            WebClient webClient = new WebClient();

            // Set API Key
            webClient.Headers.Add("x-api-key", API_KEY);

            // 1. RETRIEVE THE PRESIGNED URL TO UPLOAD THE FILE.
            // * If you already have a direct file URL, skip to the step 3.

            // Prepare URL for `Get Presigned URL` API call
            string query = Uri.EscapeUriString(string.Format(
                "https://api.pdf.co/v1/file/upload/get-presigned-url?contenttype=application/octet-stream&name={0}",
                Path.GetFileName(SourceFile)));

            try
            {
                // Execute request
                string response = webClient.DownloadString(query);

                // Parse JSON response
                JObject json = JObject.Parse(response);

                if (json["error"].ToObject<bool>() == false)
                {
                    // Get URL to use for the file upload
                    string uploadUrl = json["presignedUrl"].ToString();
                    string uploadedFileUrl = json["url"].ToString();

                    // 2. UPLOAD THE FILE TO CLOUD.

                    webClient.Headers.Add("content-type", "application/octet-stream");
                    webClient.UploadFile(uploadUrl, "PUT", SourceFile); // You can use UploadData() instead if your file is byte[] or Stream
                    webClient.Headers.Remove("content-type");

                    // 3. PARSE UPLOADED PDF DOCUMENT

                    // URL for `Document Parser` API call
                    query = Uri.EscapeUriString(string.Format(
                        "https://api.pdf.co/v1/pdf/documentparser?url={0}&async={1}",
                        uploadedFileUrl,
                        Async));

                    Dictionary<string, string> requestBody = new Dictionary<string, string>();
                    requestBody.Add("template", templateText);

                    // Execute request
                    response = webClient.UploadString(query, "POST", JsonConvert.SerializeObject(requestBody));

                    // Parse JSON response
                    json = JObject.Parse(response);

                    if (json["error"].ToObject<bool>() == false)
                    {
                        // Asynchronous job ID
                        string jobId = json["jobId"].ToString();
                        // Get URL of generated JSON file
                        string resultFileUrl = json["url"].ToString();

                        // Check the job status in a loop. 
                        // If you don't want to pause the main thread you can rework the code 
                        // to use a separate thread for the status checking and completion.
                        do
                        {
                            string status = CheckJobStatus(webClient, jobId); // Possible statuses: "working", "failed", "aborted", "success".

                            // Display timestamp and status (for demo purposes)
                            Console.WriteLine(DateTime.Now.ToLongTimeString() + ": " + status);

                            if (status == "success")
                            {
                                // Download JSON file
                                webClient.DownloadFile(resultFileUrl, DestinationFile);

                                Console.WriteLine("Generated JSON file saved as \"{0}\" file.", DestinationFile);
                                break;
                            }
                            else if (status == "working")
                            {
                                // Pause for a few seconds
                                Thread.Sleep(3000);
                            }
                            else
                            {
                                Console.WriteLine(status);
                                break;
                            }
                        }
                        while (true);
                    }
                    else
                    {
                        Console.WriteLine(json["message"].ToString());
                    }
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
        }

        /// <summary>
        /// Check PDF.co job status
        /// </summary>
        static string CheckJobStatus(WebClient webClient, string jobId)
        {
            string url = "https://api.pdf.co/v1/job/check?jobid=" + jobId;

            string response = webClient.DownloadString(url);
            JObject json = JObject.Parse(response);

            return Convert.ToString(json["status"]);
        }


    }
}
