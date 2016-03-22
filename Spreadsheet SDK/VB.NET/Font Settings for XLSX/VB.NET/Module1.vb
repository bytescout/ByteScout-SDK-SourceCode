'*******************************************************************
'       ByteScout Spreadsheet SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.Drawing

Imports Bytescout.Spreadsheet

Module Module1

    Sub Main()
        ' Create new spreadhseet
        Dim spreadsheet As New Spreadsheet()

        ' Create new worksheet
        Dim sheet As Worksheet = spreadsheet.Workbook.Worksheets.Add()

        ' Set cell value
        sheet(0, 0).Value = "Test 1"
        ' Set cell font color
        sheet(0, 0).FontColor = Color.Red
        ' Set cell font
        sheet(0, 0).Font = New Font(FontFamily.GenericSansSerif, 13)

        ' Set cell value
        sheet(0, 1).Value = "Test 2"
        ' Set cell font color
        sheet(0, 1).FontColor = Color.Blue
        ' Set cell font
        sheet(0, 1).Font = New Font("Arial", 13)

        ' Save spreadsheet as XLSX
        spreadsheet.SaveAs("Result.xlsx")
        ' Close spreadsheet
        spreadsheet.Close()
    End Sub

End Module
