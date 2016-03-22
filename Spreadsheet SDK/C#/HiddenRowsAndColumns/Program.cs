//*******************************************************************
//       ByteScout Spreadsheet SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System.Diagnostics;
using System.IO;
using Bytescout.Spreadsheet;

namespace HiddenRowsAndColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open spreadsheet from file
            Spreadsheet document = new Spreadsheet();
            document.LoadFromFile("example.xls");

            // Get first worksheet
            Worksheet worksheet = document.Workbook.Worksheets[0];

            //Hide first three columns
            worksheet.Columns[0].Hidden = true;
            worksheet.Columns[1].Hidden = true;
            worksheet.Columns[2].Hidden = true;

            //Hide first three rows
            worksheet.Rows[0].Hidden = true;
            worksheet.Rows[1].Hidden = true;
            worksheet.Rows[2].Hidden = true;

            
            // Delete output file if exists
            if (File.Exists("changed.xls"))
            {
                File.Delete("changed.xls");
            }

            // Save document
            document.SaveAs("changed.xls");

            // Close spreadsheet
            document.Close();

            // Open generated XLS document in default program
            Process.Start("changed.xls");
        }
    }
}
