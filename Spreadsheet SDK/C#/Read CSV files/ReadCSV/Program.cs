//*******************************************************************
//       ByteScout Spreadsheet SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

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
            document.LoadFromFile("Hello_world.csv");

            // Get first worksheet
            Worksheet worksheet = document.Workbook.Worksheets[0];

            // Read cell value
            Console.WriteLine("Cell (0,0) value: {0}", worksheet.Cell(0, 0).ValueAsString);

            // Write message
            Console.Write("Press any key to continue...");

            // Wait user input
            Console.ReadKey();
        }
    }
}
