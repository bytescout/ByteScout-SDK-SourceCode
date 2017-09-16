//****************************************************************************//
//                                                                            //
// Download evaluation version: https://bytescout.com/download/web-installer  //
//                                                                            //
// Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    //
//                                                                            //
// Copyright © 2017 ByteScout Inc. All rights reserved.                       //
// http://www.bytescout.com                                                   //
//                                                                            //
//****************************************************************************//


using System;
using Bytescout.PDFExtractor;

// Befor running the example copy missing .traineddata files from REDISTRIBUTABLE folder to "tessdata" project folder.
// or download from https://github.com/tesseract-ocr/tessdata/tree/3.04.00
// Make sure "Copy to Output Directory" property of each added language file is set to "Copy always".
// Note: Do not rename the "tessdata" folder - its name is hardcoded in OCR engine.

namespace OpticalCharacterRecognition
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            String inputFile = Server.MapPath(@".\bin\sample_ocr.pdf");
		    
            // Location of language files
		    String ocrLanguageDataFolder = Server.MapPath(@".\tessdata");

		    // Create Bytescout.PDFExtractor.TextExtractor instance
		    using (TextExtractor extractor = new TextExtractor())
		    {
		        extractor.RegistrationName = "demo";
		        extractor.RegistrationKey = "demo";

		        // Enable Optical Character Recognition (OCR)
		        // in .Auto mode (SDK automatically checks if needs to use OCR or not)
		        extractor.OCRMode = OCRMode.Auto;
		        // Set the location of "tessdata" folder containing language data file
		        extractor.OCRLanguageDataFolder = ocrLanguageDataFolder;
		        // Set OCR language
		        extractor.OCRLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in /tessdata
		        // Set PDF document rendering resolution
		        extractor.OCRResolution = 300;


		        // You can also apply various preprocessing filters
		        // to improve the recognition on low-quality scans.

		        // Automatically deskew skewed scans
		        //extractor.OCRImagePreprocessingFilters.AddDeskew();

		        // Repair broken letters
		        //extractor.OCRImagePreprocessingFilters.AddDilate();

		        // Remove vertical or horizontal lines (sometimes helps to avoid OCR engine's page segmentations errors)
		        //extractor.OCRImagePreprocessingFilters.AddVerticalLinesRemover();
		        //extractor.OCRImagePreprocessingFilters.AddHorizontalLinesRemover();

		        // Remove noise
		        //extractor.OCRImagePreprocessingFilters.AddMedian();

		        // Apply Gamma Correction
		        //extractor.OCRImagePreprocessingFilters.AddGammaCorrection();


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
