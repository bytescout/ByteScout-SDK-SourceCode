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
using System.Drawing.Imaging;
using System.IO;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Bytescout.PDFExtractor;

namespace ExtractAllImages
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			// This test file will be copied to the project directory on the pre-build event (see the project properties).
			String inputFile = Server.MapPath("sample1.pdf");

			// Create Bytescout.PDFExtractor.ImageExtractor instance
			ImageExtractor extractor = new ImageExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";
			
			// Load sample PDF document
			extractor.LoadDocumentFromFile("sample1.pdf");

			Response.Clear();

			int i = 0;

			// Initialize image enumeration
			if (extractor.GetFirstImage())
			{
				do
				{
					if (i == 0) // Write the fist image to the Response stream
					{
						string imageFileName = "image" + i + ".png";

						Response.Write("<b>" + imageFileName + "</b>");

						Response.ContentType = "image/png";
						Response.AddHeader("Content-Disposition", "inline;filename=" + imageFileName);

						// Write the image bytes into the Response output stream 
						Response.BinaryWrite(extractor.GetCurrentImageAsArrayOfBytes());
					}

					i++;

				} while (extractor.GetNextImage()); // Advance image enumeration
			}

			Response.End();
		}
	}
}
