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
using Bytescout.PDFExtractor;

namespace Profiles
{
    /// <summary>
    /// This example demonstrates the use of profiles. Profiles are set of properties 
    /// allowing to apply them to Extractor in any combination quickly. You can use 
    /// predefined profiles or create you own in JSON format like in this example.
    /// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			// Create Bytescout.PDFExtractor.TextExtractor instance
			TextExtractor extractor = new TextExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";
            extractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata";

			// Load sample PDF document
            extractor.LoadDocumentFromFile("sample_ocr.pdf");

            // Apply predefined profiles
            extractor.Profiles = "ocr, newspaper-layout";
            // Extract text to file
			extractor.SaveTextToFile("result1.txt");


            extractor.Reset();

            
            // Load another document
            extractor.LoadDocumentFromFile("sample_ocr.pdf");
			
            // Load and apply custom profiles
            extractor.LoadProfiles("profiles.json");
            extractor.Profiles = "keep-formatting, ocr-forced-200dpi";
            // Extract text to file
            extractor.SaveTextToFile("result2.txt");
            

            // Cleanup
			extractor.Dispose();

            
            // See result files in "bin\Debug" folder
		}
	}
}
