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
using System;

// To make OCR work you should add the following references to your project:
// 'Bytescout.PDFExtractor.dll', 'Bytescout.PDFExtractor.OCRExtension.dll'.

namespace OCRModes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input document containing vector, image and font
            string inputDocument = @".\SampleWith_Vector_Image_Font.pdf";

            // Extracting text with different OCRModes
            // 1. TextFromImagesOnly (Plain Mode)
            Console.WriteLine("---------------------------------\nExtraction Mode: TextFromImagesOnly \n---------------------------------");
            var resultText = _ExtractTextWithSpecificOCRMode(inputDocument, OCRMode.TextFromImagesOnly);
            Console.WriteLine(resultText);

            // 2. TextFromVectorOnly (Plain Mode)
            Console.WriteLine("---------------------------------\nExtraction Mode: TextFromVectorOnly \n---------------------------------");
            resultText = _ExtractTextWithSpecificOCRMode(inputDocument, OCRMode.TextFromVectorsOnly);
            Console.WriteLine(resultText);

            // 3. TextFromImagesAndFonts (Combined Mode)
            Console.WriteLine("---------------------------------\nExtraction Mode: TextFromImagesAndFonts \n---------------------------------");
            resultText = _ExtractTextWithSpecificOCRMode(inputDocument, OCRMode.TextFromImagesAndFonts);
            Console.WriteLine(resultText);

            // 4. TextFromImagesAndVectorsAndFonts (Combined Mode)
            Console.WriteLine("---------------------------------\nExtraction Mode: TextFromImagesAndVectorsAndFonts \n---------------------------------");
            resultText = _ExtractTextWithSpecificOCRMode(inputDocument, OCRMode.TextFromImagesAndVectorsAndFonts);
            Console.WriteLine(resultText);


            Console.ReadLine();
        }


        /// <summary>
        /// Extract text from document with specific Ocr Mode
        /// </summary>
        /// <param name="inputDocument"></param>
        /// <param name="oCRMode"></param>
        /// <returns></returns>
        private static string _ExtractTextWithSpecificOCRMode(string inputDocument, OCRMode ocrMode)
        {
            // Location of language data files
            string ocrLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\";

            // OCR language
            string ocrLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
                                        // Find more language files at https://github.com/bytescout/ocrdata

            // Create TextExtractor instance
            using (TextExtractor textExtractor = new TextExtractor("demo", "demo"))
            {
                // Load document to TextExtractor
                textExtractor.LoadDocumentFromFile(inputDocument);

                // Specify Ocr Mode
                textExtractor.OCRMode = ocrMode;

                // Ocr language data folder path and language
                textExtractor.OCRLanguageDataFolder = ocrLanguageDataFolder;
                textExtractor.OCRLanguage = ocrLanguage;

                // Return extracted text
                return textExtractor.GetText();
            }
        }
    }
}
