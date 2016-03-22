//*******************************************************************
//       ByteScout BarCode SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Web;
using System.Web.Mvc;
using System.Linq;
using Bytescout.BarCode;

namespace BarcodeGenerator.Helpers
{
    public static class GeneratorHelper
    {
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

        public static IHtmlString GetBarcode(this HtmlHelper helper,
                                          string value,
                                          SymbologyType symbology,
                                          bool addChecksum = false)
        {
            var base64ImageBytes = GetBase64Barcode(value, symbology, addChecksum);
            var str = string.Format("<img src=\"data:image/png;base64,{0}\">", base64ImageBytes);
            return MvcHtmlString.Create(str);
           
        }

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
