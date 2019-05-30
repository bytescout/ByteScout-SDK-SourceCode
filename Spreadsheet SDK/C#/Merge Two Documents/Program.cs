//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
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

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open existing Spreadsheets
            Spreadsheet document1 = new Spreadsheet();
	document1.LoadFromFile("workbook1.xls");
            Spreadsheet document2 = new Spreadsheet();
	document2.LoadFromFile("workbook2.xls");

            // Create output document
            Spreadsheet document3 = new Spreadsheet();

            // Add new worksheet
            document3.Workbook.Worksheets.Add();

            // Target row
            int targetRow = 0;

            // Copy cells from first document
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    document3.Worksheet(0).Cell(targetRow, j).Value = document1.Worksheet(0).Cell(i, j).Value;
                }
                targetRow++;
            }

            // Copy cells from second document
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    document3.Worksheet(0).Cell(targetRow, j).Value = document2.Worksheet(0).Cell(i, j).Value;
                }
                targetRow++;
            }

            // delete output file if exists already
            if (File.Exists("Output.xls")){
                File.Delete("Output.xls");
            }

            // Save document
            document3.SaveAs("output.xls");

            // Close document
            document3.Close();

            // Open document in default xls viewer
            Process.Start("Output.xls");
        }
    }
}
