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

namespace FindTextWithHyphens
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String inputFile = Server.MapPath(@".\bin\words-with-hyphens.pdf");

            // Create Bytescout.PDFExtractor.TextExtractor instance
            TextExtractor extractor = new TextExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";
            
            // Load sample PDF document
            extractor.LoadDocumentFromFile(inputFile);
            
            // Set the matching mode
            extractor.WordMatchingMode = WordMatchingMode.SmartMatch;

            Response.Clear();
            Response.ContentType = "text/html";

            Response.Write("Searching for \"hyphen\" string:<br>");
            
            // Search for "ipsum" string
            if (extractor.Find(0, "hyphen", false))
            {
                do
                {
                    Response.Write("<br/>");
                    Response.Write("Found on page 1 at location " + extractor.FoundText.Bounds + "<br/>");
                    Response.Write("<br/>");
                    
                    // The found text may be splitted to parts.
                    // Iterate through each part of the found text.
                    for (var i = 0; i < extractor.FoundText.Elements.Count; i++)
                    {
                        ISearchResultElement element = extractor.FoundText.Elements[i];
                        
                        Response.Write("Element #" + i + " at " + element.Bounds + "<br/>");
                        Response.Write("Text: " + element.Text + "<br/>");
                        Response.Write("Font is bold: " + element.FontIsBold + "<br/>");
                        Response.Write("Font is italic:" + element.FontIsItalic + "<br/>");
                        Response.Write("Font name: " + element.FontName + "<br/>");
                        Response.Write("Font size:" + element.FontSize + "<br/>");
                        Response.Write("Font color:" + element.FontColor + "<br/>");
                    }
                }
                while (extractor.FindNext());
            }

            Response.End();
        }
    }
}
