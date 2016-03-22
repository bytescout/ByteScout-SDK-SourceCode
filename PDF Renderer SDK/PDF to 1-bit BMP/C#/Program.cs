//*******************************************************************
//       ByteScout PDF Renderer SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System.Drawing;
using System.Drawing.Imaging;
using Bytescout.PDFRenderer;


namespace PDF2BMP
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.
			RasterRenderer renderer = new RasterRenderer();
			renderer.RegistrationName = "demo";
			renderer.RegistrationKey = "demo";

			// Load PDF document.
			renderer.LoadDocumentFromFile("multipage.pdf");

			for (int i = 0; i < renderer.GetPageCount(); i++)
			{
				// Render PDF page to Image object
				Bitmap image = (Bitmap) renderer.RenderPageToImage(i);

				// Convert to 1-bit B&W image:
				// Choose a conversion algorithm that fits your needs better:
				OneBitImageConverter.ConvertTo1BitBayerOrderedDithering(ref image);
				//OneBitImageConverter.ConvertTo1BitOrderedDithering4x4(ref image);
				//OneBitImageConverter.ConvertTo1BitRough(ref image);
				
				// Save 1-bit image to file
				image.Save("image" + i + ".bmp", ImageFormat.Bmp);
			}

			// Open the first output image in default image viewer.
			System.Diagnostics.Process.Start("image0.bmp");
		}
	}
}
