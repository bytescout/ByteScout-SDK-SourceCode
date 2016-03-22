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
using Bytescout.Spreadsheet;
using System.IO;
using System.Diagnostics;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();

	    // load csv file
	    document.LoadFromFile("input.csv");

            // Save document
            document.SaveAs("Output.xls");

            // Close Spreadsheet
            document.Close();

            // open generated XLS document in default program
            Process.Start("Output.xls");
        }
    }
}
