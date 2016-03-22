//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.IO;
using Bytescout.PDFExtractor;

namespace MakeUnsearchablePDF
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String inputFile = Server.MapPath(@"bin\sample1.pdf");

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
			
			// Process the document and write the result to the output stream
			unsearchablePDFMaker.MakePDFUnsearchable(Response.OutputStream);
			
            Response.End();
        }
    }
}
