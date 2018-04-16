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
using System.IO;
using System.Drawing;
using Bytescout.PDFRenderer;


namespace PDF2PNG
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

            // Iterate through pages
			for (int i = 0; i < renderer.GetPageCount(); i++)
			{
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    // Render document page and save to memory stream
                    renderer.Save(memoryStream, RasterImageFormat.PNG, i, 300);
                    
                    // Create image from memory stream
                    Image pngImg = Image.FromStream(memoryStream);
                    // Save image to file
                    pngImg.Save(i + ".png");
                }
			}

			// Open the first output file in default image viewer.
            // open the very first page
			System.Diagnostics.Process.Start("0.png");
		}
	}
}
