//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


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
            document.Workbook.Worksheets[0].Pictures.Add(5, 1, "image.jpg");

            // save as PDF
            bool autosize = false;
            document.SaveAsPDF("Output.pdf", autosize);

            // close the document 
            document.Close();
        }
    }
}
