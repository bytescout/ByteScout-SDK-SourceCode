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
