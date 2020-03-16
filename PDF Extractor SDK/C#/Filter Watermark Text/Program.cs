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


using System.Diagnostics;
using System.Drawing;
using Bytescout.PDFExtractor;

namespace ExtractText
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.TextExtractor instance
            TextExtractor extractor = new TextExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Load sample PDF document
            extractor.LoadDocumentFromFile(@".\DocumentWithWatermark.pdf");

            // Filter text using text filter
            extractor.AddFilter(@"^COPY$", caseSensitive: true, useRegex: true);

            // Filter text using appearance filter
            // extractor.AddFilter("Arial", fontSize: 203, exclude: true);

            // Save extracted text to file
            extractor.SaveTextToFile(@".\result.txt");

            // Cleanup
            extractor.Dispose();

            // Open result file in default associated application
            ProcessStartInfo processStartInfo = new ProcessStartInfo(@".\result.txt");
            Process.Start(processStartInfo);
        }
    }
}
