'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


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
