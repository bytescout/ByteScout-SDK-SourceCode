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


using System;
using ByteScout.InvoiceParser;

// This example demonstrates the use of Optical Character Recognition (OCR) to parse invoice data
// from scanned PDF documents and raster images.

namespace ParseWithOCR
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDocument1 = @".\DigitalOcean-scanned.jpg";

            // Create InvoiceParser instance
            using (InvoiceParser invoiceParser = new InvoiceParser("demo", "demo"))
            {
                // Enable Optical Character Recognition (OCR)
                // in .Auto mode (SDK automatically checks if needs to use OCR or not)
                invoiceParser.OCRMode = OCRMode.Auto;

                // Set the location of "tessdata" folder containing language data files
                invoiceParser.OCRLanguageDataFolder = @".\tessdata\";

                // Set OCR language
                invoiceParser.OCRLanguage = "eng";
                // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in /tessdata
                // Find more language files at https://github.com/tesseract-ocr/tessdata/tree/3.04.00


                Console.WriteLine($"Parsing \"{inputDocument1}\"...");
                Console.WriteLine();

                // Parse invoice data in JSON format
                string jsonString = invoiceParser.ParseDocument(inputDocument1, OutputFormat.JSON);
                // Display parsed data in console
                Console.WriteLine("Parsing results in JSON format:");
                Console.WriteLine();
                Console.WriteLine(jsonString);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
