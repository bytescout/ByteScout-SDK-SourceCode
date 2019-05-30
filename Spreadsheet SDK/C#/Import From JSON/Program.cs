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
