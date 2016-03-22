'*******************************************************************
'       ByteScout Spreadsheet SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports Bytescout.Spreadsheet
Imports System.IO

Module Module1

    Sub Main()
        ' Open Spreadsheet
        Dim document As New Spreadsheet()
document.LoadFromFile("SimpleReport.xls")

        ' Get Worksheet
        Dim worksheet As Worksheet = document.Workbook.Worksheets(0)

        ' remove output file if already exists
        If File.Exists("Output.htm") Then
            File.Delete("Output.htm")
        End If

        ' Export to HTML
        worksheet.SaveAsHTML("Output.htm")

        ' Close Spreadsheet
        document.Close()

        ' open in default spreadsheets viewer/editor
        Process.Start("Output.htm")

    End Sub

End Module
