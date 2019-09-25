## How to read PDF with scanned image and hindi text in VB.NET and Multiple ByteScout SDK

### How to code in VB.NET to read PDF with scanned image and hindi text with this step-by-step tutorial

The sample shows steps and algorithm of how to read PDF with scanned image and hindi text and how to make it work in your VB.NET application. What is Multiple ByteScout SDK? It is the combination of one or more ByteScout SDK components to perform complex workflows like searching for text inside documents and highlighting found results and saving as new document or splitting pdf based on visually detected horizontal lines. It can help you to read PDF with scanned image and hindi text in your VB.NET application.

This code snippet below for Multiple ByteScout SDK works best when you need to quickly read PDF with scanned image and hindi text in your VB.NET application. Follow the instructions from the scratch to work and copy the VB.NET code. You can use these VB.NET sample examples in one or many applications.

Our website provides trial version of Multiple ByteScout SDK for free. It also includes documentation and source code samples.

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

##### ****Program.vb:**
    
```
Imports System.Drawing.Imaging
Imports System.IO
Imports Bytescout.PDF
Imports Bytescout.PDFExtractor

Module Program

    Sub Main()

        Try
            ' Files
            Dim fileName As String = "hindi_text_with_image.pdf"
            Dim destFileName As String = "output_hindi_text_with_image.pdf"
            Dim destFileName_serachable As String = "output_hindi_text_with_image_searchable.pdf"

            ' Read all text from pdf file
            Dim allTextExtracted As String = ""

            Using extractor As New TextExtractor

                ' Load PDF document
                extractor.LoadDocumentFromFile(fileName)

                ' Read all text to a variable
                allTextExtracted = extractor.GetText

            End Using

            ' Get image from pdf file
            Dim memoryStream As MemoryStream = New MemoryStream

            Using extractor As New ImageExtractor

                ' Load PDF document
                extractor.LoadDocumentFromFile(fileName)

                If extractor.GetFirstImage Then
                    extractor.SaveCurrentImageToStream(memoryStream, ImageFormat.Png)
                End If

            End Using

            ' Load image from file to System.Drawing.Image object (we need it to get the image resolution)
            Using sysImage As System.Drawing.Image = System.Drawing.Image.FromStream(memoryStream)

                ' Compute image size in PDF units (Points)
                Dim widthInPoints As Single = (sysImage.Width / sysImage.HorizontalResolution * 72.0F)
                Dim heightInPoints As Single = (sysImage.Height / sysImage.VerticalResolution * 72.0F)

                ' Create new PDF document
                Dim outPdfDocument As Document = New Document
                outPdfDocument.RegistrationName = "demo"
                outPdfDocument.RegistrationKey = "demo"

                ' Create page of computed size
                Dim page As Page = New Page(widthInPoints, heightInPoints)

                ' Add page to the document
                outPdfDocument.Pages.Add(page)

                Dim canvas As Canvas = page.Canvas

                ' Create Bytescout.PDF.Image object from loaded image
                Dim pdfImage As Image = New Image(sysImage)

                ' Draw the image
                canvas.DrawImage(pdfImage, 0, 0, widthInPoints, heightInPoints)

                ' Dispose the System.Drawing.Image object to free resources
                sysImage.Dispose()

                ' Create brush
                Dim transparentBrush As SolidBrush = New SolidBrush(New ColorGray(0))

                ' ... and make it transparent
                transparentBrush.Opacity = 0

                ' Draw text with transparent brush
                ' Need to set Font which supports hindi characters.
                Dim font16 As Font = New Font("Arial Unicode MS", 16)
                canvas.DrawString(allTextExtracted, font16, transparentBrush, 40, 40)

                ' Save document to file
                outPdfDocument.Save(destFileName)

            End Using


            'Make PDF file with hindi text searchable to OCR.
            Using searchablePDFMaker As New SearchablePDFMaker

                'Load PDF document
                searchablePDFMaker.LoadDocumentFromFile(destFileName)

                ' Set the location of "tessdata" folder containing language data files

                ' It used following files for hindi language support. Need to put these files into "testdata" folder. Below location contains these files.
                ' https://github.com/tesseract-ocr/tessdata/tree/3.04.00 
                ' hin.traineddata
                ' hin.cube.bigrams
                ' hin.cube.lm
                ' hin.cube.nn
                ' hin.cube.params
                ' hin.cube.word-freq
                ' hin.tesseract_cube.nn

                ' Set the location of "tessdata" folder containing language data files
                searchablePDFMaker.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\net2.00\tessdata"

                ' Set OCR language
                searchablePDFMaker.OCRLanguage = "hin"

                ' Need to set Font which supports hindi characters
                searchablePDFMaker.LabelingFont = "Arial Unicode MS"

                ' Set PDF document rendering resolution
                searchablePDFMaker.OCRResolution = 300

                ' Make PDF document searchable
                searchablePDFMaker.MakePDFSearchable(destFileName_serachable)

            End Using

            ' Open document in default PDF viewer app
            Process.Start(destFileName_serachable)

        Catch ex As Exception
            Console.WriteLine("ERROR:" + ex.Message)
        End Try

        Console.WriteLine()
        Console.WriteLine("Press any key to exit...")
        Console.ReadLine()

    End Sub

End Module

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ReadPDFWithImageHindiText.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27703.2026
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "ReadPDFWithImageHindiText", "ReadPDFWithImageHindiText.vbproj", "{846F275E-BE99-4254-85ED-B8CBBB4546A9}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{846F275E-BE99-4254-85ED-B8CBBB4546A9}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{846F275E-BE99-4254-85ED-B8CBBB4546A9}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{846F275E-BE99-4254-85ED-B8CBBB4546A9}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{846F275E-BE99-4254-85ED-B8CBBB4546A9}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {1F0B11D3-6F1D-4CCE-91F9-5566ABC60672}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ReadPDFWithImageHindiText.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{846F275E-BE99-4254-85ED-B8CBBB4546A9}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>ReadPDFWithImageHindiText.Program</StartupObject>
    <RootNamespace>ReadPDFWithImageHindiText</RootNamespace>
    <AssemblyName>ReadPDFWithImageHindiText</AssemblyName>
    <FileAlignment>512</FileAlignment>
    <MyType>Console</MyType>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>ReadPDFWithImageHindiText.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>ReadPDFWithImageHindiText.xml</DocumentationFile>
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
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
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
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->