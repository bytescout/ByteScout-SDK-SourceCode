//*******************************************************************
//       ByteScout Spreadsheet SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Bytescout.Spreadsheet;
using System.Diagnostics;

namespace Converting_XLS_to_XML
{
    class Program
    {
        static void Main(string[] args)
        {
      Spreadsheet document = new Spreadsheet();
      document.LoadFromFile("SimpleReport.xls");

            // delete output file if exists already
            if (File.Exists("SimpleReport.xml")){
                File.Delete("SimpleReport.xml");
            }

      document.Workbook.Worksheets[0].SaveAsXML("SimpleReport.xml");
      document.Close();

            // open output document in default viewer
           Process.Start("SimpleReport.xml");


        }
    }
}
