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

namespace ExtractAllText
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			// This test file will be copied to the project directory on the pre-build event (see the project properties).
			String inputFile = Server.MapPath("columns.pdf");

			// Create Bytescout.PDFExtractor.TextExtractor instance
			TextExtractor extractor = new TextExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";
			
			// Load sample PDF document
			extractor.LoadDocumentFromFile(inputFile);

			// read width of the very first page (zero index)
			int pageWidth = extractor.GetPageRect_Width(0);
			int pageHeight = extractor.GetPageRect_Height(0);

			// now we are extracting content assuming we have 3 columns 
			// equally distributed on pages

			// first calculate the width of the one column by dividing page width by number of columns (3)
			int columnWidth = pageWidth / 3;


			Response.Clear();
			Response.ContentType = "text/html";


			// iterate through 3 columns
			for (int i=0; i<3; i++)
			{

				// set the extraction area to the #i column 
				extractor.SetExtractionArea(i * columnWidth, 0, columnWidth , pageHeight);

				// Save extracted text to output stream
				extractor.SavePageTextToStream(0, Response.OutputStream);
			}



			Response.End();
		}
	}
}
