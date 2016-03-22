'*******************************************************************
'       ByteScout Spreadsheet SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports Bytescout.Spreadsheet
Imports System.IO

Module Module1

    Sub Main()
        ' Open Spreadsheet
        Dim document As New Spreadsheet()
        document.LoadFromFile("AdvancedReport.xls")

        Dim dataSet As New DataSet("AdvancedReport")

        For i As Integer = 0 To document.Workbook.Worksheets.Count - 1
            Dim worksheet As Worksheet = document.Workbook.Worksheets(i)

            Dim table As DataTable = dataSet.Tables.Add(worksheet.Name)

            For column As Integer = 0 To worksheet.UsedRangeColumnMax
                table.Columns.Add(String.Format("Column{0}", column))
            Next

            For row As Integer = 0 To worksheet.UsedRangeRowMax
                Dim data() As Object

                [Array].Resize(data, worksheet.UsedRangeColumnMax + 1)

                For column As Integer = 0 To worksheet.UsedRangeColumnMax
                    data(column) = worksheet.Cell(row, column).Value
                Next

                table.Rows.Add(data)
            Next
        Next

        ' Close Spreadsheet
        document.Close()

        PrintDataSet(dataSet)
    End Sub

    Private Sub PrintDataSet(ByRef ds As DataSet)
        Console.WriteLine("DataSet name: {0}", ds.DataSetName)
        For Each table As DataTable In ds.Tables
            Dim rowCount As Integer = table.Rows.Count
            Dim columnCount As Integer = table.Columns.Count

            Console.WriteLine("\nTable: {0} ({1} rows)", table.TableName, rowCount)
            For Each column As DataColumn In table.Columns
                Console.Write("{0}\t", column.ColumnName)
            Next

            Console.WriteLine()

            For i As Integer = 0 To rowCount - 1
                For column As Integer = 0 To columnCount - 1
                    Console.Write("{0}\t", table.Rows(i)(column))

                    Console.WriteLine()
                Next
            Next
        Next

    End Sub

End Module
