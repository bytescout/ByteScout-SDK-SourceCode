## How to print multiple barcodes in VB.NET using ByteScout Barcode SDK ByteScout Barcode SDK is the robost library (Software Development Kit) that is designed for automatic generation of high-quality barcodes for printing, electronic documents and pdf. All popular barcode types are supported from Code 39 and Code 129 to QR Code, UPC, GS1, GS-128, Datamatrix, PDF417, Maxicode and many others. Provides support for full customization of fonts, colors, output and printing sizes. Special tools are included to verify output quality and printing quality. Can add generated barcode into new or existing documents, images and PDF.

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

##### **Module1.vb:**
    
```
Imports Bytescout.BarCode

' This example demonstrates generation and printing of multiple barcodes.

Module Module1

    Sub Main()

        ' Prepare Barcode object that will generate barcodes for printing
        Dim barcode = New Barcode()
        barcode.RegistrationName = "demo"
        barcode.RegistrationKey = "demo"
        barcode.Symbology = SymbologyType.EAN13
        barcode.DrawCaption = True
        barcode.BarHeight = 50
        barcode.DrawQuietZones = False
        barcode.Margins = New Margins(20, 20, 20, 20)

        ' Prepare BarcodePrinter object
        Dim barcodePrinter = New BarcodePrinter()
        ' Set printer paper size
        barcodePrinter.SetPaperSize("A4")
        ' Set number of barcodes on a page: 4 lines of 4 barcodes per line = 16 barcodes per page
        barcodePrinter.SetGrid(4, 4)
        ' Fit barcodes into the grid cell size
        barcodePrinter.FitBarcodesIntoGrid = True
        ' Set some optional printing params
        'barcodePrinter.SetMargins(20, 0, 0, 20)
        'barcodePrinter.Copies = 2
        'barcodePrinter.Collate = True
        'barcodePrinter.Color = False

        ' Generate 25 barcode values in EAN13 format "5901234NNNNN"
        ' and add them to the BarcodePrinter
        For i As Integer = 1 To 25
            Dim value = "5901234" + CStr(i).PadLeft(5, "0")
            barcodePrinter.AddBarcodeValue(value)
        Next

        ' Print barcodes to the specified printer 
        barcodePrinter.Print(barcode, "Microsoft Print to PDF")

    End Sub

End Module

```

<!-- code block end -->    

<!-- code block begin -->

##### **PrintBarcodes.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 16
VisualStudioVersion = 16.0.30611.23
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "PrintBarcodes", "PrintBarcodes.vbproj", "{C5923180-C9F5-4116-AF72-A9E40DB13F42}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{C5923180-C9F5-4116-AF72-A9E40DB13F42}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{C5923180-C9F5-4116-AF72-A9E40DB13F42}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{C5923180-C9F5-4116-AF72-A9E40DB13F42}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{C5923180-C9F5-4116-AF72-A9E40DB13F42}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {813788FE-237A-4F32-A8A2-74001A307463}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### **PrintBarcodes.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{C5923180-C9F5-4116-AF72-A9E40DB13F42}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>Sub Main</StartupObject>
    <RootNamespace>PrintBarcodes</RootNamespace>
    <AssemblyName>PrintBarcodes</AssemblyName>
    <MyType>Console</MyType>
    <OldToolsVersion>3.5</OldToolsVersion>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>PrintBarcodes.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>PrintBarcodes.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCode, Version=1.1.0.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout BarCode Generator SDK\net2.00\Bytescout.BarCode.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Folder Include="My Project\" />
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
    <Compile Include="Module1.vb" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
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