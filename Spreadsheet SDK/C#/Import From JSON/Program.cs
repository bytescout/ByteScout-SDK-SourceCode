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


using System.Diagnostics;
using System.IO;
using Bytescout.Spreadsheet;

namespace ImportFromJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Spreadsheet spreadsheet = new Spreadsheet())
            {
                // Load JSON string from file
                string jsonString = File.ReadAllText("sample.json");

            	// Import JSON
                spreadsheet.ImportFromJSON(jsonString);
                
                // Save spreadsheet
                spreadsheet.SaveAsXLS("result.xls");

				// Open the result file in default associated application
                Process.Start("result.xls");
            }
        }
    }
}
