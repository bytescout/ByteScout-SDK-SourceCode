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
	document.LoadFromFile("Sample.xls")

        ' Get worksheet by name
        Dim worksheet As Worksheet = document.Workbook.Worksheets.ByName("Sheet1")

        ' Check dates
        For i As Integer = 0 To 3
            ' Set current cell
            Dim currentCell As Cell = worksheet.Cell(i, 0)

            If currentCell.ValueDataTypeByNumberFormatString = Constants.NumberFormatType.DateTime Then
                ' read date time
                Dim datet As DateTime = currentCell.ValueAsDateTime()

                ' Write to console
                Console.WriteLine("{0}", datet.ToShortDateString())
            Else
                ' Write message
                Console.WriteLine("cell does not contain date time value")
            End If
        Next

        ' Close document
        document.Close()

        ' Write message
        Console.Write("Press any key to continue...")

        ' Wait user input
        Console.ReadKey()

    End Sub

End Module
