'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


Imports System.Diagnostics
Imports System.IO
Imports Bytescout.Spreadsheet

Class Program
	Friend Shared Sub Main(args As String())
		' Create new Spreadsheet
		Dim document As New Spreadsheet()

		' Add worksheets
		Dim worksheet1 As Worksheet = document.Workbook.Worksheets.Add("Demo worksheet 1")
		Dim worksheet2 As Worksheet = document.Workbook.Worksheets.Add("Demo worksheet 2")

		' Fill cell on the first worksheet
		worksheet1.Cell(0, 0).Value = "This is Demo worksheet 1"

		' Get worksheet by name and fill a cell there
		Dim worksheetByName As Worksheet = document.Workbook.Worksheets.ByName("Demo worksheet 2")
		worksheetByName.Cell(0, 0).Value = "This is Demo worksheet 2"

		' Get current directory
		Dim currentDirectory As [String] = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)

		' Construct output file name
		Dim outputFile As [String] = currentDirectory & "\Worksheets.xls"

		' delete output file if exists 
		If File.Exists(outputFile) Then
			File.Delete(outputFile)
		End If

		' Save document
		document.SaveAs(outputFile)

		' open generated XLS document in default program
		Process.Start(outputFile, "")
	End Sub
End Class
