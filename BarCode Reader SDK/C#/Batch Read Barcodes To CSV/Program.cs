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
using System.Diagnostics;
using Bytescout.BarCodeReader;

namespace ImagePDFBarcodeToCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Read Barcode Process
                Reader reader = new Reader();
                reader.RegistrationKey = "demo";
                reader.RegistrationName = "demo";

                // Set Barcode type to find
                reader.BarcodeTypesToFind.All = true;

                // Output list
                List<CSVOutputFormat> lstCSVOutput = new List<CSVOutputFormat>();

                // Get all files in folder, and iterate through each file
                var files = System.IO.Directory.GetFiles("BarcodeFiles");
                foreach (var fileName in files)
                {
                    // Read barcodes
                    FoundBarcode[] barcodes = reader.ReadFrom(fileName);

                    foreach (FoundBarcode code in barcodes)
                    {
                        lstCSVOutput.Add(new CSVOutputFormat { barcodeValue = code.Value, barcodeType = code.Type.ToString(), scanDateTime = DateTime.Now.ToString(), fileName = fileName });
                    }
                }

                Console.WriteLine("Total {0} barcode found in {1} file.", lstCSVOutput.Count, files.Length);

                // cleanup
                reader.Dispose();

                // Export to CSV
                ExportToCsv(lstCSVOutput);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press enter key to exit...");
            Console.ReadLine();
        }

        /// <summary>
        /// Exports to CSV
        /// </summary>
        /// <param name="lstCSVOutput"></param>
        private static void ExportToCsv(List<CSVOutputFormat> lstCSVOutput)
        {
            System.Text.StringBuilder csvOutputContent = new System.Text.StringBuilder(string.Empty);

            csvOutputContent.Append("Barcode Value,Barcode Type,Scan DateTime,File Name");

            foreach (var item in lstCSVOutput)
            {
                csvOutputContent.AppendFormat("\r\n{0},{1},{2},{3}", item.barcodeValue, item.barcodeType, item.scanDateTime, item.fileName);
            }

            System.IO.File.WriteAllText("output.csv", csvOutputContent.ToString());

            Process.Start("output.csv");
        }
    }

    class CSVOutputFormat
    {
        public string barcodeValue { get; set; }
        public string barcodeType { get; set; }
        public string scanDateTime { get; set; }
        public string fileName { get; set; }
    }
}
