## How to insert page break with spreadsheet sdk in VB.NET using ByteScout Data Extraction Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to insert page break with spreadsheet sdk in VB.NET

These sample source codes on this page below are displaying how to insert page break with spreadsheet sdk in VB.NET. ByteScout Data Extraction Suite can insert page break with spreadsheet sdk. It can be applied from VB.NET. ByteScout Data Extraction Suite is the set that includes 3 SDK products for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK.

The SDK samples given below describe how to quickly make your application do insert page break with spreadsheet sdk in VB.NET with the help of ByteScout Data Extraction Suite.  Simply copy and paste in your VB.NET project or application you and then run your app! If you want to use these VB.NET sample examples in one or many applications then they can be used easily.

You can download free trial version of ByteScout Data Extraction Suite from our website with this and other source code samples for VB.NET.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Data%20Extraction%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Data%20Extraction%20Suite%20Question) 

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

##### ****InsertPageBreak.VS2010.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{1382E1DC-D58E-453F-9857-81D7EF96015B}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>InsertPageBreak</RootNamespace>
    <AssemblyName>InsertPageBreak</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <FileUpgradeFlags />
    <OldToolsVersion>2.0</OldToolsVersion>
    <UpgradeBackupLocation />
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
  </PropertyGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.Spreadsheet, Version=1.0.0.0, Culture=neutral, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout Spreadsheet SDK\Bytescout.Spreadsheet.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.vb:**
    
```
Imports System.IO
Imports System.Diagnostics
Imports Bytescout.Spreadsheet
Imports Bytescout.Spreadsheet.Structures

Class Program
	Friend Shared Sub Main(args As String())
		' Create new Spreadsheet
		Dim document As New Spreadsheet()

		' Add new worksheet
		Dim worksheet As Worksheet = document.Workbook.Worksheets.Add("HelloWorld")

		' Set cell value
		worksheet.Cell(0, 0).Value = "Hello, World!"

		' Add horizontal page break
		worksheet.HPageBreaks.Add(New CellsRange("A10"))

		' Add vertical page break
		worksheet.VPageBreaks.Add(New CellsRange("F1"))

		' Save document
		document.SaveAs("Output.xls")

		' Close Spreadsheet
		document.Close()

		' Open generated XLS document in default associated application
		Process.Start("Output.xls")
	End Sub
End Class

```

<!-- code block end -->