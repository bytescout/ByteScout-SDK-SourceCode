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
Imports System.Diagnostics
Imports System.Drawing

Module Module1

    Sub Main()
        ' Create new Spreadsheet
        Dim document As Spreadsheet = New Spreadsheet()

        ' Add new worksheet
        Dim worksheet As Worksheet = document.Workbook.Worksheets.Add("AdvancedReport")

        ' Set Values
        worksheet.Cell(0, 0).Value = "Name"
        worksheet.Cell(0, 1).Value = "Full Name"

        Dim headerColor As Color = [Color].FromArgb(75, 172, 198)
        Dim contentColor As Color = [Color].FromArgb(141, 180, 227)

        ' Set font bold for headers
        worksheet.Cell(0, 0).Font = New Font("Arial", 12, FontStyle.Bold)
        worksheet.Cell(0, 1).Font = New Font("Arial", 12, FontStyle.Bold)

        ' Set back color for headers rows
        worksheet.Cell(0, 0).FillPattern = PatternStyle.Solid
        worksheet.Cell(0, 0).FillPatternForeColor = headerColor
        worksheet.Cell(0, 1).FillPattern = PatternStyle.Solid
        worksheet.Cell(0, 1).FillPatternForeColor = headerColor
        worksheet.Cell(6, 0).FillPattern = PatternStyle.Solid
        worksheet.Cell(6, 0).FillPatternForeColor = headerColor
        worksheet.Cell(6, 0).FontColor = Color.White
        worksheet.Cell(6, 1).FillPattern = PatternStyle.Solid
        worksheet.Cell(6, 1).FillPatternForeColor = headerColor

        ' Set back color for content rows
        For i As Integer = 1 To 5
            worksheet.Cell(i, 0).FillPattern = PatternStyle.Solid
            worksheet.Cell(i, 0).FillPatternForeColor = contentColor
            worksheet.Cell(i, 1).FillPattern = PatternStyle.Solid
            worksheet.Cell(i, 1).FillPatternForeColor = contentColor
        Next

        worksheet.Cell(1, 0).Value = "Homer"
        worksheet.Cell(1, 1).Value = "Homer Jay Simpson"

        worksheet.Cell(2, 0).Value = "Marjorie"
        worksheet.Cell(2, 1).Value = "Marjorie Marge Simpson (Bouvier)"

        worksheet.Cell(3, 0).Value = "Bartholomew"
        worksheet.Cell(3, 1).Value = "Bartholomew Jojo Bart Simpson"

        worksheet.Cell(4, 0).Value = "Lisa"
        worksheet.Cell(4, 1).Value = "Lisa Marie Simpson"

        worksheet.Cell(5, 0).Value = "Margaret"
        worksheet.Cell(5, 1).Value = "Margaret Maggie "

        worksheet.Cell(6, 0).Value = "Count"
        worksheet.Cell(6, 1).Value = "5"

        worksheet.Columns(1).Width = 250
        worksheet.Columns(2).Width = 250

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
