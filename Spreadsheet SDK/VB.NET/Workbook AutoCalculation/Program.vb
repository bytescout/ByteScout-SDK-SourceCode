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
Imports Bytescout.Spreadsheet

Module Program

    Sub Main()

        Try

            ' Data to be written in spreadsheet
            Dim lstProducts = New List(Of InvoiceProduct) From {
                New InvoiceProduct With {
                    .ProductName = "Product 1",
                    .Price = 30,
                    .Quantity = 10
                },
                New InvoiceProduct With {
                    .ProductName = "Product 2",
                    .Price = 40,
                    .Quantity = 30
                },
                New InvoiceProduct With {
                    .ProductName = "Product 3",
                    .Price = 50,
                    .Quantity = 15
                },
                New InvoiceProduct With {
                    .ProductName = "Product 4",
                    .Price = 20,
                    .Quantity = 20
                }
            }

            ' Generate Workbook in memory
            Dim document = _GetSpreadsheet(lstProducts)

            ' Export to XLSX
            document.SaveAsXLSX("Invoice.xlsx")
            'document.SaveAsXLS("Invoice.xls")

            ' Open output file
            Process.Start("Invoice.xlsx")

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine("Press enter key to exit...")
        Console.ReadLine()
    End Sub

    ''' <summary>
    ''' Get Spreadsheet
    ''' </summary>
    Private Function _GetSpreadsheet(ByVal lstProducts As List(Of InvoiceProduct)) As Spreadsheet

        ' Create new Spreadsheet
        Dim document As Spreadsheet = New Spreadsheet()

        ' Enable auto-calculation of formulas
        document.Workbook.AutoCalculation = True

        document.Workbook.DefaultFont = New SpreadsheetFont("Arial", 10)

        ' Add new worksheet
        Dim Sheet As Worksheet = document.Workbook.Worksheets.Add("Invoice")

        Dim startRow As Integer = 0

        ' Add Product Listing
        Dim startAddress As String = ""
        Dim endAddress As String = ""

        Sheet.Cell((startRow), 0).Value = "Item"
        _AddAllBorders(Sheet.Cell(startRow, 0))
        Sheet.Cell(startRow, 0).Font = New Font("Arial", 11, FontStyle.Bold)

        Sheet.Cell(startRow, 1).Value = "Quantity"
        _AddAllBorders(Sheet.Cell(startRow, 1))
        Sheet.Cell(startRow, 1).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right
        Sheet.Cell(startRow, 1).Font = New Font("Arial", 11, FontStyle.Bold)

        Sheet.Cell(startRow, 2).Value = "Price"
        _AddAllBorders(Sheet.Cell(startRow, 2))
        Sheet.Cell(startRow, 2).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right
        Sheet.Cell(startRow, 2).Font = New Font("Arial", 11, FontStyle.Bold)

        Sheet.Cell(startRow, 3).Value = "Total"
        _AddAllBorders(Sheet.Cell(startRow, 3))
        Sheet.Cell(startRow, 3).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right
        Sheet.Cell(startRow, 3).Font = New Font("Arial", 11, FontStyle.Bold)

        For i As Integer = 0 To lstProducts.Count - 1

            Sheet.Cell((System.Threading.Interlocked.Increment(startRow)), 0).Value = lstProducts(i).ProductName
            _AddAllBorders(Sheet.Cell(startRow, 0))

            Sheet.Cell(startRow, 1).Value = lstProducts(i).Quantity
            Sheet.Cell(startRow, 1).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right
            _AddAllBorders(Sheet.Cell(startRow, 1))

            Sheet.Cell(startRow, 2).Value = lstProducts(i).Price
            Sheet.Cell(startRow, 2).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right
            _AddAllBorders(Sheet.Cell(startRow, 2))

            ' Calculated cell
            Dim formulaMultiplication As String = String.Format("={0}*{1}", Sheet.Cell(startRow, 1).GetAddress().ToString(), Sheet.Cell(startRow, 2).GetAddress().ToString())
            Sheet.Cell(startRow, 3).Formula = formulaMultiplication
            Sheet.Cell(startRow, 3).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right
            _AddAllBorders(Sheet.Cell(startRow, 3))

            ' Address to be used for total sum
            If i = 0 Then
                startAddress = Sheet.Cell(startRow, 3).GetAddress().ToString()
            End If
            endAddress = Sheet.Cell(startRow, 3).GetAddress().ToString()

        Next

        Sheet.Cell((System.Threading.Interlocked.Increment(startRow)), 2).Value = "TOTAL"
        Sheet.Cell(startRow, 2).AlignmentHorizontal = Constants.AlignmentHorizontal.Right
        Sheet.Cell(startRow, 2).Font = New Font("Arial", 11, FontStyle.Bold)

        Dim formulaTotalSum As String = String.Format("=SUM({0}:{1})", startAddress, endAddress)
        Sheet.Cell(startRow, 3).Formula = formulaTotalSum
        Sheet.Cell(startRow, 3).Font = New Font("Arial", 11, FontStyle.Bold)
        Sheet.Cell(startRow, 3).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right

        ' AutoFit all columns
        Sheet.Columns.Item(0).AutoFit()
        Sheet.Columns.Item(1).AutoFit()
        Sheet.Columns.Item(2).AutoFit()
        Sheet.Columns.Item(3).AutoFit()

        ' Return all formatted document
        Return document

    End Function

    ''' <summary>
    ''' Add borders to cell
    ''' </summary>
    Private Sub _AddAllBorders(ByVal cell As Cell)
        cell.LeftBorderStyle = Bytescout.Spreadsheet.Constants.LineStyle.Thin
        cell.RightBorderStyle = Bytescout.Spreadsheet.Constants.LineStyle.Thin
        cell.TopBorderStyle = Bytescout.Spreadsheet.Constants.LineStyle.Thin
        cell.BottomBorderStyle = Bytescout.Spreadsheet.Constants.LineStyle.Thin
    End Sub

    Public Class InvoiceProduct
        Public Property ProductName As String
        Public Property Quantity As Integer
        Public Property Price As Decimal
    End Class

End Module
