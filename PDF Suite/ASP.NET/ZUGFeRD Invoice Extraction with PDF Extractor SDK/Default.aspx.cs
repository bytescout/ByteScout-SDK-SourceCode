//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.IO;
using System.Web;
using Bytescout.PDFExtractor;

namespace ZUGFeRDInvoiceExtraction
{
	public partial class _Default : System.Web.UI.Page
	{
		/*
		IF YOU SEE TEMPORARY FOLDER ACCESS ERRORS: 

		Temporary folder access is required for web application when you use ByteScout SDK in it.
		If you are getting errors related to the access to temporary folder like "Access to the path 'C:\Windows\TEMP\... is denied" then you need to add permission for this temporary folder to make ByteScout SDK working on that machine and IIS configuration because ByteScout SDK requires access to temp folder to cache some of its data for more efficient work.

		SOLUTION:

		If your IIS Application Pool has "Load User Profile" option enabled the IIS provides access to user's temp folder. Check user's temporary folder

		If you are running Web Application under an impersonated account or IIS_IUSRS group, IIS may redirect all requests into separate temp folder like "c:\temp\".

		In this case
		- check the User or User Group your web application is running under
		- then add permissions for this User or User Group to read and write into that temp folder (c:\temp or c:\windows\temp\ folder)
		- restart your web application and try again

		*/

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
