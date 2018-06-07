//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Collections;

namespace Bytescout.Spreadsheet.Demo.Csharp.ExportToList
{
    class Program
    {
        static void Main(string[] args)
        {
            const string inputFile = @"ListOfPlanetsSpreadsheet.xls";

            // Open and load spreadsheet
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile(inputFile);

            // Get the data from the spreadsheet
            IList planets = new string[10, 10];
            spreadsheet.ExportToList(planets);

            // Close spreadsheet
            spreadsheet.Close();

            // Display array
            string[,] planetsArray = planets as string[,];
            for (int i = 0; i < planetsArray.GetLength(0); i++)
            {
                for (int j = 0; j < planetsArray.GetLength(1); j++)
                {
                    Console.Write(planetsArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Pause
            Console.ReadLine();
        }
    }
}
