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


Imports Bytescout.Spreadsheet
Imports System.IO

Module Module1

    Sub Main()
        ' Create new Spreadsheet
        Dim document As New Spreadsheet()

        ' Add new worksheet
        Dim worksheet As Worksheet = document.Workbook.Worksheets.Add("Sheet1")

        ' set values for cells
        worksheet.Cell("A1").ValueAsHTML = "<b><u>Bold Underline</u>, and <i>bold italic</i></b> text"
        worksheet.Cell("A2").ValueAsHTML = "<font color=Blue>Blue</font>, <font color=Green>Green</font> and other <b><font face=Tahoma color=Red>co<font><font face=Tahoma color=Green>lo<font><font face=Tahoma color=Blue>rs<font></b> <font color=black><b>are</b> <u>available</u></font>"


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
