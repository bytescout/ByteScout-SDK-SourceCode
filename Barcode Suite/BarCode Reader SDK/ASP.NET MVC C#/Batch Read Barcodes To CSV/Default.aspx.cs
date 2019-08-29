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


using Bytescout.BarCodeReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImagePDFBarcodeToCSV
{
    /*
    IF YOU SEE TEMPORARY FOLDER ACCESS ERRORS: 

    Temporary folder access is required for web application when you use ByteScout SDK in it.
    If you are getting errors related to the access to temporary folder like "Access to the path 'C:\Windows\TEMP\... is denied" then you need to add permission for this temporary folder to make ByteScout SDK working on that machine and IIS configuration because ByteScout SDK requires access to temp folder to cache some of its data for more efficient work.

    SOLUTION:

    If your IIS Application Pool has "Load User Profile" option enabled the IIS provides access to user's temp folder. Check user's temporary folder

    If you are running Web Application under an impersonated account or IIS_IUSRS group, IIS may redirect all requests into separate temp folder like "c:\temp\".

    In this case
    - check the User or User Group your web application is running under
    - then add permissions for this User or User Group to read and write into that temp folder (c:\temp or c:\windows\temp\ folder)
    - restart your web application and try again

    */

    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnImagePDFBarcodeToCSV_Click(object sender, EventArgs e)
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
            var files = System.IO.Directory.GetFiles(Request.MapPath("~/BarcodeFiles"));
            foreach (var fileName in files)
            {
                // Read barcodes
                FoundBarcode[] barcodes = reader.ReadFrom(fileName);

                foreach (FoundBarcode code in barcodes)
                {
                    lstCSVOutput.Add(new CSVOutputFormat { barcodeValue = code.Value, barcodeType = code.Type.ToString(), scanDateTime = DateTime.Now.ToString(), fileName = fileName });
                }
            }

            // Set info text
            lblInfo.Text = string.Format("Total {0} barcode found in {1} file.", lstCSVOutput.Count, files.Length);

            // Export to CSV
            ExportToCsv(lstCSVOutput, Response); 
        }


        /// <summary>
        /// Exports to CSV
        /// </summary>
        /// <param name="lstCSVOutput"></param>
        private static void ExportToCsv(List<CSVOutputFormat> lstCSVOutput, HttpResponse response)
        {
            System.Text.StringBuilder csvOutputContent = new System.Text.StringBuilder(string.Empty);

            csvOutputContent.Append("Barcode Value,Barcode Type,Scan DateTime,File Name");

            foreach (var item in lstCSVOutput)
            {
                csvOutputContent.AppendFormat("\r\n{0},{1},{2},{3}", item.barcodeValue, item.barcodeType, item.scanDateTime, item.fileName);
            }

            // Perform download of file
            response.Clear();
            response.ClearHeaders();

            response.AppendHeader("Content-Length", csvOutputContent.Length.ToString());
            response.ContentType = "text/csv";
            response.AppendHeader("Content-Disposition", "attachment;filename=\"output.csv\"");

            response.Write(csvOutputContent.ToString());
            response.End();
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
