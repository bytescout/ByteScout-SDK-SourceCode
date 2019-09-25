## How to convert xls to xml and xml to xls with spreadsheet sdk in C# and ByteScout Barcode Suite

### This code in C# shows how to convert xls to xml and xml to xls with spreadsheet sdk with this how to tutorial

Every ByteScout tool includes simple example C# source codes that you can get here or in the folder with installed ByteScout product. Want to convert xls to xml and xml to xls with spreadsheet sdk in your C# app? ByteScout Barcode Suite is designed for it. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK.

Want to save time? You will save a lot of time on writing and testing code as you may just take the C# code from ByteScout Barcode Suite for convert xls to xml and xml to xls with spreadsheet sdk below and use it in your application. This C# sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Complete and detailed tutorials and documentation are available along with installed ByteScout Barcode Suite if you'd like to learn more about the topic and the details of the API.

The trial version of ByteScout Barcode Suite can be downloaded for free from our website. It also includes source code samples for C# and other programming languages.

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

##### ****Bytescout.XLS.Utils.SimpleXMLConverter.cs:**
    
```
using System;
using System.Data;
using System.IO;
using Bytescout.Spreadsheet;

namespace Bytescout.Spreadsheet.Utils
{
    /// <summary>
    /// class for simple XLS to XML and XML to XLS conversion
    /// </summary>
    public class SimpleXMLConverter
    {
        private readonly Spreadsheet document;

        public SimpleXMLConverter(Spreadsheet document)
        {
            this.document = document;
        }

        public void LoadXML(string path)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(path);

            foreach (DataTable table in dataSet.Tables)
            {
                Worksheet worksheet = document.Workbook.Worksheets.Add(table.TableName);

                // Add columns
                worksheet.Columns.Insert(0, table.Columns.Count);

                /*// Add row for header
                worksheet.Rows.Insert(0);

                // Fill headers
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    worksheet.Cell(1, i).Value = table.Columns[i].ColumnName;
                }*/

                // Add rows for data
                worksheet.Rows.Insert(0, table.Rows.Count);

                // Fill data
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        worksheet.Cell(i + 1, j).Value = table.Rows[i][j].ToString();
                    }
                }
            }
        }

        public void SaveXML(string path)
        {
            DataSet dataSet = new DataSet();

            for (int i = 0; i < document.Workbook.Worksheets.Count; i++)
            {
                Worksheet worksheet = document.Workbook.Worksheets[i];

                DataTable table = dataSet.Tables.Add(worksheet.Name);

                #region Add Columns

                for (int column = 0; column <= worksheet.UsedRangeColumnMax; column++)
                {
                    table.Columns.Add(
                        string.Format("Column_{0}", column));
                }

                #endregion

                #region Add rows

                for (int row = 0; row <= worksheet.UsedRangeRowMax; row++)
                {
                    object[] data = new object[worksheet.UsedRangeColumnMax + 1];

                    for (int column = 0; column <= worksheet.UsedRangeColumnMax; column++)
                    {
                        if (worksheet.Cell(row, column).Value != null &&
                            worksheet.Cell(row, column).Value.ToString().Trim() == "")
                            data[column] = null;
                        else
                            data[column] = worksheet.Cell(row, column).Value;
                    }

                    table.Rows.Add(data);
                }

                #endregion
            }

            dataSet.WriteXml(path);
        }

        private void PrintDataSet(DataSet ds)
        {
            Console.WriteLine("DataSet name: {0}", ds.DataSetName);
            foreach (DataTable table in ds.Tables)
            {
                int rowCount = table.Rows.Count;
                int columnCount = table.Columns.Count;

                Console.WriteLine("\nTable: {0} ({1} rows)", table.TableName, rowCount);
                foreach (DataColumn column in table.Columns)
                {
                    Console.Write("{0}\t", column.ColumnName);
                }
                Console.WriteLine();

                for (int i = 0; i < rowCount; i++)
                {
                    for (int column = 0; column < columnCount; column++)
                    {
                        Console.Write("{0}\t", table.Rows[i][column]);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.cs:**
    
```
using System;
using System.Data;
using System.IO;
using Bytescout.Spreadsheet;
using Bytescout.Spreadsheet.Utils;
using System.Diagnostics;

namespace SimpleXMLConverterSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // sample XLS to XML conversion
            SampleXLStoXMLConversion();
            // sample XML to XLS conversion
            SampleXMLtoXLSConversion();
        }

        /// <summary>
        /// shows how to convert existing XLS (Excel) document into XML using Bytescout.Spreadsheet and Bytescout.Spreadsheet.Utils.SimpleXMLConverter
        /// </summary>
        private static void SampleXLStoXMLConversion(){
            Spreadsheet document;

            // read XLS and save as XML
            document = new Spreadsheet();
	document.LoadFromFile("AdvancedReport.xls");
            SimpleXMLConverter tools = new SimpleXMLConverter(document);
            tools.SaveXML("AdvancedReport.xml");
            document.Close();
        }

        /// <summary>
        /// shows how to convert XML data into XLS excel using Bytescout.Spreadsheet and Bytescout.Spreadsheet.Utils.SimpleXMLConverter
        /// </summary>
        private static void SampleXMLtoXLSConversion()
        {
            // read XML and convert into XLS (Excel) and save

            Spreadsheet document = new Spreadsheet();

            SimpleXMLConverter tools = new SimpleXMLConverter(document);

            tools.LoadXML("AdvancedReport.xml");

            // delete output file if exists already
            if (File.Exists("Output.xls")){
                File.Delete("Output.xls");
            }

            // Save document
            document.SaveAs("Output.xls");

            // Close Spreadsheet
            document.Close();

            // open generated XLS document in default program
            Process.Start("Output.xls");

        }
    }

}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****XLSXMLTools.VS2005.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{0223318B-7FC5-4003-842F-E2B7B9289D89}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>XLSXMLTools</RootNamespace>
    <AssemblyName>XLSXMLTools</AssemblyName>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.Spreadsheet, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="AdvancedReport.xls">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Bytescout.XLS.Utils.SimpleXMLConverter.cs" />
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.CSharp.targets" />
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name="BeforeBuild">
  </Target>
  <Target Name="AfterBuild">
  </Target>
  -->
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****XLSXMLTools.VS2008.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="3.5">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.21022</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{0223318B-7FC5-4003-842F-E2B7B9289D89}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>XLSXMLTools</RootNamespace>
    <AssemblyName>XLSXMLTools</AssemblyName>
    <OldToolsVersion>2.0</OldToolsVersion>
    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.Spreadsheet, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="AdvancedReport.xls">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Bytescout.XLS.Utils.SimpleXMLConverter.cs" />
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name="BeforeBuild">
  </Target>
  <Target Name="AfterBuild">
  </Target>
  -->
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****XLSXMLTools.VS2010.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{0223318B-7FC5-4003-842F-E2B7B9289D89}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>XLSXMLTools</RootNamespace>
    <AssemblyName>XLSXMLTools</AssemblyName>
    <OldToolsVersion>3.5</OldToolsVersion>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.Spreadsheet, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="AdvancedReport.xls">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Bytescout.XLS.Utils.SimpleXMLConverter.cs" />
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name="BeforeBuild">
  </Target>
  <Target Name="AfterBuild">
  </Target>
  -->
</Project>
```

<!-- code block end -->