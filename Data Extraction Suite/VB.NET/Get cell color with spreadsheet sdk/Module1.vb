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
        ' Open existing XLS document
        Dim spreadSheet As New Spreadsheet()
         spreadSheet.LoadFromFile("input.xls")

        ' Take existing worksheet
        Dim sheet As Worksheet = spreadSheet.Worksheet(0)

        ' Take cell
        Dim cell As Cell = sheet.Cell(0, 0)

        ' Print back color of fill patter
        Console.WriteLine(cell.FillPatternBackColor.ToString())

        ' Print fore color of fill pattern
        Console.WriteLine(cell.FillPatternForeColor.ToString())

        ' Close spreadsheet
        spreadSheet.Close()
    End Sub

End Module
