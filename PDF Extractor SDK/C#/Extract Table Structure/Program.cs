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


using Bytescout.PDFExtractor;
using System.Diagnostics;
using System;

namespace TableStructure
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create Bytescout.PDFExtractor.StructuredExtractor instance
			StructuredExtractor extractor = new StructuredExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";

			// Load sample PDF document
			extractor.LoadDocumentFromFile(@".\sample3.pdf");

            for (int pageIndex = 0; pageIndex < extractor.GetPageCount(); pageIndex++)
            {
                Console.WriteLine("Starting extraction from page #" + pageIndex);
                Console.WriteLine();

                extractor.PrepareStructure(pageIndex);

                int rowCount = extractor.GetRowCount(pageIndex);

                for (int row = 0; row < rowCount; row++)
                {
                    int columnCount = extractor.GetColumnCount(pageIndex, row);

                    for (int col = 0; col < columnCount; col++)
                    {
                        Console.WriteLine(extractor.GetCellValue(pageIndex, row, col));
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key..");
            Console.ReadKey();
		}
	}
}
