//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Diagnostics;
using ByteScout.TextRecognition;

namespace ScreenTextReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputDocument = @".\result.txt";

            // Create and activate TextRecognizer instance
            using (TextRecognizer textRecognizer = new TextRecognizer("demo", "demo"))
            {
                try
                {
                    // Create ScreenshotMaker instance
                    ScreenshotMaker screenshotMaker = new ScreenshotMaker();
                    // Set rectangle to take screenshot from
                    screenshotMaker.SetScreenshotArea(0, 0, 200, 200);

                    // Load screenshot
                    textRecognizer.LoadDocument(screenshotMaker);

                    // Set the location of OCR language data files
                    textRecognizer.OCRLanguageDataFolder = @"c:\Program Files\ByteScout Text Recognition SDK\ocrdata_best\";

                    // Set OCR language.
                    // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish, etc. - according to files in "ocrdata" folder
                    // Find more language files at https://github.com/bytescout/ocrdata
                    textRecognizer.OCRLanguage = "eng"; 
                                    
                    // Recognize text from all pages and save it to file
                    textRecognizer.SaveText(outputDocument);

                    // Open the result file in default associated application (for demo purposes)
                    Process.Start(outputDocument);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
