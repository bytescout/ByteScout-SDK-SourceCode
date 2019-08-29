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
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();
	document.LoadFromFile("Hello_World.txt", "\t"); // reading from TXT file using \t (TAB) as delimiter

            // Get first worksheet
            Worksheet worksheet = document.Workbook.Worksheets[0];

            // Read cell value
            Console.WriteLine("Cell (0,0) value: {0}", worksheet.Cell(0, 0).ValueAsExcelDisplays);

            // Write message
            Console.Write("Press any key to continue...");

            // Wait user input
            Console.ReadKey();
        }
    }
}
