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

Module Module1

    ' This example demonstrates the calculation of custom functions.
    Sub Main()

        ' Create Spreadsheet instance

        Dim spreadsheet As New Spreadsheet()
        spreadsheet.RegistrationName = "demo"
        spreadsheet.RegistrationKey = "demo"

        ' Add custom formula handler
        spreadsheet.CustomFunctionsCallback = AddressOf MyFunctions

        ' Load document
        spreadsheet.LoadFromFile("CustomFuncExample.xlsx")

        ' Calculate the first worksheet
        Dim worksheet = spreadsheet.Workbook.Worksheets(0)
        worksheet.Calculate()

        ' Save calculated values to neighbor cells to demonstrate custom functions are calculated
        worksheet("C2").Value = worksheet("B2").Value
        worksheet("C3").Value = worksheet("B3").Value
        worksheet("C4").Value = worksheet("B4").Value

        ' Save modified spreadsheet
        spreadsheet.SaveAs("result.xlsx")

        ' Cleanup
        spreadsheet.Dispose()

        ' Open saved spreadsheet in associated application (for demo purpose)
        Process.Start("result.xlsx")

    End Sub

    Private Function MyFunctions(ByVal sender As Worksheet, ByVal funcName As String, ByVal arguments As Object(), ByRef handled As Boolean) As Object

        ' Handle "CUSTOMFUNC_FACTORIAL" function
        If String.Compare(funcName, "CUSTOMFUNC_FACTORIAL", StringComparison.OrdinalIgnoreCase) = 0 Then

            handled = True

            ' Compute factorial
            If arguments.Length > 0 Then
                Dim value As Integer = arguments(0)

                If value = 0 Or value = 1 Then
                    Return 1
                End If

                Dim f As Integer = 1
                For i As Integer = 1 To value
                    f = f * i
                Next

                Return f
            End If

            Return Nothing

        End If

        ' Handle "CUSTOMFUNC_SUM" function
        If String.Compare(funcName, "CUSTOMFUNC_SUM", StringComparison.OrdinalIgnoreCase) = 0 Then

            handled = True

            ' Compute the sum of values
            If arguments.Length > 0 Then

                Dim sum As Double

                For Each o As Object In arguments
                    sum = sum + o
                Next

                Return sum

            End If

            Return Nothing

        End If

        Return Nothing

    End Function

End Module
