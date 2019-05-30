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
