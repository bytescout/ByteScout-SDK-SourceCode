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
