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

namespace ReduceMemoryUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            // When processing huge PDF documents you may run into OutOfMemoryException.
            // This example demonstrates a way to spare the memory by disabling page data caching.

            // Create Bytescout.PDFExtractor.TextExtractor instance
            using (TextExtractor extractor = new TextExtractor("demo", "demo"))
            {
                try
                {
                    // Load sample PDF document
                    extractor.LoadDocumentFromFile("sample2.pdf");

                    // Disable page data caching, so processed pages wiil be disposed automatically
                    extractor.PageDataCaching = PageDataCaching.None;

                    // Save extracted text to file
                    extractor.SaveTextToFile("output.txt");
                }
                catch (PDFExtractorException exception)
                {
                    Console.Write(exception.ToString());
                }
            }

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("output.txt");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
