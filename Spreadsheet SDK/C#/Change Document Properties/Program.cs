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
using System.Text;
using System.IO;
using System.Diagnostics;
using Bytescout.Spreadsheet;

namespace Book_properties_write
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();

            // Add new worksheet
            Worksheet worksheet = document.Workbook.Worksheets.Add("Sheet1");

            // Set some properties
            document.Workbook.Properties.ApplicationName = "Bytescout Spreadsheet SDK";
            document.Workbook.Properties.Author = "Bytescout";
            document.Workbook.Properties.Comments = "Some comments";
            document.Workbook.Properties.Subject = "Some subject";

            // delete output file if exists already
            if (File.Exists("Output.xls")){
                File.Delete("Output.xls");
            }

            document.SaveAs("Output.xls");

            // open generated XLS document in default program
	    Process.Start("Output.xls");
        }
    }
}
