//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using Bytescout.PDFExtractor;

namespace ExtractInfo
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			// This test file will be copied to the project directory on the pre-build event (see the project properties).
			String inputFile = Server.MapPath(@".\bin\sample1.pdf");

			// Create Bytescout.PDFExtractor.InfoExtractor instance
			InfoExtractor extractor = new InfoExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";
			
			// Load sample PDF document
			extractor.LoadDocumentFromFile(inputFile);

			// Display document information

			Response.Clear();
			Response.ContentType = "text/html";

			Response.Write("Author: " + extractor.Author + "<br/>");
			Response.Write("Creator: " + extractor.Creator + "<br/>");
			Response.Write("Producer: " + extractor.Producer + "<br/>");
			Response.Write("Subject: " + extractor.Subject + "<br/>");
			Response.Write("Title: " + extractor.Title + "<br/>");
			Response.Write("CreationDate: " + extractor.CreationDate + "<br/>");
			Response.Write("Keywords: " + extractor.Keywords + "<br/>");
			Response.Write("Bookmarks: " + extractor.Bookmarks + "<br/>");
			Response.Write("Encrypted: " + extractor.Encrypted + "<br/>");

			Response.End();
		}
	}
}
