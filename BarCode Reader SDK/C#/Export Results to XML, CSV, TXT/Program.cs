//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


using System;
using System.IO;
using System.Text;
using System.Xml;
using Bytescout.BarCodeReader;

namespace ExportResults
{
    class Program
    {
        static void Main()
        {
            Reader reader = new Reader();
            reader.RegistrationName = "demo";
			reader.RegistrationKey = "demo";

            // Set barcode type to find
            reader.BarcodeTypesToFind.All1D = true;

            // Read barcodes
            reader.ReadFromFile("barcodes.pdf");


            // Export to files:
            // ================

            // 1. Export found barcodes to XML
            reader.ExportFoundBarcodesToXML("barcodes.xml");

            // 2a. Export found barcodes to CSV with default delimiter, quotation and character encoding
            reader.ExportFoundBarcodesToCSV("barcodes.csv");

            // 2b. Export found barcodes to CSV with custom delimiter, quotation and character encoding
            reader.ExportFoundBarcodesToCSV("barcodes2.csv", "|", "'", Encoding.UTF8);

            // 3a. Export found barcodes to plain text file in default character encoding
            reader.ExportFoundBarcodesToTXT("barcodes.txt");

            // 3b. Export found barcodes to plain text file in custom character encoding
            reader.ExportFoundBarcodesToTXT("barcodes2.txt", Encoding.UTF8);


            // Get formatted result to a variable for further processing
            // =========================================================

            // 1. Get found barcodes as XmlDocument
            XmlDocument xmlDocument = reader.ExportFoundBarcodesToXML();

            // 2a. Get found barcodes as string in CSV format with default delimiter and quotation
            string csv = reader.ExportFoundBarcodesToCSV();

            // 2b. Get found barcodes as string in CSV format with custom delimiter and quotation
            string csv2 = reader.ExportFoundBarcodesToCSV("|", "'");

            // 3. Get found barcodes as string in plain text format
            string txt = reader.ExportFoundBarcodesToTXT();
        }
    }
}
