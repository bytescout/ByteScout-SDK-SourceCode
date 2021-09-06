## How to use PDF as background to other PDF in VB.NET with ByteScout PDF SDK ByteScout PDF SDK is the pdf library that can create, update and modify PDF files. Supports text with fonts and style selections, layers, form fields, drawing lines and objects, automatic tables, images. Can be used to create and fill pdf forms.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20SDK%20Question) 

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

[https://www.youtube.com/watch?v=gdsQ0EAqwGQ](https://www.youtube.com/watch?v=gdsQ0EAqwGQ)




<!-- code block begin -->

##### **Program.vb:**
    
```
Imports Bytescout.PDF

Module Program

    Sub Main()

        Dim PDFSDK_RegName As String = "demo"
        Dim PDFSDK_RegKey As String = "demo"

        Dim templateDoc As New Document With {.RegistrationName = PDFSDK_RegName, .RegistrationKey = PDFSDK_RegKey}
        Dim mainDoc As New Document With {.RegistrationName = PDFSDK_RegName, .RegistrationKey = PDFSDK_RegKey}
        Dim resultDoc As New Document With {.RegistrationName = PDFSDK_RegName, .RegistrationKey = PDFSDK_RegKey}

        templateDoc.Load("./background.pdf")
        mainDoc.Load("./sample.pdf")

        ' Create GraphicsTemplate object from the first page of the template document
        Dim template As GraphicsTemplate
        template = templateDoc.Pages(0).SaveAsTemplate()

        For i = 0 To mainDoc.Pages.Count - 1
            ' Create empty page 
            Dim resultPage As New Page(mainDoc.Pages(i).Width, mainDoc.Pages(i).Height)


            ' Draw the template page as a background before the main content
            resultPage.Canvas.DrawTemplate(template, 0, 0)

            ' Draw main content
            Dim mainContentAsTemplate As GraphicsTemplate = mainDoc.Pages(i).SaveAsTemplate()
            resultPage.Canvas.DrawTemplate(mainContentAsTemplate, 0, 0)

            ' Add the created page to the result document
            resultDoc.Pages.Add(resultPage)
        Next

        ' Save result document
        resultDoc.Save("./result.pdf")

        resultDoc.Dispose()
        templateDoc.Dispose()
        mainDoc.Dispose()

        Console.WriteLine("Result file 'result.pdf' generated!")
        Process.Start("result.pdf")
        Console.ReadLine()

    End Sub

End Module

```

<!-- code block end -->    

<!-- code block begin -->

##### **UsePDFAsBkgdToOtrPDF.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{E0A3BA18-AA04-4C1E-AF80-F7232FD8D83E}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>UsePDFAsBkgdToOtrPDF.Program</StartupObject>
    <RootNamespace>UsePDFAsBkgdToOtrPDF</RootNamespace>
    <AssemblyName>UsePDFAsBkgdToOtrPDF</AssemblyName>
    <FileAlignment>512</FileAlignment>
    <MyType>Console</MyType>
    <TargetFrameworkVersion>v4.6.1</TargetFrameworkVersion>
    <TargetFrameworkProfile />
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>UsePDFAsBkgdToOtrPDF.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
    <Prefer32Bit>false</Prefer32Bit>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>UsePDFAsBkgdToOtrPDF.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
    <Prefer32Bit>false</Prefer32Bit>
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
    <Reference Include="Bytescout.PDF, Version=1.8.2.254, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout PDF SDK\net4.5\Bytescout.PDF.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
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
    <None Include="background.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="sample.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->