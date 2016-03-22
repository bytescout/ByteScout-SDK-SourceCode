//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Drawing;
using Bytescout.PDFExtractor;

namespace FindText
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			// This test file will be copied to the project directory on the pre-build event (see the project properties).
			String inputFile = Server.MapPath("sample1.pdf");

			// Create Bytescout.PDFExtractor.TextExtractor instance
			TextExtractor extractor = new TextExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";
			
			// Load sample PDF document
			extractor.LoadDocumentFromFile(inputFile);

			Response.Clear();
			Response.ContentType = "text/html";

			Rectangle location;
			int pageIndex;

			Response.Write("Searching for \"ipsum\" string:<br><br>");
			
			// Search for "ipsum" string
			if (extractor.Find(0, "ipsum"))
			{

                do
                {
                    Response.Write("<br/>");
                    Response.Write("Found on page " + i + " at location " + extractor.FoundText.Bounds.ToString()+"<br/>");
                    Response.Write("<br/>");
                    // iterate through each element in the found text
                    foreach (SearchResultElement element in extractor.FoundText.Elements)
                    {
                        Response.Write("Element #" + element.Index + " at left=" + element.Left + "; top=" + element.Top + "; width=" + element.Width + "; height=" + element.Height + "<br/>");
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
