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
using System.Diagnostics;

namespace LifeAndAnnuityQuoteRequest
{
    class Program
	{
		static void Main(string[] args)
		{
            // Create Bytescout.PDFExtractor.CSVExtractor instance
            CSVExtractor extractor = new CSVExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";

            // Load sample PDF document
            extractor.LoadDocumentFromFile(@".\SampleGroupDisabilityForm.pdf");

            // Set extraction area
            extractor.SetExtractionArea(new System.Drawing.RectangleF(27F, 324.8F, 554.3F, 358.5F));

            // Check whether rows can be grouped
            extractor.LineGroupingMode = LineGroupingMode.GroupByRows;

            // Extract results
            var outputFile = "result.csv";
            extractor.SaveCSVToFile(outputFile);

            // Cleanup
            extractor.Dispose();

            // Open with default associated program
            ProcessStartInfo processStartInfo = new ProcessStartInfo(outputFile);
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
		}
	}
}
