using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

// This example demonstrates the using of PDF to HTML Web API

namespace BytescoutWebApiExample
{
    class Program
    {
        // The authentication key (API Key). 
        // Get your own by registering at https://secure.bytescout.com/users/sign_up
        const String API_KEY = "****************************";

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
                    // 2. Convert uploaded file to HTML

                    // Prepare URL for PDF To HTML API: /api/v1/pdftohtml/htmlextractor/extract
                    String url = "https://bytescout.io/api/v1/pdftohtml/htmlextractor/extract" +
                                 "?apiKey=" + API_KEY +
                                 "&properties.extractInvisibleText=false" +
                                 "&properties.trimSpaces=true" +
                                 "&properties.outputImageFormat=png" + // set PNG format for images extracted from PDF document 
                                 "&properties.outputPageWidth=1200" + // set output HTML page width in pixels
                                 "&inputType=fileId" + // set input type
                                 "&input=" + uploadedFileId + // set "input" parameter to the file ID we've got on the previous step
                                 "&outputType=link"; // result is download link to generated file

                    // Execute request
                    string resultFileLink = webClient.DownloadString(url);

                    // Download the result file
                    string fileName = Path.GetFileName(resultFileLink);
                    webClient.DownloadFile(resultFileLink, fileName);

                    Console.WriteLine("Generated HTML document is saved to \"{0}\" file", fileName);
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
