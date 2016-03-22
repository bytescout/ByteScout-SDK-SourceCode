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
            // Create Bytescout.PDFExtractor.CSVExtractor instance
            CSVExtractor extractor = new CSVExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Load sample PDF document
            extractor.LoadDocumentFromFile("sample3.pdf");

            //extractor.CSVSeparatorSymbol = ","; // you can change CSV separator symbol (if needed) from "," symbol to another if needed for non-US locales

    		// Get page count
		int pageCount = extractor.GetPageCount();

		for (int i = 0; i < pageCount; i++)
		{
		    string fileName = "page" + i + ".csv";				

      		    // Save extracted page text to file
	      	    extractor.SavePageCSVToFile(i, fileName);
		}



            Console.WriteLine();
            Console.WriteLine("Data has been extracted to separate files for pages.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            //Process.Start("page0.csv");
        }
    }
}
