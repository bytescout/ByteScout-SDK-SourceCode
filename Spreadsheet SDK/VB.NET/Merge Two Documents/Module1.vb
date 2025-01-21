'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Bytescout.Spreadsheet
Imports System.Diagnostics
Imports System.IO

Module Module1

    Sub Main()
        ' Open existing Spreadsheets
        Dim document1 As New Spreadsheet()
	document1.LoadFromFile("workbook1.xls")

        Dim document2 As New Spreadsheet()
	document2.LoadFromFile("workbook2.xls")

        ' Create output document
        Dim document3 As New Spreadsheet()

        ' Add new worksheet
        document3.Workbook.Worksheets.Add()

        ' Target row
        Dim targetRow As Integer = 0
        For i As Integer = 0 To 9

            ' Copy cells from first document
            For j As Integer = 0 To 11
                document3.Worksheet(0).Cell(targetRow, j).Value = document1.Worksheet(0).Cell(i, j).Value
            Next
            targetRow += 1
        Next
        For i As Integer = 0 To 9

            ' Copy cells from second document
            For j As Integer = 0 To 11
                document3.Worksheet(0).Cell(targetRow, j).Value = document2.Worksheet(0).Cell(i, j).Value
            Next
            targetRow += 1
        Next


        ' remove output file if already exists
        If File.Exists("Output.xls") Then
            File.Delete("Output.xls")
        End If

        ' Save document
        document3.SaveAs("Output.xls")

        ' Close Spreadsheet
        document3.Close()

        ' open in default spreadsheets viewer/editor
        Process.Start("Output.xls")
    End Sub

End Module
