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


Imports System.Diagnostics
Imports System.IO
Imports Bytescout.Spreadsheet

Class Program
	Friend Shared Sub Main(args As String())
		' Open spreadsheet from file
		Dim document As New Spreadsheet()
		document.LoadFromFile("template.xls")

		' Get first worksheet
		Dim worksheet As Worksheet = document.Workbook.Worksheets(0)

		' Find macros and replace them with values
		Replace(worksheet, "<PRODUCT_NAME1>", "Product 1", Nothing)
		Replace(worksheet, "<PRODUCT_NAME2>", "Product 2", Nothing)
		Replace(worksheet, "<PRICE1>", 24.99F, "0.00")
		Replace(worksheet, "<PRICE2>", 29.99F, "0.00")
		Replace(worksheet, "<QANTITY1>", 5, Nothing)
		Replace(worksheet, "<QANTITY2>", 10, Nothing)


		' Delete output file if exists
		If File.Exists("output.xls") Then
			File.Delete("output.xls")
		End If

		' Save document
		document.SaveAs("output.xls")

		' Close spreadsheet
		document.Close()

		' Open generated XLS document in default application
		Process.Start("output.xls")
	End Sub

	Private Shared Sub Replace(worksheet As Worksheet, macro As String, value As Object, format As String)
		Dim cell As Cell = worksheet.Find(macro, True, False, False)

        While cell IsNot Nothing
            cell.Value = value

            If Not [String].IsNullOrEmpty(format) Then
                cell.NumberFormatString = format
            End If

            cell = worksheet.FindNext()
        End While
    End Sub
End Class
