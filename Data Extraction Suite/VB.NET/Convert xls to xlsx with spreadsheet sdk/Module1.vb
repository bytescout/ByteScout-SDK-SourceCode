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
Imports System.Diagnostics
Imports System.IO

Module Module1

    Sub Main()
        ' Open existing XLS file
        Dim spreadsheet As New Spreadsheet()
		spreadsheet.LoadFromFile("Input.xls")

        ' delete output file if exists already
        if File.Exists("Output.xlsx") Then
            File.Delete("Output.xlsx")
        End If
        
        ' Save it as XLSX
        spreadsheet.SaveAs("Output.xlsx")

        ' open output document in default viewer
        Process.Start("Output.xlsx")

    End Sub

End Module
