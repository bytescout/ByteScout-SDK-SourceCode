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

namespace ExtractAttachments
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String inputFile = Server.MapPath(@"bin\attachments.pdf");

            // Create Bytescout.PDFExtractor.AttachmentExtractor instance
            AttachmentExtractor extractor = new AttachmentExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Load sample PDF document
            extractor.LoadDocumentFromFile(inputFile);

            Response.Clear();
            Response.ContentType = "text/html";

            for (int i = 0; i < extractor.Count; i++)
            {
                Response.Write("Saving attachment: " + extractor.GetFileName(i) + "<br>");
                //extractor.Save(i, extractor.GetFileName(i)); // you can save into temp folder or save to Stream object to avoid temp files
                Response.Write("File size: " + extractor.GetSize(i) + "<br>");
            }

            Response.End();

            extractor.Dispose();
        }
    }
}
