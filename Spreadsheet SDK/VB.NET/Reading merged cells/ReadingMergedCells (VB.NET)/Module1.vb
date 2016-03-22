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
        ' Create new Spreadsheet
        Dim document As New Spreadsheet()
document.LoadFromFile("Input.xls")

        ' Get worksheet by name
        Dim worksheet As Worksheet = document.Workbook.Worksheets("Sheet1")

        ' Read merged cell
        Dim cell As Cell = worksheet.Cell("C12").MergedWithCell

        ' Read cell value
        Console.WriteLine(cell.Value)

        ' Close document
        document.Close()

    End Sub

End Module
