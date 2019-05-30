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

namespace XFAFormToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.XFAFormExtractor instance
            XFAFormExtractor extractor = new XFAFormExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Load PDF document
            // (!) We do not provide the sample document, please load your own.
            extractor.LoadDocumentFromFile("samplexfa.pdf");

            // Enumerate XFA form content part types
            foreach (XFAFormContentType contentType in Enum.GetValues(typeof(XFAFormContentType)))
            {
                // Get count of content parts of specified type
                int partCount = extractor.GetCount(contentType);

                // Save parts as XML files
                for (int i = 0; i < partCount; i++)
                {
                    string fileName = contentType.ToString() + i + ".xml";
                    extractor.SaveToFile(contentType, i, fileName);
                    Console.WriteLine("Saved form part " + fileName);
                }
            }

            // Cleanup
			extractor.Dispose();
            
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
