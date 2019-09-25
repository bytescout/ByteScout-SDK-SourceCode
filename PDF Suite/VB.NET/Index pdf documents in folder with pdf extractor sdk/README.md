## How to index pdf documents in folder with pdf extractor sdk in VB.NET with ByteScout PDF Suite

### If you want to learn more then this tutorial will show how to index pdf documents in folder with pdf extractor sdk in VB.NET

The sample source codes on this page shows how to index pdf documents in folder with pdf extractor sdk in VB.NET. ByteScout PDF Suite can index pdf documents in folder with pdf extractor sdk. It can be applied from VB.NET. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

The following code snippet for ByteScout PDF Suite works best when you need to quickly index pdf documents in folder with pdf extractor sdk in your VB.NET application. Just copy and paste the code into your VB.NET application’s code and follow the instructions. Applying VB.NET application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

Our website gives trial version of ByteScout PDF Suite for free. It also includes documentation and source code samples.

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

##### ****IndexDocsInFolder.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{846F275E-BE99-4254-85ED-B8CBBB4546A9}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>IndexDocsInFolder.Program</StartupObject>
    <RootNamespace>IndexDocsInFolder</RootNamespace>
    <AssemblyName>IndexDocsInFolder</AssemblyName>
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
    <DocumentationFile>IndexDocsInFolder.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>IndexDocsInFolder.xml</DocumentationFile>
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
    <Reference Include="Bytescout.PDFExtractor, Version=9.1.0.3170, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\..\..\..\..\..\..\..\..\Program Files\Bytescout PDF Extractor SDK\net2.00\Bytescout.PDFExtractor.dll</HintPath>
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
  <ItemGroup>
    <Content Include="Files\ImageSample.png">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <Content Include="Files\SampleFile1.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="Files\SampleFile2.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.vb:**
    
```
Imports System.IO
Imports Bytescout.PDFExtractor

Module Program

    Sub Main()

        Try
            ' Output file list
            Dim lstAllFilesInfo = New List(Of FileIndexOutput)()

            ' Get all files inside directory
            Dim allFiles = Directory.GetFiles(".\Files", "*.*")

            ' Iterate all files, and get details
            For Each itmFile In allFiles
                ' Get basic file information
                Dim fileInfo As FileInfo = New FileInfo(itmFile)

                ' Check whether file is supported
                If _IsFileSupported(fileInfo) Then
                    ' Fill file index model
                    Dim oFileIndex = New FileIndexOutput()
                    oFileIndex.fileName = fileInfo.Name
                    oFileIndex.fileDate = fileInfo.CreationTime
                    oFileIndex.content = _GetFileContent(fileInfo)

                    ' Add to final list
                    lstAllFilesInfo.Add(oFileIndex)
                End If
            Next

            ' Print all output
            Console.WriteLine("Total {0} files indexed" & vbLf, lstAllFilesInfo.Count)

            For Each itmFileInfo In lstAllFilesInfo
                Console.WriteLine("fileName: {0}", itmFileInfo.fileName)
                Console.WriteLine("fileDate: {0}", itmFileInfo.fileDate.ToString("MMM dd yyyy hh:mm:ss"))
                Console.WriteLine("content: {0}", itmFileInfo.content.Trim())
                Console.WriteLine(vbLf)
            Next

        Catch ex As Exception
            Console.WriteLine(("ERROR:" + ex.Message))
        End Try

        Console.WriteLine("Press any key to exit...")
        Console.ReadLine()
    End Sub

    ''' <summary>
    ''' Get File COntent
    ''' </summary>
    Private Function _GetFileContent(ByVal fileInfo As FileInfo) As String

        Dim fileExtension As String = System.IO.Path.GetExtension(fileInfo.FullName)

        If fileExtension = ".pdf" Then
            Return _GetPdfFileContent(fileInfo)
        ElseIf fileExtension = ".png" OrElse fileExtension = ".jpg" Then
            Return _GetImageContet(fileInfo)
        End If

        Throw New Exception("File not supported.")
    End Function

    ''' <summary>
    ''' Get PDF File Content
    ''' </summary>
    Private Function _GetPdfFileContent(ByVal fileInfo As FileInfo) As String

        ' Read all file content...
        Using textExtractor As TextExtractor = New TextExtractor("demo", "demo")

            ' Load Document
            textExtractor.LoadDocumentFromFile(fileInfo.FullName)

            Return textExtractor.GetText()

        End Using

    End Function

    ''' <summary>
    ''' Get Image Contents
    ''' </summary>
    Private Function _GetImageContet(ByVal fileInfo As FileInfo) As String

        ' Read all file content...
        Using extractor As TextExtractor = New TextExtractor()
            ' Load document
            extractor.LoadDocumentFromFile(fileInfo.FullName)

            ' Set option to repair text
            extractor.OCRMode = OCRMode.TextFromImagesAndVectorsAndRepairedFonts

            ' Enable Optical Character Recognition (OCR)
            ' in .Auto mode (SDK automatically checks if needs to use OCR or not)
            extractor.OCRMode = OCRMode.Auto

            ' Set the location of OCR language data files
            extractor.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata\"

            ' Set OCR language
            extractor.OCRLanguage = "eng" '"eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
            ' Find more language files at https://github.com/bytescout/ocrdata

            ' Set PDF document rendering resolution
            extractor.OCRResolution = 300

            ' Read all text
            Return extractor.GetText()
        End Using
    End Function

    ''' <summary>
    ''' Check whether file is valid
    ''' </summary>
    Private Function _IsFileSupported(ByVal fileInfo As FileInfo) As Boolean
        ' Get File Extension
        Dim fileExtension As String = Path.GetExtension(fileInfo.Name)

        ' Check whether file extension is valid
        Return (fileExtension = ".pdf" OrElse fileExtension = ".png" OrElse fileExtension = ".jpg")
    End Function

    ''' <summary>
    ''' FileIndexOutput class
    ''' </summary>
    Public Class FileIndexOutput
        Public Property fileName As String
        Public Property fileDate As DateTime
        Public Property content As String
    End Class

End Module

```

<!-- code block end -->