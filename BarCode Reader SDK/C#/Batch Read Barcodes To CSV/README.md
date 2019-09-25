## How to batch read barcodes to CSV in C# with ByteScout BarCode Reader SDK

### Write code in C# to batch read barcodes to CSV with this step-by-step tutorial

The sample source code below will teach you how to batch read barcodes to CSV in C#. Want to batch read barcodes to CSV in your C# app? ByteScout BarCode Reader SDK is designed for it. ByteScout BarCode Reader SDK is the SDK for barcode decoding. Can read all popular types from Code 128, GS1, UPC and Code 39 to QR Code, Datamatrix, PDF417. Images, pdf, TIF images and live web camera are supported as input. Designed to handle documents with noise and defects. Includes optional splitter and merger for pdf and tiff based on barcodes. Batch mode is optimized for high performance with multiple threads. Decoded values can be exported to XML, JSON, CSV or into custom data format.

Fast application programming interfaces of ByteScout BarCode Reader SDK for C# plus the instruction and the code below will help you quickly learn how to batch read barcodes to CSV. Just copy and paste the code into your C# application’s code and follow the instruction. You can use these C# sample examples in one or many applications.

Download free trial version of ByteScout BarCode Reader SDK from our website with this and other source code samples for C#.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20BarCode%20Reader%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20BarCode%20Reader%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=EARSPJFIJMU](https://www.youtube.com/watch?v=EARSPJFIJMU)




<!-- code block begin -->

##### ****ImagePDFBarcodeToCSV.NETCore.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp2.0</TargetFramework>
    <EnableDefaultCompileItems>false</EnableDefaultCompileItems>
    <GenerateAssemblyCompanyAttribute>false</GenerateAssemblyCompanyAttribute>
    <GenerateAssemblyConfigurationAttribute>false</GenerateAssemblyConfigurationAttribute>
    <GenerateAssemblyFileVersionAttribute>false</GenerateAssemblyFileVersionAttribute>
    <GenerateAssemblyInformationalVersionAttribute>false</GenerateAssemblyInformationalVersionAttribute>
    <GenerateAssemblyProductAttribute>false</GenerateAssemblyProductAttribute>
    <GenerateAssemblyTitleAttribute>false</GenerateAssemblyTitleAttribute>
    <GenerateAssemblyVersionAttribute>false</GenerateAssemblyVersionAttribute>
    <GenerateAssemblyCopyrightAttribute>false</GenerateAssemblyCopyrightAttribute>
    <GenerateAssemblyTrademarkAttribute>false</GenerateAssemblyTrademarkAttribute>
    <GenerateAssemblyCultureAttribute>false</GenerateAssemblyCultureAttribute>
    <GenerateAssemblyDescriptionAttribute>false</GenerateAssemblyDescriptionAttribute>
  </PropertyGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <None Include="BarcodeFiles\sample1.jpg">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="BarcodeFiles\sample2.png">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="BarcodeFiles\sample3.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <ItemGroup>
    <PackageReference Include="Microsoft.Windows.Compatibility" Version="2.0.0" />
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCodeReader">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout BarCode Reader SDK\netcoreapp2.0\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ImagePDFBarcodeToCSV.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{99735776-2956-463D-9795-EBCE16928C30}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>ImagePDFBarcodeToCSV</RootNamespace>
    <AssemblyName>ImagePDFBarcodeToCSV</AssemblyName>
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
    <Reference Include="Bytescout.BarCodeReader, Version=10.2.0.1799, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout BarCode Reader SDK\net2.00\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Drawing" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="BarcodeFiles\sample1.jpg">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="BarcodeFiles\sample2.png">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <None Include="BarcodeFiles\sample3.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.cs:**
    
```
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Bytescout.BarCodeReader;

namespace ImagePDFBarcodeToCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Read Barcode Process
                Reader reader = new Reader();
                reader.RegistrationKey = "demo";
                reader.RegistrationName = "demo";

                // Set Barcode type to find
                reader.BarcodeTypesToFind.All = true;

                // Output list
                List<CSVOutputFormat> lstCSVOutput = new List<CSVOutputFormat>();

                // Get all files in folder, and iterate through each file
                var files = System.IO.Directory.GetFiles("BarcodeFiles");
                foreach (var fileName in files)
                {
                    /* -----------------------------------------------------------------------
                    NOTE: We can read barcodes from specific page to increase performance .
                    For sample please refer to "Decoding barcodes from PDF by pages" program.
                    ----------------------------------------------------------------------- */

                    // Read barcodes
                    FoundBarcode[] barcodes = reader.ReadFrom(fileName);

                    foreach (FoundBarcode code in barcodes)
                    {
                        lstCSVOutput.Add(new CSVOutputFormat { barcodeValue = code.Value, barcodeType = code.Type.ToString(), scanDateTime = DateTime.Now.ToString(), fileName = fileName });
                    }
                }

                Console.WriteLine("Total {0} barcode found in {1} file.", lstCSVOutput.Count, files.Length);

                // cleanup
                reader.Dispose();

                // Export to CSV
                ExportToCsv(lstCSVOutput);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press enter key to exit...");
            Console.ReadLine();
        }

        /// <summary>
        /// Exports to CSV
        /// </summary>
        /// <param name="lstCSVOutput"></param>
        private static void ExportToCsv(List<CSVOutputFormat> lstCSVOutput)
        {
            System.Text.StringBuilder csvOutputContent = new System.Text.StringBuilder(string.Empty);

            csvOutputContent.Append("Barcode Value,Barcode Type,Scan DateTime,File Name");

            foreach (var item in lstCSVOutput)
            {
                csvOutputContent.AppendFormat("\r\n{0},{1},{2},{3}", item.barcodeValue, item.barcodeType, item.scanDateTime, item.fileName);
            }

            System.IO.File.WriteAllText("output.csv", csvOutputContent.ToString());

            Process.Start("output.csv");
        }
    }

    class CSVOutputFormat
    {
        public string barcodeValue { get; set; }
        public string barcodeType { get; set; }
        public string scanDateTime { get; set; }
        public string fileName { get; set; }
    }
}
```

<!-- code block end -->