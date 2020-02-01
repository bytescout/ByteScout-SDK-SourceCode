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


using Bytescout.BarCode;
using System.Collections.Generic;
using System.Diagnostics;

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

            Macro417SegmentHelper macro417SegmentHelper = new Macro417SegmentHelper();
            macro417SegmentHelper.AddValue("123", "456", "789");

            foreach (var itmSegment in macro417SegmentHelper.GetAllSegments())
            {
                // create the first segment barcode so set SegmentIndex = 1
                barcode.Options.PDF417SegmentIndex = itmSegment.SegmentIndex;

                // Set value            
                barcode.Value = itmSegment.SegmentValue;

                // set that this is not the last segment yet
                barcode.Options.PDF417LastSegment = itmSegment.IsLastSegment;

                // Save barcode to image
                barcode.SaveImage($"MacroPDFBarcode-part{itmSegment.SegmentIndex}.png");

                // Show image in default image viewer
                Process.Start($"MacroPDFBarcode-part{itmSegment.SegmentIndex}.png");
            }
        }
    }


    public class Macro417SegmentHelper
    {
        // Declarations
        private List<string> lstValues { get; set; } = new List<string>();

        /// <summary>
        /// Add segment value
        /// </summary>
        public void AddValue(params string[] strValue)
        {
            foreach (var item in strValue)
            {
                lstValues.Add(item);
            }
        }

        /// <summary>
        /// Get all segments
        /// </summary>
        public List<Macro417Segment> GetAllSegments()
        {
            var lstRet = new List<Macro417Segment>();

            for (int i = 0; i < lstValues.Count; i++)
            {
                // Create segment
                var oSegment = new Macro417Segment
                {
                    SegmentValue = lstValues[i],
                    SegmentIndex = i + 1,
                    IsLastSegment = ((i + 1) == lstValues.Count)
                };

                lstRet.Add(oSegment);
            }

            return lstRet;
        }

    }

    public class Macro417Segment
    {
        public string SegmentValue { get; set; }
        public int SegmentIndex { get; set; }
        public bool IsLastSegment { get; set; }
    }

}
