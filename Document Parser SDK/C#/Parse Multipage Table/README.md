## How to parse multipage table in C# using ByteScout Document Parser SDK

### How to parse multipage table in C#

ByteScout tutorials are designed to explain the code for both C# beginners and advanced programmers. ByteScout Document Parser SDK is the template based data extraction engine can process thousands and millions of documents per day based on templates. Can work online and offline for privacy focused tasks. Templates can be supported and updated without any programming or technical knowledge required. Output is generated in JSON, CSV, XML and custom format if required and you can use it to parse multipage table with C#.

The SDK samples like this one below explain how to quickly make your application do parse multipage table in C# with the help of ByteScout Document Parser SDK. In your C# project or application you may simply copy & paste the code and then run your app! You can use these C# sample examples in one or many applications.

ByteScout free trial version is available for download from our website. It includes all these programming tutorials along with source code samples.

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

##### **MultiPageTable-template1.yml:**
    
```
templateName: Multipage Table Test
templateVersion: 4
templatePriority: 0
detectionRules:
  keywords:
  - Sample document with multi-page table
objects:
- name: total
  objectType: field
  fieldProperties:
    fieldType: macros
    expression: TOTAL{{Spaces}}({{Number}})
    regex: true
    dataType: decimal
- name: table1
  objectType: table
  tableProperties:
    start:
      expression: Item{{Spaces}}Description{{Spaces}}Price
      regex: true
    end:
      expression: TOTAL{{Spaces}}{{Number}}
      regex: true
    row:
      expression: '{{LineStart}}{{Spaces}}(?<itemNo>{{Digits}}){{Spaces}}(?<description>{{SentenceWithSingleSpaces}}){{Spaces}}(?<price>{{Number}}){{Spaces}}(?<qty>{{Digits}}){{Spaces}}(?<extPrice>{{Number}})'
      regex: true
    columns:
    - name: itemNo
      dataType: integer
    - name: description
      dataType: string
    - name: price
      dataType: decimal
    - name: qty
      dataType: integer
    - name: extPrice
      dataType: decimal
    multipage: true


```

<!-- code block end -->    

<!-- code block begin -->

##### **MultiPageTable-template2.yml:**
    
```
templateName: Multipage Table Test
templateVersion: 4
templatePriority: 0
detectionRules:
  keywords:
  - Sample document with multi-page table
objects:
- name: total
  objectType: field
  fieldProperties:
    fieldType: regex
    expression: TOTAL{{Spaces}}({{Number}})
    regex: true
    dataType: decimal
- name: table1
  objectType: table
  tableProperties:
    start:
      expression: Item{{Spaces}}Description{{Spaces}}Price
      regex: true
    end:
      expression: (Page {{Digits}} of {{Digits}})|(TOTAL{{Spaces}}{{Number}})
      regex: true
    left: 51
    right: 528
    columns:
    - x: 51
      name: itemNo
      dataType: integer
    - x: 102
      name: description
      dataType: string
    - x: 324
      name: price
      dataType: decimal
    - x: 396
      name: qty
      dataType: integer
    - x: 441
      name: extPrice
      dataType: decimal
    multipage: true


```

<!-- code block end -->    

<!-- code block begin -->

##### **ParseMultipageTable.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{A73776C6-D2B2-4E37-B852-06C6454D1B5B}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>ParseMultipageTable</RootNamespace>
    <AssemblyName>ParseMultipageTable</AssemblyName>
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
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <None Include="MultiPageTable.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="MultiPageTable-template1.yml">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="MultiPageTable-template2.yml">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### **ParseMultipageTable.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27703.2018
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "ParseMultipageTable", "ParseMultipageTable.csproj", "{A73776C6-D2B2-4E37-B852-06C6454D1B5B}"
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

// This example demonstrates parsing of multipage tables in two different approaches.
// See comments in the code of templates.

namespace ParseMultipageTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDocument = @".\MultiPageTable.pdf";
            string template1 = @".\MultiPageTable-template1.yml";
            string template2 = @".\MultiPageTable-template2.yml";

            using (DocumentParser documentParser = new DocumentParser("demo", "demo"))
            {
                Console.WriteLine($"Loading template 1...");
                documentParser.AddTemplate(template1);

                Console.WriteLine($"Template 1 loaded.");
                Console.WriteLine();

                Console.WriteLine($"Parsing \"{inputDocument}\"...");
                Console.WriteLine();

                // Parse document data in JSON format
                documentParser.ParseDocument(inputDocument, "result1.json", OutputFormat.JSON);

                Console.WriteLine("Parsing results saved to `result1.json`.");
                Console.WriteLine();
            }

            using (DocumentParser documentParser = new DocumentParser("demo", "demo"))
            {
                Console.WriteLine($"Loading template 2...");
                documentParser.AddTemplate(template2);

                Console.WriteLine($"Template 2 loaded.");
                Console.WriteLine();

                Console.WriteLine($"Parsing \"{inputDocument}\"...");
                Console.WriteLine();

                // Parse document data in JSON format
                documentParser.ParseDocument(inputDocument, "result2.json", OutputFormat.JSON);

                Console.WriteLine("Parsing results saved to `result2.json`.");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}

```

<!-- code block end -->