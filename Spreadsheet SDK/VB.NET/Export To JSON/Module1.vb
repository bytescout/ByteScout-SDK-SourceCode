'*******************************************************************
'       ByteScout Spreadsheet SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

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
