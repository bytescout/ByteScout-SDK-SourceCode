## How to parse from url for document parser API in VB.NET and PDF.co Web API

### How to parse from url for document parser API in VB.NET: Step By Step Instructions

These simple tutorials explain the code material for beginners and advanced programmers who are using VB.NET. PDF.co Web API was designed to assist document parser API in VB.NET. PDF.co Web API is the Rest API that provides set of data extraction functions, tools for documents manipulation, splitting and merging of pdf files. Includes built-in OCR, images recognition, can generate and read barcodes from images, scans and pdf.

If you want to speed up the application’s code writing then VB.NET code samples for VB.NET developers help to implement using PDF.co Web API. This VB.NET sample code can be used by copying and pasting into your project. Once done,just compile your project and click Run. This basic programming language sample code for VB.NET will do the whole work for you in implementing document parser API in your app.

Trial version of ByteScout is available for free download from our website. This and other source code samples for VB.NET and other programming languages are available.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=PDF.co%20Web%20API%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=PDF.co%20Web%20API%20Question) 

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

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### **ByteScoutWebApiExample.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.26730.10
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "ByteScoutWebApiExample", "ByteScoutWebApiExample.vbproj", "{9B91124C-66C3-4BD9-B29E-168C1ABB15AC}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{9B91124C-66C3-4BD9-B29E-168C1ABB15AC}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{9B91124C-66C3-4BD9-B29E-168C1ABB15AC}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{9B91124C-66C3-4BD9-B29E-168C1ABB15AC}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{9B91124C-66C3-4BD9-B29E-168C1ABB15AC}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {4576C9BB-A42D-46A8-9198-7E2982E122FA}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### **ByteScoutWebApiExample.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{9B91124C-66C3-4BD9-B29E-168C1ABB15AC}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>ByteScoutWebApiExample.Module1</StartupObject>
    <RootNamespace>ByteScoutWebApiExample</RootNamespace>
    <AssemblyName>ByteScoutWebApiExample</AssemblyName>
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
    <DocumentationFile>ByteScoutWebApiExample.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>ByteScoutWebApiExample.xml</DocumentationFile>
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
    <Reference Include="Newtonsoft.Json, Version=10.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed, processorArchitecture=MSIL">
      <HintPath>packages\Newtonsoft.Json.10.0.3\lib\net40\Newtonsoft.Json.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
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
    <None Include="packages.config" />
    <None Include="MultiPageTable-template1.yml">
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
Imports System.Collections.Specialized
Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json.Linq

Module Module1

    ' The authentication key (API Key).
    ' Get your own by registering at https://app.pdf.co/documentation/api
    Const API_KEY As String = "***********************************"

    ' Source PDF file Urll
    Const SourceFileUrl As String = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/document-parser/MultiPageTable.pdf"

    ' Destination TXT file name
    Const DestinationFile As String = ".\result.json"

    Sub Main()

        ' Template text. Use Document Parser (https://pdf.co/document-parser, https://app.pdf.co/document-parser)
        ' to create templates.
        ' Read template from file
        Dim templateText As String = File.ReadAllText("MultiPageTable-template1.yml")

        ' Create standard .NET web client instance
        Dim webClient As WebClient = New WebClient()

        ' Set API Key
        webClient.Headers.Add("x-api-key", API_KEY)

        Try

            ' PARSE UPLOADED PDF DOCUMENT

            ' URL for `Document Parser` API call
            Dim query As String = "https://api.pdf.co/v1/pdf/documentparser"

            Dim requestBody As New NameValueCollection()
            requestBody.Add("url", SourceFileUrl)
            requestBody.Add("template", templateText)

            ' Execute request
            Dim responseBytes As Byte() = webClient.UploadValues(query, "POST", requestBody)
            Dim response As String = Encoding.UTF8.GetString(responseBytes)

            ' Parse JSON response
            Dim json As JObject = JObject.Parse(response)

            If json("error").ToObject(Of Boolean) = False Then

                ' Get URL of generated JSON file
                Dim resultFileUrl As String = json("url")

                ' Download JSON file
                webClient.DownloadFile(resultFileUrl, DestinationFile)

                Console.WriteLine("Generated JSON file saved as {0} file.", DestinationFile)
            Else
                Console.WriteLine(json("message").ToString())
            End If

        Catch ex As WebException
            Console.WriteLine(ex.ToString())
        End Try

        webClient.Dispose()

        Console.WriteLine()
        Console.WriteLine("Press any key...")
        Console.ReadKey()

    End Sub

End Module
```

<!-- code block end -->    

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

##### **packages.config:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="Newtonsoft.Json" version="10.0.3" targetFramework="net40" />
</packages>
```

<!-- code block end -->