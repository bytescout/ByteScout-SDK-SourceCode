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
using Bytescout.PDFExtractor;

namespace SearchablePDFMakerProgressChangedEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
                By default, "SearchablePDFMaker" uses one of the standard PDF fonts to apply 
                recognized text over the scanned document. Such fonts contain only basic characters 
                from ISO-8859-1 charset. 
                If you run OCR for one of the languages with characters that are not present in the default
                encoding, you should explicitly specify the font that contains the required characters
                using ".LabelingFont" property.
                If you run the application in Windows with a selected locale that matches OCR language, 
                it will be enough to specify the usual font "Arial". But if your app will run in an unknown
                environment (for example, in some virtual machine) you will need to install some full Unicode 
                font (e.g. "Arial Unicode MS") and then use it with SearchablePDFMaker:

                //searchablePDFMaker.LabelingFont = "Arial Unicode MS";
                */
                using (var searchablePDFMaker = new SearchablePDFMaker("demo", "demo"))
                {
                    // Load sample PDF document
                    searchablePDFMaker.LoadDocumentFromFile("sample_ocr.pdf");

                    // Extractor Progress event
                    Console.WriteLine("Searchable PDF making in progress: \n");
                    searchablePDFMaker.ProgressChanged += SearchablePDF_ProgressChanged;

                    // Set the location of OCR language data files
                    searchablePDFMaker.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\";

                    // Set OCR language
                    searchablePDFMaker.OCRLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
                    // Find more language files at https://github.com/bytescout/ocrdata

                    // Set PDF document rendering resolution
                    searchablePDFMaker.OCRResolution = 300;

                    // Save extracted text to file
                    searchablePDFMaker.MakePDFSearchable("output.pdf");

                    // Open result document in default associated application (for demo purpose)
                    ProcessStartInfo processStartInfo = new ProcessStartInfo("output.pdf");
                    processStartInfo.UseShellExecute = true;
                    Process.Start(processStartInfo);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n\n Press enter key to exit...");
            Console.ReadLine();
        }

        /// <summary>
        /// Handle progress change event
        /// </summary>
        private static void SearchablePDF_ProgressChanged(object sender, OngoingOperation ongoingOperation, double progress, ref bool cancel)
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
