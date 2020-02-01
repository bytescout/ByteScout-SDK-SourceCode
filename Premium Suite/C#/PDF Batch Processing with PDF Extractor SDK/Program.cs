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


using System.IO;
using Bytescout.PDFExtractor;

namespace BatchProcessing
{
    class Program
    {
        static void Main()
        {
            // Create Bytescout.PDFExtractor.TextExtractor instance
            TextExtractor extractor = new TextExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Get PDF files 
            string[] pdfFiles = Directory.GetFiles(".", "*.pdf");

            foreach (string file in pdfFiles)
            {
                // Load document
                extractor.LoadDocumentFromFile(file);

                // Save extracted text to .txt file
                extractor.SaveTextToFile(Path.ChangeExtension(file, ".txt"));

                // Reset the extractor before load another file
                extractor.Reset();
            }

            // Cleanup
			extractor.Dispose();
        }
    }
}
