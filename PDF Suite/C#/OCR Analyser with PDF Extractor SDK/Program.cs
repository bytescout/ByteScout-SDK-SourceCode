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


using System;
using System.Drawing;
using System.Diagnostics;
using Bytescout.PDFExtractor;

// This example demonstrates the use of OCR Analyser - a tooling class for analysis of scanned documents
// in PDF or raster image formats to find best parameters for Optical Character Recognition (OCR) that
// provide highest recognition quality.

// To make OCR work you should add the following references to your project:
// 'Bytescout.PDFExtractor.dll', 'Bytescout.PDFExtractor.OCRExtension.dll'.

namespace OCRAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input document
            string inputDocument = @".\sample_ocr.pdf";
            
            // Document page index
            int pageIndex = 0;
            
            // Area of the document page to perform the analysis (optional).
            // RectangleF.Empty means the full page.
            RectangleF rectangle = RectangleF.Empty; // new RectangleF(100, 50, 350, 250);

            // Location of language data files
            string ocrLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best_best\";

            // OCR language
            string ocrLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
            // Find more language files at https://github.com/bytescout/ocrdata


            // Create OCRAnalyzer instance and activate it with your registration information
            using (OCRAnalyzer ocrAnalyzer = new OCRAnalyzer("demo", "demo"))
            {
                // Display analysis progress
                ocrAnalyzer.ProgressChanged += (object sender, string message, double progress, ref bool cancel) =>
                {
                    Console.WriteLine(message);
                };

                // Load document to OCRAnalyzer
                ocrAnalyzer.LoadDocumentFromFile(inputDocument);

                // Setup OCRAnalyzer
                ocrAnalyzer.OCRLanguage = ocrLanguage;
                ocrAnalyzer.OCRLanguageDataFolder = ocrLanguageDataFolder;
                
                // Set page area for analysis (optional)
                ocrAnalyzer.SetExtractionArea(rectangle);
                
                // Perform analysis and get results
                OCRAnalysisResults analysisResults = ocrAnalyzer.AnalyzeByOCRConfidence(pageIndex);


                // Now extract the text using detected OCR parameters

                string outputDocument = @".\result.txt";
                
                // Create TextExtractor instance
                using (TextExtractor textExtractor = new TextExtractor("demo", "demo"))
                {
                    // Load document to TextExtractor
                    textExtractor.LoadDocumentFromFile(inputDocument);

                    // Setup TextExtractor
                    textExtractor.OCRMode = OCRMode.Auto;
                    textExtractor.OCRLanguageDataFolder = ocrLanguageDataFolder;
                    textExtractor.OCRLanguage = ocrLanguage;

                    // Apply analysis results to TextExtractor instance
                    ocrAnalyzer.ApplyResults(analysisResults, textExtractor);

                    // Set extraction area (optional)
                    textExtractor.SetExtractionArea(rectangle);

                    // Save extracted text to file
                    textExtractor.SaveTextToFile(outputDocument);

                    // Open result document in default associated application (for demo purpose)
                    ProcessStartInfo processStartInfo = new ProcessStartInfo(outputDocument);
                    processStartInfo.UseShellExecute = true;
                    Process.Start(processStartInfo);
                }
            }
        }
    }
}
