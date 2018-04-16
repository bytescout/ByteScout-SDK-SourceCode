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
