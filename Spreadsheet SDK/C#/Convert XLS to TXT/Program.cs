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
using System.IO;
using System.Text;
using Bytescout.Spreadsheet;
using System.Diagnostics;

namespace Converting_XLS_to_TXT
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet from SimpleReport.xls file
            Spreadsheet document = new Spreadsheet();
	document.LoadFromFile("SimpleReport.xls");

            // delete output file if exists already
            if (File.Exists("SimpleReport.txt")){
                File.Delete("SimpleReport.txt");
            }

           // save into TXT 
           document.Workbook.Worksheets[0].SaveAsTXT("SimpleReport.txt");

            // open output document in default viewer
           Process.Start("SimpleReport.txt");

        }
    }
}
