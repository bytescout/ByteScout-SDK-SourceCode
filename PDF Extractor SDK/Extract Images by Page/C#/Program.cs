//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

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
			extractor.LoadDocumentFromFile("sample1.pdf");

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
			
			// Open first output file in default associated application
			System.Diagnostics.Process.Start("page0image0.png");
		}
	}
}
