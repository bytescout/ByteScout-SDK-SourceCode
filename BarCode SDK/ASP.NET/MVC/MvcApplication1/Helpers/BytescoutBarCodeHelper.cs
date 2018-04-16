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
using System.Web;
using System.Web.Mvc;
using System.Linq;
using Bytescout.BarCode; // add reference from c:\program files\bytescout barcode generator sdk\net4.00\


namespace BarcodeGenerator.Helpers
{
    public static class GeneratorHelper
    {
        /// <summary>
        /// Generate barcode and return as base 64 image
        /// </summary>
        /// <param name="value">value</param>
        /// <param name="symbology">barcode type</param>
        /// <param name="addChecksum">add checkum or not</param>
        /// <returns></returns>
        public static string GetBase64Barcode(string value, SymbologyType symbology, bool addChecksum = false)
        {
            using (var barcode = new Barcode())
            {
                barcode.Symbology = symbology;
                barcode.Value = value;

                barcode.AddChecksum = addChecksum;

                var imageBytes = barcode.GetImageBytesPNG();

                return Convert.ToBase64String(imageBytes);
            }
        }

        /// <summary>
        /// Returns HTML string with the image with barcode
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="value"></param>
        /// <param name="symbology"></param>
        /// <param name="addChecksum"></param>
        /// <returns></returns>
        public static IHtmlString GetBarcode(this HtmlHelper helper,
                                          string value,
                                          SymbologyType symbology,
                                          bool addChecksum = false)
        {
            var base64ImageBytes = GetBase64Barcode(value, symbology, addChecksum);
            var str = string.Format("<img src=\"data:image/png;base64,{0}\">", base64ImageBytes);
            return MvcHtmlString.Create(str);
           
        }

        /// <summary>
        /// Returns embedded HTML barcode image
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="value"></param>
        /// <param name="symbology"></param>
        /// <param name="addChecksum"></param>
        /// <returns></returns>
        public static IHtmlString EmbeddedBarcodeImage(this HtmlHelper helper,
                                          string value,
                                          SymbologyType symbology,
                                          bool addChecksum = false)
        {
            using (var barcode = new Barcode())
            {
                barcode.Symbology = symbology;
                barcode.Value = value;

                barcode.AddChecksum = addChecksum;

                var imageBytes = barcode.GetImageBytesPNG();
                var str = string.Format("data:image/png;base64,{0}",
                                        Convert.ToBase64String(imageBytes));
                return MvcHtmlString.Create(str);
            }
        }      
        
    }
}
