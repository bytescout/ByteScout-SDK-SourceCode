//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Drawing;
using Bytescout.PDFExtractor;

namespace FindText
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			// This test file will be copied to the project directory on the pre-build event (see the project properties).
			String inputFile = Server.MapPath("words-with-hyphens.pdf");

			// Create Bytescout.PDFExtractor.TextExtractor instance
			TextExtractor extractor = new TextExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";
			
			// Load sample PDF document
			extractor.LoadDocumentFromFile(inputFile);

			Response.Clear();
			Response.ContentType = "text/html";

			Rectangle location;
			int pageIndex;

			Response.Write("Searching for \"hyphen\" string:<br><br>");
			
			// Search for "hyphen" string
			if (extractor.Find(0, "hyphen"))
			{
				do
				{
					Response.Write("Found at location " + extractor.FoundText.Bounds.ToString()+ "<br>");

				} while (extractor.FindNext())
			}

			Response.End();
		}
	}
}
