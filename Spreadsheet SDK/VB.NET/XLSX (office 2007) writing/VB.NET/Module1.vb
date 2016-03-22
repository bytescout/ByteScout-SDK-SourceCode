'*******************************************************************
'       ByteScout Spreadsheet SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System
Imports System.Collections.Generic
Imports System.Text

Imports Bytescout.Spreadsheet

Module Module1

    Sub Main()
        ' Create new Spreadsheet
        Dim document As New Spreadsheet()

        ' Add new worksheet
        Dim worksheet As Worksheet = document.Workbook.Worksheets.Add("HelloWorld")

        ' Set cell value
        worksheet.Cell(0, 0).Value = "Hello, World!"

        ' Save document
        document.SaveAs("HelloWorld.xlsx")
    End Sub

End Module
