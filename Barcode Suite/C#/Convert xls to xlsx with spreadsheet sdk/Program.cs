//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Bytescout.Spreadsheet;
using System.Diagnostics;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
			// Open existing XLS file
            Spreadsheet spreadsheet = new Spreadsheet();
			spreadsheet.LoadFromFile("Input.xls");

            // delete output file if exists already
            if (File.Exists("Output.xlsx")){
                File.Delete("Output.xlsx");
            }

            // Save document
            spreadsheet.SaveAs("Output.xlsx");

            // Close Spreadsheet
            spreadsheet.Close();

            // open generated XLSX document in default program
            Process.Start("Output.xlsx");

        }
    }
}
