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


using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Web.Script.Serialization;
using Bytescout.PDFExtractor;

namespace InvoiceFraudDetection
{
	/// <summary>
	/// This example demonstrates detecting fraud within invoices
    /// Please Note: With Trial version, extracted value might have demo warnings and sample might not work as exptected.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
            var allInputFiles = new string[] { "Sample_Files\\InvoiceMar.pdf", "Sample_Files\\InvoiceApr.pdf", "Sample_Files\\InvoiceApr_Forged.pdf" };
            var settingJson = File.ReadAllText("settings.json");
            var deserializer = new JavaScriptSerializer();
            
            // Deserialize json to class objects
            var lstExtractionSettings = deserializer.Deserialize<List<ExtractionSettings>>(settingJson);

            // Loop through all input files
            foreach (var itmFile in allInputFiles)
            {
                // Create TextExtractor instance
                using (var textExtractor = new TextExtractor("demo", "demo"))
                {
                    // Load document from file
                    textExtractor.LoadDocumentFromFile(itmFile);

                    Console.WriteLine("Evaluating File: {0}\n", itmFile);

                    bool isAllCriteriaMatched = true;
                    foreach (var itmSetting in lstExtractionSettings)
                    {
                        // Region to extract from
                        var extractionRegion = new RectangleF(itmSetting.RegionLocation.X, itmSetting.RegionLocation.Y, itmSetting.RegionLocation.Width, itmSetting.RegionLocation.Height);

                        // Get Extracted Value
                        var extractedValue = GetTextFromRegion(textExtractor, extractionRegion);
                        var isCriteriaPassed = (itmSetting.CorrectValue == extractedValue);

                        Console.WriteLine("Region Type: {0}", itmSetting.RegionType);
                        Console.WriteLine("Expected Value: {0}", itmSetting.CorrectValue);
                        Console.WriteLine("Extracted Value: {0}", extractedValue);
                        Console.WriteLine("Criteria Passed: {0}\n", isCriteriaPassed);

                        isAllCriteriaMatched = isCriteriaPassed && isAllCriteriaMatched;
                    }

                    Console.WriteLine("Fraud Detected: {0}", !isAllCriteriaMatched);
                    Console.WriteLine("\n\n-----------------------------\n\n");
                }
            }

			Console.WriteLine("Press any key...");
			Console.ReadKey();
		}


        /// <summary>
        /// Get text from particular region
        /// </summary>
        private static string GetTextFromRegion(TextExtractor textExtractor, RectangleF extractionRegion, int pageIndex = 0)
        {
            // Set Extraction Area
            textExtractor.SetExtractionArea(extractionRegion);

            // Get Text from that region
            return textExtractor.GetTextFromPage(pageIndex).Trim();
        }

	}

    class ExtractionSettings
    {
        public ExtractionSettings()
        {
            RegionLocation = new ExtractionSettingRegion();
        }

        public string RegionType { get; set; }
        public string CorrectValue { get; set; }
        public ExtractionSettingRegion RegionLocation { get; set; }
    }

    class ExtractionSettingRegion
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
    }

}
