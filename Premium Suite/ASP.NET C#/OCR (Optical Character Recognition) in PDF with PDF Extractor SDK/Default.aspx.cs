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
using Bytescout.PDFExtractor;

// Before running the example, copy missing *.traineddata files from "Redistributable" folder to "ocrdata" project folder.
// or download from https://github.com/bytescout/ocrdata
// Make sure "Copy to Output Directory" property of each added language file is set to "Copy always".

namespace OpticalCharacterRecognition
{

    /*
    IF YOU SEE TEMPORARY FOLDER ACCESS ERRORS: 

    Temporary folder access is required for web application when you use ByteScout SDK in it.
    If you are getting errors related to the access to temporary folder like "Access to the path 'C:\Windows\TEMP\... is denied" then you need to add permission for this temporary folder to make ByteScout SDK working on that machine and IIS configuration because ByteScout SDK requires access to temp folder to cache some of its data for more efficient work.

    SOLUTION:

    If your IIS Application Pool has "Load User Profile" option enabled the IIS provides access to user's temp folder. Check user's temporary folder

    If you are running Web Application under an impersonated account or IIS_IUSRS group, IIS may redirect all requests into separate temp folder like "c:\temp\".

    In this case
    - check the User or User Group your web application is running under
    - then add permissions for this User or User Group to read and write into that temp folder (c:\temp or c:\windows\temp\ folder)
    - restart your web application and try again

    */

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
