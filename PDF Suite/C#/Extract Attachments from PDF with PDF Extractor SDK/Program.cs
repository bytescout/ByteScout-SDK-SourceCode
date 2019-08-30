//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using Bytescout.PDFExtractor;

namespace ExtractAttachments
{
    class Program
    {
        static void Main()
        {
            // Create Bytescout.PDFExtractor.AttachmentExtractor instance
            AttachmentExtractor extractor = new AttachmentExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Load sample PDF document
            extractor.LoadDocumentFromFile(@".\attachments.pdf");

            for (int i = 0; i < extractor.Count; i++)
            {
                Console.WriteLine("Saving attachment: " + extractor.GetFileName(i));
                // Save attachment to file
                extractor.Save(i, extractor.GetFileName(i));
                Console.WriteLine("File size: " + extractor.GetSize(i));
            }

            // Cleanup
			extractor.Dispose();
        }
    }
}
