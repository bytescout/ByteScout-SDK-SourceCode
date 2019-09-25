## How to generate invoice with spreadsheet sdk in VB.NET with ByteScout Barcode Suite

### How to write a robust code in VB.NET to generate invoice with spreadsheet sdk with this step-by-step tutorial

ByteScout simple and easy to understand tutorials are planned to describe the code for both VB.NET beginners and advanced programmers. What is ByteScout Barcode Suite? It is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can help you to generate invoice with spreadsheet sdk in your VB.NET application.

 These VB.NET code samples for VB.NET guide developers to speed up coding of the application when using ByteScout Barcode Suite.  Simply copy and paste in your VB.NET project or application you and then run your app! This basic programming language sample code for VB.NET will do the whole work for you to generate invoice with spreadsheet sdk.

Our website gives trial version of ByteScout Barcode Suite for free. It also includes documentation and source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20Suite%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****GenerateInvoice.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{846F275E-BE99-4254-85ED-B8CBBB4546A9}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>GenerateInvoice.Program</StartupObject>
    <RootNamespace>GenerateInvoice</RootNamespace>
    <AssemblyName>GenerateInvoice</AssemblyName>
    <FileAlignment>512</FileAlignment>
    <MyType>Console</MyType>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup>
    <OptionExplicit>On</OptionExplicit>
  </PropertyGroup>
  <PropertyGroup>
    <OptionCompare>Binary</OptionCompare>
  </PropertyGroup>
  <PropertyGroup>
    <OptionStrict>Off</OptionStrict>
  </PropertyGroup>
  <PropertyGroup>
    <OptionInfer>On</OptionInfer>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.Spreadsheet, Version=3.1.0.1715, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout Spreadsheet SDK\net2.00\Bytescout.Spreadsheet.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Collections" />
    <Import Include="System.Collections.Generic" />
    <Import Include="System.Data" />
    <Import Include="System.Diagnostics" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.vb" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.vb:**
    
```
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

```

<!-- code block end -->