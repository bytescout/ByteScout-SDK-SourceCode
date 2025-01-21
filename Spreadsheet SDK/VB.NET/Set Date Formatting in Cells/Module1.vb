'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
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

        ' Set captions
        worksheet.Cell(0, 0).Value = "#"
        worksheet.Cell(0, 1).Value = "Date"

        For i As Integer = 1 To 7
            ' Set number
            worksheet.Cell(i, 0).Value = i

            ' Set current cell
            Dim currentCell As Cell = worksheet.Cell(i, 1)

            ' Set date to the current date time
            currentCell.ValueAsDateTime = DateTime.Now

            ' Set date format
            currentCell.NumberFormatString = "dd.mm.yyyy"
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
