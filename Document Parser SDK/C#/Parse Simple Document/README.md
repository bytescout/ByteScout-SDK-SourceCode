## How to parse simple document in C# and ByteScout Document Parser SDK

### The tutorial shows how to parse simple document in C#

Every ByteScout tool contains example C# source codes that you can find here or in the folder with installed ByteScout product. Want to parse simple document in your C# app? ByteScout Document Parser SDK is designed for it. ByteScout Document Parser SDK is the robost offline data extraction platform for template based data extraction and processing. Supports high load with millions of documents as input. Templates can be quickly created and updated with no special technical knowledge required.

This code snippet below for ByteScout Document Parser SDK works best when you need to quickly parse simple document in your C# application. Follow the instructions from the scratch to work and copy the C# code. Use of ByteScout Document Parser SDK in C# is also explained in the documentation included along with the product.

Trial version of ByteScout Document Parser SDK can be downloaded for free from our website. It also includes source code samples for C# and other programming languages.

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

##### **AmazonAWS.yml:**
    
```
templateName: Amazon Web Services Invoice
templateVersion: 4
templatePriority: 0
detectionRules:
  keywords:
  - Amazon Web Services
  - ATTN
  - Invoice
objects:
- name: total
  objectType: field
  fieldProperties:
    fieldType: macros
    expression: TOTAL AMOUNT DUE ON{{Anything}}{{Dollar}}({{Number}})
    regex: true
    dataType: decimal
- name: subTotal
  objectType: field
  fieldProperties:
    fieldType: macros
    expression: '{{LineStart}}{{Spaces}}Charges{{Spaces}}{{Dollar}}({{Number}})'
    regex: true
    dataType: decimal
- name: dateIssued
  objectType: field
  fieldProperties:
    fieldType: macros
    expression: Invoice Date:{{Spaces}}({{Anything}}){{LineEnd}}
    regex: true
    dataType: date
    dateFormat: MMMM d , yyyy
- name: invoiceId
  objectType: field
  fieldProperties:
    fieldType: macros
    expression: Invoice Number:{{Spaces}}({{Digits}})
    regex: true
- name: companyName
  objectType: field
  fieldProperties:
    fieldType: static
    expression: Amazon Web Services, Inc.
    regex: true
- name: companyWebsite
  objectType: field
  fieldProperties:
    fieldType: static
    expression: aws.amazon.com
    regex: true
- name: billTo
  objectType: field
  fieldProperties:
    fieldType: rectangle
    expression: Bill to Address:{{ToggleSingleLineMode}}({{AnythingGreedy}})
    regex: true
    rectangle:
    - 33
    - 115.5
    - 213.75
    - 72.75
    pageIndex: 0
- name: currency
  objectType: field
  fieldProperties:
    fieldType: static
    expression: USD
    regex: true
- name: table1
  objectType: table
  tableProperties:
    start:
      expression: '{{LineStart}}{{Spaces}}Detail{{LineEnd}}'
      regex: true
    end:
      expression: '{{EndOfPage}}'
      regex: true
    row:
      expression: '{{LineStart}}{{Spaces}}(?<description>{{SentenceWithSingleSpaces}}){{Spaces}}{{Dollar}}(?<unitPrice>{{Number}}){{LineEnd}}'
      regex: true
    columns:
    - name: unitPrice
      dataType: decimal


```

<!-- code block end -->    

<!-- code block begin -->

##### **DigitalOcean.yml:**
    
```
templateName: DigitalOcean Invoice
templateVersion: 4
templatePriority: 0
detectionRules:
  keywords:
  - DigitalOcean
  - 101 Avenue of the Americas
  - Invoice Number
objects:
- name: companyName
  objectType: field
  fieldProperties:
    fieldType: static
    expression: DigitalOcean
    regex: true
- name: invoiceId
  objectType: field
  fieldProperties:
    fieldType: macros
    expression: 'Invoice Number: ({{Digits}})'
    regex: true
- name: dateIssued
  objectType: field
  fieldProperties:
    fieldType: macros
    expression: 'Date Issued: ({{SmartDate}})'
    regex: true
    dataType: date
    dateFormat: auto-mdy
- name: total
  objectType: field
  fieldProperties:
    fieldType: macros
    expression: 'Total: {{Dollar}}({{Number}})'
    regex: true
    dataType: decimal
- name: currency
  objectType: field
  fieldProperties:
    fieldType: static
    expression: USD
    regex: true
- name: table1
  objectType: table
  tableProperties:
    start:
      expression: Description{{Spaces}}Hours
      regex: true
    end:
      expression: 'Total:'
      regex: true
    row:
      expression: '{{LineStart}}{{Spaces}}(?<description>{{SentenceWithSingleSpaces}}){{Spaces}}(?<hours>{{Digits}}){{Spaces}}(?<start>{{2Digits}}{{Minus}}{{2Digits}}{{Space}}{{2Digits}}{{Colon}}{{2Digits}}){{Spaces}}(?<end>{{2Digits}}{{Minus}}{{2Digits}}{{Space}}{{2Digits}}{{Colon}}{{2Digits}}){{Spaces}}{{Dollar}}(?<unitPrice>{{Number}})'
      regex: true
    columns:
    - name: hours
      dataType: integer
    - name: unitPrice
      dataType: decimal


```

<!-- code block end -->    

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
    <None Include="DigitalOcean.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="AmazonAWS.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="Google.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="AmazonAWS.yml">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="DigitalOcean.yml">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="Google.yml">
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

##### **Google.yml:**
    
```
templateName: Google Invoice
templateVersion: 4
templatePriority: 0
detectionRules:
  keywords:
  - Google
  - 77-0493581
  - Invoice
objects:
- name: invoiceId
  objectType: field
  fieldProperties:
    expression: Invoice number:{{Spaces}}({{Digits}})
    regex: true
- name: dateIssued
  objectType: field
  fieldProperties:
    expression: Issue date:{{Spaces}}({{SmartDate}})
    regex: true
    dataType: date
    dateFormat: MMM d, yyyy
- name: total
  objectType: field
  fieldProperties:
    expression: Amount due in USD:{{Spaces}}{{Number}}
    regex: true
    dataType: decimal
- name: subTotal
  objectType: field
  fieldProperties:
    expression: Subtotal in USD:{{Spaces}}{{Number}}
    regex: true
    dataType: decimal
- name: taxRate
  objectType: field
  fieldProperties:
    expression: State sales tax {{OpeningParenthesis}}{{Digits}}{{Percent}}{{ClosingParenthesis}}
    regex: true
    dataType: integer
- name: tax
  objectType: field
  fieldProperties:
    expression: State sales tax{{Anything}}{{Number}}{{LineEnd}}
    regex: true
    dataType: decimal
- name: companyName
  objectType: field
  fieldProperties:
    fieldType: static
    expression: Google LLC
    regex: true
- name: billTo
  objectType: field
  fieldProperties:
    fieldType: rectangle
    regex: true
    rectangle:
    - 0
    - 152
    - 280
    - 72
    pageIndex: 0
- name: billingId
  objectType: field
  fieldProperties:
    expression: Billing ID:{{Spaces}}({{DigitsOrSymbols}})
    regex: true
- name: currency
  objectType: field
  fieldProperties:
    fieldType: static
    expression: USD
    regex: true
- name: table1
  objectType: table
  tableProperties:
    start:
      expression: Description{{Spaces}}Interval{{Spaces}}Quantity{{Spaces}}Amount
      regex: true
    end:
      expression: Subtotal in USD
      regex: true
    row:
      expression: '{{LineStart}}{{Spaces}}(?<description>{{SentenceWithSingleSpaces}}){{Spaces}}(?<interval>{{3Letters}}{{Space}}{{Digits}}{{Space}}{{Minus}}{{Space}}{{3Letters}}{{Space}}{{Digits}}){{Spaces}}(?<quantity>{{Digits}}){{Spaces}}(?<amount>{{Number}})'
      regex: true
    columns:
    - name: quantity
      dataType: integer
    - name: amount
      dataType: decimal


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
            var templates = new string[] { "DigitalOcean.yml", "AmazonAWS.yml", "Google.yml" } ;

            string inputDocument1 = @".\DigitalOcean.pdf";
            string inputDocument2 = @".\AmazonAWS.pdf";
            string inputDocument3 = @".\Google.pdf";

            // Create DocumentParser instance
            using (DocumentParser documentParser = new DocumentParser("demo", "demo"))
            {
                Console.WriteLine($"Loading templates...");

                foreach (var template in templates)
                {
                    documentParser.AddTemplate(template);
                }

                Console.WriteLine($"templates loaded.");
                Console.WriteLine();

                Console.WriteLine($"Parsing \"{inputDocument1}\"...");
                Console.WriteLine();

                // Parse document data in JSON format
                string jsonString = documentParser.ParseDocument(inputDocument1, OutputFormat.JSON);
                // Display parsed data in console
                Console.WriteLine("Parsing results in JSON format:");
                Console.WriteLine();
                Console.WriteLine(jsonString);

                Console.WriteLine();
                Console.WriteLine($"Parsing \"{inputDocument2}\"...");
                Console.WriteLine();

                // Parse document data in YAML format
                string yamlString = documentParser.ParseDocument(inputDocument2, OutputFormat.YAML);
                // Display parsed data in console
                Console.WriteLine("Parsing results in YAML format:");
                Console.WriteLine();
                Console.WriteLine(yamlString);
                
                Console.WriteLine();
                Console.WriteLine($"Parsing \"{inputDocument3}\"...");
                Console.WriteLine();

                // Parse document data in XML format
                string xmlString = documentParser.ParseDocument(inputDocument3, OutputFormat.XML);
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