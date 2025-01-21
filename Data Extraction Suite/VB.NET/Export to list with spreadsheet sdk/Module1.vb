'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Module Module1

    Sub Main()
        Dim inputFile As String = "ListOfPlanetsSpreadsheet.xls"
        
        'Open and load spreadsheet
        Dim spreadsheet As Spreadsheet = New Spreadsheet()
        spreadsheet.LoadFromFile(inputFile)

        'Get the data from the spreadsheet
        Dim planets(10, 2) As String
        spreadsheet.ExportToList(planets)

        'Close spreadsheet
        spreadsheet.Close()

        'Display array
        Dim planetsArray(,) As String = planets
        For i As Integer = 0 To planetsArray.GetLength(0) - 1
            For j As Integer = 0 To planets.GetLength(1) - 1
                Console.Write(planetsArray(i, j) + " ")
            Next
            Console.WriteLine()
        Next

        'Pause
        Console.ReadLine()
        
    End Sub

End Module
