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
using System.Drawing;
using Bytescout.PDFExtractor;

namespace ExtractTextFromPageArea
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

	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			String inputFile = Server.MapPath(@".\bin\columns.pdf");

			// Create Bytescout.PDFExtractor.TextExtractor instance
			TextExtractor extractor = new TextExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";
			
			// Load sample PDF document
			extractor.LoadDocumentFromFile(inputFile);

			// Get dimensions of the first document page
			RectangleF rectangle = extractor.GetPageRectangle(0);

			// Get text from the 1/3 of the page

			rectangle.Width = rectangle.Width / 3f;
			
			Response.Clear();
			Response.ContentType = "text/html";

			extractor.SetExtractionArea(rectangle);

			Response.Write("<pre>");

			// Save extracted text to output stream
			extractor.SavePageTextToStream(0, Response.OutputStream);

			Response.Write("</pre>");
			
			Response.End();
		}
	}
}
