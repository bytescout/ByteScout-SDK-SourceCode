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

Module Module1

    Sub Main()
        ' Create new Spreadsheet
        Dim document As New Spreadsheet()
document.LoadFromFile("Data.xls")

        ' Get worksheet by name
        Dim worksheet As Worksheet = document.Workbook.Worksheets.ByName("Sample")

        ' Spellcheck words
        For i As Integer = 0 To 4
            ' Set current cell
            Dim currentCell As Cell = worksheet.Cell(0, i)

            ' Spellcheck current cell
            If currentCell.Value = "Simpsan" Then
                ' Set fill pattern
                currentCell.FillPattern = Bytescout.Spreadsheet.Constants.PatternStyle.Solid

                ' Markup wrong word by red color
                currentCell.FillPatternForeColor = System.Drawing.Color.Red
            End If
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
