## workbook autocalculation in VB.NET and ByteScout Spreadsheet SDK ByteScout Spreadsheet SDK: the library (SDK) that is capable of writing, reading, modifying and calculating Excel and CSV spreadsheets. Most popular formulas can be calculated and reculculated with Excel installed. You may import or export data to and from CSV, XML, JSON as well as to and from databases, arrays.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Spreadsheet%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Spreadsheet%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=nm_7I0PN1TY](https://www.youtube.com/watch?v=nm_7I0PN1TY)




<!-- code block begin -->

##### **Program.vb:**
    
```
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

```

<!-- code block end -->    

<!-- code block begin -->

##### **WorkbookAutoCalculation.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{846F275E-BE99-4254-85ED-B8CBBB4546A9}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>WorkbookAutoCalculation.Program</StartupObject>
    <RootNamespace>WorkbookAutoCalculation</RootNamespace>
    <AssemblyName>WorkbookAutoCalculation</AssemblyName>
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