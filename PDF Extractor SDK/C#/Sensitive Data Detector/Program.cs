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
using System.Drawing;
using Bytescout.PDFExtractor;

namespace SensitiveDataDetectorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.SensitiveDataDetector instance
            SensitiveDataDetector sensitiveDataDetector = new SensitiveDataDetector();
            sensitiveDataDetector.RegistrationName = "demo";
            sensitiveDataDetector.RegistrationKey = "demo";

            // Load sample PDF document
            sensitiveDataDetector.LoadDocumentFromFile(@".\samplePDF_EmailSSN.pdf");

            // Set the location of OCR language data files
            sensitiveDataDetector.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\";

            // Perform detecting sensitive data
            SensitiveDataDetectionResults detectionResults = sensitiveDataDetector.PerformDetection();

            // Generate Report
            string report = sensitiveDataDetector.GenerateReport(detectionResults, SensitiveDataReportFormat.TXT);

            Console.WriteLine(report);
 
            // Cleanup
			sensitiveDataDetector.Dispose();

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
