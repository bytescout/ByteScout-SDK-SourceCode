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


Imports System.IO
Imports System.Diagnostics
Imports Bytescout.Spreadsheet

Module Module1

    Sub Main()

        Const fileName As String = "VBNetImportFrom2DArray.xls"

        'Create a new spreadsheet
        Dim spreadsheet As Bytescout.Spreadsheet.Spreadsheet = New Bytescout.Spreadsheet.Spreadsheet
        
        'Get the data from the 2D array that we want to import
        Dim stockPrices(,) As String = Get2DArray()

        'Import data into spreadheet
        spreadsheet.ImportFrom2DArray(stockPrices)

        'Save the spreadsheet
        If (File.Exists(fileName)) Then
            File.Delete(fileName)
        End If
        spreadsheet.SaveAs(fileName)

        'Close spreadsheet
        spreadsheet.Close()

        'Open the spreadsheet
        Process.Start(fileName)

    End Sub

    ''' <summary>
    ''' Creates a 2D array of stock prices
    ''' </summary>
    ''' <returns>A 2D array of stock prices</returns>
    Function Get2DArray() As String(,)

        Dim stockPrices(10, 2) As String

        stockPrices(0, 0) = "AAPL"
        stockPrices(0, 1) = "24,89"

        stockPrices(1, 0) = "AMZN"
        stockPrices(1, 1) = "27,95"

        stockPrices(2, 0) = "DELL"
        stockPrices(2, 1) = "12,68"

        stockPrices(3, 0) = "EBAY"
        stockPrices(3, 1) = "57,27"

        stockPrices(4, 0) = "GOOG"
        stockPrices(4, 1) = "28,98"

        stockPrices(5, 0) = "IBM "
        stockPrices(5, 1) = "24,00"
        stockPrices(6, 0) = "INTC"
        stockPrices(6, 1) = "12,24"
        stockPrices(7, 0) = "MSFT"
        stockPrices(7, 1) = "37,85"
        stockPrices(8, 0) = "SNE "
        stockPrices(8, 1) = "39,91"
        stockPrices(9, 0) = "YHOO"
        stockPrices(9, 1) = "78,72"

        Return stockPrices
    End Function


End Module
