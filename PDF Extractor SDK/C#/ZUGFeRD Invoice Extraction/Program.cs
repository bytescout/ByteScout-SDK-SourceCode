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
using Bytescout.PDFExtractor;

namespace ExtractZUGFeRD
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.AttachmentExtractor instance
            AttachmentExtractor extractor = new AttachmentExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Load sample PDF document
            extractor.LoadDocumentFromFile(@".\ZUGFeRD-invoice.pdf");

            // Extract the XML invoice that is stored as an attachment
            for (int i = 0; i < extractor.Count; i++)
            {
                Console.WriteLine("Saving XML invoice attachment: " + extractor.GetFileName(i));
                
                // Save file to current folder
                extractor.Save(i, extractor.GetFileName(i));

                Console.WriteLine("Done.");
            }

            extractor.Dispose();
            
            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }
    }
}
