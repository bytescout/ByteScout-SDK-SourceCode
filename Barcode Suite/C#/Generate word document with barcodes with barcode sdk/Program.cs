//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


// This example uses Word Automation to create a document, add some text, add a table, 
// fill it with random data and generate barcode images for it.

using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
using Bytescout.BarCode;

namespace GenerateWordDocumentWithBarcodes
{
	class Program
	{
		static void Main(string[] args)
		{
			object optional = Missing.Value;
			object endOfDocBookmark = "\\endofdoc"; /* \endofdoc is a predefined bookmark */ 

			// start Word
			_Application word = new Application();
			word.Visible = false;

			// create new document
			_Document document = word.Documents.Add(ref optional, ref optional, ref optional, ref optional);

			// insert a paragraph at the beginning of the document
			Paragraph paragraph1 = document.Content.Paragraphs.Add(ref optional);
			paragraph1.Range.Text = "Heading 1";
			paragraph1.Range.Font.Bold = 1;
			paragraph1.Format.SpaceAfter = 24; // 24 pt spacing after paragraph
			paragraph1.Range.InsertParagraphAfter();

			// insert another paragraph
			object range = document.Bookmarks.get_Item(ref endOfDocBookmark).Range;
			Paragraph paragraph2 = document.Content.Paragraphs.Add(ref range);
			paragraph2.Range.Text = "This is a sentence of normal text. Now here is a table:";
			paragraph2.Range.Font.Bold = 0;
			paragraph2.Format.SpaceAfter = 24;
			paragraph2.Range.InsertParagraphAfter();


			// insert a 5 x 2 table, make the first header row bold and italic
			range = document.Bookmarks.get_Item(ref endOfDocBookmark).Range;
			Table table = document.Tables.Add((Range) range, 5, 2, ref optional, ref optional);
			table.Cell(1, 1).Range.Text = "Value";   // 1st column header
			table.Cell(1, 2).Range.Text = "Barcode"; // 2nd column header
			table.Rows[1].Range.Font.Bold = 1;
			table.Rows[1].Range.Font.Italic = 1;
			AddBorders(table.Cell(1, 1).Range);
			AddBorders(table.Cell(1, 2).Range);
			
			Random random = new Random();
			string tempImage = Path.Combine(Path.GetTempPath(), "tempImage.png");

			// create barcode object
			Barcode barcode = new Barcode("demo", "demo");
			barcode.Symbology = SymbologyType.Code128;
			barcode.DrawCaption = false;
			
			// fill the table with random data and add barcode images
			for (int row = 2; row <= 5; row++)
			{
				string randomValue = random.Next().ToString(CultureInfo.InvariantCulture);
				Range cell = table.Cell(row, 1).Range;
				cell.Text = randomValue;
				
				AddBorders(cell);

				// generate barcode and save it to temporary image file
				barcode.Value = randomValue;
				barcode.SaveImage(tempImage);

				// put barcode image to second column
				cell = table.Cell(row, 2).Range;
				cell.InlineShapes.AddPicture(tempImage, ref optional, ref optional, ref optional);
				
				AddBorders(cell);
			}


			// save document
			object fileName = @"sample.doc"; // use full file path in your app
			document.SaveAs(ref fileName, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional);

			// quit Word
			object saveChanges = true;
			word.Quit(ref saveChanges, ref optional, ref optional);

			System.Diagnostics.Process.Start((string) fileName);
		}

		// Adds borders to provided Range
		static void AddBorders(Range cell)
		{
			cell.Borders[WdBorderType.wdBorderLeft].LineStyle = WdLineStyle.wdLineStyleSingle;
			cell.Borders[WdBorderType.wdBorderTop].LineStyle = WdLineStyle.wdLineStyleSingle;
			cell.Borders[WdBorderType.wdBorderRight].LineStyle = WdLineStyle.wdLineStyleSingle;
			cell.Borders[WdBorderType.wdBorderBottom].LineStyle = WdLineStyle.wdLineStyleSingle;
		}
	}
}
