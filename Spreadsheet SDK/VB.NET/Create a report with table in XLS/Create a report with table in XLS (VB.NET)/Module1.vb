'*******************************************************************
'       ByteScout Spreadsheet SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.Drawing
Imports System.IO
Imports Bytescout.Spreadsheet

Module Module1

    Sub Main()
        ' Create new Spreadsheet
        Dim document As New Spreadsheet()

        ' Add new worksheet
        Dim worksheet As Worksheet = document.Workbook.Worksheets.Add("SimpleReport")

        ' Set Values
        worksheet.Cell(0, 0).Value = "Name"
        worksheet.Cell(0, 1).Value = "Full Name"

        ' Set font bold for headers
        worksheet.Cell(0, 0).Font = New Font("Arial", 12, FontStyle.Bold)
        worksheet.Cell(0, 1).Font = New Font("Arial", 12, FontStyle.Bold)

        worksheet.Cell(1, 0).Value = "Homer"
        worksheet.Cell(1, 1).Value = "Homer Jay Simpson"

        worksheet.Cell(2, 0).Value = "Marjorie"
        worksheet.Cell(2, 1).Value = "Marjorie Marge Simpson (Bouvier)"

        worksheet.Cell(3, 0).Value = "Bartholomew"
        worksheet.Cell(3, 1).Value = "Bartholomew Jojo Bart Simpson"

        worksheet.Cell(4, 0).Value = "Lisa"
        worksheet.Cell(4, 1).Value = "Lisa Marie Simpson"

        worksheet.Cell(5, 0).Value = "Margaret"
        worksheet.Cell(5, 1).Value = "Margaret Maggie "

        ' remove output file if already exists
        If File.Exists("Output.xls") Then
            File.Delete("Output.xls")
        End If

        ' Save document
        document.SaveAs("Output.xls")

        ' Close Spreadsheet
        document.Close()

        ' open in default spreadsheets viewer/editor
        Process.Start("Output.xls")

    End Sub

End Module
