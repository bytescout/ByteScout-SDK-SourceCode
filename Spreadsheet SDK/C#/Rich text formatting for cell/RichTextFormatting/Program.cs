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
using Bytescout.Spreadsheet;
using System.Diagnostics;
using System.IO;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();

            // Add new worksheet
            Worksheet worksheet = document.Workbook.Worksheets.Add("Sheet1");

            // Apply rich text formatting
            worksheet.Cell(0, 0).ValueAsHTML = "<b><u>Bold Underline</u>, and <i>bold italic</i></b> text";
            worksheet.Cell(1, 0).ValueAsHTML = "<font color=Blue>Blue</font>, <font color=Green>Green</font> and other <b><font face=Tahoma color=Red>co<font><font face=Tahoma color=Green>lo<font><font face=Tahoma color=Blue>rs<font></b> <font color=black><b>are</b> <u>available</u></font>";

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
