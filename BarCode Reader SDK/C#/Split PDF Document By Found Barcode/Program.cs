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
using System.IO;
using System.Text;
using Bytescout.BarCodeReader;

namespace SplitDocumentByFoundBarcode
{
    class Program
    {
        const string InputFIle = "Barcodes.pdf";

        static void Main()
        {
            Console.WriteLine("Reading barcode(s) from PDF document {0}", Path.GetFullPath(InputFIle));

            // Create Bytescout.BarCodeReader.Reader instance
            Reader reader = new Reader();
            reader.RegistrationName = "demo";
            reader.RegistrationKey = "demo";

            // Set barcode type to find
            reader.BarcodeTypesToFind.Code39 = true;

            // Find barcode in PDF document
            reader.ReadFrom(InputFIle);


            // Method 1: Split PDF document in two parts by found barcode
            // NOTE: In Full version of the SDK this method is unlocked in "PRO" license type only.

            reader.SplitDocument(@"barcodes.pdf", @"part1.pdf", @"part2.pdf", reader.FoundBarcodes[0].Page + 1);


            // Method 2: Extract page containing the barcode from PDF document
            // NOTE: In Full version of the SDK this method is unlocked in "PRO" license type only.

            reader.ExtractPageFromDocument(@"barcodes.pdf", @"extracted_page.pdf", reader.FoundBarcodes[0].Page + 1);


            // Method 3: Split PDF document into parts in one pass.
            // NOTE: In Full version of the SDK this method is unlocked in "PRO" license type only.

            StringBuilder pageRanges = new StringBuilder();

            // Create string containing page ranges to extract in the form "1-4,6-8,10-11,12-". Page numbers are 1-based!
            for (int i = 0; i < reader.FoundBarcodes.Length; i++)
            {
                FoundBarcode barcode = reader.FoundBarcodes[i];

                // Add pages before the first barcode found
                if (i == 0 && barcode.Page > 0)
                {
                    pageRanges.Append("1");
                    if (barcode.Page > 1)
                    {
                        pageRanges.Append("-");
                        pageRanges.Append(barcode.Page);
                    }
                    pageRanges.Append(",");
                }

                // Add page with barcode
                pageRanges.Append(barcode.Page + 1); // +1 because we skip the page with barcode and another +1 because need 1-based page numbers
                
                // Add range untill the next barcode
                if (i < reader.FoundBarcodes.Length - 1)
                {
                    if (reader.FoundBarcodes[i + 1].Page - barcode.Page > 1)
                    {
                        pageRanges.Append("-");
                        pageRanges.Append(reader.FoundBarcodes[i + 1].Page);
                    }

                    pageRanges.Append(",");
                }
                else // for the last found barcode add ending "-" meaning "to the last page"
                {
                    pageRanges.Append("-");
                }
            }

            // Split document 
            string[] splittedParts = reader.SplitDocument(@"barcodes.pdf", pageRanges.ToString());
            // The method returns array of file names. Rename files as desired.

            foreach (var fileName in splittedParts)
            {
                Console.WriteLine(fileName);
            }

            // Cleanup
            reader.Dispose();

            Console.Read();
            Console.WriteLine("Press enter key to exit...");
        }
    }
}
