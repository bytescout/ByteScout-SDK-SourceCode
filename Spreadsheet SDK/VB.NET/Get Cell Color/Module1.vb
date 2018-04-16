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
