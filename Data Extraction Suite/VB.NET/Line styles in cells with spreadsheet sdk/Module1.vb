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
Imports Bytescout.Spreadsheet.Constants
Imports System.IO

Module Module1

    Sub Main()
        ' Create new Spreadsheet
        Dim document As New Spreadsheet()

        ' Get worksheet by name
        Dim worksheet As Worksheet = document.Workbook.Worksheets.Add()

        ' Number of cell in the first column
        Dim cellRow As Integer = 0

        ' Apply all line styles
        For Each lineStyle As LineStyle In [Enum].GetValues(GetType(LineStyle))
            ' Set current cell
            Dim currentCell As Cell = worksheet.Cell(cellRow, 0)

            ' Set border styles
            currentCell.RightBorderStyle = lineStyle
            currentCell.LeftBorderStyle = lineStyle
            currentCell.TopBorderStyle = lineStyle
            currentCell.BottomBorderStyle = lineStyle

            ' Print style name
            currentCell.Value = lineStyle.ToString()

            ' Choose next row
            cellRow += 2
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
