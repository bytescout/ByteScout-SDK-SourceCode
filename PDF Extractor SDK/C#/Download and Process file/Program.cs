//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System.Diagnostics;
using System.IO;
using Bytescout.PDFExtractor;

namespace ExtractText
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.TextExtractor instance
            TextExtractor extractor = new TextExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Input file Url
            var inputUrl = @"https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-text/sample.pdf";

            // Get Input Stream
            var inpStream = GetStreamFromUrl(inputUrl);

            // Load sample PDF document
            extractor.LoadDocumentFromStream(inpStream);

            // Save extracted text to file
            extractor.SaveTextToFile(@".\result.txt");

            // Cleanup
            extractor.Dispose();

            // Open result file in default associated application
            ProcessStartInfo processStartInfo = new ProcessStartInfo(@".\result.txt");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }

        /// <summary>
        /// Get stream from Url
        /// </summary>
        private static Stream GetStreamFromUrl(string url)
        {
            byte[] oData = null;

            using (var wc = new System.Net.WebClient())
                oData = wc.DownloadData(url);

            return new MemoryStream(oData);
        }

    }
}
