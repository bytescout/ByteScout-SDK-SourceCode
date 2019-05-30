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
using System.Data;
using System.IO;
using Bytescout.Spreadsheet;
using Bytescout.Spreadsheet.Utils;
using System.Diagnostics;

namespace SimpleXMLConverterSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // sample XLS to XML conversion
            SampleXLStoXMLConversion();
            // sample XML to XLS conversion
            SampleXMLtoXLSConversion();
        }

        /// <summary>
        /// shows how to convert existing XLS (Excel) document into XML using Bytescout.Spreadsheet and Bytescout.Spreadsheet.Utils.SimpleXMLConverter
        /// </summary>
        private static void SampleXLStoXMLConversion(){
            Spreadsheet document;

            // read XLS and save as XML
            document = new Spreadsheet();
	document.LoadFromFile("AdvancedReport.xls");
            SimpleXMLConverter tools = new SimpleXMLConverter(document);
            tools.SaveXML("AdvancedReport.xml");
            document.Close();
        }

        /// <summary>
        /// shows how to convert XML data into XLS excel using Bytescout.Spreadsheet and Bytescout.Spreadsheet.Utils.SimpleXMLConverter
        /// </summary>
        private static void SampleXMLtoXLSConversion()
        {
            // read XML and convert into XLS (Excel) and save

            Spreadsheet document = new Spreadsheet();

            SimpleXMLConverter tools = new SimpleXMLConverter(document);

            tools.LoadXML("AdvancedReport.xml");

            // delete output file if exists already
            if (File.Exists("Output.xls")){
                File.Delete("Output.xls");
            }

            // Save document
            document.SaveAs("Output.xls");

            // Close Spreadsheet
            document.Close();

            // open generated XLS document in default program
            Process.Start("Output.xls");

        }
    }

}
