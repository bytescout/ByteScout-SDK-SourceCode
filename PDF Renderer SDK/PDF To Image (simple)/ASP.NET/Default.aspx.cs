//*******************************************************************
//       ByteScout PDF Renderer SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Web.UI;
using Bytescout.PDFRenderer;

namespace BasicExample
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			// Prepare a test document.
			// Multipage.pdf file will be copied to the project directory on the pre-build event (see the project properties).
			String inputDocument = Server.MapPath("multipage.pdf");

			// Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.
			RasterRenderer renderer = new RasterRenderer();
			renderer.RegistrationName = "demo";
			renderer.RegistrationKey = "demo";

			// Load PDF document.
			renderer.LoadDocumentFromFile(inputDocument);

			// Prepare response.
			Response.Clear();
			Response.ContentType = "image/png";
			Response.AddHeader("Content-Disposition", "inline;filename=result.png");

			// Render first page of the document to the output stream.
			renderer.RenderPageToStream(0, RasterOutputFormat.PNG, Response.OutputStream);

			Response.End();
		}
	}
}
