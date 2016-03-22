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

namespace MergeCells
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();

            // Get worksheet by name
            Worksheet worksheet = document.Workbook.Worksheets.Add("Sheet1");
            
            // Merge cells
            worksheet.Range("B6:D18").Merge();

            // Write text
            worksheet.Cell("C10").MergedWithCell.Value = "Bytescout.Spreadsheet";


            // delete output file if exists already
            if (File.Exists("Output.xls")){
                File.Delete("Output.xls");
            }

            // Save document
            document.SaveAs("Output.xls");

            // Close document
            document.Close();

            // Open document in default xls viewer
            Process.Start("Output.xls");
        }
    }
}
