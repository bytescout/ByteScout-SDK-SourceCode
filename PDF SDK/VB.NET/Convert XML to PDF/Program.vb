'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Xml
Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how to create table from some XML data.
''' Since your XML file has different structure the example just shows technique of XML data reading 
''' and PDF table creation.
''' </summary>
Class Program

    Shared Sub Main()

		' Load XML document
		Dim xmlDocument = New XmlDocument()
		xmlDocument.Load("sample.xml")

		' Read columns information from XML data
		Dim columns = New List(Of String)()
		Dim columnNodeList = xmlDocument.SelectNodes("/Report/Columns/Column")
		For Each node As XmlNode In columnNodeList
			columns.Add(node.Attributes("Name").Value)
		Next

		' Read row nodes from XML data
		Dim rowNodeList = xmlDocument.SelectNodes("/Report/ReportData")


		' Create new PDF document
		Dim pdfDocument = New Document()
		pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"

		' If you wish to load an existing document uncomment the line below And comment the Add page section instead
		' pdfDocument.Load(".\existing_document.pdf")

		' Add page
		Dim page = New Page(PaperFormat.A4)
		pdfDocument.Pages.Add(page)

		Dim lightGrayColor = New ColorGray(200)
		Dim whiteColor = New ColorGray(255)


		' Create PDF table
		Dim table = New Table()
		table.BackgroundColor = lightGrayColor

		' Add columns
		For c = 0 To columns.Count - 1

			Dim column = New TableColumn(columns(c), columns(c))
			' Set column width
			column.Width = If(c = 0, 100, 60)
			table.Columns.Add(column)
		Next

		' Add rows
		For Each rowNode As XmlNode In rowNodeList

			' Create new row and set its background color
			Dim row = table.NewRow()
			row.BackgroundColor = whiteColor

			' Get cell values from XML data
			For Each childNode As XmlNode In rowNode.ChildNodes

				' Get cell info from XML data
				Dim columnName = childNode.Name
				Dim columnIndex = columns.IndexOf(childNode.Name)
				Dim cellValue = childNode.InnerText

				' Set cell text
				row(columnName).Text = cellValue
				' Set cell text alignment
				row(columnName).TextFormat.HorizontalAlign = If(columnIndex = 0, HorizontalAlign.Left, HorizontalAlign.Right)
			Next

			' Add the row to the table
			table.Rows.Add(row)
		Next

		' Draw the table on canvas
		page.Canvas.DrawTable(table, 20, 20)


		' Save document to file
		pdfDocument.Save("result.pdf")

		' Cleanup 
		pdfDocument.Dispose()

		' Open document in default PDF viewer application
		Process.Start("result.pdf")

	End Sub

End Class
