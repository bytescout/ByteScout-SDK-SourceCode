## How to print multiple barcodes in C# and ByteScout Barcode SDK ByteScout Barcode SDK is the robost SDK that generates high quality barcode images and pdf. Can generate all popular types of barcodes from QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix to more exotic barcode types. Fully customizable fonts, colors, print sizes. Includes special functions to ensure output quality, and tools for adding barcodes to new or existing pdf files and images.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore Documentation](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Explore Source Code Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://app.pdf.co/signup?utm_source=github-readme)
[Security](https://pdf.co/security)
[Explore Web API Documentation](https://apidocs.pdf.co?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=REnj3A-oSPI](https://www.youtube.com/watch?v=REnj3A-oSPI)




<!-- code block begin -->

##### **PrintBarcodes.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{A657F388-7D2A-4C05-9E04-6F6FAFF16F0C}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>PrintBarcodes</RootNamespace>
    <AssemblyName>PrintBarcodes</AssemblyName>
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
    <Reference Include="Bytescout.BarCode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout BarCode Generator SDK\net4.00\Bytescout.BarCode.dll</HintPath>
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

##### **PrintBarcodes.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 16
VisualStudioVersion = 16.0.30611.23
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "PrintBarcodes", "PrintBarcodes.csproj", "{A657F388-7D2A-4C05-9E04-6F6FAFF16F0C}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{A657F388-7D2A-4C05-9E04-6F6FAFF16F0C}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{A657F388-7D2A-4C05-9E04-6F6FAFF16F0C}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{A657F388-7D2A-4C05-9E04-6F6FAFF16F0C}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{A657F388-7D2A-4C05-9E04-6F6FAFF16F0C}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {601CF642-67ED-4BEF-94E4-140EA7FDF239}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### **Program.cs:**
    
```
using System.Linq;
using Bytescout.BarCode;

namespace PrintBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prepare Barcode object that will generate barcodes for printing
            var barcode = new Barcode();
            barcode.RegistrationName = "demo";
            barcode.RegistrationKey = "demo";
            barcode.Symbology = SymbologyType.EAN13;
            barcode.DrawCaption = true;
            barcode.BarHeight = 50;
            barcode.DrawQuietZones = false;
            barcode.Margins = new Margins(20, 20, 20, 20);

            // Prepare BarcodePrinter object
            var barcodePrinter = new BarcodePrinter();
            // Set printer paper size
            barcodePrinter.SetPaperSize("A4");
            // Set number of barcodes on a page: 4 lines of 4 barcodes per line = 16 barcodes per page
            barcodePrinter.SetGrid(4, 4);
            // Fit barcodes into the grid cell size
            barcodePrinter.FitBarcodesIntoGrid = true;
            // Set some optional printing params
            //barcodePrinter.SetMargins(20, 0, 0, 20);
            //barcodePrinter.Copies = 2;
            //barcodePrinter.Collate = true;
            //barcodePrinter.Color = false;

            // Generate 25 barcode values in EAN13 format "5901234NNNNN"
            // and add them to the BarcodePrinter
            var barcodeValues = Enumerable.Range(1, 25).Select(n => "5901234" + n.ToString("00000")).ToList();
            barcodePrinter.AddBarcodeValues(barcodeValues);

            // Print barcodes to the specified printer 
            barcodePrinter.Print(barcode, "Microsoft Print to PDF");
        }
    }
}

```

<!-- code block end -->