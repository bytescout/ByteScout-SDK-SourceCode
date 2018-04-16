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
