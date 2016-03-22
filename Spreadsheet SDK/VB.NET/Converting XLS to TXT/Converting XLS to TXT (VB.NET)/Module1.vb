'*******************************************************************
'       ByteScout Spreadsheet SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.Text
Imports System.IO
Imports Bytescout.Spreadsheet
Imports System.Diagnostics

Module Module1

    Sub Main()
        ' Create new Spreadsheet from SimpleReport.xls file
        Dim document = New Spreadsheet()
        document.LoadFromFile("SimpleReport.xls")

        ' remove output file if already exists
        If File.Exists("Output.txt") Then
            File.Delete("Output.txt")
        End If

        ' Save into TXT file
        document.Workbook.Worksheets(0).SaveAsTXT("Output.txt")


        ' Close Spreadsheet
        document.Close()

        ' open in default spreadsheets viewer/editor
        Process.Start("Output.txt")

    End Sub

End Module
