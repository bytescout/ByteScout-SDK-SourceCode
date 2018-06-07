'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
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
