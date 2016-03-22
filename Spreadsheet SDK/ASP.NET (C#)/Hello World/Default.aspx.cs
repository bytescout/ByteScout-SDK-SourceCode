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
using System.IO;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Bytescout.Spreadsheet;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Create new document
        Spreadsheet document = new Spreadsheet();

        // Add "HelloWorld" worksheet
        Worksheet worksheet = document.Workbook.Worksheets.Add("HelloWorld");

        // Set cell B2 value "HelloWorld"
        worksheet.Cell(0, 0).Value = "HelloWorld";

        // clear http output
        Response.Clear();
        // set the content type to XLS (to open with Excel)
        Response.ContentType = "application/xls";
        // add content type header
        Response.AddHeader("Content-Type", "application/xls");
        // set the content disposition
        Response.AddHeader("Content-Disposition", "attachment;filename=HelloWorld.xls"); // change "attachment" to "inline" if you want to appear Excel editor right inside the browser instead of File Save dialog
        // write the buffer with xls spreadsheet file to the output
        document.SaveToStream(Response.OutputStream);

        Response.End();
    }
}
