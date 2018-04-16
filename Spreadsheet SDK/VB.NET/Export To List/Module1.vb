'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


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
