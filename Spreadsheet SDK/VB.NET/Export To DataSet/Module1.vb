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


Module Module1

    Sub Main()
        Dim inputFile As String = "PeriodicTableOfElementsSpreadsheet.xls"

        'Open and load spreadsheet
        Dim spreadsheet = New Spreadsheet()
        spreadsheet.LoadFromFile(inputFile)

        'Get the data from the spreadsheet
        Dim ds As DataSet = spreadsheet.ExportToDataSet()

        'Close spreadsheet
        spreadsheet.Close()

        'Display data in first datatable of dataset
        Dim dt As DataTable = ds.Tables(0)
        Console.WriteLine("Displaying contents of first datatable")
        For i As Integer = 0 To dt.Rows.Count - 1
            For j As Integer = 0 To dt.Columns.Count - 1

                Console.Write(dt.Rows(i)(j) + " ")
            Next
            Console.WriteLine()
        Next

        'Pause
        Console.ReadLine()
    End Sub

End Module
