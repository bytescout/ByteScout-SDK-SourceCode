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
using System.IO;
using System.Web.UI;
using Bytescout.PDFExtractor;

namespace MakePDFUnsearchable
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String inputFile = Server.MapPath(@".\bin\sample1.pdf");

            // Create Bytescout.PDFExtractor.UnsearchablePDFMaker instance
            UnsearchablePDFMaker unsearchablePDFMaker = new UnsearchablePDFMaker();
            unsearchablePDFMaker.RegistrationName = "demo";
            unsearchablePDFMaker.RegistrationKey = "demo";

            // Load sample PDF document
            unsearchablePDFMaker.LoadDocumentFromFile(inputFile);

            // Set PDF rendering resolution to 150 DPI. Higher value - better quality, but larger output file.
            unsearchablePDFMaker.RenderingResolution = 150;
            // Set embedded images format
            unsearchablePDFMaker.ImageFormat = EmbeddedImageFormat.PNG;

            Response.Clear();
            Response.ContentType = "application/pdf";
            Response.AddHeader("Content-Disposition", "attachment;filename=result.pdf");

            // Process document and write result to temporary stream.
            byte[] resultBytes;
            using (MemoryStream tempStream = new MemoryStream())
            {
                unsearchablePDFMaker.MakePDFUnsearchable(tempStream);
                resultBytes = tempStream.ToArray();
            }

            // Write result bytes to the output stream
            Response.BinaryWrite(resultBytes);

            Response.End();
        }
    }
}
