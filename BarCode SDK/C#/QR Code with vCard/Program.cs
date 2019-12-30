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
using System.Text;
using System.Diagnostics;

using Bytescout.BarCode;
using CreateBarCode;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new barcode
            Barcode barcode = new Barcode();

            // Set symbology
            barcode.Symbology = SymbologyType.QRCode;

            // Inputs
            var oQrcodeVCard = new QrCodeVCardTemplate {
                FirstName = "Forest",
                LastName = "Gump",
                Company = "Bubba Gump Shrimp Co.",
                Job = "Shrimp Man",
                Phone = "+1-111-555-1212",
                Fax = "+1-404-555-1212",
                Email = "forrestgump@example.com",
                Street  = "100 Waters Edge",
                City = "Baytown",
                State = "LA",
                Country = "USA",
                ZipCode = "30314"
            };


            // Set value            
            barcode.Value = oQrcodeVCard.ToString();

            // Save barcode to image
            barcode.SaveImage("result.png");

            // Show image in default image viewer
            Process.Start("result.png");
        }
    }
}
