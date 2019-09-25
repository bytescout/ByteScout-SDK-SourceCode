## How to extract text from areas in C# and ByteScout Text Recognition SDK

### How to code in C# to extract text from areas with this step-by-step tutorial

ByteScout tutorials are designed to explain the code for both C# beginners and advanced programmers. What is ByteScout Text Recognition SDK? It is the software development kit for automatic text recognition and OCR from pdf documents and images. Can recognize English and non-English languages. It can help you to extract text from areas in your C# application.

The SDK samples like this one below explain how to quickly make your application do extract text from areas in C# with the help of ByteScout Text Recognition SDK. Just copy and paste the code into your C# application’s code and follow the instruction. Use of ByteScout Text Recognition SDK in C# is also explained in the documentation included along with the product.

Trial version of ByteScout Text Recognition SDK is available for free. Source code samples are included to help you with your C# app.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Text%20Recognition%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Text%20Recognition%20SDK%20Question) 

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

##### ****Program.cs:**
    
```
using System;
using System.Diagnostics;
using System.Drawing;
using ByteScout.TextRecognition;

namespace TextRecognitionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDocument = @".\areas-sample.pdf";
            int pageIndex = 0;
            string outputDocument = @".\result.txt";
            
            // Create and activate TextRecognizer instance
            using (TextRecognizer textRecognizer = new TextRecognizer("demo", "demo"))
            {
                try
                {
                    // Load document (image or PDF)
                    textRecognizer.LoadDocument(inputDocument);

                    // Set the location of OCR language data files
                    textRecognizer.OCRLanguageDataFolder = @"c:\Program Files\ByteScout Text Recognition SDK\ocrdata_best\";

                    // Set OCR language.
                    // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish, etc. - according to files in "ocrdata" folder
                    // Find more language files at https://github.com/bytescout/ocrdata
                    textRecognizer.OCRLanguage = "eng"; 
                                        
                    // Get page size (in pixels). Size of PDF document is computed from PDF Points 
                    // and the rendering resolution specified by `textRecognizer.PDFRenderingResolution` (default 300 DPI)
                    Size pageSize = textRecognizer.GetPageSize(pageIndex);
                    
                    // Add area of interest as a rectangle at the top-right corner of the page
                    textRecognizer.RecognitionAreas.Add(pageSize.Width / 2, 0, pageSize.Width / 2, 300);
                    // Add area of interest as a rectangle at the bottom-left corner of the page,
                    // and indicate it should be rotated at 90 deg
                    textRecognizer.RecognitionAreas.Add(0, pageSize.Height / 2, 300, pageSize.Height / 2, AreaRotation.Rotate90FlipNone);

                    // Now, you can get recognized text for further analysis as a list of objects 
                    // containing coordinates, object kind, confidence.
                    OCRObjectList ocrObjectList = textRecognizer.GetOCRObjects(pageIndex);
                    foreach (OCRObject ocrObject in ocrObjectList)
                        Console.WriteLine(ocrObject.ToString());

                    // ... or you can save recognized text pieces to file
                    textRecognizer.KeepTextFormatting = false; // save without formatting
                    textRecognizer.SaveText(outputDocument, pageIndex, pageIndex);


                    // Open the result file in default associated application (for demo purposes)
                    Process.Start(outputDocument);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****TextRecognitionExample.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.30703</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{A76FCB4A-8C36-4107-AC0E-26C659745F55}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>TextRecognitionExample</RootNamespace>
    <AssemblyName>TextRecognitionExample</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <TargetFrameworkProfile>Client</TargetFrameworkProfile>
    <FileAlignment>512</FileAlignment>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Debug|AnyCPU'">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>AnyCPU</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Release|AnyCPU'">
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>AnyCPU</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisIgnoreBuiltInRules>false</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="ByteScout.TextRecognition">
      <HintPath>C:\Program Files\ByteScout Text Recognition SDK\net4.00\ByteScout.TextRecognition.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Core" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="..\..\areas-sample.pdf">
      <Link>areas-sample.pdf</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name="BeforeBuild">
  </Target>
  <Target Name="AfterBuild">
  </Target>
  -->
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****TextRecognitionExample.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 11.00
# Visual Studio 2010
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "TextRecognitionExample", "TextRecognitionExample.csproj", "{A76FCB4A-8C36-4107-AC0E-26C659745F55}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{A76FCB4A-8C36-4107-AC0E-26C659745F55}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{A76FCB4A-8C36-4107-AC0E-26C659745F55}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{A76FCB4A-8C36-4107-AC0E-26C659745F55}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{A76FCB4A-8C36-4107-AC0E-26C659745F55}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
EndGlobal

```

<!-- code block end -->