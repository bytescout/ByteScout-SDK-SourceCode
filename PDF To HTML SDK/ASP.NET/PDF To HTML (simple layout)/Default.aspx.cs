//*******************************************************************
//       ByteScout PDF To HTML SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using Bytescout.PDF2HTML;

namespace ExtractHTML
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			// This test file will be copied to the project directory on the pre-build event (see the project properties).
			String inputFile = Server.MapPath("sample2.pdf");

			// Create Bytescout.PDFExtractor.HTMLExtractor instance
			HTMLExtractor extractor = new HTMLExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";

			// Set plain HTML extraction mode
			extractor.ExtractionMode = HTMLExtractionMode.PlainHTML;
			
			// Load sample PDF document
			extractor.LoadDocumentFromFile(inputFile);

			Response.Clear();
			Response.ContentType = "text/html";

			// Save extracted text to output stream
			extractor.SaveHtmlToStream(Response.OutputStream);

			Response.End();

			extractor.Dispose();
		}
	}
}
