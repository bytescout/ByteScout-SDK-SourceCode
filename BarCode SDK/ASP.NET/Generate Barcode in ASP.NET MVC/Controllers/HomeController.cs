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
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bytescout.BarCode; // add reference from c:\program files\bytescout barcode generator sdk\net4.00\
using BarcodeGenerator.Helpers; // reference to Helpers/BytescoutBarCodeHelper.cs 

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Default1/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string theValue)
        {
            var base64ImageBytes = "";
            try
            {
                bool addChecksum = false;
                // generate QR Code barcode
                base64ImageBytes = GeneratorHelper.GetBase64Barcode(theValue, SymbologyType.QRCode, addChecksum);
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return View();
            }

            var str = string.Format("<img src=\"data:image/png;base64,{0}\">", base64ImageBytes);
            ViewBag.Image = str;

            return View();
        }
    }
}
