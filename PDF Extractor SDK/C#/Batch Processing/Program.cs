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
        }
    }
}
