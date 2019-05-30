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
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace BarcodeReaderFromDoc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Process uploaded file and try to read barcodes from it
        /// </summary>
        [HttpPost]
        public ActionResult ProcessFile(HttpPostedFileBase UploadedFile, int PageNo)
        {
            List<string> lstResult = new List<string>();

            try
            {
                // Save uploaded file
                if (UploadedFile.ContentLength > 0)
                {

                    // Barcode reader
                    Reader barcodeReader = new Reader();

                    // Limit search to 1D barcodes only (exclude 2D barcodes to speed up the search).
                    // Change to barcodeReader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcodes 
                    // or select specific type, e.g. barcodeReader.BarcodeTypesToFind.PDF417 = True
                    barcodeReader.BarcodeTypesToFind.SetAll1D();

                    // Reading barcode from document on page-by-page basic
                    barcodeReader.ReadFromStream(UploadedFile.InputStream, (PageNo - 1), 1);

                    // Get all found barcodes for that page
                    FoundBarcode[] barcodes = barcodeReader.FoundBarcodes;

                    lstResult.Add($"Reading barcode(s) from file {Path.GetFileName(UploadedFile.FileName)}, Page No: {PageNo}");

                    if (barcodes.Length == 0)
                    {
                        lstResult.Add("No barcodes found");
                    }
                    else
                    {
                        foreach (FoundBarcode barcode in barcodes)
                        {
                            lstResult.Add(String.Format("Found barcode - Type: '{0}', Value: '{1}', Position: '{2}'", barcode.Type, barcode.Value, barcode.Rect.ToString()));
                        }
                    }
                }
                else
                {
                    lstResult.Add("Please upload document");
                }
            }
            catch (Exception ex)
            {
                lstResult = new List<string> { ex.Message };
            }

            return View("Result", lstResult);
        }

    }
}
