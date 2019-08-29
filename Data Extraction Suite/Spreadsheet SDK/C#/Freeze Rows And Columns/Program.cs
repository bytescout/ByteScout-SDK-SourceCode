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
using Bytescout.Spreadsheet;

namespace Freeze_rows_and_columns
{
    class Program
    {
        static void Main(string[] args)
        {
            Spreadsheet spreadsheet = new Spreadsheet();

            Console.WriteLine("Read excel file...");
            spreadsheet.LoadFromFile(@".\Input.xls");

            Console.WriteLine("Read first spreadsheet...");
            Worksheet worksheet = spreadsheet.Worksheets[0];

            Console.WriteLine("Freeze rows...");
            worksheet.ViewOptions.SplitVertical = worksheet.Rows[0].Height;
            worksheet.ViewOptions.SplitRow = 1;
            worksheet.ViewOptions.PanesFrozen = true;
			
            Console.WriteLine("Freeze columns...");
            worksheet = spreadsheet.Worksheets[1];
            worksheet.ViewOptions.SplitHorizontal = worksheet.Columns[0].Width;
            worksheet.ViewOptions.SplitColumn = 1;
            worksheet.ViewOptions.PanesFrozen = true;

            
            Console.WriteLine("Save excel file...");
            spreadsheet.SaveAs("Output.xls");

            // Cleanup
            spreadsheet.Dispose();

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
