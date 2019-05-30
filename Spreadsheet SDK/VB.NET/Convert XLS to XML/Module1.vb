'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports Bytescout.Spreadsheet
Imports System.IO
Imports System.Diagnostics

Module Module1

    Sub Main()
        Dim document As New Spreadsheet()
	document.LoadFromFile("SimpleReport.xls")

        ' remove output file if already exists
        If File.Exists("Output.xml") Then
            File.Delete("Output.xml")
        End If

        ' Save document
        document.Workbook.Worksheets(0).SaveAsXML("Output.xml")

        ' Close Spreadsheet
        document.Close()

        ' open in default spreadsheets viewer/editor
        Process.Start("Output.xml")

        document.Close()
    End Sub

End Module
