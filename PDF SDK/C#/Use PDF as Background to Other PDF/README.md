## How to use PDF as background to other PDF in C# with ByteScout PDF SDK ByteScout PDF SDK: the library for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings.

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

##### **Program.cs:**
    
```
using Bytescout.PDF;
using System;
using System.Diagnostics;

namespace UsePDFAsBkgdToOtrPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            var PDFSDK_RegName = "demo";
            var PDFSDK_RegKey = "demo";

            Document templateDoc = new Document { RegistrationName = PDFSDK_RegName, RegistrationKey = PDFSDK_RegKey };
            Document mainDoc = new Document { RegistrationName = PDFSDK_RegName, RegistrationKey = PDFSDK_RegKey };
            Document resultDoc = new Document { RegistrationName = PDFSDK_RegName, RegistrationKey = PDFSDK_RegKey };

            templateDoc.Load(@"./background.pdf");
            mainDoc.Load(@"./sample.pdf");

            // Create GraphicsTemplate object from the first page of the template document
            GraphicsTemplate template = templateDoc.Pages[0].SaveAsTemplate();
            
            for (int i = 0; i < mainDoc.Pages.Count; i++)
            {
                // Create empty page 
                Page resultPage = new Page(mainDoc.Pages[i].Width, mainDoc.Pages[i].Height);

                // Draw the template page as a background before the main content
                resultPage.Canvas.DrawTemplate(template, 0, 0);

                // Draw main content
                GraphicsTemplate mainContentAsTemplate = mainDoc.Pages[i].SaveAsTemplate();
                resultPage.Canvas.DrawTemplate(mainContentAsTemplate, 0, 0);
                
                // Add the created page to the result document
                resultDoc.Pages.Add(resultPage);
            }

            // Save result document
            resultDoc.Save(@"./result.pdf");

            resultDoc.Dispose();
            templateDoc.Dispose();
            mainDoc.Dispose();

            Console.WriteLine("Result file 'result.pdf' generated!");
            Process.Start(@"result.pdf");
            Console.ReadLine();
        }
    }
}
```

<!-- code block end -->    

<!-- code block begin -->

##### **UsePDFAsBkgdToOtrPDF.NETCore.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp2.0</TargetFramework>
    <EnableDefaultCompileItems>false</EnableDefaultCompileItems>
    <GenerateAssemblyCompanyAttribute>false</GenerateAssemblyCompanyAttribute>
    <GenerateAssemblyConfigurationAttribute>false</GenerateAssemblyConfigurationAttribute>
    <GenerateAssemblyFileVersionAttribute>false</GenerateAssemblyFileVersionAttribute>
    <GenerateAssemblyInformationalVersionAttribute>false</GenerateAssemblyInformationalVersionAttribute>
    <GenerateAssemblyProductAttribute>false</GenerateAssemblyProductAttribute>
    <GenerateAssemblyTitleAttribute>false</GenerateAssemblyTitleAttribute>
    <GenerateAssemblyVersionAttribute>false</GenerateAssemblyVersionAttribute>
    <GenerateAssemblyCopyrightAttribute>false</GenerateAssemblyCopyrightAttribute>
    <GenerateAssemblyTrademarkAttribute>false</GenerateAssemblyTrademarkAttribute>
    <GenerateAssemblyCultureAttribute>false</GenerateAssemblyCultureAttribute>
    <GenerateAssemblyDescriptionAttribute>false</GenerateAssemblyDescriptionAttribute>
  </PropertyGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <None Include="background.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="sample.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <ItemGroup>
    <PackageReference Include="Microsoft.Windows.Compatibility" Version="2.0.0" />
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDF">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF SDK\netcoreapp2.0\Bytescout.PDF.dll</HintPath>
    </Reference>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### **UsePDFAsBkgdToOtrPDF.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{8B33CB1C-B6A2-4750-9D1C-EB963DC8A17D}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>UsePDFAsBkgdToOtrPDF</RootNamespace>
    <AssemblyName>UsePDFAsBkgdToOtrPDF</AssemblyName>
    <TargetFrameworkVersion>v4.6.1</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
    <TargetFrameworkProfile />
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
    <Prefer32Bit>false</Prefer32Bit>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <Prefer32Bit>false</Prefer32Bit>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDF, Version=1.8.2.254, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF SDK\net2.0\Bytescout.PDF.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <None Include="background.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="sample.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->