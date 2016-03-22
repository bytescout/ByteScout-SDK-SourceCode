//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using Bytescout.PDFExtractor;

namespace ExtractTextByPages
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create Bytescout.PDFExtractor.TextExtractor instance
			CSVExtractor extractor = new CSVExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";

            TableDetector tdetector = new TableDetector();
            tdetector.RegistrationKey = "demo";
            tdetector.RegistrationName = "demo";

		// we should define what kind of tables we should detect
		// so we set min required number of columns to 3
		tdetector.DetectionMinNumberOfColumns = 3;

		// and we set min required number of columns to 3
		tdetector.DetectionMinNumberOfRows = 3;

			// Load sample PDF document
			extractor.LoadDocumentFromFile("sample3.pdf");
            tdetector.LoadDocumentFromFile("sample3.pdf");

			// Get page count
			int pageCount = tdetector.GetPageCount();

			for (int i = 0; i < pageCount; i++)
			{
                int j = 1;
                // find first table and continue if found
                if (tdetector.FindTable(i))
                    do
                    {
                        // set extraction area for CSV extractor to rectangle given by table detector
                        extractor.SetExtractionArea(tdetector.GetFoundTableRectangle_Left(),
                            tdetector.GetFoundTableRectangle_Top(),
                            tdetector.GetFoundTableRectangle_Width(),
                            tdetector.GetFoundTableRectangle_Height()
                        );

                        // and finally save the table into CSV file
                        extractor.SavePageCSVToFile(i, "page-" + i + "-table-" + j + ".csv");
                        j++;
                    } while (tdetector.FindNextTable()); // search next table
			}

			// Open first output file in default associated application
			System.Diagnostics.Process.Start("page-0-table-1.csv");
		}
	}
}
