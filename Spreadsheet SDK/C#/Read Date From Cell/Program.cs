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
	document.LoadFromFile("Sample.xls");

            // Get worksheet by name
            Worksheet worksheet = document.Workbook.Worksheets.ByName("Sheet1");

            // Check dates
            for (int i = 0; i < 4; i++)
            {
                // Set current cell
                Cell currentCell = worksheet.Cell(i, 0);

                DateTime date = currentCell.ValueAsDateTime;

                // Write Date
                Console.WriteLine("{0}", date.ToShortDateString());
            }

            // Close document
            document.Close();

            // Write message
            Console.Write("Press any key to continue...");

            // Wait user input
            Console.ReadKey();

        }
    }
}
