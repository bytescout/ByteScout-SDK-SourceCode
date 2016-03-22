//*******************************************************************
//       ByteScout Spreadsheet SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

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
