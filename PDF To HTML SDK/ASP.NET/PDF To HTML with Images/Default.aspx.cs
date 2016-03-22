//*******************************************************************
//       ByteScout PDF To HTML SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.IO;
using System.Text;
using Bytescout.PDF2HTML;

namespace ExtractHTML
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			// This test PDF file is automatically copied to the output build directory.
			String inputFile = Server.MapPath("bin\\sample2.pdf");

			// Prepare output file path
			String outputFolder = Server.MapPath("~/output/");
			String outputFile = Path.Combine(outputFolder, "result.html");

			// Create Bytescout.PDF2HTML.HTMLExtractor instance
			HTMLExtractor extractor = new HTMLExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";

			// Set HTML with CSS extraction mode
			extractor.ExtractionMode = HTMLExtractionMode.HTMLWithCSS;

			// Load sample PDF document
			extractor.LoadDocumentFromFile(inputFile);

			// Save extracted text to output file. Document images will be created in a subfolder.
			extractor.SaveHtmlToFile(outputFile);

			// The converter knows nothing about server's home directory, so it places images to a subfolder 
			// named "<filename>.images" near to the output file and generates image paths relative to the output folder.
			// We need to change those paths relative to server home directory.

			string[] lines = File.ReadAllLines(outputFile);
			StringBuilder builder = new StringBuilder();

			foreach (string line in lines)
			{
				// replace image source paths
				builder.AppendLine(line.Replace("sample2.pdf.images", "output/sample2.pdf.images"));
			}

			// Write the modified content to Response:

			Response.Clear();
			Response.ContentType = "text/html";

			Response.Write(builder.ToString());

			Response.End();

			extractor.Dispose();
		}
	}
}
