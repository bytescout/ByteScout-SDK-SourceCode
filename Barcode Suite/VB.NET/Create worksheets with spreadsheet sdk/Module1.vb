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

Module Module1

    Sub Main()
        ' Create new Spreadsheet
        Dim document = New Spreadsheet()

        ' Add worksheets
        Dim worksheet1 As Worksheet = document.Workbook.Worksheets.Add("Demo worksheet 1")

        Dim worksheet2 As Worksheet = document.Workbook.Worksheets.Add("Demo worksheet 2")

        ' Get worksheet by name
        Dim worksheetByName As Worksheet = document.Workbook.Worksheets.ByName("Demo worksheet 2")

        ' Set cell values
        worksheet1.Cell(0, 0).Value = "This is Demo worksheet 1"

        worksheetByName.Cell(0, 0).Value = "This is Demo worksheet 2"

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
