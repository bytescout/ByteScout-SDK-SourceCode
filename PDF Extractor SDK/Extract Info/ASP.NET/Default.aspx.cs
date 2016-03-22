//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.IO;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Bytescout.PDFExtractor;

namespace ExtractInfo
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			// This test file will be copied to the project directory on the pre-build event (see the project properties).
			String inputFile = Server.MapPath("sample1.pdf");

			// Create Bytescout.PDFExtractor.InfoExtractor instance
			InfoExtractor extractor = new InfoExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";
			
			// Load sample PDF document
			extractor.LoadDocumentFromFile(inputFile);

			Response.Clear();
			Response.ContentType = "text/html";

			Response.Write("Author: " + extractor.Author + "<br>");
			Response.Write("Creator: " + extractor.Creator + "<br>");
			Response.Write("Producer: " + extractor.Producer + "<br>");
			Response.Write("Subject: " + extractor.Subject + "<br>");
			Response.Write("Title: " + extractor.Title + "<br>");
			Response.Write("CreationDate: " + extractor.CreationDate + "<br>");
			Response.Write("Keywords: " + extractor.Keywords + "<br>");
			Response.Write("Bookmarks: " + extractor.Bookmarks + "<br>");
			Response.Write("Encrypted: " + extractor.Encrypted + "<br>");

			Response.End();
		}
	}
}
