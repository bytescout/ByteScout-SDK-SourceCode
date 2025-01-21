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
using Bytescout.Spreadsheet;

namespace DisplayXlsAsHtml
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

		Spreadsheet _document = null;

		protected void Page_Load(object sender, EventArgs e)
		{
			String inputXlsFile = Server.MapPath("example.xls");

			// Open spreadsheet
			_document = new Spreadsheet();
			_document.LoadFromFile(inputXlsFile);

			Label1.Text = "\"Example.xls\" loaded";

			for (int i = 0; i < _document.Worksheets.Count ; i++)
			{
				DropDownList1.Items.Add(_document.Worksheets[i].Name);
			}
		}

		protected void ButtonGo_Click(object sender, EventArgs e)
		{
			String sheet = DropDownList1.SelectedItem.Text;

			if (!String.IsNullOrEmpty(sheet))
			{
				// Clear HTTP output
				Response.Clear();
				// Set the content type to HTML
				Response.ContentType = "text/HTML";
				// Save selected worksheet to output stream as HTML
				_document.Worksheets[sheet].SaveAsHTML(Response.OutputStream);

				Response.End();
			}
		}
	}
}
