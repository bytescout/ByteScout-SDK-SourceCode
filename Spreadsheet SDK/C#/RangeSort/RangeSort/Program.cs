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
using System.Diagnostics;
using System.IO;
using Bytescout.Spreadsheet;


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
            Worksheet worksheet = document.Workbook.Worksheets.ByName("Sheet1");

            // Select cell range
            Range range = worksheet.Range("A3:E184");

            // Sorting Data
            range.Sort("A3", Bytescout.Spreadsheet.Constants.SortOrder.Ascending, false, Bytescout.Spreadsheet.Constants.SortOrientation.SortRows, Bytescout.Spreadsheet.Constants.SortDataOption.SortNormal);


            // Get worksheet by name
            worksheet = document.Workbook.Worksheets.ByName("Sheet2");

            // Select cell range
            range = worksheet.Range("B1:T4");

            // Sorting Data
            range.Sort("B4", Bytescout.Spreadsheet.Constants.SortOrder.Descending, "", Bytescout.Spreadsheet.Constants.SortOrder.Ascending,
                "", Bytescout.Spreadsheet.Constants.SortOrder.Ascending, false, Bytescout.Spreadsheet.Constants.SortOrientation.SortColumns,
                Bytescout.Spreadsheet.Constants.SortDataOption.SortNormal, Bytescout.Spreadsheet.Constants.SortDataOption.SortNormal, Bytescout.Spreadsheet.Constants.SortDataOption.SortNormal);

            // delete output file if exists already
            if (File.Exists("Output.xls")){
                File.Delete("Output.xls");
            }

            // Save document
            document.SaveAs("Output.xls");

            // Close Spreadsheet
            document.Close();

            // open generated XLS document in default program
            Process.Start("Output.xls");
        }
    }
}
