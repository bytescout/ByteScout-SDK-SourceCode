## How to parse simple document in VB.NET with ByteScout Document Parser SDK

### Tutorial on how to parse simple document in VB.NET

These source code samples are listed and grouped by their programming language and functions they use. ByteScout Document Parser SDK: the customizable data extraction platform for batch data extraction from documents. Relies on special templates that can be created with no special technical skills required. Supports millions of documents as input and designed to handle multiple threads. Can output data as JSON, CSV, XML or custom format. It can parse simple document in VB.NET.

You will save a lot of time on writing and testing code as you may just take the VB.NET code from ByteScout Document Parser SDK for parse simple document below and use it in your application. In your VB.NET project or application you may simply copy & paste the code and then run your app! Test VB.NET sample code examples whether they respond your needs and requirements for the project.

ByteScout Document Parser SDK free trial version is available on our website. VB.NET and other programming languages are supported.

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
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
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

##### **Module1.vb:**
    
```
Imports ByteScout.DocumentParser

' This example demonstrates document data parsing to JSON, YAML and XML formats.

Module Module1

    Sub Main()

        Dim templates As String() = New String() {"DigitalOcean.yml", "AmazonAWS.yml", "Google.yml"}

        Dim inputDocument1 As String = ".\DigitalOcean.pdf"
        Dim inputDocument2 As String = ".\AmazonAWS.pdf"
        Dim inputDocument3 As String = ".\Google.pdf"

        ' Create DocumentParser instance
        Using documentParser As New DocumentParser("demo", "demo")

            Console.WriteLine("Loading templates...")

            For Each template In templates
                documentParser.AddTemplate(template)
            Next

            Console.WriteLine("templates loaded...")
            Console.WriteLine()


            Console.WriteLine($"Parsing ""{inputDocument1}""...")
            Console.WriteLine()

            ' Parse document data in JSON format
            Dim jsonString As String = documentParser.ParseDocument(inputDocument1, OutputFormat.JSON)
            ' Display parsed data in console
            Console.WriteLine("Parsing results in JSON format:")
            Console.WriteLine()
            Console.WriteLine(jsonString)

            Console.WriteLine()
            Console.WriteLine($"Parsing ""{inputDocument2}""...")
            Console.WriteLine()

            ' Parse document data in YAML format
            Dim yamlString As String = documentParser.ParseDocument(inputDocument2, OutputFormat.YAML)
            ' Display parsed data in console
            Console.WriteLine("Parsing results in YAML format:")
            Console.WriteLine()
            Console.WriteLine(yamlString)


            Console.WriteLine()
            Console.WriteLine($"Parsing ""{inputDocument3}""...")
            Console.WriteLine()

            ' Parse document data in YAML format
            Dim xmlString As String = documentParser.ParseDocument(inputDocument3, OutputFormat.XML)
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