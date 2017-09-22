//****************************************************************************//
//                                                                            //
// Download evaluation version: https://bytescout.com/download/web-installer  //
//                                                                            //
// Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    //
//                                                                            //
// Copyright © 2017 ByteScout Inc. All rights reserved.                       //
// http://www.bytescout.com                                                   //
//                                                                            //
//****************************************************************************//


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

            // Load sample PDF document
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

            extractor.Dispose();
            
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
