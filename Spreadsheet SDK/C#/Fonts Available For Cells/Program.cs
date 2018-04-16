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

            // Add new worksheet
            Worksheet worksheet = document.Workbook.Worksheets.Add("HelloWorld");

            // Create array with font names
            string[] fontNames = new string[] {
                                              "Helvetica", 
                                              "Times New Roman", 
                                              "Verdana",
                                              "Times New Roman"
            };

            // Use all fonts in fontsNames array
            for (int i = 0; i < fontNames.Length; i++)
            {
                // Set font size based on loop counter
                float fontSize = 10 + i * 3;

                //Set cell font type and font size
                worksheet.Cell(i, 0).Font = new System.Drawing.Font(fontNames[i], fontSize);

                // Set cell value
                worksheet.Cell(i, 0).Value = fontNames[i];
            }

            // delete output file if exists already
            if (File.Exists("Fonts.xls")){
                File.Delete("Fonts.xls");
            }

            // Save document
            document.SaveAs("Fonts.xls");
            
            // Close document
            document.Close();

            // open generated XLS document in default program
            Process.Start("Fonts.xls");
        }
    }
}
