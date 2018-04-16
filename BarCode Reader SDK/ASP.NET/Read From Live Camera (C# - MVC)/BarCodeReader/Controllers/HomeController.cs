//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarcodeReader.Controllers
{
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Text;
    using Bytescout.BarCodeReader;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            if (file != null)
            {
                string name = file.FileName;
                string path = Path.Combine(Server.MapPath("/"), Path.GetFileName(name));
                file.SaveAs(path);
                ViewBag.Barcodes = Barcode.FindBarcodes(path);
                ViewBag.Img = name;
            }

            return View();
        }

        [HttpPost]
        public ActionResult UploadHtml5(string image, string type)
        {
            try
            {
                StringBuilder send = new StringBuilder();
                // lock by send variable 
                lock (send)
                {
                    // convert base64 string from the client side into byte array
                    byte[] bitmapArrayOfBytes = Convert.FromBase64String(image);
                    // convert the byte array into the bitmap 

                    Bitmap bp = (Bitmap)Bitmap.FromStream(new MemoryStream(bitmapArrayOfBytes));

                    bp.Save("c:\\temp\\barcode.jpg",ImageFormat.Jpeg);
                    // new bytescout barcode reader sdk object
                    Reader reader = new Reader();
                    // get the type to find from user's selection in the combobox
                    reader.BarcodeTypesToFind = Barcode.GetBarcodeTypeToFindFromCombobox(type);
                    // read image to get barcodes
                    reader.ReadFrom(bp);
                    // check if we have got barcodes from the image
                    if (reader.FoundBarcodes != null)
                    {
                        // add each barcode into the string 
                        foreach (FoundBarcode barcode in reader.FoundBarcodes)
                        {
                            // add barcodes as text into the output string
                            send.AppendLine(String.Format("{0} : {1}", barcode.Type, barcode.Value));
                        }
                    }
                    // return the output string
                    return Json(new { d = send.ToString() });
                } // end of lock
            }
            catch (Exception ex)
            {
                // return the exception instead
                return Json(new { d = ex.Message + "\r\n" + ex.StackTrace });
            }

        }

        [HttpPost]
        public ActionResult UploadFlash(string type)
        {
            try
            {
                String send = "";
                System.Drawing.Image originalimg;
                // read barcode type set 
                MemoryStream log = new MemoryStream();
                byte[] buffer = new byte[1024];
                int c;
                // read input buffer with image and saving into the "log" memory stream
                while ((c = Request.InputStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    log.Write(buffer, 0, c);
                }
                // create image object
                originalimg = System.Drawing.Image.FromStream(log);
                // resample image
                originalimg = originalimg.GetThumbnailImage(640, 480, new System.Drawing.Image.GetThumbnailImageAbort(() => { return false; }), IntPtr.Zero);

                Bitmap bp = new Bitmap(originalimg);

                bp.Save("c:\\temp\\barcode.jpg", ImageFormat.Jpeg);

                // create bytescout barcode reader object
                Reader reader = new Reader();
                // set barcode type to read
                reader.BarcodeTypesToFind = Barcode.GetBarcodeTypeToFindFromCombobox(type);
                // read barcodes from image
                reader.ReadFrom(bp);
                // if there are any result then convert them into a single stream
                if (reader.FoundBarcodes != null)
                {
                    foreach (FoundBarcode barcode in reader.FoundBarcodes)
                    {
                        // form the output string
                        send = send + (String.Format("{0} : {1}", barcode.Type, barcode.Value));
                    }
                }
                // close the memory stream
                log.Close();
                // dispose the image object
                originalimg.Dispose();
                // write output 
                return Content("<d>" + send + "</d>");
            }
            catch (Exception ex)
            {
                // write the exception if any
                return Content("<d>" + ex + "</d>");
            }
        }
    }

}
