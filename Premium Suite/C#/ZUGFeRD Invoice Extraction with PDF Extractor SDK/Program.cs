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

            // Cleanup
			extractor.Dispose();
            
            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }
    }
}
