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

' in this sample we scan cells with ages data for people
' then mark all dates where age is between 10 and 19 years and mark these cells with red color

        ' Create new Spreadsheet
        Dim document As New Spreadsheet()
document.LoadFromFile("Data.xls")

        ' Get worksheet by name
        Dim worksheet As Worksheet = document.Workbook.Worksheets.ByName("Sample")

        ' Years range
        Dim RangeMin As Integer = 10
        Dim RangeMax As Integer = 19

        ' Minimum age
        Dim YearMin As DateTime = DateTime.Now
        ' Maximum age
        Dim YearMax As DateTime = DateTime.Now

        ' Minimum year
        YearMax = YearMax.AddYears(-RangeMin)
        ' Maximum year
        YearMin = YearMin.AddYears(-RangeMax)

        ' Check dates
        For i As Integer = 1 To 7
            ' Set current cell
            Dim currentCell As Cell = worksheet.Cell(i, 1)

            Dim dateBirth As DateTime = currentCell.ValueAsDateTime

            ' Check current cell
            If dateBirth < YearMin Or dateBirth > YearMax Then
                ' Set fill pattern
                currentCell.FillPattern = Bytescout.Spreadsheet.Constants.PatternStyle.Solid

                ' Markup wrong cell by red color
                currentCell.FillPatternForeColor = System.Drawing.Color.Red
            End If

            ' Set cell format
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
