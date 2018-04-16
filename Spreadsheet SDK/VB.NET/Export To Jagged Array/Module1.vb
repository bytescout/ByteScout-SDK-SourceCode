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


Module Module1

    Sub Main()
        Dim inputFile As String = "StockPricesSpreadsheet.xls"

        'Open and load spreadsheet
        Dim spreadsheet = New Spreadsheet()
        spreadsheet.LoadFromFile(inputFile)

        'Get the data from the spreadsheet
        Dim stockPrices()() As String = spreadsheet.ExportToJaggedArray()

        'Close spreadsheet
        spreadsheet.Close()

        'Display data in jagged array
        For i As Integer = 0 To stockPrices.GetLength(0) - 1
            Console.Write(stockPrices(i)(0) + " ")
            Console.Write(stockPrices(i)(1) + " ")
            Console.WriteLine()
        Next

        'Pause
        Console.ReadLine()
    End Sub

End Module
