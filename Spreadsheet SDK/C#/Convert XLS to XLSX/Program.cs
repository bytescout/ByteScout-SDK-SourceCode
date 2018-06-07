//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Bytescout.Spreadsheet;
using System.Diagnostics;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
			// Open existing XLS file
            Spreadsheet spreadsheet = new Spreadsheet();
			spreadsheet.LoadFromFile("Input.xls");

            // delete output file if exists already
            if (File.Exists("Output.xlsx")){
                File.Delete("Output.xlsx");
            }

            // Save document
            spreadsheet.SaveAs("Output.xlsx");

            // Close Spreadsheet
            spreadsheet.Close();

            // open generated XLSX document in default program
            Process.Start("Output.xlsx");

        }
    }
}
