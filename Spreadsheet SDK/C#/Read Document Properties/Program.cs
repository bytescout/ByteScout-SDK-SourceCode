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
