'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
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
