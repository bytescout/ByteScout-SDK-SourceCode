## check if OCR is required for PDF with PDF extractor SDK in C# using ByteScout PDF Suite

### How to apply ByteScout PDF Suite for check if OCR is required for PDF with PDF extractor SDK in C#

We regularly create and update our sample code library so you may quickly learn check if OCR is required for PDF with PDF extractor SDK and the step-by-step process in C#. Check if OCR is required for PDF with PDF extractor SDK in C# can be applied with ByteScout PDF Suite. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

If you want to quickly learn then these fast application programming interfaces of ByteScout PDF Suite for C# plus the guideline and the C# code below will help you quickly learn check if OCR is required for PDF with PDF extractor SDK. If you want to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Check these C# sample code examples to see if they acknowledge to your needs and requirements for the project.

On our website you may get trial version of ByteScout PDF Suite for free. Source code samples are included to help you with your C# application.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Suite%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****CheckIfOCRIsRequired.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{99735776-2956-463D-9795-EBCE16928C30}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>CheckIfOCRIsRequired</RootNamespace>
    <AssemblyName>CheckIfOCRIsRequired</AssemblyName>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
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
    <Reference Include="Bytescout.PDFExtractor, Version=9.1.0.3170, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF Extractor SDK\net2.00\Bytescout.PDFExtractor.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <None Include="InputFiles\sample_ocr_not_required.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="InputFiles\sample_ocr_required.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.cs:**
    
```
using Bytescout.PDFExtractor;
using System;

namespace CheckIfOCRIsRequired
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Loop through all files in directory and check whether OCR operation is required
                foreach (string filePath in System.IO.Directory.GetFiles("InputFiles"))
                {
                    _CheckOCRRequired(filePath);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

			Console.WriteLine("Press enter key to exit...");
            Console.ReadLine();
        }

        
        /// <summary>
        /// Check whether OCR Operation is required
        /// </summary>
        /// <param name="filePath"></param>
        private static void _CheckOCRRequired(string filePath)
        {
            //Read all file content...
            using (TextExtractor extractor = new TextExtractor())
            {
                extractor.RegistrationKey = "demo";
                extractor.RegistrationName = "demo";

                // Load document
                extractor.LoadDocumentFromFile(filePath);
                Console.WriteLine("\n*******************\n\nFilePath: {0}", filePath);

                int pageIndex = 0;

                // Identify OCR operation is recommended for page
                if (extractor.IsOCRRecommendedForPage(pageIndex))
                {
                    Console.WriteLine("\nOCR Recommended: True");

                    // Enable Optical Character Recognition (OCR)
                    // in .Auto mode (SDK automatically checks if needs to use OCR or not)
                    extractor.OCRMode = OCRMode.Auto;

                    // Set the location of language data files
                    extractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata\";

                    // Set OCR language
                    extractor.OCRLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
                    // Find more language files at https://github.com/bytescout/ocrdata

                    // Set PDF document rendering resolution
                    extractor.OCRResolution = 300;
                }
                else
                {
                    Console.WriteLine("\nOCR Recommended: False");
                }

                //Read all text
                var allExtractedText = extractor.GetText();
                Console.WriteLine("\nExtracted Text:\n{0}\n\n", allExtractedText);
            }

        }

    }
}

```

<!-- code block end -->