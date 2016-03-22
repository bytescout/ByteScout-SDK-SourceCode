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
