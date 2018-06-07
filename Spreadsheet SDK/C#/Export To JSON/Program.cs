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


using System.Diagnostics;
using System.IO;
using Bytescout.Spreadsheet;

namespace ExportToJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Spreadsheet spreadsheet = new Spreadsheet())
            {
            	// Load document
                spreadsheet.LoadFromFile("Table.xls");
                
                // Export first worksheet to JSON format
                string jsonString = spreadsheet.ExportToJSON(0);
                
                // Write JSON string to file
                File.WriteAllText("exported.json.txt", jsonString);

				// Open the result file in default associated application
                Process.Start("exported.json.txt");
            }
        }
    }
}
