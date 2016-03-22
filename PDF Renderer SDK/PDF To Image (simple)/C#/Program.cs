//*******************************************************************
//       ByteScout PDF Renderer SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;

using Bytescout.PDFRenderer;


namespace BasicExample
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

			// Render first page of the document to PNG image file.
			renderer.RenderPageToFile(0, RasterOutputFormat.PNG, "result.png");

			// Open the output file in default image viewer.
			System.Diagnostics.Process.Start("result.png");
		}
	}
}
