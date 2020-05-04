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


Imports System.Drawing
Imports System.IO
Imports Bytescout.PDFExtractor
Imports Bytescout.Spreadsheet

Module Module1

    Sub Main()

        Dim allInputFiles As String() = {"Sample_Files\InvoiceMar.pdf", "Sample_Files\InvoiceApr.pdf"}
        Dim resultFileName = "output.xlsx"

        ' Set page index
        Dim pageIndex = 0

        ' Create output Spreadsheet
        Using document As New Spreadsheet()

            ' Add new worksheet
            Dim worksheet As Worksheet = document.Worksheets.Add("Invoices")

            Dim ws_row As Int32 = 0
            Dim ws_column As Int32 = 0

            ' Set Header value
            worksheet.Cell(ws_row, ws_column).Font = New Font("Arial", 11, FontStyle.Bold)
            worksheet.Cell(ws_row, ws_column).Value = "Invoice"
            ws_column += 1

            worksheet.Cell(ws_row, ws_column).Font = New Font("Arial", 11, FontStyle.Bold)
            worksheet.Cell(ws_row, ws_column).Value = "Product Name"
            ws_column += 1

            worksheet.Cell(ws_row, ws_column).Font = New Font("Arial", 11, FontStyle.Bold)
            worksheet.Cell(ws_row, ws_column).Value = "Price"
            ws_row += 1
            ws_column += 1

            ' Loop through all input files
            For Each itmFile In allInputFiles

                Dim invName = Path.GetFileNameWithoutExtension(itmFile)

                ' Create TextExtractor instance
                Using tableExtractor As New StructuredExtractor("demo", "demo")

                    Dim tableExtractionArea = GetTableExtractionArea(itmFile, pageIndex)
                    If tableExtractionArea.HasValue Then

                        ' Load document from file
                        tableExtractor.LoadDocumentFromFile(itmFile)

                        ' Set extraction area
                        tableExtractor.SetExtractionArea(tableExtractionArea)

                        ' Prepare table structure
                        tableExtractor.PrepareStructure(pageIndex)

                        Dim rowCount As Int32 = tableExtractor.GetRowCount(pageIndex)

                        ' Ignoring first title row
                        For row As Int32 = 1 To rowCount - 1

                            Dim columnCount As Int32 = tableExtractor.GetColumnCount(pageIndex, row)

                            ' Write Invoice Data
                            ws_column = 0
                            worksheet.Cell(ws_row, ws_column).Value = invName
                            ws_column += 1

                            For column As Int32 = 0 To columnCount - 1

                                ' Get table cell value
                                Dim tableCellValue = tableExtractor.GetCellValue(pageIndex, row, column)

                                ' Write to spreadsheet
                                worksheet.Cell(ws_row, ws_column).Value = tableCellValue
                                ws_column += 1
                            Next

                            ' Set row pointer to next row
                            ws_row += 1
                        Next

                    End If

                End Using

            Next

            ' Save document
            document.SaveAs(resultFileName, Constants.SpreadsheetFormatType.XLSX)

        End Using

        ' Open generated XLSX file in default program
        Process.Start(resultFileName)

    End Sub

    ''' <summary>
    ''' Gets table extraction area
    ''' </summary>
    Private Function GetTableExtractionArea(ByVal inputFile As String, ByVal Optional pageIndex As Int32 = 0) As Nullable(Of RectangleF)

        ' Create Bytescout.PDFExtractor.TableDetector instance
        Using tableDetector As New TableDetector("demo", "demo")

            ' Set table detection mode to "bordered tables" - best for tables with closed solid borders.
            tableDetector.ColumnDetectionMode = ColumnDetectionMode.BorderedTables

            ' We should define what kind of tables we should detect.
            ' So we set min required number of columns to 2 ...
            tableDetector.DetectionMinNumberOfColumns = 2
            ' ... And we set min required number of rows to 2
            tableDetector.DetectionMinNumberOfRows = 2

            tableDetector.LoadDocumentFromFile(inputFile)

            If Not tableDetector.FindTable(pageIndex) Then
                Return Nothing
            End If

            ' Getting first found table location
            Return tableDetector.FoundTableLocation

        End Using

    End Function

End Module
