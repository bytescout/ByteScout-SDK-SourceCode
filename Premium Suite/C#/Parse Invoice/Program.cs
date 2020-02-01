//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Drawing;
using Bytescout.PDFExtractor;

namespace InvoiceParsing
{
	/// <summary>
	/// This example demonstrates parsing and data extraction from typical invoice.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			// Create TextExtractor instance
			TextExtractor textExtractor = new TextExtractor("demo", "demo");
			textExtractor.WordMatchingMode = WordMatchingMode.ExactMatch; // Set exact search (default is SmartSearch that works like in Adobe Reader)

			// Create XMLExtractor instance
			XMLExtractor xmlExtractor = new XMLExtractor("demo", "demo");

			// Load document
			textExtractor.LoadDocumentFromFile("Invoice.pdf");
			xmlExtractor.LoadDocumentFromFile("Invoice.pdf");

			// Results
			string invoiceNo = string.Empty;
			string invoiceDate = string.Empty;
			string total = string.Empty;
			string tableData = string.Empty;

			// Iterate pages
			for (int i = 0; i < textExtractor.GetPageCount(); i++)
			{
				RectangleF pageRectangle = textExtractor.GetPageRectangle(i);
				RectangleF tableRect = new RectangleF(0, 0, pageRectangle.Width, 0);

				// Search for "Invoice No."
				if (textExtractor.Find(i, "Invoice No.", false))
				{
					// Get the found text rectangle
					RectangleF textRect = textExtractor.FoundText.Bounds;
					// Assume the text at right is the invoice number.
					// Shift the rectangle to the right:
					textRect.X = textRect.Right;
					textRect.Width = pageRectangle.Right - textRect.Left;
					// Set the extraction region and extract the text
					textExtractor.SetExtractionArea(textRect);
					invoiceNo = textExtractor.GetTextFromPage(i).Trim();
				}
				
				// Search for "Invoice Date" and extract text at right
				if (textExtractor.Find(i, "Invoice Date", false))
				{
					RectangleF textRect = textExtractor.FoundText.Bounds;
					textRect.X = textRect.Right;
					textRect.Width = pageRectangle.Right - textRect.Left;
					textExtractor.SetExtractionArea(textRect);
					invoiceDate = textExtractor.GetTextFromPage(i).Trim();
				}

				// Search for "Quantity" keyword to detect the top of the tabular data rectangle
				if (textExtractor.Find(i, "Quantity", false))
				{
					// Keep the top table coordinate
					tableRect.Y = textExtractor.FoundText.Bounds.Top; // use textRect.Bottom if you want to skip column headers
				}
				
				// Search for "TOTAL" (it will be also the bottom of tabular data rectangle)
				if (textExtractor.Find(i, "TOTAL", true /* case sensitive! */)) 
				{
					RectangleF textRect = textExtractor.FoundText.Bounds;
					textRect.X = textRect.Right;
					textRect.Width = pageRectangle.Right - textRect.Left;
					textExtractor.SetExtractionArea(textRect);
					total = textExtractor.GetTextFromPage(i).Trim();

					// Calculate the table height
					tableRect.Height = textRect.Top - tableRect.Top;
				}

				// Extract tabular data using XMLExtractor
				if (tableRect.Height > 0)
				{
					xmlExtractor.SetExtractionArea(tableRect);
					tableData = xmlExtractor.GetXMLFromPage(i);
				}
			}

			// Display extracted data
			Console.WriteLine("Invoice No.: " + invoiceNo);
			Console.WriteLine("Invoice Date: " + invoiceDate);
			Console.WriteLine("TOTAL: " + total);
			Console.WriteLine("Table Data: ");
			Console.WriteLine(tableData);

			Console.WriteLine("Press any key...");
			Console.ReadKey();
		}
	}
}
