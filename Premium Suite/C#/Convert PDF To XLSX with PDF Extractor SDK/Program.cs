//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System.IO;
using Bytescout.PDFExtractor;
using System.Diagnostics;

namespace PDF2XLS
{

    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.XLSExtractor instance
            XLSExtractor extractor = new XLSExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            File.Delete("output.xlsx");

            // Load sample PDF document
            extractor.LoadDocumentFromFile("sample3.pdf");

            // Uncomment this line if you need all pages converted into a single worksheet:
            //extractor.PageToWorksheet = false;

            // Set the output format to XLSX
            extractor.OutputFormat = SpreadseetOutputFormat.XLSX;
            
            // Save the spreadsheet to file
            extractor.SaveToXLSFile("output.xlsx");

            // Cleanup
            extractor.Dispose();

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("output.xlsx");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
