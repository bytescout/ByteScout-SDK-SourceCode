//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


using System.Diagnostics;
using Bytescout.PDF;
using Image = Bytescout.PDF.Image;

namespace Images
{
	/// <summary>
	/// This example demonstrates how to add images of various formats. 
	/// </summary>
	class Program
	{
		static void Main()
		{
			// Create new document
			Document pdfDocument = new Document();
			pdfDocument.RegistrationName = "demo";
			pdfDocument.RegistrationKey = "demo";
			// Add page
			Page page = new Page(PaperFormat.A4);
			pdfDocument.Pages.Add(page);

			Canvas canvas = page.Canvas;

			// Add JPEG image and draw unscaled
			Image image1 = new Image("Image1.jpg");
			canvas.DrawImage(image1, 20, 20);

			// Add PNG image and draw reduced twice
			Image image2 = new Image("Image2.png");
			canvas.DrawImage(image2, 20, 520, image2.Width / 2, image2.Height / 2);

			// Add TIFF image and draw scaled disproportionately
			Image image3 = new Image("Image3.tif");
			canvas.DrawImage(image3, 270, 520, image3.Width / 2, image3.Height / 4);

			// Add GIF image and draw rotated 90 degrees and scaled
			Image image4 = new Image("Image4.gif");
			canvas.TranslateTransform(390, 650);
			canvas.RotateTransform(90);
			canvas.DrawImage(image4, 0, 0, image4.Width / 4, image4.Height / 4);
			
			// Save document to file
			pdfDocument.Save("result.pdf");

			// Cleanup 
			pdfDocument.Dispose();

			// Open document in default PDF viewer app
			Process.Start("result.pdf");
		}
	}
}
