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

            RenderingOptions renderingOptions = new RenderingOptions();
            // Set pixel format to 1-bit
	        renderingOptions.ImageBitsPerPixel = ImageBitsPerPixel.BPP1;

			for (int i = 0; i < renderer.GetPageCount(); i++)
			{
				// Save 1-bit image to file
                renderer.Save("image" + i + ".bmp", RasterImageFormat.BMP, i, 200, renderingOptions);
			}

			// Open the first output image in default image viewer.
			System.Diagnostics.Process.Start("image0.bmp");
		}
	}
}
