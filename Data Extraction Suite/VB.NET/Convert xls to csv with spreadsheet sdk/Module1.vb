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


Imports Bytescout.Spreadsheet
Imports System.IO
Imports System.Diagnostics


Module Module1

    Sub Main()
        ' Open Spreadsheet
        Dim document As New Spreadsheet()
        document.LoadFromFile("SimpleReport.xls")

        ' remove output file if already exists
        If File.Exists("SimpleReport.csv") Then
            File.Delete("SimpleReport.csv")
        End If

        document.Workbook.Worksheets(0).SaveAsCSV("SimpleReport.csv")
        document.Close()

        ' open output document in default viewer
        Process.Start("SimpleReport.csv")

    End Sub

End Module
