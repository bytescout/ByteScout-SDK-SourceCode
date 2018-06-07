'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports Bytescout.Spreadsheet

Class Program
	Friend Shared Sub Main(args As String())
		' Open spreadsheet from file
		Dim document As New Spreadsheet()
		document.LoadFromFile("example.xls")
		' document.LoadFromFile(@"d:\2\1\Bytescout\Spreadsheet SDK\TestCase\Formats.xls")

		' Get first worksheet
		Dim worksheet As Worksheet = document.Workbook.Worksheets(0)

		' Copy first two ("A-B") columns to the fourth ("D") column
		worksheet.Columns.CopyAndPaste(0, 1, 12)

		' Delete output file if exists
		If File.Exists("changed.xls") Then
			File.Delete("changed.xls")
		End If

		' Save document
		document.SaveAs("changed.xls")

		' Close spreadsheet
		document.Close()

		' Open generated XLS document in default program
		Process.Start("changed.xls")
	End Sub
End Class
