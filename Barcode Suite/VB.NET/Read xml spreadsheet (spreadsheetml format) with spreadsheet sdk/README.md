## How to read xml spreadsheet (spreadsheetml format) with spreadsheet sdk in VB.NET and ByteScout Barcode Suite

### Learn to code in VB.NET to read xml spreadsheet (spreadsheetml format) with spreadsheet sdk with this step-by-step tutorial

Every ByteScout tool includes simple example VB.NET source codes that you can get here or in the folder with installed ByteScout product. ByteScout Barcode Suite: the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can read xml spreadsheet (spreadsheetml format) with spreadsheet sdk in VB.NET.

The following code snippet for ByteScout Barcode Suite works best when you need to quickly read xml spreadsheet (spreadsheetml format) with spreadsheet sdk in your VB.NET application. This VB.NET sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Use of ByteScout Barcode Suite in VB.NET is also described in the documentation included along with the product.

Our website gives trial version of ByteScout Barcode Suite for free. It also includes documentation and source code samples.

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

##### ****Program.vb:**
    
```
Imports Bytescout.Spreadsheet

Module Program

    Sub Main()

        Try

            ' Convert SpreadhseetML (xml spreadsheet) to XLSX format
            Using spreadsheet As New Spreadsheet

                spreadsheet.RegistrationName = "demo"
                spreadsheet.RegistrationKey = "demo"

                ' Load input file
                spreadsheet.LoadFromFile("sample.xml")

                ' Generate XLSX format
                spreadsheet.SaveAsXLSX("sample.xlsx")
            End Using

            ' Read spreadsheet and display data to console
            Using spreadsheet As New Spreadsheet

                spreadsheet.RegistrationName = "demo"
                spreadsheet.RegistrationKey = "demo"

                ' Load input file
                spreadsheet.LoadFromFile("sample.xlsx")

                ' Reference Worksheet
                Dim Worksheet As Worksheet = spreadsheet.Worksheet(0)

                Console.WriteLine("=====================================================")
                Console.WriteLine("================ Spreadsheet data ===================")
                Console.WriteLine("=====================================================")

                ' Read And output cells to console.
                For row = Worksheet.UsedRangeRowMin To Worksheet.UsedRangeRowMax

                    For column = Worksheet.UsedRangeColumnMin To Worksheet.UsedRangeColumnMax

                        Console.Write("{0}" + vbTab, Worksheet.Cell(row, column).ValueAsString)

                    Next

                    Console.WriteLine()

                Next

            End Using


        Catch ex As Exception
            Console.WriteLine(("ERROR:" + ex.Message))
        End Try

        Console.WriteLine("Press any key to exit...")
        Console.ReadLine()

    End Sub

End Module

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ReadSpreadsheetMLFormat.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27703.2026
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "ReadSpreadsheetMLFormat", "ReadSpreadsheetMLFormat.vbproj", "{846F275E-BE99-4254-85ED-B8CBBB4546A9}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{846F275E-BE99-4254-85ED-B8CBBB4546A9}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{846F275E-BE99-4254-85ED-B8CBBB4546A9}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{846F275E-BE99-4254-85ED-B8CBBB4546A9}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{846F275E-BE99-4254-85ED-B8CBBB4546A9}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {1F0B11D3-6F1D-4CCE-91F9-5566ABC60672}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ReadSpreadsheetMLFormat.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{846F275E-BE99-4254-85ED-B8CBBB4546A9}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>ReadSpreadsheetMLFormat.Program</StartupObject>
    <RootNamespace>ReadSpreadsheetMLFormat</RootNamespace>
    <AssemblyName>ReadSpreadsheetMLFormat</AssemblyName>
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
    <DocumentationFile>ReadSpreadsheetMLFormat.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>ReadSpreadsheetMLFormat.xml</DocumentationFile>
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
  <ItemGroup>
    <None Include="sample.xml">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <ItemGroup>
    <Folder Include="My Project\" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->