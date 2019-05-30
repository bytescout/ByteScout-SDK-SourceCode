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
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Bytescout.Spreadsheet;
using Bytescout.Spreadsheet.Constants;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();
            document.LoadFromFile("Data.xls");

            // Get worksheet by name
            Worksheet worksheet = document.Workbook.Worksheets.ByName("Sample");

            // Check dates
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    // Set current cell
                    Cell currentCell = worksheet.Cell(i, j);

                    // Get format type

                    NumberFormatType formatType = currentCell.ValueDataTypeByNumberFormatString;

                    // Write line
                    Console.Write("Cell({0}:{1}) type is {2}. Value : ", i, j, formatType.ToString());

                    switch (formatType)
                    {
                        case NumberFormatType.DateTime:
                            {
                                // Read datetime
                                DateTime date = currentCell.ValueAsDateTime;

                                // Write date to console output
                                Console.Write(date.ToString());
                            }
                            break;
                        case NumberFormatType.General:
                            {
                                // Write value to console output
                                Console.Write(currentCell.Value);
                            }
                            break;
                    }

                    Console.WriteLine();

                }
            }

            // Close document
            document.Close();
            Console.ReadKey(); 
        }
    }
}
