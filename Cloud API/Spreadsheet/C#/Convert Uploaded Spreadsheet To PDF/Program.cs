using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

// This example demonstrates the using of Spreadsheet Web API

namespace BytescoutWebApiExample
{
    class Program
    {
        // The authentication key (API Key). 
        // Get your own by registering at https://secure.bytescout.com/users/sign_up
        const String API_KEY = "***********************************";

        static void Main(string[] args)
        {
            string inputFile = "sample.xlsx";
            string uploadedFileId = null;

            WebClient webClient = new WebClient();

            try
            {
                // 1. Upload source file

                byte[] responseArray = webClient.UploadFile("https://bytescout.io/api/v1/file/upload?apiKey=" + API_KEY, inputFile);
                if (responseArray != null)
                    uploadedFileId = Encoding.ASCII.GetString(responseArray);

                if (uploadedFileId != null)
                {
                    // 2. Convert XLSX to PDF

                    // Prepare URL for Spreadsheet API: /api/v1/spreadsheet/convert
                    String url = "https://bytescout.io/api/v1/spreadsheet/convert" +
                                 "?apiKey=" + API_KEY +
                                 "&properties.convertType=pdf" + // set output format
                                 "&properties.createNavigationLinks=true" + // set rendering resolution
                                 "&properties.autoSize=false" + // disable auto-sizing for output PDF
                                 "&inputType=fileId" + // set input type
                                 "&input=" + uploadedFileId + // set "input" parameter to the file ID we've got on the previous step
                                 "&outputType=link"; // result is download link to generated file

                    // Execute request
                    string resultFileLink = webClient.DownloadString(url);

                    // Download the result file
                    string fileName = Path.GetFileName(resultFileLink);
                    webClient.DownloadFile(resultFileLink, fileName);

                    Console.WriteLine("Generated document is saved to \"{0}\" file", fileName);
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
