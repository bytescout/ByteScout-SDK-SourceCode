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

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet 
            Spreadsheet document = new Spreadsheet ();

            // Move page
            Worksheet worksheet = document.Workbook.Worksheets.Add();

            // Set unicode text
            worksheet.Cell(0, 0).Value = "鍖鐳鑅";

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
