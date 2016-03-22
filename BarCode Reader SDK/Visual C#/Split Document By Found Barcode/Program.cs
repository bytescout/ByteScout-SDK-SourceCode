//*******************************************************************
//       ByteScout BarCode Reader SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.IO;

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
            // NOTE: In Full version of the SDK this method is unlocked in "PRO" license type only

            reader.SplitDocument(@"barcodes.pdf", @"part1.pdf", @"part2.pdf", reader.FoundBarcodes[0].Page + 1);

            // Method 2: Extract page containing the barcode from PDF document
            // NOTE: In Full version of the SDK this method is unlocked in "PRO" license type only

            reader.ExtractPageFromDocument(@"barcodes.pdf", @"extracted_page.pdf", reader.FoundBarcodes[0].Page + 1);
        }
    }
}
