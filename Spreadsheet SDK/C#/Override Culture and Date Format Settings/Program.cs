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


using Bytescout.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();
            document.LoadFromFile("sampleDates.xlsx");

            // Get worksheet
            Worksheet worksheet = document.Workbook.Worksheets.ByName("Sheet1");

            // List of cell-addresses
            var valuesToRead = new List<KeyValuePair<int, int>>
            {
                new KeyValuePair<int, int>(1,0),
                new KeyValuePair<int, int>(2,0),
                new KeyValuePair<int, int>(3,0)
            };

            // Set culture as en-us
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            // Iterate through list of cell addresses
            foreach (var itmAddress in valuesToRead)
            {
                var itmValue = worksheet.Cell(itmAddress.Key, itmAddress.Value).ValueAsDateTime;

                // Read cell value
                Console.WriteLine($"Cell ({itmAddress.Key},{itmAddress.Value}) value: {itmValue.ToShortDateString()}");
            }

            // Write message
            Console.Write("Press any key to continue...");

            // Wait user input
            Console.ReadKey();
        }
    }
}
