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
        Const fileName As String = "VBNetImportFromList.xls"

        'Create a new spreadsheet
        Dim spreadsheet As Bytescout.Spreadsheet.Spreadsheet = New Bytescout.Spreadsheet.Spreadsheet

        'Get the data from the jagged array that we want to import
        Dim list As IList = GetList()

        'Import data into spreadheet
        spreadsheet.ImportFromList(list)

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
    ''' Creates a list of planets
    ''' </summary>
    ''' <returns>A list of planets</returns>
    ''' <remarks></remarks>
    Function GetList() As IList

        Dim planets(9, 1) As String

        planets(0, 0) = "Mercury"
        planets(1, 0) = "Venus"
        planets(2, 0) = "Earth"
        planets(3, 0) = "Mars"
        planets(4, 0) = "Jupiter"
        planets(5, 0) = "Saturn"
        planets(6, 0) = "Uranus"
        planets(7, 0) = "Neptune"
        planets(8, 0) = "Pluto"

        Return planets
    End Function

End Module
