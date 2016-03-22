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

namespace Book_properties_read
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();
	document.LoadFromFile("Input.xls");

            // Get some properties
            Console.WriteLine("Author: " + document.Workbook.Properties.Author);
            Console.WriteLine("Comments: " + document.Workbook.Properties.Comments);
            Console.WriteLine("Subject: " + document.Workbook.Properties.Subject);
        }
    }
}
