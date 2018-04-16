'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


Imports Bytescout.Spreadsheet
Imports System.IO

Module Module1

    Sub Main()

        Using spreadsheet As New Spreadsheet

            ' Load document
            spreadsheet.LoadFromFile("Table.xls")

            ' Export first worksheet to JSON format
            Dim jsonString As String = spreadsheet.ExportToJSON(0)

            ' Write JSON string to file
            File.WriteAllText("exported.json.txt", jsonString)

            ' Open the result file in default associated application
            Process.Start("exported.json.txt")

        End Using

    End Sub

End Module
