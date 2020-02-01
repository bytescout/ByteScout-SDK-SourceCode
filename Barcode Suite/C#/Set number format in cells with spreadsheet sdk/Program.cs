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
using System.Diagnostics;
using Bytescout.Spreadsheet;
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
            Worksheet worksheet = document.Workbook.Worksheets.Add("Sample");

            // Set header
            worksheet.Cell(0, 0).Value = "Value (Number)";
            worksheet.Cell(0, 1).Value = "Formatting String";

            // Set variables
            double plan = 3000;
            double result = 3100;

            // Fill cells
            for (int i = 1; i < 6; i++)
            {
                worksheet.Cell(i, 0).Value = result / plan;
            }

            // Set cells format
            worksheet.Cell(1, 0).NumberFormatString = "0.00";
            worksheet.Cell(2, 0).NumberFormatString = "0.00%";
            worksheet.Cell(3, 0).NumberFormatString = "mm:ss";
            worksheet.Cell(4, 0).NumberFormatString = "hh:mm:ss";
            worksheet.Cell(5, 0).NumberFormatString = "##0,0E+0";

            // Set captions
            worksheet.Cell(1, 1).Value = "0.00";
            worksheet.Cell(2, 1).Value = "0.00%"; 
            worksheet.Cell(3, 1).Value = "mm:ss"; 
            worksheet.Cell(4, 1).Value = "hh:mm:ss";   
            worksheet.Cell(5, 1).Value = "##0,0E+0";


            // delete output file if exists already
            if (File.Exists("Sample.xls")){
                File.Delete("Sample.xls");
            }

            // Save document
            document.SaveAs("Sample.xls");

            // Close document
            document.Close();

            // open generated XLS document in default program
            Process.Start("Sample.xls");
        }
    }
}
