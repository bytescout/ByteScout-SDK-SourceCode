//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


using Bytescout.PDFExtractor;

// To make OCR work you should add to your project references to Bytescout.PDFExtractor.dll and Bytescout.PDFExtractor.OCRExtension.dll 

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

            // Load sample PDF document
            searchablePDFMaker.LoadDocumentFromFile("sample_ocr.pdf");
            
            // Set the location of "tessdata" folder containing language data files
            searchablePDFMaker.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\Redistributable\net2.00\tessdata\";

            // Set OCR language
            searchablePDFMaker.OCRLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in /tessdata

            // Set PDF document rendering resolution
            searchablePDFMaker.OCRResolution = 300;

            // Save extracted text to file
            searchablePDFMaker.MakePDFSearchable("output.pdf");

            searchablePDFMaker.Dispose();

            // Open output file in default associated application
            System.Diagnostics.Process.Start("output.pdf");
        }
    }
}
