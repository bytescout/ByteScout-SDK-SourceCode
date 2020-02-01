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

Module Module1

    Sub Main()
        ' Create new Spreadsheet
        Dim document As New Spreadsheet()

        ' Add new worksheet
        Dim worksheet As Worksheet = document.Workbook.Worksheets.Add("HelloWorld")

        ' Create array with font names
        Dim fontNames() As String = {"Helvetica", "Times New Roman", "Verdana", "Times New Roman"}

        ' Use all fonts in fontsNames array
        For i As Integer = 0 To fontNames.Length - 1
            ' Set font size based on loop counter
            Dim fontSize As Double = 10 + i * 3

            'Set cell font type and font size
            worksheet.Cell(i, 0).Font = New System.Drawing.Font(fontNames(i), fontSize)

            ' Set cell value
            worksheet.Cell(i, 0).Value = fontNames(i)
        Next


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
