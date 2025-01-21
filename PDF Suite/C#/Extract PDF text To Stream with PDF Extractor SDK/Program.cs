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
using System.Diagnostics;
using Bytescout.PDFExtractor;

namespace ExtractToStream
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.TextExtractor instance
            TextExtractor extractor = new TextExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Load sample PDF document
            extractor.LoadDocumentFromFile(@".\sample1.pdf");

            // Get page count
            int pageCount = extractor.GetPageCount();

            for (int i = 0; i < pageCount; i++)
            {
                // Create new stream. You can use MemoryStream or any other System.IO.Stream inheritor.
                FileStream stream = new FileStream(@".\page" + i + ".txt", FileMode.Create);
                
                // Save text from page to the file stream
                extractor.SavePageTextToStream(i, stream);

                // Close stream
                stream.Dispose();
            }

            // Cleanup
            extractor.Dispose();

            // Open first output file in default associated application
            ProcessStartInfo processStartInfo = new ProcessStartInfo(@".\page1.txt");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
