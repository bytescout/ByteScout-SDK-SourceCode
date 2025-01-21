'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.IO

Module Module1

    Sub Main()
        Const fileName As String = "VBNetImportFromDataTable.xls"

        'Create a new spreadsheet
        Dim spreadsheet As Bytescout.Spreadsheet.Spreadsheet = New Bytescout.Spreadsheet.Spreadsheet

        'Get the data from the 2D array that we want to import
        Dim periodicTable As DataTable = GetDataTable()

        'Import data into spreadheet
        spreadsheet.ImportFromDataTable(periodicTable)

        'Insert row with column captions
        Dim worksheet As Worksheet = spreadsheet.Worksheets(0)
        worksheet.Rows.Insert(0)
        For colIndex As Integer = 0 To periodicTable.Columns.Count - 1
            worksheet.Cell(0, colIndex).Value = periodicTable.Columns(colIndex).Caption
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
    ''' Creates a data table of the periodic table of elements
    ''' </summary>
    ''' <returns>A data table of the periodic table of elements</returns>
    Function GetDataTable() As DataTable

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


End Module
