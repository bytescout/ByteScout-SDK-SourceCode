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


using Bytescout.Spreadsheet;
using System;

namespace ReadSpreadsheetMLFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Convert SpreadhseetML (xml spreadsheet) to XLSX format
                using (var spreadsheet = new Spreadsheet())
                {
                    spreadsheet.RegistrationName = "demo";
                    spreadsheet.RegistrationKey = "demo";

                    // Load input file
                    spreadsheet.LoadFromFile("sample.xml");

                    // Generate XLSX format
                    spreadsheet.SaveAsXLSX("sample.xlsx");
                }

                // Read spreadsheet and display data to console
                using (var spreadsheet = new Spreadsheet())
                {
                    spreadsheet.RegistrationName = "demo";
                    spreadsheet.RegistrationKey = "demo";

                    // Load input file
                    spreadsheet.LoadFromFile("sample.xlsx");

                    //Reference Worksheet
                    Worksheet worksheet = spreadsheet.Worksheets[0];

                    Console.WriteLine("=====================================================");
                    Console.WriteLine("================ Spreadsheet data ===================");
                    Console.WriteLine("=====================================================");

                    // Read and output cells to console.
                    for (int row = worksheet.UsedRangeRowMin; row <= worksheet.UsedRangeRowMax; row++)
                    {
                        for (int column = worksheet.UsedRangeColumnMin; column <= worksheet.UsedRangeColumnMax; column++)
                        {
                            Console.Write("{0}\t", worksheet.Cell(row, column).ValueAsString);
                        }

                        Console.WriteLine();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
