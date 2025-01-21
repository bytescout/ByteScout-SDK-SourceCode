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
using System.Diagnostics;
using Bytescout.PDF2HTML;

namespace ReduceMemoryUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            // When processing huge PDF documents you may run into OutOfMemoryException.
            // This example demonstrates a way to spare the memory by disabling page data caching.

            // Create Bytescout.PDF2HTML.HTMLExtractor instance
            using (HTMLExtractor extractor = new HTMLExtractor("demo", "demo"))
            {
                try
                {
                    // Load sample PDF document
                    extractor.LoadDocumentFromFile("sample2.pdf");

                    // Disable page data caching, so processed pages will be disposed automatically
                    extractor.PageDataCaching = PageDataCaching.None;

                    // Save result to file
                    extractor.SaveHtmlToFile("output.html");
                }
                catch (PDF2HTMLException exception)
                {
                    Console.Write(exception.ToString());
                }
            }

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("output.html");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
