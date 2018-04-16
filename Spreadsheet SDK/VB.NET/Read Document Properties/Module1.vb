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


Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Bytescout.Spreadsheet

Module Module1

    Sub Main()
        ' read spreadsheet
        Dim document As Spreadsheet = New Spreadsheet()
document.LoadFromFile("Input.xls")

        Console.WriteLine("Reading XLS properties")

        ' Get some properties
        Console.WriteLine("Author: " + document.Workbook.Properties.Author)
        Console.WriteLine("Comments: " + document.Workbook.Properties.Comments)
        Console.WriteLine("Subject: " + document.Workbook.Properties.Subject)

        Console.ReadKey()

        document.Close()        

    End Sub

End Module
