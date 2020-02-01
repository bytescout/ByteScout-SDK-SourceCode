'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports Bytescout.Spreadsheet
Imports System.Diagnostics
Imports System.IO

Module Module1

    Sub Main()
        ' Open existing XLS file
        Dim spreadsheet As New Spreadsheet()
		spreadsheet.LoadFromFile("Input.xls")

        ' delete output file if exists already
        if File.Exists("Output.xlsx") Then
            File.Delete("Output.xlsx")
        End If
        
        ' Save it as XLSX
        spreadsheet.SaveAs("Output.xlsx")

        ' open output document in default viewer
        Process.Start("Output.xlsx")

    End Sub

End Module
