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
        ' Create new Spreadsheet
        Dim document As New Spreadsheet()

        ' Get worksheet by name
        Dim worksheet As Worksheet = document.Workbook.Worksheets.Add("Sample")

        ' Set header
        worksheet.Cell(0, 0).Value = "Number"
        worksheet.Cell(0, 1).Value = "Format"

        ' Set variables
        Dim plan As Double = 3000
        Dim result As Double = 3100

        ' Fill cells
        For i As Integer = 1 To 5
            worksheet.Cell(i, 0).Value = result / plan
        Next

        ' Set cells format
        worksheet.Cell(1, 0).NumberFormatString = "0.00"
        worksheet.Cell(2, 0).NumberFormatString = "0.00%"
        worksheet.Cell(3, 0).NumberFormatString = "mm:ss"
        worksheet.Cell(4, 0).NumberFormatString = "hh:mm:ss"
        worksheet.Cell(5, 0).NumberFormatString = "##0,0E+0"

        ' Set captions
        worksheet.Cell(1, 1).Value = "0.00"
        worksheet.Cell(2, 1).Value = "0.00%"
        worksheet.Cell(3, 1).Value = "mm:ss"
        worksheet.Cell(4, 1).Value = "hh:mm:ss"
        worksheet.Cell(5, 1).Value = "##0,0E+0"


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
