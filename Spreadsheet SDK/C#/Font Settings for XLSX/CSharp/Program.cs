//*******************************************************************
//       ByteScout Spreadsheet SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Diagnostics;
using System.IO;

using Bytescout.Spreadsheet;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new spreadhseet
            Spreadsheet spreadsheet = new Spreadsheet();

            // Create new worksheet
            Worksheet sheet = spreadsheet.Workbook.Worksheets.Add();
            
            // Set cell value
            sheet[0, 0].Value = "Test 1";
            // Set cell font color
            sheet[0, 0].FontColor = Color.Red;
            // Set cell font
            sheet[0, 0].Font = new Font(FontFamily.GenericSansSerif, 13);

            // Set cell value
            sheet[0, 1].Value = "Test 2";
            // Set cell font color
            sheet[0, 1].FontColor = Color.Blue;
            // Set cell font
            sheet[0, 1].Font = new Font("Arial", 13);

            // delete output file if exists already
            if (File.Exists("Result.xlsx")){
                File.Delete("result.xlsx");
            }

            // Save spreadsheet as XLSX
            spreadsheet.SaveAs("Result.xlsx");
            // Close spreadsheet
            spreadsheet.Close();


            // open generated XLS document in default program
            Process.Start("Result.xlsx");
        }
    }
}
