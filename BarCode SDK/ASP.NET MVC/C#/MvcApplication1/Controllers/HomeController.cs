//*******************************************************************
//       ByteScout BarCode SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

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
