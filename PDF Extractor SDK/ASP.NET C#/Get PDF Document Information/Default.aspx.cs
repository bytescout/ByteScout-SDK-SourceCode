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
using Bytescout.PDFExtractor;

namespace ExtractInfo
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
