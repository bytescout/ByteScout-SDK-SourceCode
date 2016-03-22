//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

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
            // Create Bytescout.PDFExtractor.XFDFExtractor instance
            XFDFExtractor extractor = new XFDFExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Load sample PDF document
            extractor.LoadDocumentFromFile("sample3.pdf");

            extractor.SaveXFDFToFile("output.xml");

            Console.WriteLine();
            Console.WriteLine("Data has been extracted to 'output.xml' file.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue and open file in default associated application...");
            Console.ReadKey();
            Process.Start("output.xml");
        }
    }
}
