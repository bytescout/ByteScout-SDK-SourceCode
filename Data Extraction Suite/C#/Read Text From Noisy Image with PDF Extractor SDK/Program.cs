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


using Bytescout.PDFExtractor;
using System;

namespace ReadTextFromNoisyImage
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Read all text from noisy image file
                using (TextExtractor extractor = new TextExtractor())
                {
                    // Load noisy image document
                    extractor.LoadDocumentFromFile("sample.png");

                    // Set the font repairing OCR mode 
                    extractor.OCRMode = OCRMode.TextFromImagesAndVectorsAndRepairedFonts;

                    // Set the location of OCR language data files
                    extractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\";

                    // Set OCR language
                    extractor.OCRLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
                                                   // Find more language files at https://github.com/bytescout/ocrdata

                    // Set document rendering resolution
                    extractor.OCRResolution = 300;

                    // You can also apply various preprocessing filters
                    // to improve the recognition on low-quality scans.

					Console.WriteLine("Please wait while PDF Extractor SDK is processing noisy image to read data...");

                    // Automatically deskew skewed scans
                    extractor.OCRImagePreprocessingFilters.AddDeskew();

                    // Remove vertical or horizontal lines (sometimes helps to avoid OCR engine's page segmentation errors)
                    //extractor.OCRImagePreprocessingFilters.AddVerticalLinesRemover();
                    //extractor.OCRImagePreprocessingFilters.AddHorizontalLinesRemover();

                    // Repair broken letters
                    extractor.OCRImagePreprocessingFilters.AddDilate();
                    
                    // Remove noise
                    extractor.OCRImagePreprocessingFilters.AddMedian();

                    // Apply Gamma Correction
                    extractor.OCRImagePreprocessingFilters.AddGammaCorrection();

                    // Add Contrast
                    //extractor.OCRImagePreprocessingFilters.AddContrast(20);

                    // (!) You can use new OCRAnalyser class to find an optimal set of image preprocessing 
                    // filters for your specific document.
                    // See "OCR Analyser" example.

                    //Read all text
                    string allText = extractor.GetText();

                    Console.Clear();
                    Console.WriteLine("Extracted Text: \n\n" + allText);
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Exception: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
