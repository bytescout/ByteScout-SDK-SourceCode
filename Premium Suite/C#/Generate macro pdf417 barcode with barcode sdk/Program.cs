//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

using Bytescout.BarCode;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new barcode
            Barcode barcode = new Barcode();

            // Set symbology
            barcode.Symbology = SymbologyType.MacroPDF417;

            // we will encode value 123456789
            // will break into 3 segments, each segment includes 3 symbols
                       
            // 1st segment
            // create the first segment barcode so set SegmentIndex = 1
            barcode.Options.PDF417SegmentIndex = 1;
            // Set value            
            barcode.Value = "123";
            // set that this is not the last segment yet
            barcode.Options.PDF417LastSegment = false;

            // Save barcode to image
            barcode.SaveImage("MacroPDFBarcode-part1.png");

            // 2nd segment
            // create the 2nd segment barcode so set SegmentIndex = 2
            barcode.Options.PDF417SegmentIndex = 2;
            // Set value            
            barcode.Value = "456";
            // set that this is not the last segment yet
            barcode.Options.PDF417LastSegment = false;

            // Save barcode to image
            barcode.SaveImage("MacroPDFBarcode-part2.png");


            // 3rd segment
            // create the 3rd segment barcode so set SegmentIndex = 3
            barcode.Options.PDF417SegmentIndex = 3;
            // Set value            
            barcode.Value = "789";
            // set that this is the LAST segment, so set PDF417LastSegment = TRUE
            barcode.Options.PDF417LastSegment = true;

            // Save barcode to image
            barcode.SaveImage("MacroPDFBarcode-part3.png");

            // now open all three images
            
            // Show image in default image viewer
            Process.Start("MacroPDFBarcode-part1.png");
            Process.Start("MacroPDFBarcode-part2.png");
            Process.Start("MacroPDFBarcode-part3.png");
        }
    }
}
