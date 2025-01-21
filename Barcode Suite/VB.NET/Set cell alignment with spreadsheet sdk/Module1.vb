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
