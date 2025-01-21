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
Imports System.Text
Imports Bytescout.Spreadsheet

Module Module1

    Sub Main()

        ' Spreadsheet document
        Using document As New Spreadsheet()

            ' Load Input File
            document.LoadFromFile("SimpleReport.xls")

            ' Create stream and export CSV data to stream
            Dim ms As New MemoryStream()
            document.Worksheet(0).SaveAsCSV(ms, vbTab)

            ' Convert memory stream to string
            Dim tabSeparatedData = Encoding.UTF8.GetString(ms.ToArray())

            ' Copy data to clipboard
            System.Windows.Forms.Clipboard.SetText(tabSeparatedData)

        End Using

        Console.WriteLine("Data copied to clipboard")
        Console.ReadLine()

    End Sub

End Module
