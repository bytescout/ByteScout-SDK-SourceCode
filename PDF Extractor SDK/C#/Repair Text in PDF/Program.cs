//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.PDFExtractor;
using System;

namespace RepairText
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Read all text from pdf file
                using (TextExtractor extractor = new TextExtractor())
                {
                    // Load PDF document
                    extractor.LoadDocumentFromFile("sample.pdf");

                    // Set the font repairing OCR mode 
                    extractor.OCRMode = OCRMode.TextFromImagesAndVectorsAndRepairedFonts;

                    // Set the location of OCR language data files
                    extractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata\";

                    // Set OCR language
                    extractor.OCRLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
                                                   // Find more language files at https://github.com/tesseract-ocr/tessdata

                    // Set PDF document rendering resolution
                    extractor.OCRResolution = 300;

                    //Read all text
                    string allText = extractor.GetText();

                    Console.WriteLine("Extracted Text: \n\n" + allText);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
