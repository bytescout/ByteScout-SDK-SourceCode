'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


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
