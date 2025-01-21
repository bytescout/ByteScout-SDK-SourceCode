//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.PDFExtractor;
using System;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.JSONExtractor instance
            JSONExtractor extractor = new JSONExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Load sample PDF document
            extractor.LoadDocumentFromFile("sample3.pdf");

            // Add the following params to get clean data with word nodes only:
            extractor.DetectNewColumnBySpacesRatio = 0.1f;  // this splits all text into words
            extractor.PreserveFormattingOnTextExtraction = false;  // Get rid Of empty nodes

            extractor.SaveJSONToFile("output.json");

            // Cleanup
            extractor.Dispose();

            Console.WriteLine();
            Console.WriteLine("Data has been extracted to 'output.json' file.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue and open JSON in default viewer...");
            Console.ReadKey();

            ProcessStartInfo processStartInfo = new ProcessStartInfo("output.json");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
