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


using Bytescout.PDFRenderer;

namespace PDF2TIFF
{
	class Program
	{
		static void Main()
		{
			// Create Bytescout.PDFRenderer.RasterRenderer object instance and register it.
			RasterRenderer renderer = new RasterRenderer();
			renderer.RegistrationName = "demo";
			renderer.RegistrationKey = "demo";

			// Load PDF document.
			renderer.LoadDocumentFromFile("multipage.pdf");

			int startPage = 0;
			int endPage = renderer.GetPageCount() - 1;

			// Save PDF document to black-and-white multi-page TIFF at 120 DPI
            RenderingOptions renderingOptions = new RenderingOptions();
            renderingOptions.TIFFCompression = TIFFCompression.CCITT4;
            renderer.SaveMultipageTiff("multipage.tiff", startPage, endPage, 120, renderingOptions);

			// Open the first output file in default image viewer.
			System.Diagnostics.Process.Start("multipage.tiff");
		}
	}
}
