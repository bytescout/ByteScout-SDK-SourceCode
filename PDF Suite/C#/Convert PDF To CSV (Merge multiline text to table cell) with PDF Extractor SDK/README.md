## How to convert PDF to CSV (merge multiline text to table cell) with PDF extractor SDK in C# with ByteScout PDF Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to convert PDF to CSV (merge multiline text to table cell) with PDF extractor SDK in C#

These sample source codes on this page below are displaying how to convert PDF to CSV (merge multiline text to table cell) with PDF extractor SDK in C#. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can be applied to convert PDF to CSV (merge multiline text to table cell) with PDF extractor SDK using C#.

 These C# code samples for C# guide developers to speed up coding of the application when using ByteScout PDF Suite. This C# sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Check C# sample code samples to see if they respond to your needs and requirements for the project.

Our website gives trial version of ByteScout PDF Suite for free. It also includes documentation and source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Suite%20Question) 

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

##### ****ConsoleApplication1.NETCore.csproj:**
    
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
    <None Include="..\..\sample3_multiline.pdf" Link="sample3_multiline.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <ItemGroup>
    <PackageReference Include="Microsoft.Windows.Compatibility" Version="2.0.0" />
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDFExtractor">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF Extractor SDK\netcoreapp2.0\Bytescout.PDFExtractor.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.PDFExtractor.OCRExtension">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF Extractor SDK\netcoreapp2.0\Bytescout.PDFExtractor.OCRExtension.dll</HintPath>
    </Reference>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ConsoleApplication1.VS2005.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{5FD39006-92D8-4ACC-B2EB-A43ECBC67F99}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>ConsoleApplication1</RootNamespace>
    <AssemblyName>ConsoleApplication1</AssemblyName>
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
    <Reference Include="Bytescout.PDFExtractor, Version=1.10.0.73, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="..\..\sample3_multiline.pdf">
      <Link>sample3_multiline.pdf</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
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

##### ****ConsoleApplication1.VS2008.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="3.5">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.21022</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{5FD39006-92D8-4ACC-B2EB-A43ECBC67F99}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>ConsoleApplication1</RootNamespace>
    <AssemblyName>ConsoleApplication1</AssemblyName>
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
    <Reference Include="Bytescout.PDFExtractor, Version=1.10.0.73, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="..\..\sample3_multiline.pdf">
      <Link>sample3_multiline.pdf</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
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

##### ****ConsoleApplication1.VS2010.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{5FD39006-92D8-4ACC-B2EB-A43ECBC67F99}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>ConsoleApplication1</RootNamespace>
    <AssemblyName>ConsoleApplication1</AssemblyName>
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
    <Reference Include="Bytescout.PDFExtractor, Version=1.10.0.73, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="..\..\sample3_multiline.pdf">
      <Link>sample3_multiline.pdf</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
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

##### ****Program.cs:**
    
```
using System;
using System.Diagnostics;
using Bytescout.PDFExtractor;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.CSVExtractor instance
            CSVExtractor extractor = new CSVExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Load sample PDF document
            extractor.LoadDocumentFromFile("sample3_multiline.pdf");

            // you can change CSV separator symbol (if needed) from "," symbol to another if needed for non-US locales
            //extractor.CSVSeparatorSymbol = ",";

            // For multiline cell join extracted cell text into single line
            extractor.LineGroupingMode = LineGroupingMode.GroupByRows;
            extractor.Unwrap = true;

            // Save extracted CSV data
            extractor.SaveCSVToFile("output.csv");

            // Cleanup
            extractor.Dispose();

            Console.WriteLine();
            Console.WriteLine("Data has been extracted to 'output.csv' file.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue and open CSV in default CSV viewer (or Excel)...");
            Console.ReadKey();

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("output.csv");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}

```

<!-- code block end -->