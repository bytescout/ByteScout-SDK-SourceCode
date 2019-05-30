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

            // Cleanup
			extractor.Dispose();

            Console.WriteLine();
            Console.WriteLine("Press any key..");
            Console.ReadKey();
		}
	}
}
