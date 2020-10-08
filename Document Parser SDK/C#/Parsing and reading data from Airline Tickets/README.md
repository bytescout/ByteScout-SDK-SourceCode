## parsing and reading data from airline tickets in C# with ByteScout Document Parser SDK

### Learn parsing and reading data from airline tickets in C#

An easy to understand guide to learn how to parsing and reading data from airline tickets in C#. Parsing and reading data from airline tickets in C# can be applied with ByteScout Document Parser SDK. ByteScout Document Parser SDK is the customizable data extraction platform for batch data extraction from documents. Relies on special templates that can be created with no special technical skills required. Supports millions of documents as input and designed to handle multiple threads. Can output data as JSON, CSV, XML or custom format.

This rich and prolific sample source code in C# for ByteScout Document Parser SDK contains various functions and options you should do calling the API to implement parsing and reading data from airline tickets. If you want to know how it works, then this C# sample code should be copied and pasted into your application’s code editor. Then just compile and run it. Want to see how it works with your data then code testing will allow the function to be tested and work properly.

Visit our website to get a free trial version of ByteScout Document Parser SDK. Free trial contains many of source code samples to help you with your C# project.

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

##### **GeneralExample.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{A73776C6-D2B2-4E37-B852-06C6454D1B5B}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>GeneralExample</RootNamespace>
    <AssemblyName>GeneralExample</AssemblyName>
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
    <None Include="SampleTicket.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="SampleTicket.yml">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### **GeneralExample.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27703.2018
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "GeneralExample", "GeneralExample.csproj", "{A73776C6-D2B2-4E37-B852-06C6454D1B5B}"
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

##### **Program.cs:**
    
```
using System;
using ByteScout.DocumentParser;

// This example demonstrates document data parsing to JSON, YAML and XML formats.

namespace GeneralExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string templateDocument = @".\SampleTicket.yml";
            string inputDocument = @".\SampleTicket.pdf";

            // Create DocumentParser instance
            using (DocumentParser documentParser = new DocumentParser("demo", "demo"))
            {

                // Add template format
                documentParser.AddTemplate(templateDocument);

                // Parse document data in JSON format
                string jsonString = documentParser.ParseDocument(inputDocument, OutputFormat.JSON);
                
                // Display parsed data in console
                Console.WriteLine("Parsing results in JSON format:");
                Console.WriteLine();
                Console.WriteLine(jsonString);

                Console.WriteLine("\n\n=========================\n\n");

                // Parse document data in YAML format
                string yamlString = documentParser.ParseDocument(inputDocument, OutputFormat.YAML);

                // Display parsed data in console
                Console.WriteLine("Parsing results in YAML format:");
                Console.WriteLine();
                Console.WriteLine(yamlString);

                Console.WriteLine("\n\n=========================\n\n");

                // Parse document data in XML format
                string xmlString = documentParser.ParseDocument(inputDocument, OutputFormat.XML);
                // Display parsed data in console
                Console.WriteLine("Parsing results in XML format:");
                Console.WriteLine();
                Console.WriteLine(xmlString);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}

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