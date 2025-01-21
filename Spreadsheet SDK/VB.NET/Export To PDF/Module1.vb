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
        ' Open Spreadsheet
        Dim document As New Spreadsheet()
		document.LoadFromFile("SimpleReport.xls")

		' add image
    	document.Workbook.Worksheets(0).Pictures.Add(5, 1, "image.jpg")

        ' remove output file if already exists
        If File.Exists("Output.pdf") Then
            File.Delete("Output.pdf")
        End If

        ' Export to PDF
        Dim autosize = False
		document.SaveAsPDF("Output.pdf", autosize)

        ' Close Spreadsheet
        document.Close()

        ' open in default spreadsheets viewer/editor
        Process.Start("Output.pdf")

    End Sub

End Module
