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


using System;
using System.IO;
using Bytescout.PDFExtractor;

namespace SplittingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input File
            string inputFile = "sample.pdf";

            // Output FOlder
            string outputFolder = "./output";

            // Regex-Enabled - Search for multiple strings
            //String[] pattern_list = new string[] {"Invoice", "1nvoice"};
            //String searchString = String.Format("({0})", String.Join("|", pattern_list));
            //bool isRegexEnabled = true;

            // Search single string
            string searchString = "Invoice";
            bool isRegexEnabled = false;

            // Registration name/key
            string registration_name = "demo";
            string registration_key = "demo";

            using (var extractor = new DocumentSplitter2(registration_name, registration_key))
            {
                // Enable Optical Character Recognition (OCR)
                // in .Auto mode (SDK automatically checks if needs to use OCR or not)
                extractor.OCRMode = OCRMode.Auto;

                // Set the location of OCR language data files
                extractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\";

                // Set OCR language
                extractor.OCRLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
                                               // Find more language files at https://github.com/bytescout/ocrdata/tree/master/ocrdata

                // Repair broken letters
                extractor.OCRImagePreprocessingFilters.AddDilate();

                // Remove noise
                extractor.OCRImagePreprocessingFilters.AddMedian();

                // Auto-Detect Page Rotation
                extractor.OCRDetectPageRotation = true;

                // Add Filters for Horizonal/Vertical Line
                extractor.OCRImagePreprocessingFilters.AddHorizontalLinesRemover();
                extractor.OCRImagePreprocessingFilters.AddVerticalLinesRemover();

                // Perform Split by Text
                var files = extractor.Split(inputFile, searchString,
                    caseSensitive: false,
                    useRegex: isRegexEnabled,
                    excludePageWithFoundText: false,
                    outputFolder: outputFolder);

                // Display Output
                Console.WriteLine(@"Splitted by Text: ");
                foreach (string file in files)
                    Console.WriteLine("    " + Path.GetFileName(file));
            }

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
