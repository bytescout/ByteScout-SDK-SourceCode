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

namespace TextExtractorProgressChangedEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Read all file content...
                using (TextExtractor extractor = new TextExtractor())
                {
                    // Load document
                    extractor.LoadDocumentFromFile("sample.png");

                    // Extractor Progress event
                    Console.WriteLine("Text Extraction in progress: \n");
                    extractor.ProgressChanged += Extractor_ProgressChanged;

                    // Set option to repair text
                    extractor.OCRMode = OCRMode.TextFromImagesAndVectorsAndRepairedFonts;

                    // Enable Optical Character Recognition (OCR)
                    // in .Auto mode (SDK automatically checks if needs to use OCR or not)
                    extractor.OCRMode = OCRMode.Auto;

                    // Set the location of OCR language data files
                    extractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata\";

                    // Set OCR language
                    extractor.OCRLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
                    // Find more language files at https://github.com/bytescout/ocrdata

                    // Set PDF document rendering resolution
                    extractor.OCRResolution = 300;

                    //Read all text
                    var allExtractedText = extractor.GetText();
                    Console.WriteLine("\n\nExtracted Text:\n\n{0}", allExtractedText);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

			Console.WriteLine("Press enter key to exit...");
            Console.ReadLine();
        }

        /// <summary>
        /// Handle progress change event
        /// </summary>
        private static void Extractor_ProgressChanged(object sender, OngoingOperation ongoingOperation, double progress, ref bool cancel)
        {
            drawTextProgressBar(Convert.ToInt32(progress), 100);
        }

        /// <summary>
        /// Display progress bar
        /// </summary>
        private static void drawTextProgressBar(int progress, int total)
        {
            //draw empty progress bar
            Console.CursorLeft = 0;
            Console.Write("["); //start
            Console.CursorLeft = 32;
            Console.Write("]"); //end
            Console.CursorLeft = 1;
            float onechunk = 30.0f / total;

            //draw filled part
            int position = 1;
            for (int i = 0; i < onechunk * progress; i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            //draw unfilled part
            for (int i = position; i <= 31; i++)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            //draw totals
            Console.CursorLeft = 35;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(progress.ToString() + " of " + total.ToString() + "    "); //blanks at the end remove any excess
        }
    }
}
