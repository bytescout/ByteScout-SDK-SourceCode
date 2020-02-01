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
Imports Bytescout.Spreadsheet
Imports System.Diagnostics
Imports System.IO

Module Module1

    Sub Main()
        ' Open existing Spreadsheets
        Dim document1 As New Spreadsheet()
document1.LoadFromFile("input.xls")

        ' Get first cell value
        Dim value1 As Object = document1.Worksheet(0).Cell("A1").Value
        ' Get another cell value
        Dim value2 As Object = document1.Worksheet(0).Cell("B1").Value

        ' Swap them
        Dim value3 As Object
        value3 = value2
        value2 = value1
        value1 = value3

        document1.Worksheet(0).Cell("A1").Value = value1
        document1.Worksheet(0).Cell("B1").Value = value2


        ' remove output file if already exists
        If File.Exists("Output.xls") Then
            File.Delete("Output.xls")
        End If

        ' Save document
        document1.SaveAs("Output.xls")

        ' Close Spreadsheet
        document1.Close()

        ' open in default spreadsheets viewer/editor
        Process.Start("Output.xls")
    End Sub

End Module
