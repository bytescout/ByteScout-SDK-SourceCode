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


using System.Collections;
using System.Diagnostics;
using System.IO;

namespace Bytescout.Spreadsheet.Demo.Csharp.ImportFromList
{
    class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "CSharpImportFromList.xls";

            // Create a new spreadsheet
            Spreadsheet spreadsheet = new Spreadsheet();

            // Get the data from the 2D array that we want to import
            IList planets = GetList();

            // Import data into spreadheet
            spreadsheet.ImportFromList(planets);

            // Save the spreadsheet
            if (File.Exists(fileName)) File.Delete(fileName);
            spreadsheet.SaveAs(fileName);

            // Close spreadsheet
            spreadsheet.Close();

            // Open the spreadsheet
            Process.Start(fileName);
        }

        /// <summary>
        /// Creates a list of planets
        /// </summary>
        /// <returns>List of planets</returns>
        private static IList GetList()
        {
            string[,] planets = new string[9,1];
            planets[0,0] = "Mercury";
            planets[1,0] = "Venus";
            planets[2,0] = "Earth";
            planets[3,0] = "Mars";
            planets[4,0] = "Jupiter";
            planets[5,0] = "Saturn";
            planets[6,0] = "Uranus";
            planets[7,0] = "Neptune";
            planets[8,0] = "Pluto";

            return planets;
        }
    }
}
