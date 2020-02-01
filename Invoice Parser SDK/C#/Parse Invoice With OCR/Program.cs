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

                // Set the location of OCR language data files
                invoiceParser.OCRLanguageDataFolder = @"c:\Program Files\ByteScout Invoice Parser SDK\ocrdata";

                // Set OCR language
                // "eng" for english, "deu" for German, "fra" for French, etc. - according to files in "ocrdata" folder
                invoiceParser.OCRLanguage = "eng";
                // Find more language files at https://github.com/bytescout/ocrdata


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
