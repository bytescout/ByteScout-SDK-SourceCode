//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Collections.Generic;
using System.Text;
using Bytescout.Spreadsheet;

namespace ReadingMergedCells
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();
document.LoadFromFile("Input.xls");

            // Get worksheet by name
            Worksheet worksheet = document.Workbook.Worksheets["Sheet1"];

            // Read merged cell
            Cell cell = worksheet.Cell("C12").MergedWithCell;

            // Read cell value
            Console.WriteLine(cell.Value);

            // Close document
            document.Close();
        }
    }
}
