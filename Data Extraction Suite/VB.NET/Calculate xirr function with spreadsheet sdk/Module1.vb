'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.IO

Imports Bytescout.Spreadsheet
Module Module1

    Sub Main()
        ' Create new Spreadsheet
        Dim document As New Spreadsheet()

        ' Set locale
        document.Workbook.Locale = New System.Globalization.CultureInfo("en-US")

        ' Add new worksheet
        Dim worksheet As Worksheet = document.Workbook.Worksheets.Add()

        ' Fill some data
        worksheet.Cell(1, 1).Value = New DateTime(2008, 1, 1)
        worksheet.Cell(1, 2).Value = 100
        worksheet.Cell(2, 1).Value = New DateTime(2009, 1, 1)
        worksheet.Cell(2, 2).Value = -200

        ' Apply function
        worksheet.Cell(4, 1).Formula = "=XIRR(C2:C3,B2:B3,0)"
        ' Read value
        worksheet.Cell(4, 2).Value = worksheet.Cell(4, 1).Value

        ' delete output file if exists already
        If File.Exists("Output.xls") Then
            File.Delete("Output.xls")
        End If

        ' Save document
        document.SaveAs("Output.xls")

        ' Close Spreadsheet
        document.Close()

        ' open generated XLS document in default program
        Process.Start("Output.xls")
    End Sub

End Module
