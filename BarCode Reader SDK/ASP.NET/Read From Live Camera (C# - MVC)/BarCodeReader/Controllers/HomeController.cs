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
                
                // Lock by send variable 
                lock (send)
                {
                    // Convert base64 string from the client side into byte array
                    byte[] bitmapArrayOfBytes = Convert.FromBase64String(image);
                    // Create Bytescout.BarCodeReader.Reader object
                    Reader reader = new Reader();
                    // Get the barcode type from user's selection in the combobox
                    reader.BarcodeTypesToFind = Barcode.GetBarcodeTypeToFindFromCombobox(type);
                    // Read barcodes from image bytes
                    reader.ReadFromMemory(bitmapArrayOfBytes);
                    // Check whether the barcode is decoded
                    if (reader.FoundBarcodes != null)
                    {
                        // Add each decoded barcode into the string 
                        foreach (FoundBarcode barcode in reader.FoundBarcodes)
                        {
                            // Add barcodes as text into the output string
                            send.AppendLine(String.Format("{0} : {1}", barcode.Type, barcode.Value));
                        }
                    }

                    // Return the output string as JSON
                    return Json(new { d = send.ToString() });
                }
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
