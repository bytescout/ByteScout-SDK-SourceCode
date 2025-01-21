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
        document.LoadFromFile("sample.xls")

        ' get the very first worksheet
        Dim sheet As Worksheet = document.Worksheet(0)

        Console.WriteLine("reading total price formula from cell B5")
        ' we use .Formula value to read from the B5 cell
        Console.WriteLine("Formula in B5 cell is: " + sheet.Cell("B5").Formula)
        Console.WriteLine("\npress any key to continue")
        Console.ReadKey()
    End Sub

End Module
