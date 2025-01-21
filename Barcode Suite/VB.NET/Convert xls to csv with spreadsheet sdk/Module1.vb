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
        document.LoadFromFile("SimpleReport.xls")

        ' remove output file if already exists
        If File.Exists("SimpleReport.csv") Then
            File.Delete("SimpleReport.csv")
        End If

        document.Workbook.Worksheets(0).SaveAsCSV("SimpleReport.csv")
        document.Close()

        ' open output document in default viewer
        Process.Start("SimpleReport.csv")

    End Sub

End Module
