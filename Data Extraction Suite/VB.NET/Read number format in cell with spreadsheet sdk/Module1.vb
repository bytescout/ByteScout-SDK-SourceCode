'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.Spreadsheet
Imports Bytescout.Spreadsheet.Constants
Imports System.IO

Module Module1

    Sub Main()
        ' Create new Spreadsheet
        Dim document As New Spreadsheet()
document.LoadFromFile("Data.xls")

        ' Get worksheet by name
        Dim worksheet As Worksheet = document.Workbook.Worksheets.ByName("Sample")

        ' Check dates
        For i As Integer = 0 To 7
            For j As Integer = 0 To 1
                ' Set current cell
                Dim currentCell As Cell = worksheet.Cell(i, j)

                ' Get format type
                Dim formatType As NumberFormatType = currentCell.ValueDataTypeByNumberFormatString

                ' Write line
                Console.Write("Cell({0}:{1}) type is {2}. Value : ", i, j, formatType.ToString())

                Select Case formatType
                    Case formatType.DateTime
                        ' Read datetime
                        Dim datm As DateTime = currentCell.ValueAsDateTime

                        ' Write date to console output
                        Console.Write(datm.ToString())
                    Case formatType.General
                        ' Write value to console output
                        Console.Write(currentCell.Value)
                End Select

                Console.WriteLine()

            Next
        Next

        ' Close document
        document.Close()
        Console.ReadKey()

    End Sub

End Module
