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

namespace GetCellColor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open existing XLS document
            Spreadsheet spreadSheet = new Spreadsheet();
            spreadSheet.LoadFromFile("input.xls");

            // Take existing worksheet
            Worksheet sheet = spreadSheet.Worksheet(0);

            // Take cell
            Cell cell = sheet.Cell(0, 0);

            // Print back color of fill patter
            Console.WriteLine(cell.FillPatternBackColor.ToString());

            // Print fore color of fill pattern
            Console.WriteLine(cell.FillPatternForeColor.ToString());

            // Close spreadsheet
            spreadSheet.Close();


            Console.ReadKey();
        }
    }
}
