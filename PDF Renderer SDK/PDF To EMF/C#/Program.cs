//*******************************************************************
//       ByteScout PDF Renderer SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;

using Bytescout.PDFRenderer;


namespace PDF2EMF
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create an instance of Bytescout.PDFRenderer.VectorRenderer object and register it.
			VectorRenderer renderer = new VectorRenderer();
			renderer.RegistrationName = "demo";
			renderer.RegistrationKey = "demo";

			// Load PDF document.
			renderer.LoadDocumentFromFile("vector_drawing.pdf");

			for (int i = 0; i < renderer.GetPageCount(); i++)
			{
				// Render first page of the document to EMF image file.
				renderer.RenderPageToFile(i, VectorOutputFormat.EMF, "image" + i + ".emf");
			}

			// Open the first output file in default image viewer.
			System.Diagnostics.Process.Start("image0.emf");
		}
	}
}
