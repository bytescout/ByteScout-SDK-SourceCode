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
            Worksheet worksheet = document.Workbook.Worksheets.Add("AlignmentDemo");

            // Set Values
            worksheet.Cell("A1").Value = "Name";
            // setting centered alignment for the cell
            worksheet.Cell("A1").AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Centered;
            worksheet.Cell("B1").Value = "Full Name";
            // setting centered alignment for the cell 
            worksheet.Cell("B1").AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Centered;

            worksheet.Cell("A2").Value = "Homer";
            // setting justifiedalignment for the cell 
            worksheet.Cell("A2").AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right;

            worksheet.Cell("B2").Value = "Homer Jay Simpson";
            // setting justified alignment for the cell 
            worksheet.Cell("B2").AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right;

            // set columns width
            worksheet.Columns[0].Width = 300; // A column
            worksheet.Columns[1].Width = 400; // B column

            // delete output file if exists already
            if (File.Exists("CellAlignment.xls")){
                File.Delete("CellAlignment.xls");
            }

            // Save document
            document.SaveAs("CellAlignment.xls");

            // open XLS document in default XLS Excel documents application
            Process.Start("CellAlignment.xls");
        }
    }
}
