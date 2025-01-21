'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.Spreadsheet
Imports Bytescout.Spreadsheet.BaseClasses

Class Program
	Friend Shared Sub Main(args As String())
		' Open spreadsheet from file
		Dim document As New Spreadsheet()
		document.LoadFromFile("example.xls")

		' Get first worksheet
		Dim worksheet As Worksheet = document.Workbook.Worksheets(0)

		' Find cells containing "in" substring

        Dim cell As Cell = worksheet.Find("in", False, False, False) 'case insesitive, not regexp, search forward

		While cell IsNot Nothing
			' Print found cell address and value to console
			Dim address As CellAddress = cell.GetAddress()
			Dim message As String = String.Format("({0}, {1}): {2}", address.Column, address.Row, cell.ValueAsExcelDisplays)

			Console.WriteLine(message)

			cell = worksheet.FindNext()
		End While

		document.Dispose()

		Console.WriteLine()
		Console.WriteLine("Press any key to continue.")
		Console.ReadKey(True)
	End Sub
End Class
