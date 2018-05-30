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


using System;
using System.Drawing.Imaging;
using Bytescout.PDFExtractor;

namespace ExtractImagesByPages
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create Bytescout.PDFExtractor.ImageExtractor instance
			ImageExtractor extractor = new ImageExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";

			// Load sample PDF document
			extractor.LoadDocumentFromFile(@".\sample1.pdf");

			// Get count of pages
			int pageCount = extractor.GetPageCount();

			// Extract images from each page
			for (int i = 0; i < pageCount; i++)
			{
				int j = 0;
				
				// Initialize page images enumeration
				if (extractor.GetFirstPageImage(i))
				{
					do
					{
						string outputFileName = "page" + i + "image" + j + ".png";

						// Save image to file
						extractor.SaveCurrentImageToFile(outputFileName, ImageFormat.Png);

						j++;

					} while (extractor.GetNextImage()); // Advance image enumeration
				}
			}

			// Cleanup
			extractor.Dispose();
			
			// Open first output file in default associated application
			System.Diagnostics.Process.Start("page0image0.png");
		}
	}
}
