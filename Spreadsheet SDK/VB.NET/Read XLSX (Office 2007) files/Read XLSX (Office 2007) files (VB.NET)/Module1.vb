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
        document.LoadFromFile("Hello_world.xlsx")

        ' Get worksheet
        Dim worksheet As Worksheet = document.Workbook.Worksheets.ByName("Sheet1")

        ' Read cell value
        Console.WriteLine("Cell (0,0) value: {0}", worksheet.Cell(0, 0).Value)

        ' Write message
        Console.Write("Press any key to continue...")

        ' Wait user input
        Console.ReadKey()
    End Sub

End Module
