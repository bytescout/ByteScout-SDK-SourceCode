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

namespace ExtractAllImages
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

			int i = 0;

			// Initialize image enumeration
			if (extractor.GetFirstImage())
			{
				do
				{
					string outputFileName = "image" + i + ".png";

					// Save image to file
					extractor.SaveCurrentImageToFile(outputFileName, ImageFormat.Png);

					i++;

				} while (extractor.GetNextImage()); // Advance image enumeration
			}

			// Open first output file in default associated application
			System.Diagnostics.Process.Start("image0.png");
		}
	}
}
