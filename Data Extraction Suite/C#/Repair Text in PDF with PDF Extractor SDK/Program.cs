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
                    extractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\";

                    // Set OCR language
                    extractor.OCRLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
                    // Find more language files at https://github.com/bytescout/ocrdata

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
