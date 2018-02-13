//****************************************************************************//
//                                                                            //
// Download evaluation version: https://bytescout.com/download/web-installer  //
//                                                                            //
// Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    //
//                                                                            //
// Copyright © 2017 ByteScout Inc. All rights reserved.                       //
// http://www.bytescout.com                                                   //
//                                                                            //
//****************************************************************************//


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

                    // Set location of "tessdata" folder containing language data files
                    textRecognizer.OCRLanguageDataFolder = @"c:\Program Files\ByteScout Text Recognition SDK\tessdata\";

                    // Set OCR language
                    textRecognizer.OCRLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in /tessdata
                    // Find more language files at https://github.com/tesseract-ocr/tessdata/tree/3.04.00
                
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
