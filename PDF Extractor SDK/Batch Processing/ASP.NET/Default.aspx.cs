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

namespace BatchProcessing
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Directory containing test files
            String inputFolder = Server.MapPath(@".\bin");

            // Create Bytescout.PDFExtractor.TextExtractor instance
            TextExtractor extractor = new TextExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            Response.Clear();
            Response.ContentType = "text/html";

            // Get PDF files 
            string[] pdfFiles = Directory.GetFiles(inputFolder, "*.pdf");

            foreach (string file in pdfFiles)
            {
                // Load document
                extractor.LoadDocumentFromFile(file);

                // Save extracted text to output stream
                extractor.SaveTextToStream(Response.OutputStream);

                // Reset the extractor before load another file
                extractor.Reset();
            }

            Response.End();
        }
    }
}
