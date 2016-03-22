//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using Bytescout.PDFExtractor;

// To compile the example copy missing .traineddata files from REDISTRIBUTABLE folder to "tessdata" project folder.
// or download from http://code.google.com/p/tesseract-ocr/downloads/list
// Make sure "Copy to Output Directory" property of each added language file is set to "Copy always".
// Note: Do not rename the "tessdata" folder - its name is hardcoded in OCR engine.

namespace WebApplication1
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			String inputFile = Server.MapPath("sample_ocr.pdf");
            // Set the location of 
		    String ocrLanguageDataFolder = Server.MapPath(@"tessdata");

			using (TextExtractor extractor = new TextExtractor())
			{
				extractor.RegistrationName = "demo";
				extractor.RegistrationKey = "demo";

                // setup OCR
				extractor.OCRMode = OCRMode.Auto;
                extractor.OCRLanguageDataFolder = ocrLanguageDataFolder;
				extractor.OCRLanguage = "eng";
				extractor.OCRResolution = 300;

                extractor.LoadDocumentFromFile(inputFile);

                // Write extracted text to output stream
                Response.Clear();
				Response.ContentType = "text/html";
				Response.Write(extractor.GetText());
				
				Response.End();
			}
		}
	}
}
