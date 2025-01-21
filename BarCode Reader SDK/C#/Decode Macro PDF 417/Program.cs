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
using System.IO;
using System.Linq;
using System.Text;
using Bytescout.BarCodeReader;

namespace ReadMacroPDF417
{
    class Program
    {
        static void Main()
        {
            // Input Image files
            var ImageFiles = new string[] { "MacroPDFBarcode-part1.png", "MacroPDFBarcode-part2.png", "MacroPDFBarcode-part3.png" };

            // Create Instance of Macro PDF 417 class
            var oMacroPDF417Values = new MacroPDF417Values();

            // Loop through input files to get value
            foreach (string itmInput in ImageFiles)
            {
                using (var reader = new Reader("demo", "demo"))
                {
                    /* -----------------------------------------------------------------------
                   NOTE: We can read barcodes from specific page to increase performance.
                   For sample please refer to "Decoding barcodes from PDF by pages" program.
                   ----------------------------------------------------------------------- */
                    // Set barcode type to find
                    reader.BarcodeTypesToFind.PDF417 = true;

                    // Read barcodes
                    Console.WriteLine("Reading barcode(s) from image {0}", Path.GetFullPath(itmInput));
                    FoundBarcode[] barcodes = reader.ReadFrom(itmInput);

                    foreach (FoundBarcode barcode in barcodes)
                    {
                        Console.WriteLine("Found Value: " + barcode.Value + "\n");

                        // Add found barcode value
                        oMacroPDF417Values.AddValue(barcode.Value);
                    }
                }
            }

            // Get MacroPDF417 output value
            var outputValue = oMacroPDF417Values.GetValue();

            Console.WriteLine("\n\nConsolidated Output Value: " + outputValue);

            Console.WriteLine("\n\nPress any key to exit..");
            Console.ReadKey();
        }
    }

    public class MacroPDF417Values
    {
        #region Constructors and Properties

        public MacroPDF417Values() { lstSegments = new List<MacroPDFSegmment>(); }

        public List<MacroPDFSegmment> lstSegments { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Add Value
        /// </summary>
        public void AddValue(string strValue)
        {
            lstSegments.Add(new MacroPDFSegmment(strValue));
        }

        /// <summary>
        /// Get value
        /// </summary>
        public string GetValue()
        {
            var retValue = new StringBuilder("");

            foreach (var itmSegment in lstSegments.Where(x => x.SegmentNo > 0).OrderBy(x => x.SegmentNo))
            {
                retValue.Append(itmSegment.SegmentValue);
            }

            return retValue.ToString();
        }

        #endregion

    }

    public class MacroPDFSegmment
    {
        #region Constructors and Declarations

        public MacroPDFSegmment() { }
        public MacroPDFSegmment(string inpValue)
        {
            if (!string.IsNullOrEmpty(inpValue))
            {
                Segments = inpValue.Split('\\');
            }
        }

        private string[] Segments { get; set; }

        /// <summary>
        /// Get Segment Index
        /// </summary>
        public int SegmentNo
        {
            get
            {
                int retSegmentValue = -1;
                var segmentVal = GetSegmentValue(2);

                if (!string.IsNullOrEmpty(segmentVal))
                {
                    int.TryParse(segmentVal, out retSegmentValue);
                }

                return retSegmentValue;
            }
        }

        /// <summary>
        /// Get Segment Value
        /// </summary>
        public string SegmentValue
        {
            get
            {
                return GetSegmentValue(1);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get Segment Value
        /// </summary>
        public string GetSegmentValue(int segmentNo)
        {
            if (Segments != null && Segments.Length >= segmentNo)
            {
                return Segments[segmentNo - 1];
            }

            return "";
        }

        #endregion
    }
}
