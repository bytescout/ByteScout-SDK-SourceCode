//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


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
