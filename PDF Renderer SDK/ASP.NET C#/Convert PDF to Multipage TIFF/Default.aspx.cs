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
using System.Web.UI;
using Bytescout.PDFRenderer;

namespace BasicExample
{
	public partial class _Default : Page
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
			// Prepare a test document.
			// Multipage.pdf file will be copied to the project directory on the pre-build event (see the project properties).
			String inputDocument = Server.MapPath("multipage.pdf");

			// Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.
			RasterRenderer renderer = new RasterRenderer();
			renderer.RegistrationName = "demo";
			renderer.RegistrationKey = "demo";

			// Load PDF document.
			renderer.LoadDocumentFromFile(inputDocument);

            // Write the response.
            Response.Clear();
            Response.ContentType = "text/html";

            Response.Write("Converting into multipaged TIFF image...<br>");
            Response.Flush();

			// Render document to multi-page TIFF file at 300 DPI resoultion
            renderer.SaveMultipageTiff(Server.MapPath("output.tiff"), 0, -1, 300);

            Response.Write("Done! Check <a href=\"output.tiff\">output.tiff</a> file saved");

			Response.End();
		}
	}
}
