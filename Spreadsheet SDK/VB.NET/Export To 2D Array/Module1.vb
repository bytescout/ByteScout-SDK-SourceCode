'*******************************************************************
'       ByteScout Spreadsheet SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Module Module1

    Sub Main()
        Dim inputFile As String = "StockPricesSpreadsheet.xls"

        'Open and load spreadsheet
        Dim spreadsheet As Spreadsheet = New Spreadsheet
        spreadsheet.LoadFromFile(inputFile)

        'Get the data from the spreadsheet
        Dim stockPrices(,) As String = spreadsheet.ExportTo2DArray()

        'Close spreadsheet
        spreadsheet.Close()

        'Display contents of the array
        For i As Integer = 0 To stockPrices.GetLength(0) - 1 Step 1
            For j As Integer = 0 To stockPrices.GetLength(1) - 1 Step 1
                Console.Write(stockPrices(i, j) + " ")
            Next
            Console.WriteLine()
        Next

        'Pause
        Console.ReadLine()
    End Sub

End Module
