//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System.IO;
using Bytescout.PDFExtractor;
using System.Diagnostics;

namespace PDF2CSV2XLS
{

    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.XLSExtractor instance
            XLSExtractor extractor = new XLSExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

			File.Delete("output.xls");

            // Load sample PDF document
            extractor.LoadDocumentFromFile("sample3.pdf");
			
			// Save the spreadsheet to file
			extractor.SaveToXLSFile("output.xls");

			// Open the spreadsheet in default associated application
            Process.Start("output.xls");
        }
    }
}
