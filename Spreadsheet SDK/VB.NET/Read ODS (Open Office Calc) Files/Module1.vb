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
Imports System.IO

Module Module1

    Sub Main()
        ' Create new Spreadsheet
        Dim document As New Spreadsheet()
       document.LoadFromFile("Hello_world.ods")

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
