using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

// This example demonstrates the using of PDF Renderer Web API

namespace BytescoutWebApiExample
{
    class Program
    {
        // The authentication key (API Key). 
        // Get your own by registering at https://secure.bytescout.com/users/sign_up
        const String API_KEY = "*****************************";

        static void Main(string[] args)
        {
            string inputFile = "sample.pdf";
            string uploadedFileId = null;

            WebClient webClient = new WebClient();

            try
            {
                // 1. Upload PDF file

                byte[] responseArray = webClient.UploadFile("https://bytescout.io/api/v1/file/upload?apiKey=" + API_KEY, inputFile);
                if (responseArray != null)
                    uploadedFileId = Encoding.ASCII.GetString(responseArray);

                if (uploadedFileId != null)
                {
                    // 2. Convert uploaded document to image

                    // Prepare URL for PDF Renderer API: /api/v1/pdfrenderer/render
                    String url = "https://bytescout.io/api/v1/pdfrenderer/render" +
                                 "?apiKey=" + API_KEY +
                                 "&properties.pageIndex=0" + // set page index to convert
                                 "&properties.resolution=300" + // set rendering resolution
                                 "&properties.rasterOutputFormat=jpeg" + // set JPEG output format
                                 "&properties.JPEGQuality=85" + // set JPEG quality
                                 "&inputType=fileId" + // set input type
                                 "&input=" + uploadedFileId + // set "input" parameter to the file ID we've got on the previous step
                                 "&outputType=link"; // result is download link to generated file

                    // Execute request
                    string resultFileLink = webClient.DownloadString(url);

                    // Download the result file
                    string fileName = Path.GetFileName(resultFileLink);
                    webClient.DownloadFile(resultFileLink, fileName);

                    Console.WriteLine("Generated image is saved to \"{0}\" file", fileName);
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
