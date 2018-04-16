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
using Bytescout.PDFExtractor;

namespace ExtractTextByColumns
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			String inputFile = Server.MapPath(@".\bin\columns.pdf");

			// Create Bytescout.PDFExtractor.TextExtractor instance
			TextExtractor extractor = new TextExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";

			// Extract text by columns (useful if PDF document is designed in column layout like a newspaper)
			extractor.ExtractColumnByColumn = true;
			
			// Load sample PDF document
			extractor.LoadDocumentFromFile(inputFile);
			
			Response.Clear();
			Response.ContentType = "text/html";

			Response.Write("<pre>");

			// Save extracted text to output stream
			extractor.SaveTextToStream(Response.OutputStream);

			Response.Write("</pre>");

			Response.End();
		}
	}
}
