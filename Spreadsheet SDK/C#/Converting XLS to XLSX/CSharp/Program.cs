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
            document.SaveAs("Output.xlsx");

            // Close Spreadsheet
            document.Close();

            // open generated XLSX document in default program
            Process.Start("Output.xlsx");

        }
    }
}
