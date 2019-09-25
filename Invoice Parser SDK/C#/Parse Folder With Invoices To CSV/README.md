## How to parse folder with invoices to CSV in C# with ByteScout Invoice Parser SDK

### How to code in C# to parse folder with invoices to CSV with this step-by-step tutorial

The coding tutorials are designed to help you test the features without need to write your own code. ByteScout Invoice Parser SDK is the invoices processor engine that comes with built-in support for invoices from thousands of companies. Automatically detects company that issued invoice, extracts invoice number, date, total amount to be paid. Constantly updated to support invoices from new companies. Supports batch processing of invoices with JSON, CSV, XML output. It can parse folder with invoices to CSV in C#.

This rich sample source code in C# for ByteScout Invoice Parser SDK includes the number of functions and options you should do calling the API to parse folder with invoices to CSV. In your C# project or application you may simply copy & paste the code and then run your app! Further enhancement of the code will make it more vigorous.

Download free trial version of ByteScout Invoice Parser SDK from our website with this and other source code samples for C#.

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

##### ****ParseFolderToCSV.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{D674E35B-D877-45FC-A459-6CEF673CF427}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>ParseFolderToCSV</RootNamespace>
    <AssemblyName>ParseFolderToCSV</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
    <Deterministic>true</Deterministic>
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
    <Reference Include="ByteScout.InvoiceParser, Version=1.0.0.100, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\ByteScout Invoice Parser SDK\net40\ByteScout.InvoiceParser.dll</HintPath>
    </Reference>
    <Reference Include="ByteScout.InvoiceParser.Templates, Version=1.0.0.100, Culture=neutral, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\ByteScout Invoice Parser SDK\net40\ByteScout.InvoiceParser.Templates.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
  </ItemGroup>
  <ItemGroup />
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
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ParseFolderToCSV.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.28010.2016
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "ParseFolderToCSV", "ParseFolderToCSV.csproj", "{D674E35B-D877-45FC-A459-6CEF673CF427}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{D674E35B-D877-45FC-A459-6CEF673CF427}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{D674E35B-D877-45FC-A459-6CEF673CF427}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{D674E35B-D877-45FC-A459-6CEF673CF427}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{D674E35B-D877-45FC-A459-6CEF673CF427}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {EDCD81CC-A538-41D3-A99A-0F287E9FC614}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.cs:**
    
```
using System;
using System.Diagnostics;
using System.Text;
using ByteScout.InvoiceParser;

namespace ParseFolderToCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFolder = @".\invoices";
            string outputFile = @".\result.csv";

            // Create InvoiceParser instance
            using (InvoiceParser parser = new InvoiceParser("demo", "demo"))
            {
                // Setup CSV output
                CSVOptions csvOptions = new CSVOptions
                {
                    Encoding = Encoding.UTF8,
                    SeparatorCharacter = ",",
                    QuotationCharacter = "\"",
                    UnwrapMultilineValues = true
                };

                // Parse all document in input folder and save results to CSV file
                BatchProcessing.ParseFolderToCSV(parser, inputFolder, outputFile, csvOptions, ProcessingCallback);
            }

            // Open generated CSV file in default associated application (for demo purpose)
            Process.Start(outputFile);
        }

        /// <summary>
        /// Callback method to display progress and interrupt processing if needed. 
        /// </summary>
        /// <param name="fileName">File name.</param>
        /// <param name="parsingResult">Parsing result.</param>
        /// <param name="progress">Current progress in percents.</param>
        /// <param name="innerException">Exception information in case of error.</param>
        /// <param name="cancel">Set to <c>true</c> to interrupt the batch processing.</param>
        static void ProcessingCallback(string fileName, bool parsingResult, double progress, Exception innerException, ref bool cancel)
        {
            Console.WriteLine($"{progress}% Processed file \"{fileName}\"");
            Console.WriteLine($"  Result: {parsingResult}");
            if (!parsingResult)
            {
                if (innerException != null)
                    Console.WriteLine(innerException.ToString());

                Console.Write("Continue processing? (y/n): ");
                int key = Console.Read();
                if (key == 'n')
                {
                    Console.WriteLine("Interrupted.");
                    cancel = true;
                }
            }
        }
    }
}

```

<!-- code block end -->