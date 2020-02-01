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

        ' Add new worksheet
        Dim worksheet As Worksheet = document.Workbook.Worksheets.Add("AlignmentDemo")


        ' Set Values
        worksheet.Cell("A1").Value = "Name"
        ' setting centered alignment for the cell
        worksheet.Cell("A1").AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Centered
        worksheet.Cell("B1").Value = "Full Name"
        ' setting centered alignment for the cell 
        worksheet.Cell("B1").AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Centered

        worksheet.Cell("A2").Value = "Homer"
        ' setting justifiedalignment for the cell 
        worksheet.Cell("A2").AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right

        worksheet.Cell("B2").Value = "Homer Jay Simpson"
        ' setting justified alignment for the cell 
        worksheet.Cell("B2").AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right

        ' set columns width
        worksheet.Columns(0).Width = 300 ' A column
        worksheet.Columns(1).Width = 400 ' B column

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
