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
using Bytescout.Spreadsheet;
using System.IO;
using System.Diagnostics;

namespace Converting_XLS_to_CSV
{
    class Program
    {
        static void Main(string[] args)
        {
      Spreadsheet document = new Spreadsheet();
	document.LoadFromFile("SimpleReport.xls");

            // delete output file if exists already
            if (File.Exists("SimpleReport.csv")){
                File.Delete("SimpleReport.csv");
            }

      document.Workbook.Worksheets[0].SaveAsCSV("SimpleReport.csv");
      document.Close();

            // open output document in default viewer
           Process.Start("SimpleReport.csv");

        }
    }
}
