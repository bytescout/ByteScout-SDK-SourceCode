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

        Using spreadsheet As New Spreadsheet

            ' Load JSON string from file
            Dim jsonString As String = File.ReadAllText("sample.json")

            ' Import JSON
            spreadsheet.ImportFromJSON(jsonString)

            ' Save spreadsheet
            spreadsheet.SaveAsXLS("result.xls")

            ' Open the result file in default associated application
            Process.Start("result.xls")

        End Using

    End Sub

End Module
