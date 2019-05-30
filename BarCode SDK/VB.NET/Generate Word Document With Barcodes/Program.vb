'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


' This example uses Word Automation to create a document, add some text, add a table, 
' fill it with random data and generate barcode images for it.

Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports Microsoft.Office.Interop.Word
Imports Word = Microsoft.Office.Interop.Word
Imports Bytescout.BarCode

Class Program
	Private Shared Sub Main(args As String())
		Dim [optional] As Object = Missing.Value
		Dim endOfDocBookmark As Object = "\endofdoc"
		' \endofdoc is a predefined bookmark 

		' start Word
		Dim word As _Application = New Application()
		word.Visible = False

		' create new document
		Dim document As _Document = word.Documents.Add([optional], [optional], [optional], [optional])

		' insert a paragraph at the beginning of the document
		Dim paragraph1 As Paragraph = document.Content.Paragraphs.Add([optional])
		paragraph1.Range.Text = "Heading 1"
		paragraph1.Range.Font.Bold = 1
		paragraph1.Format.SpaceAfter = 24
		' 24 pt spacing after paragraph
		paragraph1.Range.InsertParagraphAfter()

		' insert another paragraph
		Dim range As Object = document.Bookmarks.get_Item(endOfDocBookmark).Range
		Dim paragraph2 As Paragraph = document.Content.Paragraphs.Add(range)
		paragraph2.Range.Text = "This is a sentence of normal text. Now here is a table:"
		paragraph2.Range.Font.Bold = 0
		paragraph2.Format.SpaceAfter = 24
		paragraph2.Range.InsertParagraphAfter()


		' insert a 5 x 2 table, make the first header row bold and italic
		range = document.Bookmarks.get_Item(endOfDocBookmark).Range
		Dim table As Table = document.Tables.Add(DirectCast(range, Range), 5, 2, [optional], [optional])
		table.Cell(1, 1).Range.Text = "Value"
		' 1st column header
		table.Cell(1, 2).Range.Text = "Barcode"
		' 2nd column header
		table.Rows(1).Range.Font.Bold = 1
		table.Rows(1).Range.Font.Italic = 1
		AddBorders(table.Cell(1, 1).Range)
		AddBorders(table.Cell(1, 2).Range)

		Dim random As New Random()
		Dim tempImage As String = Path.Combine(Path.GetTempPath(), "tempImage.png")

		' create barcode object
		Dim barcode As New Barcode("demo", "demo")
		barcode.Symbology = SymbologyType.Code128
		barcode.DrawCaption = False

		' fill the table with random data and add barcode images
		For row As Integer = 2 To 5
			Dim randomValue As String = random.[Next]().ToString(CultureInfo.InvariantCulture)
			Dim cell As Range = table.Cell(row, 1).Range
			cell.Text = randomValue

			AddBorders(cell)

			' generate barcode and save it to temporary image file
			barcode.Value = randomValue
			barcode.SaveImage(tempImage)

			' put barcode image to second column
			cell = table.Cell(row, 2).Range
			cell.InlineShapes.AddPicture(tempImage, [optional], [optional], [optional])

			AddBorders(cell)
		Next


		' save document
		Dim fileName As Object = "sample.doc"
		' use full file path in your app
		document.SaveAs(fileName, [optional], [optional], [optional], [optional], [optional], _
			[optional], [optional], [optional], [optional], [optional], [optional], _
			[optional], [optional], [optional], [optional])

		' quit Word
		Dim saveChanges As Object = True
		word.Quit(saveChanges, [optional], [optional])

		System.Diagnostics.Process.Start(DirectCast(fileName, String))
	End Sub

	' Adds borders to provided Range
	Private Shared Sub AddBorders(cell As Range)
		AddressOf cell.Borders(WdBorderType.wdBorderLeft).LineStyle = WdLineStyle.wdLineStyleSingle
		AddressOf cell.Borders(WdBorderType.wdBorderTop).LineStyle = WdLineStyle.wdLineStyleSingle
		AddressOf cell.Borders(WdBorderType.wdBorderRight).LineStyle = WdLineStyle.wdLineStyleSingle
		AddressOf cell.Borders(WdBorderType.wdBorderBottom).LineStyle = WdLineStyle.wdLineStyleSingle
	End Sub
End Class
