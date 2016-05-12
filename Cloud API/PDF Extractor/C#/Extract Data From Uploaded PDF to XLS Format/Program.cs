using System;
using System.Diagnostics;
using System.Net;
using System.Text;

namespace BytescoutWebApiExample
{
    class Program
    {
        // The authentication key (API Key). 
        // Get your own by registering at https://secure.bytescout.com/users/sign_up
        const String API_KEY = "***********************************";

        static void Main(string[] args)
        {
            string inputFile = "sample.pdf";
            string outputFile = "result.csv";
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
                    // 2. Extract PDF document content to CSV format

                    // Prepare URL for CSV Extractor API
                    String url = "https://bytescout.io/api/v1/pdfextractor/csvextractor/extract" +
                                 "?apiKey=" + API_KEY +
                                 "&properties.csvSeparatorSymbol=;" + // set CSV separator char
                                 "&properties.csvQuotaionSymbol=\"" + // set CSV qutation char
                                 "&properties.trimSpaces=true" + // trim spaces
                                 "&inputType=fileId" + // input is uploaded file ID
                                 "&input=" + uploadedFileId +
                                 "&outputType=link"; // output is the download link of generated file

                    // Execute request
                    string resultFileLink = webClient.DownloadString(url);
                    
                    // Download the result file
                    webClient.DownloadFile(resultFileLink, outputFile);

                    Console.WriteLine("The result is saved to 'result.csv'.");
                    
                    Console.WriteLine();
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
            }
        }
    }
}
