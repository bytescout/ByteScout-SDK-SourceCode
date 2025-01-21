'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Bytescout.Spreadsheet

Module Module1

    Sub Main()
        ' read spreadsheet
        Dim document As Spreadsheet = New Spreadsheet()
document.LoadFromFile("Input.xls")

        Console.WriteLine("Reading XLS properties")

        ' Get some properties
        Console.WriteLine("Author: " + document.Workbook.Properties.Author)
        Console.WriteLine("Comments: " + document.Workbook.Properties.Comments)
        Console.WriteLine("Subject: " + document.Workbook.Properties.Subject)

        Console.ReadKey()

        document.Close()        

    End Sub

End Module
