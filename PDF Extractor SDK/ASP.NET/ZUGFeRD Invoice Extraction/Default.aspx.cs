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
using System.IO;
using System.Web;
using Bytescout.PDFExtractor;

namespace ZUGFeRDInvoiceExtraction
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			String inputFile = Server.MapPath(@".\bin\ZUGFeRD-invoice.pdf");

			// Create Bytescout.PDFExtractor.AttachmentExtractor instance
			AttachmentExtractor extractor = new AttachmentExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";
			
			// Load sample PDF document
			extractor.LoadDocumentFromFile(inputFile);

			Response.Clear();
			Response.ContentType = "text/html";

            Response.Write("<html><body>\r\n");

            // Display attached ZUGFeRD XML data
			for (int i = 0; i < extractor.Count; i++)
			{
                Response.Write("ZUGFeRD XML invoice attachment: " + extractor.GetFileName(i) + "<br/>");
                MemoryStream mem = new MemoryStream();
				Response.Write("File size: " + extractor.GetSize(i) + "<br/>");

			    // You can save the file into temp folder or save to stream to avoid temp files
                //extractor.Save(i, extractor.GetFileName(i)); 

                extractor.SaveToStream(i, mem);
                mem.Position = 0; // reset the stream position
                StreamReader sreader = new StreamReader(mem);
                string zugferdXmlData = sreader.ReadToEnd(); // XML content

                Response.Write("<textarea rows='20' cols='80'>" + HttpUtility.HtmlEncode(zugferdXmlData) + "</textarea>");
			}

            Response.Write("\r\n</body></html>");

			Response.End();
		}
	}
}
