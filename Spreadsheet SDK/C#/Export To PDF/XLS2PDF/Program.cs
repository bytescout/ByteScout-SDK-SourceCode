//*******************************************************************
//       ByteScout Spreadsheet SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using Bytescout.Spreadsheet;
using System.IO;

namespace XLS2PDF
{
    class Program
    {
        static void Main(string[] args)
        {
            Spreadsheet document = new Spreadsheet();

            // load table from existing XLS file        
            document.LoadFromFile("SimpleReport.xls");

            // add image
            document.Workbook.Worksheets[0].Pictures.Add(10, 2, "image.jpg");

            // save as PDF
            document.SaveAsPDF("Output.pdf", false);

            // close the document 
            document.Close();
        }
    }
}
