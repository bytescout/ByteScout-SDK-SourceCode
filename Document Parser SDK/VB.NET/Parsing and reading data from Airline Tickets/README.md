## parsing and reading data from airline tickets in VB.NET and ByteScout Document Parser SDK

### Build parsing and reading data from airline tickets in VB.NET: ### Step-by-step instructions on how to do parsing and reading data from airline tickets in VB.NET

ByteScout tutorials describe the stuff for programmers who use VB.NET. ByteScout Document Parser SDK was made to help with parsing and reading data from airline tickets in VB.NET. ByteScout Document Parser SDK is the robost offline data extraction platform for template based data extraction and processing. Supports high load with millions of documents as input. Templates can be quickly created and updated with no special technical knowledge required.

If you want to quickly learn then these fast application programming interfaces of ByteScout Document Parser SDK for VB.NET plus the guideline and the VB.NET code below will help you quickly learn parsing and reading data from airline tickets. If you want to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Enjoy writing a code with ready-to-use sample VB.NET codes to add parsing and reading data from airline tickets functions using ByteScout Document Parser SDK in VB.NET.

 If you want to try other samples for VB.NET then free trial version of ByteScout Document Parser SDK is available on our website.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Document%20Parser%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Document%20Parser%20SDK%20Question) 

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

[https://www.youtube.com/watch?v=MG5FfTWWSVE](https://www.youtube.com/watch?v=MG5FfTWWSVE)




<!-- code block begin -->

##### **GeneralExample.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27703.2026
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "GeneralExample", "GeneralExample.vbproj", "{A5FA1293-C15B-4249-A771-ED4301658454}"
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

##### **GeneralExample.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{A5FA1293-C15B-4249-A771-ED4301658454}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>GeneralExample.Module1</StartupObject>
    <RootNamespace>GeneralExample</RootNamespace>
    <AssemblyName>GeneralExample</AssemblyName>
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
    <DocumentationFile>GeneralExample.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>GeneralExample.xml</DocumentationFile>
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
    <None Include="SampleTicket.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="SampleTicket.yml">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### **Module1.vb:**
    
```
Imports ByteScout.DocumentParser

' This example demonstrates document data parsing to JSON, YAML and XML formats.

Module Module1

    Sub Main()

        Dim templatesDocument As String = ".\SampleTicket.yml"
        Dim inputDocument As String = ".\SampleTicket.pdf"

        ' Create DocumentParser instance
        Using documentParser As New DocumentParser("demo", "demo")

            ' Loading template
            documentParser.AddTemplate(templatesDocument)

            ' Parse document data in JSON format
            Dim jsonString As String = documentParser.ParseDocument(inputDocument, OutputFormat.JSON)
            ' Display parsed data in console
            Console.WriteLine("Parsing results in JSON format:")
            Console.WriteLine()
            Console.WriteLine(jsonString)

            Console.WriteLine(Environment.NewLine + Environment.NewLine + "==================" + Environment.NewLine + Environment.NewLine)

            ' Parse document data in YAML format
            Dim yamlString As String = documentParser.ParseDocument(inputDocument, OutputFormat.YAML)
            ' Display parsed data in console
            Console.WriteLine("Parsing results in YAML format:")
            Console.WriteLine()
            Console.WriteLine(yamlString)

            Console.WriteLine(Environment.NewLine + Environment.NewLine + "==================" + Environment.NewLine + Environment.NewLine)

            ' Parse document data in YAML format
            Dim xmlString As String = documentParser.ParseDocument(inputDocument, OutputFormat.XML)
            ' Display parsed data in console
            Console.WriteLine("Parsing results in XML format:")
            Console.WriteLine()
            Console.WriteLine(xmlString)

        End Using

        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()

    End Sub

End Module
```

<!-- code block end -->    

<!-- code block begin -->

##### **SampleTicket.yml:**
    
```
templateName: MakeMyTrip Booking
templateVersion: 4
templatePriority: 0
detectionRules:
  keywords:
  - MakeMyTrip
  - Eticket-Dom-Flight
objects:
- name: BookingNo
  objectType: field
  fieldProperties:
    fieldType: rectangle
    rectangle:
    - 198.75
    - 85.625
    - 96.875
    - 12.500001
    pageIndex: 0
- name: BookingDate
  objectType: field
  fieldProperties:
    fieldType: rectangle
    dataType: date
    rectangle:
    - 133.125
    - 97.5000076
    - 78.75
    - 12.500001
    pageIndex: 0
- name: DepartureFrom
  objectType: field
  fieldProperties:
    fieldType: rectangle
    rectangle:
    - 153
    - 176
    - 77
    - 8.5
    pageIndex: 0
- name: ArrivalTo
  objectType: field
  fieldProperties:
    fieldType: rectangle
    rectangle:
    - 285
    - 176
    - 84
    - 8.5
    pageIndex: 0
- name: DepartureAt
  objectType: field
  fieldProperties:
    fieldType: rectangle
    dataType: date
    rectangle:
    - 153.75
    - 187.5
    - 123.75
    - 10.625
    pageIndex: 0
- name: ArrivalAt
  objectType: field
  fieldProperties:
    fieldType: rectangle
    dataType: date
    rectangle:
    - 288.125
    - 186.875
    - 125.625008
    - 11.25
    pageIndex: 0
- name: FlightType
  objectType: field
  fieldProperties:
    fieldType: rectangle
    rectangle:
    - 433.5
    - 159.5
    - 68
    - 10.5
    pageIndex: 0
- name: FlightDuration
  objectType: field
  fieldProperties:
    fieldType: rectangle
    rectangle:
    - 474.375031
    - 170.625
    - 30.0000019
    - 10
    pageIndex: 0
- name: CabinType
  objectType: field
  fieldProperties:
    fieldType: rectangle
    rectangle:
    - 463.125031
    - 194.375015
    - 51.25
    - 10
    pageIndex: 0
- name: PassengerName
  objectType: field
  fieldProperties:
    fieldType: rectangle
    rectangle:
    - 85
    - 238.125
    - 93.125
    - 14.375
    pageIndex: 0
- name: PassengerType
  objectType: field
  fieldProperties:
    fieldType: rectangle
    rectangle:
    - 229.375015
    - 238.125
    - 31.25
    - 13.75
    pageIndex: 0
- name: AirlinePNR
  objectType: field
  fieldProperties:
    fieldType: rectangle
    rectangle:
    - 375
    - 240.000015
    - 46.25
    - 13.75
    pageIndex: 0


```

<!-- code block end -->