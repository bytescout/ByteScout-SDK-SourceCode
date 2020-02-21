## workbook autocalculation in C# and ByteScout Spreadsheet SDK ByteScout Spreadsheet SDK is the library (SDK) that is capable of writing, reading, modifying and calculating Excel and CSV spreadsheets. Most popular formulas can be calculated and reculculated with Excel installed. You may import or export data to and from CSV, XML, JSON as well as to and from databases, arrays.

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

##### **Program.cs:**
    
```
using Bytescout.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace WorkbookAutoCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Data to be written in spreadsheet
                var lstProducts = new List<InvoiceProduct> {
                    new InvoiceProduct{ ProductName = "Product 1", Price = 30, Quantity = 10 },
                    new InvoiceProduct{ ProductName = "Product 2", Price = 40, Quantity = 30 },
                    new InvoiceProduct{ ProductName = "Product 3", Price = 50, Quantity = 15 },
                    new InvoiceProduct{ ProductName = "Product 4", Price = 20, Quantity = 20 }
                };

                // Generate Workbook in memory
                var document = _GetSpreadsheet(lstProducts);

                // Export to XLSX
                document.SaveAsXLSX("Invoice.xlsx");
                //document.SaveAsXLS("Invoice.xls");

                // Open output file
                Process.Start("Invoice.xlsx");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press enter key to exit...");
            Console.ReadLine();
        }

        /// <summary>
        /// Get Spreadsheet
        /// </summary>
        private static Spreadsheet _GetSpreadsheet(List<InvoiceProduct> lstProducts)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();

            // Enable auto-calculation of formulas
            document.Workbook.AutoCalculation = true;

            document.Workbook.DefaultFont = new SpreadsheetFont("Arial", 10);

            // Add new worksheet
            Worksheet Sheet = document.Workbook.Worksheets.Add("Invoice");

            int startRow = 0;

            // Add Product Listing
            string startAddress = "";
            string endAddress = "";

            Sheet.Cell((startRow), 0).Value = "Item";
            _AddAllBorders(Sheet.Cell(startRow, 0));
            Sheet.Cell(startRow, 0).Font = new Font("Arial", 11, FontStyle.Bold);

            Sheet.Cell(startRow, 1).Value = "Quantity";
            _AddAllBorders(Sheet.Cell(startRow, 1));
            Sheet.Cell(startRow, 1).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right;
            Sheet.Cell(startRow, 1).Font = new Font("Arial", 11, FontStyle.Bold);

            Sheet.Cell(startRow, 2).Value = "Price";
            _AddAllBorders(Sheet.Cell(startRow, 2));
            Sheet.Cell(startRow, 2).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right;
            Sheet.Cell(startRow, 2).Font = new Font("Arial", 11, FontStyle.Bold);

            Sheet.Cell(startRow, 3).Value = "Total";
            _AddAllBorders(Sheet.Cell(startRow, 3));
            Sheet.Cell(startRow, 3).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right;
            Sheet.Cell(startRow, 3).Font = new Font("Arial", 11, FontStyle.Bold);


            for (int i = 0; i < lstProducts.Count; i++)
            {
                Sheet.Cell((++startRow), 0).Value = lstProducts[i].ProductName;
                _AddAllBorders(Sheet.Cell(startRow, 0));

                Sheet.Cell(startRow, 1).Value = lstProducts[i].Quantity;
                Sheet.Cell(startRow, 1).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right;
                _AddAllBorders(Sheet.Cell(startRow, 1));

                Sheet.Cell(startRow, 2).Value = lstProducts[i].Price;
                Sheet.Cell(startRow, 2).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right;
                _AddAllBorders(Sheet.Cell(startRow, 2));

                // Calculated cell
                string formulaMultiplication = string.Format("={0}*{1}", Sheet.Cell(startRow, 1).GetAddress().ToString(), Sheet.Cell(startRow, 2).GetAddress().ToString());
                Sheet.Cell(startRow, 3).Formula = formulaMultiplication;
                Sheet.Cell(startRow, 3).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right;
                _AddAllBorders(Sheet.Cell(startRow, 3));

                // Address to be used for total sum
                if (i == 0)
                {
                    startAddress = Sheet.Cell(startRow, 3).GetAddress().ToString();
                }
                endAddress = Sheet.Cell(startRow, 3).GetAddress().ToString();
            }

            Sheet.Cell((++startRow), 2).Value = "TOTAL";
            Sheet.Cell(startRow, 2).Font = new Font("Arial", 11, FontStyle.Bold);
            Sheet.Cell(startRow, 2).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right;

            string formulaTotalSum = string.Format("=SUM({0}:{1})", startAddress, endAddress);
            Sheet.Cell(startRow, 3).Formula = formulaTotalSum;
            Sheet.Cell(startRow, 3).Font = new Font("Arial", 11, FontStyle.Bold);
            Sheet.Cell(startRow, 3).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right;

            // AutoFit all columns
            Sheet.Columns[0].AutoFit();
            Sheet.Columns[1].AutoFit();
            Sheet.Columns[2].AutoFit();
            Sheet.Columns[3].AutoFit();

            // Return all formatted document
            return document;
        }

        /// <summary>
        /// Add borders to cell
        /// </summary>
        private static void _AddAllBorders(Cell cell)
        {
            cell.LeftBorderStyle = Bytescout.Spreadsheet.Constants.LineStyle.Thin;
            cell.RightBorderStyle = Bytescout.Spreadsheet.Constants.LineStyle.Thin;
            cell.TopBorderStyle = Bytescout.Spreadsheet.Constants.LineStyle.Thin;
            cell.BottomBorderStyle = Bytescout.Spreadsheet.Constants.LineStyle.Thin;
        }

    }


    /// <summary>
    /// Invoice Product class
    /// </summary>
    public class InvoiceProduct
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

}

```

<!-- code block end -->    

<!-- code block begin -->

##### **WorkbookAutoCalculation.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{99735776-2956-463D-9795-EBCE16928C30}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>WorkbookAutoCalculation</RootNamespace>
    <AssemblyName>WorkbookAutoCalculation</AssemblyName>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.Spreadsheet, Version=3.1.0.1715, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout Spreadsheet SDK\net2.00\Bytescout.Spreadsheet.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->