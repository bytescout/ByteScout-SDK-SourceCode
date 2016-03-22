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
			String inputFile = Server.MapPath("Beispielrechnung_ZUGFeRD_RC_COMFORT_neu.pdf");

			// Create Bytescout.PDFExtractor.AttachmentExtractor instance
			AttachmentExtractor extractor = new AttachmentExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";
			
			// Load sample PDF document
			extractor.LoadDocumentFromFile(inputFile);

			Response.Clear();
			Response.ContentType = "text/html";

            Response.Write("<html><body>\r\n");

            // output the attached XML file
			for (int i = 0; i < extractor.Count; i++)
			{

				Response.Write("Saving XML invoice attachment:       " + extractor.GetFileName(i) + "<br>");
                MemoryStream mem = new MemoryStream();
				Response.Write("File size: " + extractor.GetSize(i).ToString() + "<br>");

                // optionally save XML invoice to a file
                // extractor.Save (i, extractor.GetFileName(i)); // you can save into temp folder or save to Stream object to avoid temp files

                extractor.SaveToStream(i, mem);
                mem.Position = 0; // reset the stream position
                StreamReader sreader = new StreamReader(mem);
                string XMLInvoice = sreader.ReadToEnd(); // xml invoice content

                Response.Write("<textarea rows='20' cols='80'><pre>"+ HttpUtility.HtmlEncode(XMLInvoice) + "</pre></textarea>");

			}

            Response.Write("\r\n</body></html>");

			Response.End();
		}
	}
}
