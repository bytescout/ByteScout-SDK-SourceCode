'*******************************************************************
'       ByteScout Spreadsheet SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports Bytescout.Spreadsheet

Class Program
	Friend Shared Sub Main(args As String())
		' Create new spreadsheet (or open existing)
		Dim doc As New Spreadsheet()
		' Add worksheet
		Dim worksheet As Worksheet = doc.Worksheets.Add()

		' Put background image on the worksheet
		worksheet.BackgroundPicture = Image.FromFile("image1.jpg")


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
