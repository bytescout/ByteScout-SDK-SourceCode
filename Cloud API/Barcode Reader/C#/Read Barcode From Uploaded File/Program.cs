using System;
using System.Diagnostics;
using System.Net;
using System.Text;

// This example demonstrates the using of Barcode Reader Web API

namespace BytescoutWebApiExample
{
    class Program
    {
        // The authentication key (API Key). 
        // Get your own by registering at https://secure.bytescout.com/users/sign_up
        const String API_KEY = "***********************************";

        static void Main(string[] args)
        {
            string inputFile = "QRCode.jpg";
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
                    // 2. Read barcode

                    // Prepare URL for Barcode Reader API: /api/v1/barcodereader/read
                    String url = "https://bytescout.io/api/v1/barcodereader/read" +
                                 "?apiKey=" + API_KEY +
                                 "&properties.barcodeTypesToFind.qrCode=true" + // // enable QR Code decoding
                                 "&inputType=fileId" + // input is uploaded file ID
                                 "&input=" + uploadedFileId + // set "input" parameter to the file ID we've got on the previous step
                                 "&outputType=content"; // output is JSON or XML string containing decoding results

                    // Set the result format to JSON. Change to "application/xml" if you prefer XML.
                    webClient.Headers.Add("Accept", "application/json");

                    // Execute request
                    string decodingResults = webClient.DownloadString(url);

                    Console.WriteLine("Decoding results:");
                    Console.WriteLine();
                    Console.WriteLine(decodingResults);
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
