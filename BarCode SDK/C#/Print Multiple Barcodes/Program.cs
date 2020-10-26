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


using System.Linq;
using Bytescout.BarCode;

namespace PrintBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prepare Barcode object that will generate barcodes for printing
            var barcode = new Barcode();
            barcode.RegistrationName = "demo";
            barcode.RegistrationKey = "demo";
            barcode.Symbology = SymbologyType.EAN13;
            barcode.DrawCaption = true;
            barcode.BarHeight = 50;
            barcode.DrawQuietZones = false;
            barcode.Margins = new Margins(20, 20, 20, 20);

            // Prepare BarcodePrinter object
            var barcodePrinter = new BarcodePrinter();
            // Set printer paper size
            barcodePrinter.SetPaperSize("A4");
            // Set number of barcodes on a page: 4 lines of 4 barcodes per line = 16 barcodes per page
            barcodePrinter.SetGrid(4, 4);
            // Fit barcodes into the grid cell size
            barcodePrinter.FitBarcodesIntoGrid = true;
            // Set some optional printing params
            //barcodePrinter.SetMargins(20, 0, 0, 20);
            //barcodePrinter.Copies = 2;
            //barcodePrinter.Collate = true;
            //barcodePrinter.Color = false;

            // Generate 25 barcode values in EAN13 format "5901234NNNNN"
            // and add them to the BarcodePrinter
            var barcodeValues = Enumerable.Range(1, 25).Select(n => "5901234" + n.ToString("00000")).ToList();
            barcodePrinter.AddBarcodeValues(barcodeValues);

            // Print barcodes to the specified printer 
            barcodePrinter.Print(barcode, "Microsoft Print to PDF");
        }
    }
}
