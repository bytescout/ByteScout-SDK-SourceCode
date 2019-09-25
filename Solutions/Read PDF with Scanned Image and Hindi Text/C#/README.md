## How to read PDF with scanned image and hindi text in C# with Multiple ByteScout SDK

### The tutorial below will demonstrate how to read PDF with scanned image and hindi text in C#

We made thousands of pre-made source code pieces for easy implementation in your own programming projects. What is Multiple ByteScout SDK? It is the set of few ByteScout SDK libraries that is used in apps performing multi-step workflows like searching for keywords or phrases inside existing documents with highlighting of results, or adding e-signature to existing document pdf based on the analysis of visual content in another document. It can help you to read PDF with scanned image and hindi text in your C# application.

You will save a lot of time on writing and testing code as you may just take the C# code from Multiple ByteScout SDK for read PDF with scanned image and hindi text below and use it in your application. This C# sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Detailed tutorials and documentation are available along with installed Multiple ByteScout SDK if you'd like to dive deeper into the topic and the details of the API.

Free trial version of Multiple ByteScout SDK is available for download from our website. Get it to try other source code samples for C#.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=Multiple%20ByteScout%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=Multiple%20ByteScout%20SDK%20Question) 

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
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Drawing.Imaging;
using Bytescout.PDFExtractor;
using Bytescout.PDF;
using System.Diagnostics;

namespace ReadPDFWithImageHindiText
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Files
                string fileName = "hindi_text_with_image.pdf";
                string destFileName = "output_hindi_text_with_image.pdf";
                string destFileName_serachable = "output_hindi_text_with_image_searchable.pdf";

                // Read all text from pdf file
                string allTextExtracted = "";
                using (TextExtractor extractor = new TextExtractor())
                {
                    // Load PDF document
                    extractor.LoadDocumentFromFile(fileName);

                    // Read all text directly
                    allTextExtracted = extractor.GetText();
                }

                // Get image from pdf file
                MemoryStream memoryStream = new MemoryStream();
                using (ImageExtractor extractor = new ImageExtractor())
                {
                    // Load PDF document
                    extractor.LoadDocumentFromFile(fileName);

                    if (extractor.GetFirstImage())
                    {
                        extractor.SaveCurrentImageToStream(memoryStream, ImageFormat.Png);
                    }
                }

                // Load image from file to System.Drawing.Image object (we need it to get the image resolution)
                using (System.Drawing.Image sysImage = System.Drawing.Image.FromStream(memoryStream))
                {
                    // Compute image size in PDF units (Points)
                    float widthInPoints = sysImage.Width / sysImage.HorizontalResolution * 72f;
                    float heightInPoints = sysImage.Height / sysImage.VerticalResolution * 72f;

                    // Create new PDF document
                    using (Document outPdfDocument = new Document())
                    {
                        outPdfDocument.RegistrationName = "demo";
                        outPdfDocument.RegistrationKey = "demo";

                        // Create page of computed size
                        Page page = new Page(widthInPoints, heightInPoints);

                        // Add page to the document
                        outPdfDocument.Pages.Add(page);

                        Canvas canvas = page.Canvas;

                        // Create Bytescout.PDF.Image object from loaded image
                        Image pdfImage = new Image(sysImage);

                        // Draw the image
                        canvas.DrawImage(pdfImage, 0, 0, widthInPoints, heightInPoints);

                        // Dispose the System.Drawing.Image object to free resources
                        sysImage.Dispose();

                        // Create brush
                        SolidBrush transparentBrush = new SolidBrush(new ColorGray(0));

                        // ... and make it transparent
                        transparentBrush.Opacity = 0;

                        // Draw text with transparent brush
                        // Need to set Font which supports hindi characters.
                        Font font16 = new Font("Arial Unicode MS", 16);
                        canvas.DrawString(allTextExtracted, font16, transparentBrush, 40, 40);

                        // Save document to file
                        outPdfDocument.Save(destFileName);
                    }
                }


                // Make PDF file with hindi text searchable to OCR.
                using (SearchablePDFMaker searchablePDFMaker = new SearchablePDFMaker())
                {
                    //Load PDF document
                    searchablePDFMaker.LoadDocumentFromFile(destFileName);

                    // Set the location of "tessdata" folder containing language data files
                    /*
                     * It used following files for hindi language support. Need to put these files into "testdata" folder. Below location contains these files.
                     * https://github.com/tesseract-ocr/tessdata/tree/3.04.00 
                     hin.traineddata
                     hin.cube.bigrams
                     hin.cube.lm
                     hin.cube.nn
                     hin.cube.params
                     hin.cube.word-freq
                     hin.tesseract_cube.nn
                     */
                    searchablePDFMaker.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\Redistributable\net2.00\tessdata\";

                    // Set OCR language
                    searchablePDFMaker.OCRLanguage = "hin";

                    // Need to set Font which supports hindi characters
                    searchablePDFMaker.LabelingFont = "Arial Unicode MS";

                    // Set PDF document rendering resolution
                    searchablePDFMaker.OCRResolution = 300;

                    searchablePDFMaker.MakePDFSearchable(destFileName_serachable);
                }

                // Open document in default PDF viewer app
                Process.Start(destFileName_serachable);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR:" + ex.Message);
            }

            Console.ReadLine();
        }
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ReadPDFWithImageHindiText.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{99735776-2956-463D-9795-EBCE16928C30}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>ReadPDFWithImageHindiText</RootNamespace>
    <AssemblyName>ReadPDFWithImageHindiText</AssemblyName>
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
    <Reference Include="Bytescout.PDF, Version=1.8.2.254, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF SDK\net2.0\Bytescout.PDF.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.PDFExtractor, Version=9.1.0.3170, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF Extractor SDK\net2.00\Bytescout.PDFExtractor.dll</HintPath>
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
    <None Include="hindi_text_with_image.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ReadPDFWithImageHindiText.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27703.2026
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "ReadHindiText", "ReadPDFWithImageHindiText.csproj", "{99735776-2956-463D-9795-EBCE16928C30}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{99735776-2956-463D-9795-EBCE16928C30}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{99735776-2956-463D-9795-EBCE16928C30}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{99735776-2956-463D-9795-EBCE16928C30}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{99735776-2956-463D-9795-EBCE16928C30}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {3ABE3EEF-B212-4E8B-9A74-67A52FD333AC}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->