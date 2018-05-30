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
using System.Collections.Generic;
using System.Text;
using Bytescout.PDFExtractor;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.CSVExtractor instance
            CSVExtractor extractor = new CSVExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Load sample PDF document
            extractor.LoadDocumentFromFile("sample3.pdf");

            // you can change CSV separator symbol (if needed) from "," symbol to another if needed for non-US locales
            //extractor.CSVSeparatorSymbol = ",";

            // Save extracted CSV data
            extractor.SaveCSVToFile("output.csv");

            // Cleanup
			extractor.Dispose();

            Console.WriteLine();
            Console.WriteLine("Data has been extracted to 'output.csv' file.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue and open CSV in default CSV viewer (or Excel)...");
            Console.ReadKey();

            // Open result file in default associated application (for demo purposes)
            Process.Start("output.csv");
        }
    }
}
