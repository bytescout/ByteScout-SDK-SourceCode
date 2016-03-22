//*******************************************************************
//       ByteScout Spreadsheet SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Bytescout.Spreadsheet;

namespace DisplayXlsAsHtml
{
	public partial class _Default : System.Web.UI.Page
	{
		Spreadsheet document = null;

		protected void Page_Load(object sender, EventArgs e)
		{
			String inputXlsFile = Server.MapPath("example.xls");

			// Open spreadsheet
			document = new Spreadsheet(inputXlsFile);

			Label1.Text = "\"Example.xls\" loaded";

			for (int i = 0; i < document.Worksheets.Count ; i++)
			{
				DropDownList1.Items.Add(document.Worksheets[i].Name);
			}
		}

		protected void ButtonGo_Click(object sender, EventArgs e)
		{
			String sheet = DropDownList1.SelectedItem.Text;

			if (!String.IsNullOrEmpty(sheet))
			{
				// clear HTTP output
				Response.Clear();
				// set the content type to HTML
				Response.ContentType = "text/HTML";
				// save selected worksheet to output stream as HTML
				document.Worksheets[sheet].SaveAsHTML(Response.OutputStream);

				Response.End();
			}
		}
	}
}
