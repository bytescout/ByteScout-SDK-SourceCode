'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


Imports System
Imports Bytescout.Spreadsheet

Module Module1

    Sub Main()

        Dim spreadsheet As Spreadsheet = New Spreadsheet()

        Console.WriteLine("Read excel file...")
		spreadsheet.LoadFromFile(".\Input.xls")

        Console.WriteLine("Read first spreadsheet...")
        Dim worksheet As Worksheet = spreadsheet.Worksheets(0)

        Console.WriteLine("Freeze rows...")
        worksheet.ViewOptions.SplitVertical = worksheet.Rows(0).Height
        worksheet.ViewOptions.SplitRow = 1
        worksheet.ViewOptions.PanesFrozen = True

        Console.WriteLine("Freeze columns...")
        worksheet = spreadsheet.Worksheets(1)
        worksheet.ViewOptions.SplitHorizontal = worksheet.Columns(0).Width
        worksheet.ViewOptions.SplitColumn = 1
        worksheet.ViewOptions.PanesFrozen = True

        Console.WriteLine("Save excel file...")
        spreadsheet.SaveAs("Output.xls")

		' Cleanup
	    spreadsheet.Dispose()


        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()


    End Sub

End Module
