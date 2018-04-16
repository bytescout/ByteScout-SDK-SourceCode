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

namespace Bytescout.Spreadsheet.Demo.Csharp.ExportToJaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            const string inputFile = @"StockPricesSpreadsheet.xls";

            // Open and load spreadsheet
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile(inputFile);

            // Get the data from the spreadsheet
            string[][] stockPrices = spreadsheet.ExportToJaggedArray();

            // Close spreadsheet
            spreadsheet.Close();

            // Display data in jagged array
            for (int i = 0; i < stockPrices.GetLength(0); i++)
            {
                Console.Write(stockPrices[i][0] + " ");
                Console.Write(stockPrices[i][1] + " ");
                Console.WriteLine();
            }

            // Pause
            Console.ReadLine();
        }
    }
}
