'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Drawing
Imports System.Xml
Imports Bytescout.Spreadsheet
Imports Bytescout.Spreadsheet.Constants

Module Module1

	Sub Main()

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


		' Create new spreadsheet
		Dim spreadsheet = New Spreadsheet()
		spreadsheet.RegistrationName = "demo"
		spreadsheet.RegistrationKey = "demo"
		' Add worksheet
		Dim worksheet = spreadsheet.Worksheets.Add()

		' Add column headers
		For c As Integer = 0 To columns.Count - 1
			worksheet(0, c).Value = columns(c)
			worksheet(0, c).FillPattern = PatternStyle.Solid
			worksheet(0, c).FillPatternForeColor = Color.LightGray
		Next

		Dim rowIndex = 1

		' Add rows
		For Each rowNode As XmlNode In rowNodeList

			' Get cell values from XML data
			For Each childNode As XmlNode In rowNode.ChildNodes

				' Get cell info from XML data
				Dim columnIndex = columns.IndexOf(childNode.Name)
				Dim cellValue = childNode.InnerText

				Dim cell = worksheet(rowIndex, columnIndex)

				' Set cell text
				Cell.Value = cellValue
				' Set cell text alignment
				cell.AlignmentHorizontal = IIf(columnIndex = 0, AlignmentHorizontal.Left, AlignmentHorizontal.Right)
			Next

			' Add the row to the table
			rowIndex = rowIndex + 1
		Next

		' Fit columns width to cell data
		For c As Integer = 0 To columns.Count - 1
			worksheet.Columns(c).AutoFit()
		Next

		' Save document to file
		spreadsheet.SaveAsXLS("result.xls")

		' Cleanup 
		spreadsheet.Dispose()

		' Open document in Excel
		Process.Start("result.xls")

	End Sub

End Module
