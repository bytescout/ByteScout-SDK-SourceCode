//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


using System;
using Bytescout.PDFExtractor;

// Before running the example, copy missing *.traineddata files from "Redistributable" folder to "ocrdata" project folder.
// or download from https://github.com/tesseract-ocr/tessdata
// Make sure "Copy to Output Directory" property of each added language file is set to "Copy always".

namespace OpticalCharacterRecognition
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            String inputFile = Server.MapPath(@".\bin\sample_ocr.pdf");
		    
            // Location of language files
		    String ocrLanguageDataFolder = Server.MapPath(@".\bin\ocrdata");

		    // Create Bytescout.PDFExtractor.TextExtractor instance
		    using (TextExtractor extractor = new TextExtractor())
		    {
		        extractor.RegistrationName = "demo";
		        extractor.RegistrationKey = "demo";

		        // Enable Optical Character Recognition (OCR)
		        // in .Auto mode (SDK automatically checks if needs to use OCR or not)
		        extractor.OCRMode = OCRMode.Auto;
		        // Set the location of OCR language data files
		        extractor.OCRLanguageDataFolder = ocrLanguageDataFolder;
		        // Set OCR language
		        extractor.OCRLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
		        // Set PDF document rendering resolution
		        extractor.OCRResolution = 300;


		        // You can also apply various preprocessing filters
		        // to improve the recognition on low-quality scans.

		        // Automatically deskew skewed scans
		        //extractor.OCRImagePreprocessingFilters.AddDeskew();

		        // Remove vertical or horizontal lines (sometimes helps to avoid OCR engine's page segmentation errors)
		        //extractor.OCRImagePreprocessingFilters.AddVerticalLinesRemover();
		        //extractor.OCRImagePreprocessingFilters.AddHorizontalLinesRemover();

		        // Repair broken letters
		        //extractor.OCRImagePreprocessingFilters.AddDilate();

		        // Remove noise
		        //extractor.OCRImagePreprocessingFilters.AddMedian();

		        // Apply Gamma Correction
		        //extractor.OCRImagePreprocessingFilters.AddGammaCorrection();

				// Add Contrast
				//extractor.OCRImagePreprocessingFilters.AddContrast(20);


				// (!) You can use new OCRAnalyser class to find an optimal set of image preprocessing 
				// filters for your specific document.
				// See "OCR Analyser" example.


		        // Load PDF document
		        extractor.LoadDocumentFromFile(inputFile);

		        // Write extracted text to output stream
		        Response.Clear();
		        Response.ContentType = "text/html";

		        Response.Write("<pre>");
		        // Write extracted text to output stream
		        Response.Write(extractor.GetText());
		        Response.Write("</pre>");

		        Response.End();
		    }
		}
	}
}
