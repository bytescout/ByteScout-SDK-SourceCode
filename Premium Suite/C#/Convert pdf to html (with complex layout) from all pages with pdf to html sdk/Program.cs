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

namespace ExtractHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDF2HTML.HTMLExtractor instance
            HTMLExtractor extractor = new HTMLExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Set HTML with CSS extraction mode
            extractor.ExtractionMode = HTMLExtractionMode.HTMLWithCSS;

            // Load sample PDF document
            extractor.LoadDocumentFromFile("sample2.pdf");

            // Save extracted HTML to file
            extractor.SaveHtmlToFile("output.html");

            // Cleanup
            extractor.Dispose();

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("output.html");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
