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
document.LoadFromFile("Hello_world.csv")

        ' Get first worksheet
        Dim worksheet As Worksheet = document.Workbook.Worksheets(0)

        ' Read cell value
        Console.WriteLine("Cell (0,0) value: {0}", worksheet.Cell(0, 0).Value)

        ' Write message
        Console.Write("Press any key to continue...")

        ' Wait user input
        Console.ReadKey()

    End Sub

End Module
