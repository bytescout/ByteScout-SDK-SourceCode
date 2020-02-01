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


Imports Bytescout.Spreadsheet

Public Class SimpleXMLConverter

    Dim _document As Spreadsheet

    Sub New(ByRef document As Spreadsheet)
        _document = document
    End Sub

    Sub LoadXML(ByVal path As String)
        Dim dataSet As New DataSet()
        dataSet.ReadXml(path)

        For Each table As DataTable In dataSet.Tables

            Dim worksheet As Worksheet = _document.Workbook.Worksheets.Add(table.TableName)

            ' Add columns
            worksheet.Columns.Insert(0, table.Columns.Count)

            ' Add rows for data
            worksheet.Rows.Insert(0, table.Rows.Count)

            ' Fill data
            For i As Integer = 0 To table.Rows.Count - 1
                For j As Integer = 0 To table.Columns.Count - 1
                    worksheet.Cell(i + 1, j).Value = table.Rows(i)(j).ToString()
                Next
            Next
        Next
    End Sub

    Sub SaveXML(ByVal path As String)

        Dim dataSet As New DataSet()

        For i As Integer = 0 To _document.Workbook.Worksheets.Count - 1

            Dim worksheet As Worksheet = _document.Workbook.Worksheets(i)

            Dim table As DataTable = dataSet.Tables.Add(worksheet.Name)

            For column As Integer = 0 To worksheet.UsedRangeColumnMax
                table.Columns.Add(String.Format("Column_{0}", column))
            Next


            For row As Integer = 0 To worksheet.UsedRangeRowMax
                Dim data() As Object
                Array.Resize(data, worksheet.UsedRangeColumnMax + 1)

                For column As Integer = 0 To worksheet.UsedRangeColumnMax
                    data(column) = worksheet.Cell(row, column).Value
                Next

                table.Rows.Add(data)
            Next
        Next

        dataSet.WriteXml(path)
    End Sub

    Sub PrintDataSet(ByRef ds As DataSet)

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
                Next

                Console.WriteLine()
            Next
        Next
    End Sub

End Class
