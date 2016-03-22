'*******************************************************************
'       ByteScout Spreadsheet SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports Bytescout.Spreadsheet
Imports System.IO
Imports System.Diagnostics


Module Module1

    Sub Main()
        ' Open Spreadsheet
        Dim document As New Spreadsheet()
       document.LoadFromFile("SimpleReport.xls")

        ' remove output file if already exists
        If File.Exists("SimpleReport.csv") Then
            File.Delete("SimpleReport.csv")
        End If

        document.Workbook.Worksheets(0).SaveAsCSV("SimpleReport.csv")
        document.Close()

        ' open output document in default viewer
        Process.Start("SimpleReport.csv");

    End Sub

End Module
