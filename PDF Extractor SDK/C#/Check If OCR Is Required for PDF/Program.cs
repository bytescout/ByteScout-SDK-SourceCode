//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.PDFExtractor;
using System;

namespace CheckIfOCRIsRequired
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Loop through all files in directory and check whether OCR operation is required
                foreach (string filePath in System.IO.Directory.GetFiles("InputFiles"))
                {
                    _CheckOCRRequired(filePath);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

			Console.WriteLine("Press enter key to exit...");
            Console.ReadLine();
        }

        
        /// <summary>
        /// Check whether OCR Operation is required
        /// </summary>
        /// <param name="filePath"></param>
        private static void _CheckOCRRequired(string filePath)
        {
            //Read all file content...
            using (TextExtractor extractor = new TextExtractor())
            {
                extractor.RegistrationKey = "demo";
                extractor.RegistrationName = "demo";

                // Load document
                extractor.LoadDocumentFromFile(filePath);
                Console.WriteLine("\n*******************\n\nFilePath: {0}", filePath);

                int pageIndex = 0;

                // Identify OCR operation is recommended for page
                if (extractor.IsOCRRecommendedForPage(pageIndex))
                {
                    Console.WriteLine("\nOCR Recommended: True");

                    // Enable Optical Character Recognition (OCR)
                    // in .Auto mode (SDK automatically checks if needs to use OCR or not)
                    extractor.OCRMode = OCRMode.Auto;

                    // Set the location of language data files
                    extractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\";

                    // Set OCR language
                    extractor.OCRLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
                    // Find more language files at https://github.com/bytescout/ocrdata

                    // Set PDF document rendering resolution
                    extractor.OCRResolution = 300;
                }
                else
                {
                    Console.WriteLine("\nOCR Recommended: False");
                }

                //Read all text
                var allExtractedText = extractor.GetText();
                Console.WriteLine("\nExtracted Text:\n{0}\n\n", allExtractedText);
            }

        }

    }
}
