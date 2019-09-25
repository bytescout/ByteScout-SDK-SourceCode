## How to parse with OCR in C# with ByteScout Document Parser SDK

### The tutorial below will demonstrate how to parse with OCR in C#

On this page you will learn from code samples for programming in C#.Writing of the code to parse with OCR in C# can be done by developers of any level using ByteScout Document Parser SDK. What is ByteScout Document Parser SDK? It is the robost offline data extraction platform for template based data extraction and processing. Supports high load with millions of documents as input. Templates can be quickly created and updated with no special technical knowledge required. It can help you to parse with OCR in your C# application.

The SDK samples like this one below explain how to quickly make your application do parse with OCR in C# with the help of ByteScout Document Parser SDK. In order to implement the functionality, you should copy and paste this code for C# below into your code editor with your app, compile and run your application. Detailed tutorials and documentation are available along with installed ByteScout Document Parser SDK if you'd like to dive deeper into the topic and the details of the API.

You can download free trial version of ByteScout Document Parser SDK from our website to see and try many others source code samples for C#.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Document%20Parser%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Document%20Parser%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=MG5FfTWWSVE](https://www.youtube.com/watch?v=MG5FfTWWSVE)




<!-- code block begin -->

##### ****ParseWithOCR.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{A73776C6-D2B2-4E37-B852-06C6454D1B5B}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>ParseWithOCR</RootNamespace>
    <AssemblyName>ParseWithOCR</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
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
    <Reference Include="ByteScout.DocumentParser, Version=1.0.0.100, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\ByteScout Document Parser SDK\net40\ByteScout.DocumentParser.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="..\..\DigitalOcean-scanned.jpg">
      <Link>DigitalOcean-scanned.jpg</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <None Include="..\..\_Sample Templates\DigitalOcean.yml">
      <Link>DigitalOcean.yml</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ParseWithOCR.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 16
VisualStudioVersion = 16.0.28729.10
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "ParseWithOCR", "ParseWithOCR.csproj", "{A73776C6-D2B2-4E37-B852-06C6454D1B5B}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{A73776C6-D2B2-4E37-B852-06C6454D1B5B}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{A73776C6-D2B2-4E37-B852-06C6454D1B5B}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{A73776C6-D2B2-4E37-B852-06C6454D1B5B}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{A73776C6-D2B2-4E37-B852-06C6454D1B5B}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {7E6DAA79-020B-421A-844A-5FE05EFC9B15}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.cs:**
    
```
using System;
using ByteScout.DocumentParser;

// This example demonstrates parsing of scanned documents
// using the Optical Character Recognition (OCR).

namespace GeneralExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string template = @".\DigitalOcean.yml";
            string inputDocument = @".\DigitalOcean-scanned.jpg";

            // Create and activate DocumentParser instance
            using (DocumentParser documentParser = new DocumentParser("demo", "demo"))
            {
                // Enable Optical Character Recognition (OCR) in Auto mode
                // (DocumentParser automatically detects if OCR is required).
                documentParser.OCRMode = OCRMode.Auto;

                // Set PDF document rendering resolution
                documentParser.OCRResolution = 300;

                // Set the location of OCR language data files
                documentParser.OCRLanguageDataFolder = @"c:\Program Files\ByteScout Document Parser SDK\ocrdata";

                // Set OCR language
                // "eng" for english, "deu" for German, "fra" for French, etc. - according to files in "ocrdata" folder
                documentParser.OCRLanguage = "eng";
                // Find more language files at https://github.com/bytescout/ocrdata

                // Note: The OCRLanguage can be overridden in a template. 
                // See the Template Creation Guide.

                
                
                // You can also apply various preprocessing filters
                // to improve the recognition on low-quality scans.

                // Automatically deskew skewed scans
                //documentParser.OCRImagePreprocessingFilters.AddDeskew();

                // Remove vertical or horizontal lines (sometimes helps to avoid OCR engine's page segmentation errors)
                //documentParser.OCRImagePreprocessingFilters.AddVerticalLinesRemover();
                //documentParser.OCRImagePreprocessingFilters.AddHorizontalLinesRemover();

                // Repair broken letters
                //documentParser.OCRImagePreprocessingFilters.AddDilate();

                // Remove noise
                //documentParser.OCRImagePreprocessingFilters.AddMedian();

                // Apply Gamma Correction
                //documentParser.OCRImagePreprocessingFilters.AddGammaCorrection(1.4);

                // Add Contrast
                //documentParser.OCRImagePreprocessingFilters.AddContrast(20);


                // Load template
                documentParser.AddTemplate(template);

                Console.WriteLine("Template loaded.");
                Console.WriteLine();

                Console.WriteLine($"Parsing \"{inputDocument}\" with OCR...");
                Console.WriteLine();

                // Parse document data to JSON format
                string jsonString = documentParser.ParseDocument(inputDocument, OutputFormat.JSON);

                // Display parsed data in console
                Console.WriteLine("Parsed data in JSON format:");
                Console.WriteLine();
                Console.WriteLine(jsonString);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}

```

<!-- code block end -->