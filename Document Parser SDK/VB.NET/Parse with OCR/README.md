## How to parse with OCR in VB.NET and ByteScout Document Parser SDK

### This code in VB.NET shows how to parse with OCR with this how to tutorial

We made thousands of pre-made source code pieces for easy implementation in your own programming projects. What is ByteScout Document Parser SDK? It is the robost offline data extraction platform for template based data extraction and processing. Supports high load with millions of documents as input. Templates can be quickly created and updated with no special technical knowledge required. It can help you to parse with OCR in your VB.NET application.

VB.NET code samples for VB.NET developers help to speed up coding of your application when using ByteScout Document Parser SDK. In order to implement the functionality, you should copy and paste this code for VB.NET below into your code editor with your app, compile and run your application. Enjoy writing a code with ready-to-use sample VB.NET codes.

Download free trial version of ByteScout Document Parser SDK from our website with this and other source code samples for VB.NET.

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

##### ****Module1.vb:**
    
```
Imports ByteScout.DocumentParser

' This example demonstrates parsing of scanned documents
' using the Optical Character Recognition (OCR).

Module Module1

    Sub Main()

        Dim template As String = ".\DigitalOcean.yml"
        Dim inputDocument As String = ".\DigitalOcean-scanned.jpg"

        ' Create and activate DocumentParser instance
        Using documentParser As New DocumentParser("demo", "demo")

            ' Enable Optical Character Recognition (OCR) in Auto mode
            ' (DocumentParser automatically detects if OCR Is required).
            documentParser.OCRMode = OCRMode.Auto

            ' Set PDF document rendering resolution
            documentParser.OCRResolution = 300

            ' Set the location of OCR language data files
            documentParser.OCRLanguageDataFolder = "c:\Program Files\ByteScout Document Parser SDK\ocrdata"

            ' Set OCR language
            ' "eng" for english, "deu" for German, "fra" for French, etc. - according to files in "ocrdata" folder
            documentParser.OCRLanguage = "eng"
            ' Find more language files at https://github.com/bytescout/ocrdata

            ' Note: The OCRLanguage can be overridden in a template. 
            ' See the Template Creation Guide.


            ' You can also apply various preprocessing filters
            ' to improve the recognition on low-quality scans.

            ' Automatically deskew skewed scans
            'documentParser.OCRImagePreprocessingFilters.AddDeskew()

            ' Remove vertical or horizontal lines (sometimes helps to avoid OCR engine's page segmentation errors)
            'documentParser.OCRImagePreprocessingFilters.AddVerticalLinesRemover()
            'documentParser.OCRImagePreprocessingFilters.AddHorizontalLinesRemover()

            ' Repair broken letters
            'documentParser.OCRImagePreprocessingFilters.AddDilate()

            ' Remove noise
            'documentParser.OCRImagePreprocessingFilters.AddMedian()

            ' Apply Gamma Correction
            'documentParser.OCRImagePreprocessingFilters.AddGammaCorrection(1.4)

            ' Add Contrast
            'documentParser.OCRImagePreprocessingFilters.AddContrast(20)

            ' Load template
            documentParser.AddTemplate(template)
                
            Console.WriteLine("Template loaded.")
            Console.WriteLine()

            Console.WriteLine($"Parsing ""{inputDocument}"" with OCR...")
            Console.WriteLine()


            ' Parse document data to JSON format
            Dim jsonString As String = documentParser.ParseDocument(inputDocument, OutputFormat.JSON)

            ' Display parsed data in console
            Console.WriteLine("Parsed data in JSON format:")
            Console.WriteLine()
            Console.WriteLine(jsonString)

        End Using

        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()

    End Sub

End Module

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ParseWithOCR.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 16
VisualStudioVersion = 16.0.28729.10
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "ParseWithOCR", "ParseWithOCR.vbproj", "{A5FA1293-C15B-4249-A771-ED4301658454}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{A5FA1293-C15B-4249-A771-ED4301658454}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{A5FA1293-C15B-4249-A771-ED4301658454}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{A5FA1293-C15B-4249-A771-ED4301658454}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{A5FA1293-C15B-4249-A771-ED4301658454}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {DCA85560-1523-40E0-917A-5BB3AA7E031F}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ParseWithOCR.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{A5FA1293-C15B-4249-A771-ED4301658454}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>ParseWithOCR.Module1</StartupObject>
    <RootNamespace>ParseWithOCR</RootNamespace>
    <AssemblyName>ParseWithOCR</AssemblyName>
    <FileAlignment>512</FileAlignment>
    <MyType>Console</MyType>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>ParseWithOCR.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>ParseWithOCR.xml</DocumentationFile>
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
    <Reference Include="ByteScout.DocumentParser, Version=1.0.0.100, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\ByteScout Document Parser SDK\net40\ByteScout.DocumentParser.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
  </ItemGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Collections" />
    <Import Include="System.Collections.Generic" />
    <Import Include="System.Data" />
    <Import Include="System.Diagnostics" />
    <Import Include="System.Linq" />
    <Import Include="System.Xml.Linq" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Module1.vb" />
  </ItemGroup>
  <ItemGroup>
    <None Include="..\..\_Sample Templates\DigitalOcean.yml">
      <Link>DigitalOcean.yml</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <ItemGroup>
    <Content Include="..\..\DigitalOcean-scanned.jpg">
      <Link>DigitalOcean-scanned.jpg</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->