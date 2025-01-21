'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports Bytescout.Spreadsheet

Class Program
	Friend Shared Sub Main(args As String())
		' Create spreadsheet
		Dim doc As New Spreadsheet()
		' Add worksheet
		Dim worksheet As Worksheet = doc.Worksheets.Add()

		' Put an image on the worksheet with 10 pixel margin from the top-left corner of the worksheet
		worksheet.Pictures.Add("image1.jpg", 10, 10)
		' Put second image to 200 pixel offset and resize it to 250x200 px
		worksheet.Pictures.Add("image2.jpg", 200, 200, 250, 200)

		' Delete output file if exists
		If File.Exists("output.xls") Then
			File.Delete("output.xls")
		End If

		' Save document
		doc.SaveAs("output.xls")

		' Close spreadsheet
		doc.Close()

		' Open generated XLS document in default application
		Process.Start("output.xls")

		doc.Dispose()
	End Sub
End Class
