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
using Bytescout.PDFExtractor;

// To make OCR work you should references "Bytescout.PDFExtractor.dll" and "Bytescout.PDFExtractor.OCRExtension.dll" from your project.

namespace MakeSearchablePDF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.TextExtractor instance
            SearchablePDFMaker searchablePDFMaker = new SearchablePDFMaker();
            searchablePDFMaker.RegistrationName = "demo";
            searchablePDFMaker.RegistrationKey = "demo";

            // Load sample Image document
            searchablePDFMaker.LoadDocumentFromFile("sample_ocr.jpg");
            
            // Set the location of OCR language data files
            searchablePDFMaker.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\";

            // Set OCR language
            searchablePDFMaker.OCRLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder

            // Set PDF document rendering resolution
            searchablePDFMaker.OCRResolution = 300;

            // Save extracted text to file
            searchablePDFMaker.MakePDFSearchable("output.pdf");

            // Cleanup
            searchablePDFMaker.Dispose();

            // Open output file in default associated application
            ProcessStartInfo processStartInfo = new ProcessStartInfo("output.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
