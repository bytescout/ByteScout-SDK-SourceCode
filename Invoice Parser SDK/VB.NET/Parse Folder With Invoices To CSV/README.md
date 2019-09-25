## How to parse folder with invoices to CSV in VB.NET and ByteScout Invoice Parser SDK

### Write code in VB.NET to parse folder with invoices to CSV with this step-by-step tutorial

Parse folder with invoices to CSV is easy to implement in VB.NET if you use these source codes below. What is ByteScout Invoice Parser SDK? It is the invoices processor engine that comes with built-in support for invoices from thousands of companies. Automatically detects company that issued invoice, extracts invoice number, date, total amount to be paid. Constantly updated to support invoices from new companies. Supports batch processing of invoices with JSON, CSV, XML output. It can help you to parse folder with invoices to CSV in your VB.NET application.

This code snippet below for ByteScout Invoice Parser SDK works best when you need to quickly parse folder with invoices to CSV in your VB.NET application. This VB.NET sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Implementing VB.NET application typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

Free trial version of ByteScout Invoice Parser SDK is available on our website. Documentation and source code samples are included.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Invoice%20Parser%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Invoice%20Parser%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=nVANfuA4Xh0](https://www.youtube.com/watch?v=nVANfuA4Xh0)




<!-- code block begin -->

##### ****Module1.vb:**
    
```
Imports System.Text
Imports ByteScout.InvoiceParser

Module Module1

    Sub Main()

        Dim inputFolder As String = ".\invoices"
        Dim outputFile As String = ".\result.csv"

        ' Create InvoiceParser instance
        Using parser As InvoiceParser = New InvoiceParser("demo", "demo")

            ' Setup CSV output
            Dim csvOptions As CSVOptions = New CSVOptions()
            csvOptions.Encoding = Encoding.UTF8
            csvOptions.SeparatorCharacter = ","
            csvOptions.QuotationCharacter = """"
            csvOptions.UnwrapMultilineValues = True

            ' Parse all document in input folder and save results to CSV file
            BatchProcessing.ParseFolderToCSV(parser, inputFolder, outputFile, csvOptions, AddressOf ProcessingCallback)

        End Using

        ' Open generated CSV file in default associated application (for demo purpose)
        Process.Start(outputFile)

    End Sub

    Sub ProcessingCallback(fileName As String, parsingResult As Boolean, progress As Double, innerException As Exception, ByRef cancel As Boolean)

        Console.WriteLine($"{progress}% Processed file ""{fileName}""")
        Console.WriteLine($"  Result: {parsingResult}")

        If Not parsingResult 

            If innerException IsNot Nothing
                Console.WriteLine(innerException.ToString())
            End If

            Console.Write("Continue processing? (y/n): ")
            Dim key As Integer = Console.Read()
            If key = 110 ' n
                Console.WriteLine("Interrupted.")
                cancel = True
            End If

        End If

    End Sub

End Module

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Parse Folder To CSV.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.28010.2016
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "Parse Folder To CSV", "Parse Folder To CSV.vbproj", "{A40CFAA8-F477-47CA-839D-FF4B7FFB6160}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{A40CFAA8-F477-47CA-839D-FF4B7FFB6160}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{A40CFAA8-F477-47CA-839D-FF4B7FFB6160}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{A40CFAA8-F477-47CA-839D-FF4B7FFB6160}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{A40CFAA8-F477-47CA-839D-FF4B7FFB6160}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {7023C353-37E1-4A32-876D-897D6BC778D1}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Parse Folder To CSV.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{A40CFAA8-F477-47CA-839D-FF4B7FFB6160}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>Parse_Folder_To_CSV.Module1</StartupObject>
    <RootNamespace>Parse_Folder_To_CSV</RootNamespace>
    <AssemblyName>Parse Folder To CSV</AssemblyName>
    <FileAlignment>512</FileAlignment>
    <MyType>Console</MyType>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <Deterministic>true</Deterministic>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>Parse Folder To CSV.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>Parse Folder To CSV.xml</DocumentationFile>
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
    <Reference Include="ByteScout.InvoiceParser, Version=1.0.0.100, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\ByteScout Invoice Parser SDK\net40\ByteScout.InvoiceParser.dll</HintPath>
    </Reference>
    <Reference Include="ByteScout.InvoiceParser.Templates, Version=1.0.0.100, Culture=neutral, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\ByteScout Invoice Parser SDK\net40\ByteScout.InvoiceParser.Templates.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
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
    <Compile Include="My Project\AssemblyInfo.vb" />
    <Compile Include="My Project\Application.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Application.myapp</DependentUpon>
    </Compile>
    <Compile Include="My Project\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>Resources.resx</DependentUpon>
    </Compile>
    <Compile Include="My Project\Settings.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="My Project\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
      <SubType>Designer</SubType>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <Content Include="..\..\AmazonAWS.pdf">
      <Link>invoices\AmazonAWS.pdf</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="..\..\DigitalOcean.pdf">
      <Link>invoices\DigitalOcean.pdf</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="..\..\Google.pdf">
      <Link>invoices\Google.pdf</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <None Include="My Project\Application.myapp">
      <Generator>MyApplicationCodeGenerator</Generator>
      <LastGenOutput>Application.Designer.vb</LastGenOutput>
    </None>
    <None Include="My Project\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <CustomToolNamespace>My</CustomToolNamespace>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->