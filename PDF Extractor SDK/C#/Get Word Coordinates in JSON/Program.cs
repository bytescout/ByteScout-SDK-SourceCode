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


using Bytescout.PDFExtractor;
using System;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.JSONExtractor instance
            JSONExtractor extractor = new JSONExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Load sample PDF document
            extractor.LoadDocumentFromFile("sample3.pdf");

            // Add the following params to get clean data with word nodes only:
            extractor.DetectNewColumnBySpacesRatio = 0.1f;  // this splits all text into words
            extractor.PreserveFormattingOnTextExtraction = false;  // Get rid Of empty nodes

            extractor.SaveJSONToFile("output.json");

            // Cleanup
            extractor.Dispose();

            Console.WriteLine();
            Console.WriteLine("Data has been extracted to 'output.json' file.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue and open JSON in default viewer...");
            Console.ReadKey();

            ProcessStartInfo processStartInfo = new ProcessStartInfo("output.json");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
