//*******************************************************************
//       ByteScout PDF Renderer SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System.Drawing;
using Bytescout.PDFRenderer;

namespace MakeThumbnail
{
	static class Program
	{
		static void Main()
		{
			// Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it
			RasterRenderer renderer = new RasterRenderer();
			renderer.RegistrationName = "demo";
			renderer.RegistrationKey = "demo";

			// Load PDF document
			renderer.LoadDocumentFromFile("multipage.pdf");

			// Size of the page in Points (standart PDF document units; 1 Point = 1/72")
			RectangleF rectangle = renderer.GetPageRectangle(0);

			if (rectangle.Width < rectangle.Height) // portrait page orientation
			{
				// Calculate rendering resoultion to get an image of 100px width
				renderer.Resolution = 100 / rectangle.Width * 72;
			}
			else // landscape page orientation
			{
				// Calculate rendering resoultion to get an image of 100px height
				renderer.Resolution = 100 / rectangle.Height * 72;
			}
			
			// Render first page of the document to JPEG image file
			renderer.RenderPageToFile(0, RasterOutputFormat.JPEG, "thumbnail.jpg");
			
			// Open the output image file in default image viewer
			System.Diagnostics.Process.Start("thumbnail.jpg");
		}
	}
}
