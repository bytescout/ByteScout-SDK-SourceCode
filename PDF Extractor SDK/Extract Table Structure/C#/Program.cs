//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using Bytescout.PDFExtractor;
using System.Diagnostics;
using System;

namespace TableStructure
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create Bytescout.PDFExtractor.StructuredExtractor instance (former TableExtractor)
			StructuredExtractor extractor = new StructuredExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";

			// Load sample PDF document
			extractor.LoadDocumentFromFile("sample3.pdf");

            for (int ipage = 0; ipage < extractor.GetPageCount(); ipage++)
            {
                Console.WriteLine("starting extraction from page #" + ipage);
                extractor.PrepareStructure(ipage);

                int rowCount = extractor.GetRowCount(ipage);
                int CellsAlreadyScanned = 0;

                for (int row = 0; row < rowCount; row++)
                {
                    int columnCount = extractor.GetColumnCount(ipage, row);

                    for (int col = 0; col < columnCount; col++)
                    {
                        Console.WriteLine(extractor.GetCellValue(ipage, row, col));
                    }

                    CellsAlreadyScanned += columnCount;
                }
            }
            Console.WriteLine("Press any key..");
            Console.ReadKey();
		}
	}
}
