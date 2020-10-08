## How to parse typical invoice in C# using ByteScout Document Parser SDK ByteScout Document Parser SDK is the robost offline data extraction platform for template based data extraction and processing. Supports high load with millions of documents as input. Templates can be quickly created and updated with no special technical knowledge required.

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

##### **ParseTypicalInvoice.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{A73776C6-D2B2-4E37-B852-06C6454D1B5B}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>ParseTypicalInvoice</RootNamespace>
    <AssemblyName>ParseTypicalInvoice</AssemblyName>
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
    <None Include="SampleInvoice.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### **ParseTypicalInvoice.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27703.2018
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "ParseTypicalInvoice", "ParseTypicalInvoice.csproj", "{A73776C6-D2B2-4E37-B852-06C6454D1B5B}"
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

// This example demonstrates parsing of typical invoice.

namespace ParseTypicalInvoice
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDocument = @".\SampleInvoice.pdf";
            
            // Create DocumentParser instance
            using (DocumentParser documentParser = new DocumentParser("demo", "demo"))
            {
                // Add an internal generic template for typical invoices.
                // Note, if it does not parse all required fields, you should create
                // own template using Template Editor application.
                documentParser.AddTemplate("internal://invoice");
                
                Console.WriteLine($"Parsing \"{inputDocument}\"...");
                Console.WriteLine();

                // Parse document data in JSON format
                string jsonString = documentParser.ParseDocument(inputDocument, OutputFormat.JSON);
                
                // Display parsed data in console
                Console.WriteLine("Parsing results in JSON format:");
                Console.WriteLine();
                Console.WriteLine(jsonString);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}

```

<!-- code block end -->