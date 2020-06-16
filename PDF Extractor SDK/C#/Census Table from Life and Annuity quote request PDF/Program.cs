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


using Bytescout.PDFExtractor;
using System.Diagnostics;

namespace LifeAndAnnuityQuoteRequest
{
    class Program
	{
		static void Main(string[] args)
		{
            // Create Bytescout.PDFExtractor.CSVExtractor instance
            CSVExtractor extractor = new CSVExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";

            // Load sample PDF document
            extractor.LoadDocumentFromFile(@".\SampleGroupDisabilityForm.pdf");

            // Set extraction area
            extractor.SetExtractionArea(new System.Drawing.RectangleF(27F, 324.8F, 554.3F, 358.5F));

            // Check whether rows can be grouped
            extractor.LineGroupingMode = LineGroupingMode.GroupByRows;

            // Extract results
            var outputFile = "result.csv";
            extractor.SaveCSVToFile(outputFile);

            // Cleanup
            extractor.Dispose();

            // Open with default associated program
            ProcessStartInfo processStartInfo = new ProcessStartInfo(outputFile);
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
		}
	}
}
