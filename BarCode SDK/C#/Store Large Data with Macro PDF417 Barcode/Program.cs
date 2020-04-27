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
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load text file 
            string textInput = System.IO.File.ReadAllText("InputData.txt");

            // Split text into chunks
            var lstChunks = textInput.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            // Create new barcode
            using (Barcode barcode = new Barcode("demo", "demo"))
            {
                // Keep generated barcode images in the list
                List<Image> images = new List<Image>();

                // Select Macro PDF417 barcode type
                barcode.Symbology = SymbologyType.MacroPDF417;

                Macro417SegmentHelper macro417SegmentHelper = new Macro417SegmentHelper();
                macro417SegmentHelper.AddValue(lstChunks);

                // Set FileID. 
                // FileID is a number from 0 to 899. It must be same for all barcodes in the set.
                barcode.Options.PDF417FileID = 123;

                int ctr = 0;
                var resImgName = "";
                foreach (var itmSegment in macro417SegmentHelper.GetAllSegments())
                {
                    // create the first segment barcode so set SegmentIndex = 1
                    barcode.Options.PDF417SegmentIndex = itmSegment.SegmentIndex;

                    // Set value            
                    barcode.Value = itmSegment.SegmentValue;

                    // set that this is not the last segment yet
                    barcode.Options.PDF417LastSegment = itmSegment.IsLastSegment;

                    // Save barcode to image
                    resImgName = $"img{++ctr}.png";
                    barcode.SaveImage(resImgName, imageFormat: System.Drawing.Imaging.ImageFormat.Png);
                    
					Console.WriteLine("'{0}' generated!", resImgName);
                }
            }

            Console.ReadLine();
        }
    }


    /// <summary>
    /// Macro 417 Segment Helper
    /// </summary>
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
