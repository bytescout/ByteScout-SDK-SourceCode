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
using System.Diagnostics;
using System.IO;
using Bytescout.Spreadsheet;

namespace AddHeaderAndFooter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
			    // Create new Spreadsheet object
                Spreadsheet spreadsheet = new Spreadsheet();

                // Add new worksheet
                Worksheet worksheet = spreadsheet.Workbook.Worksheets.Add("Sample");

                // Add headers:

                // add date as left header
                worksheet.PageSetup.LeftHeader = "&D";
                // add label with custom font as center header
                worksheet.PageSetup.CenterHeader = "&\"Verdana,bold\"&14Laws && Rights";
                // add time as right header
                worksheet.PageSetup.RightHeader = "&T";

                // Add footers:

                // add file name as left footer
                worksheet.PageSetup.LeftFooter = "&F";
                // add "page of pages" indicator as center footer
                worksheet.PageSetup.CenterFooter = "&P/&N";
                // add simple text as right footer
                worksheet.PageSetup.RightFooter = "Right footer";

                // Add worksheet content
                worksheet.Cell(1, 1).Value = "Click Print Preview to see headers and footers.";

                // Save it as XLS
                if (File.Exists("Output.xls"))
                    File.Delete("Output.xls");
                spreadsheet.SaveAs("Output.xls");

                // Close the document
                spreadsheet.Close();

                // Open output XLS file
                Process.Start("Output.xls");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
