//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System.Diagnostics;
using Bytescout.PDFExtractor;

// To make OCR work you should references "Bytescout.PDFExtractor.dll" and "Bytescout.PDFExtractor.OCRExtension.dll" from your project.

namespace MakeSearchablePDFDiscardingExistingContent
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.TextExtractor instance
            SearchablePDFMaker searchablePDFMaker = new SearchablePDFMaker();
            searchablePDFMaker.RegistrationName = "demo";
            searchablePDFMaker.RegistrationKey = "demo";

            // Load sample PDF document
            searchablePDFMaker.LoadDocumentFromFile("sample_ocr_withText.pdf");
            
            // Set the location of language data files
            searchablePDFMaker.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\";

            // Set OCR language
            searchablePDFMaker.OCRLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder

            // Set PDF document rendering resolution
            searchablePDFMaker.OCRResolution = 300;

            // Discard Existing Text in document
            searchablePDFMaker.DiscardExistingDocumentText = true;

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
