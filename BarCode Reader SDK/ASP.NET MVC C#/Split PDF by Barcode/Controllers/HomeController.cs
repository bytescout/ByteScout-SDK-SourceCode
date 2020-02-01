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


using Bytescout.BarCodeReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace SplitPdfByBarcode.Controllers
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

    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProcessIndex()
        {
            var pdfFileUrl = Request.MapPath("~/barcodes.pdf");

            var savePath = Request.MapPath("~");

            var outputString = "";


            Reader barcodeReader = new Reader();

            // Limit search to 1D barcodes only (exclude 2D barcodes to speed up the search).
            // Change to barcodeReader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcodes 
            // or select specific type, e.g. barcodeReader.BarcodeTypesToFind.PDF417 = True
            barcodeReader.BarcodeTypesToFind.SetAll1D();

            // reader.MediumTrustLevelCompatible = true; // uncomment this line to enable Medium Trust compatible mode (slows down the recognition process as direct image data access is disabled in Medium Trust mode)

            FoundBarcode[] barcodes = barcodeReader.ReadFrom(pdfFileUrl);

            if (barcodes.Length == 0)
            {
                outputString += "No barcodes found";
            }
            else
            {
                int partIndex = 0;

                foreach (FoundBarcode barcode in barcodes)
                {
                    // Split PDF document in two parts by found barcode
                    partIndex++;
                    barcodeReader.SplitDocument(
                        pdfFileUrl,
                        savePath + @"part-" + partIndex + ".pdf",
                        savePath + @"part-last.pdf",
                        barcode.Page + 1);

                    outputString += String.Format("Splitting barcodes.pdf file into 2 by barcode with type '{0}' and value '{1}' on page {2} at {3} <br/>", barcode.Type, barcode.Value, barcode.Page, barcode.Rect.ToString());
                    outputString += "Saved:" + @"part-" + partIndex + ".pdf <br/>";
                }

                outputString += "Saved:" + @"part-last.pdf <br/>";
            }

            return Content(outputString);
        }
    }
}
