//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Data;
using System.Drawing.Imaging;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using Bytescout.BarCode;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Create new barcode
        Barcode barcode = new Barcode();

        // Set symbology
        barcode.Symbology = SymbologyType.Code39;
        // Set value
        barcode.Value = "Sample";

        // Clear http output
        Response.Clear();
        // Set the content type to PNG
        Response.ContentType = "image/png";
        // Add content type header
        Response.AddHeader("Content-Type", "image/png");
        // Set the content disposition
        Response.AddHeader("Content-Disposition", "inline;filename=result.png");

        // Save image to output stream
        barcode.SaveImage(Response.OutputStream, ImageFormat.Png);

        // End response
        Response.End();

    }
}
