'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.IO
Imports Bytescout.Spreadsheet

Module Module1

    Sub Main()
        ' Create new XLS document
        Dim document As New Spreadsheet()

        ' Create new worksheet
        Dim worksheet As Worksheet = document.Workbook.Worksheets.Add()

        ' Set column width
        worksheet.Columns(1).Width = 300
        ' Set column height
        worksheet.Rows(1).Height = 100

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
