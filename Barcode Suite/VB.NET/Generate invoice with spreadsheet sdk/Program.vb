'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Drawing
Imports Bytescout.Spreadsheet

Module Program

    Sub Main()

        Try

            ' STEP-1: Get Invoice Data
            Dim oInvoiceData = GetInvoiceData()

            ' STEP-2: Generate Invoice in memory
            Dim document = _GetSpreadsheet(oInvoiceData)

            ' Step-3: Export to XLS, XLSX and PDF
            document.SaveAsXLSX("Invoice.xlsx")
            document.SaveAsXLS("Invoice.xls")
            document.SaveAsPDF("Invoice.pdf")

            ' Open output file
            Process.Start("Invoice.xlsx")
            Process.Start("Invoice.pdf")

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine("Press enter key to exit...")
        Console.ReadLine()
    End Sub

    ''' <summary>
    ''' Get Spreadsheet
    ''' </summary>
    Private Function _GetSpreadsheet(ByVal oInvoiceData As InvoiceData) As Spreadsheet

        ' Create new Spreadsheet
        Dim document As Spreadsheet = New Spreadsheet()
        document.Workbook.AutoCalculation = True
        document.Workbook.DefaultFont = New SpreadsheetFont("Arial", 10)

        ' Add new worksheet
        Dim Sheet As Worksheet = document.Workbook.Worksheets.Add("Invoice")

        Dim startRow As Integer = 0

        ' 1. Write Company Name
        Sheet.Cell(startRow, 0).Value = oInvoiceData.CompanyName
        Sheet.Cell(startRow, 0).Font = New Font("Arial", 15, FontStyle.Bold Or FontStyle.Italic)

        ' 2. Write Company Address
        Sheet.Cell((System.Threading.Interlocked.Increment(startRow)), 0).Value = oInvoiceData.CompanyAddress1
        Sheet.Cell((System.Threading.Interlocked.Increment(startRow)), 0).Value = oInvoiceData.CompanyAddress2
        startRow += 1

        ' 3. Write Invoice Info
        Sheet.Cell((System.Threading.Interlocked.Increment(startRow)), 2).Value = "Invoice No."
        Sheet.Cell(startRow, 2).Font = New Font("Arial", 10, FontStyle.Bold)
        Sheet.Cell(startRow, 2).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right

        Sheet.Cell(startRow, 3).Value = oInvoiceData.InvoiceNo

        Sheet.Cell((System.Threading.Interlocked.Increment(startRow)), 2).Value = "Invoice Date."
        Sheet.Cell(startRow, 2).Font = New Font("Arial", 10, FontStyle.Bold)
        Sheet.Cell(startRow, 2).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right

        Sheet.Cell(startRow, 3).ValueAsDateTime = oInvoiceData.InvoiceDate
        Sheet.Cell(startRow, 3).NumberFormatString = "mm/dd/yyyy"

        ' 4. Write Client Info
        Sheet.Cell((System.Threading.Interlocked.Increment(startRow)), 0).Value = oInvoiceData.ClientName
        Sheet.Cell(startRow, 0).Font = New Font("Arial", 12, FontStyle.Bold)

        Sheet.Cell((System.Threading.Interlocked.Increment(startRow)), 0).Value = oInvoiceData.ClientAddress1
        Sheet.Cell((System.Threading.Interlocked.Increment(startRow)), 0).Value = oInvoiceData.ClientAddress2

        startRow += 1

        ' 5. Write Notes
        Sheet.Cell((System.Threading.Interlocked.Increment(startRow)), 0).Value = "Notes"
        Sheet.Cell(startRow, 0).Font = New Font("Arial", 12, FontStyle.Bold)
        Sheet.Cell((System.Threading.Interlocked.Increment(startRow)), 0).Value = oInvoiceData.Notes

        startRow += 2

        ' 6. Add Product Listing
        Dim startAddress As String = ""
        Dim endAddress As String = ""

        Sheet.Cell((System.Threading.Interlocked.Increment(startRow)), 0).Value = "Item"
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

        For i As Integer = 0 To oInvoiceData.lstProducts.Count - 1

            Sheet.Cell((System.Threading.Interlocked.Increment(startRow)), 0).Value = oInvoiceData.lstProducts(i).ProductName
            _AddAllBorders(Sheet.Cell(startRow, 0))

            Sheet.Cell(startRow, 1).Value = oInvoiceData.lstProducts(i).Quantity
            Sheet.Cell(startRow, 1).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right
            _AddAllBorders(Sheet.Cell(startRow, 1))

            Sheet.Cell(startRow, 2).Value = oInvoiceData.lstProducts(i).Price
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

    ''' <summary>
    ''' Gets Sample invoice data
    ''' </summary>
    Private Function GetInvoiceData() As InvoiceData
        Dim oRet = New InvoiceData With {
            .CompanyName = "Your Company Name",
            .CompanyAddress1 = "Your Address",
            .CompanyAddress2 = "City, State Zip",
            .ClientName = "Client Name",
            .ClientAddress1 = "Address",
            .ClientAddress2 = "City, State Zip",
            .InvoiceNo = "123456",
            .InvoiceDate = DateTime.Now,
            .Notes = "Some notes...",
            .lstProducts = New List(Of InvoiceProduct) From {
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
        }
        Return oRet
    End Function

#Region "Invoice Class"

    Public Class InvoiceData
        Public Sub New()
            lstProducts = New List(Of InvoiceProduct)()
        End Sub

        Public Property CompanyName As String
        Public Property CompanyAddress1 As String
        Public Property CompanyAddress2 As String
        Public Property InvoiceNo As String
        Public Property InvoiceDate As DateTime
        Public Property ClientName As String
        Public Property ClientAddress1 As String
        Public Property ClientAddress2 As String
        Public Property Notes As String
        Public Property lstProducts As List(Of InvoiceProduct)
    End Class

    Public Class InvoiceProduct
        Public Property ProductName As String
        Public Property Quantity As Integer
        Public Property Price As Decimal
    End Class


#End Region


End Module
