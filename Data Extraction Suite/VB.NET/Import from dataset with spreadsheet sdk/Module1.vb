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


Imports System.IO

Module Module1

    Sub Main()
        Const fileName As String = "VBNetImportFromDataSet.xls"

        'Create a new spreadsheet
        Dim spreadsheet As Bytescout.Spreadsheet.Spreadsheet = New Bytescout.Spreadsheet.Spreadsheet

        'Get the data from the 2D array that we want to import
        Dim dataset = GetDataSet()

        'Import data into spreadheet
        spreadsheet.ImportFromDataSet(dataset)

        'Insert row with column captions
        For i As Integer = 0 To dataset.Tables.Count - 1

            Dim dataTable As DataTable = dataset.Tables(i)
            Dim worksheet As Worksheet = spreadsheet.Worksheets(i)

            worksheet.Rows.Insert(0)

            For colIndex As Integer = 0 To dataTable.Columns.Count - 1
                worksheet.Cell(0, colIndex).Value = dataTable.Columns(colIndex).Caption
            Next
        Next

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
    ''' Returns a dataset containing 2 tables
    ''' </summary>
    ''' <returns>Dataset containing 2 tables</returns>
    Function GetDataSet() As DataSet
        Dim dataSet = New DataSet

        dataSet.Tables.Add(GetDataTableOfElements())
        dataSet.Tables.Add(GetDataTableOfScientists())

        Return dataSet

    End Function

    ''' <summary>
    ''' Creates a data table of the periodic table of elements
    ''' </summary>
    ''' <returns>A data table of the periodic table of elements</returns>
    Function GetDataTableOfElements() As DataTable

        Dim periodicTable = New DataTable("PeriodicTable")
        Dim dr As DataRow

        periodicTable.Columns.Add("Name", GetType(String))
        periodicTable.Columns.Add("Symbol", GetType(String))
        periodicTable.Columns.Add("AtomicNumber", GetType(Integer))

        dr = periodicTable.Rows.Add()
        dr(0) = "Hydrogen"
        dr(1) = "H"
        dr(2) = "1"

        dr = periodicTable.Rows.Add()
        dr(0) = "Helium"
        dr(1) = "He"
        dr(2) = "2"

        dr = periodicTable.Rows.Add()
        dr(0) = "Lithium"
        dr(1) = "Li"
        dr(2) = "3"

        dr = periodicTable.Rows.Add()
        dr(0) = "Beryllium"
        dr(1) = "Be"
        dr(2) = "4"

        dr = periodicTable.Rows.Add()
        dr(0) = "Boron"
        dr(1) = "B"
        dr(2) = "5"

        dr = periodicTable.Rows.Add()
        dr(0) = "Carbon"
        dr(1) = "C"
        dr(2) = "6"

        Return periodicTable
    End Function

    ''' <summary>
    ''' Creates a data table of scientists
    ''' </summary>
    ''' <returns>A datatable of scientists</returns>
    ''' <remarks></remarks>
    Function GetDataTableOfScientists() As DataTable

        Dim scientistsTable = New DataTable("Scientists")
        Dim dr As DataRow

        scientistsTable.Columns.Add("Name", GetType(String))

        dr = scientistsTable.Rows.Add()
        dr(0) = "Antoine Lavoisier"

        dr = scientistsTable.Rows.Add()
        dr(0) = "Julius Lothar Meyer "

        dr = scientistsTable.Rows.Add()
        dr(0) = "Dmitri Ivanovich Mendeleev"

        Return scientistsTable

    End Function

End Module
