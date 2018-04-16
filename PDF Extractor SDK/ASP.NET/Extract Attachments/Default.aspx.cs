//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


using System;
using Bytescout.PDFExtractor;

namespace ExtractAttachments
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String inputFile = Server.MapPath(@".\bin\attachments.pdf");

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
                string attachmentFileName = extractor.GetFileName(i);
                int attachmentFileSize = extractor.GetSize(i);

                Response.Write("Found attachment: " + attachmentFileName + "<br/>");

                // You can save the attachment to a file
                //extractor.Save(i, attachmentFileName);

                 // ... or write to output stream
                //extractor.Save(i, Response.OutputStream);

                Response.Write("- file size: " + attachmentFileSize + "<br/><br/>");
            }

            Response.End();

            extractor.Dispose();
        }
    }
}
