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
        document.LoadFromFile("AdvancedReport.xls")

        ' Get Worksheet
        Dim worksheet As Worksheet = document.Workbook.Worksheets(0)

        ' Remove Column
        worksheet.Columns.Delete(1, 1)


        ' remove output file if already exists
        If File.Exists("Output.xls") Then
            File.Delete("Output.xls")
        End If

        ' Save document
        document.SaveAs("Output.xls")

        ' Close Spreadsheet
        document.Close()

        ' open in default spreadsheets viewer/editor
        Process.Start("Output.xls")

    End Sub

End Module
