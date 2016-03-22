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

            // Get worksheet by name
            Worksheet worksheet = document.Workbook.Worksheets.Add();
            
            // Number of cell in the first column
            int cellRow = 0;

            // Apply all line styles
            foreach (LineStyle lineStyle in Enum.GetValues(typeof(LineStyle)))
            {
                // Set current cell
                Cell currentCell = worksheet.Cell(cellRow, 0);

                // Set border styles
                currentCell.RightBorderStyle =lineStyle;
                currentCell.LeftBorderStyle = lineStyle;
                currentCell.TopBorderStyle = lineStyle;
                currentCell.BottomBorderStyle = lineStyle;

                // Print style name
                currentCell.Value = lineStyle.ToString();

                // Choose next row
                cellRow += 2;
            }

            // delete output file if exists already
            if (File.Exists("LineTypes.xls")){
                File.Delete("LineTypes.xls");
            }

            // Save document
            document.SaveAs("LineTypes.xls");

            // Close document
            document.Close();

            // open generated XLS document in default program
            Process.Start("LineTypes.xls");
        }
    }
}
