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
using System.Diagnostics;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();

            // Input file url
            var cInputUrl = @"https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/csv-to-pdf/sample.csv";

            // Get stream from url
            var oStream = GetStreamFromUrl(cInputUrl);

            // load csv file stream
            document.LoadFromStream(oStream);

            // Save document
            document.SaveAs("Output.xls");

            // Close Spreadsheet
            document.Close();

            // open generated XLS document in default program
            Process.Start("Output.xls");
        }

        /// <summary>
        /// Get stream from Url
        /// </summary>
        private static Stream GetStreamFromUrl(string url)
        {
            byte[] oData = null;

            using (var wc = new System.Net.WebClient())
                oData = wc.DownloadData(url);

            return new MemoryStream(oData);
        }
    }
}
