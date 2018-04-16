//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Bytescout.Spreadsheet;

namespace CopyPasteRows
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open spreadsheet from file
            Spreadsheet document = new Spreadsheet();
            document.LoadFromFile(@"example.xls");
            //document.LoadFromFile(@"d:\2\1\Bytescout\Spreadsheet SDK\TestCase\Formats.xls");

            // Get first worksheet
            Worksheet worksheet = document.Workbook.Worksheets[0];

            // Copy first eight rows to the 10th row
            worksheet.Rows.CopyAndPaste(0, 7, 9);

            // Delete output file if exists
            if (File.Exists("changed.xls"))
            {
                File.Delete("changed.xls");
            }

            // Save document
            document.SaveAs("changed.xls");

            // Close spreadsheet
            document.Close();

            // Open generated XLS document in default program
            Process.Start("changed.xls");
        }
    }
}
