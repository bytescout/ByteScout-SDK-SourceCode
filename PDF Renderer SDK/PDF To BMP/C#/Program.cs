//*******************************************************************
//       ByteScout PDF Renderer SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;

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
				// Render first page of the document to BMP image file.
				renderer.RenderPageToFile(i, RasterOutputFormat.BMP, "image" + i + ".bmp");
			}

			// Open the first output file in default image viewer.
			System.Diagnostics.Process.Start("image0.bmp");
		}
	}
}
