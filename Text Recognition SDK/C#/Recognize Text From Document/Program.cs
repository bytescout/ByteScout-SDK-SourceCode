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
using System.Diagnostics;
using ByteScout.TextRecognition;

namespace TextRecognitionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDocument = @".\invoice-sample.png";
            string outputDocument = @".\result.txt";

            // Create and activate TextRecognizer instance
            using (TextRecognizer textRecognizer = new TextRecognizer("demo", "demo"))
            {
                try
                {
                    // Load document (image or PDF)
                    textRecognizer.LoadDocument(inputDocument);

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
