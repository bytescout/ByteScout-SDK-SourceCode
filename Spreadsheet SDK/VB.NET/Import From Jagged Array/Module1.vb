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
        Const fileName As String = "VBNetImportFromJaggedArray.xls"

        'Create a new spreadsheet
        Dim spreadsheet As Bytescout.Spreadsheet.Spreadsheet = New Bytescout.Spreadsheet.Spreadsheet

        'Get the data from the jagged array that we want to import
        Dim periodicTable()() As String = GetJaggedArray()

        'Import data into spreadheet
        spreadsheet.ImportFromJaggedArray(periodicTable)

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
    ''' Creates a jagged array of the period table of elements
    ''' </summary>
    ''' <returns>Jagged array of the periodic table of elements</returns>
    Function GetJaggedArray() As String()()

        Dim periodicTable()() As String = New String()() { _
            New String() {"H", "He"}, _
            New String() {"Li", "Be", "B", "C", "N", "O", "F", "Ne"}, _
            New String() {"Na", "Mg", "Al", "Si", "P", "S", "Cl", "Ar"}, _
            New String() {"K", "Ca", "Sc", "Ti", "V", "Cr", "Mn", "Fe", "Co", "Ni", "Cu", "Zn", "Ga", "Ge", "As", "Se", "Br", "Kr"}}

        Return periodicTable
    End Function

End Module
