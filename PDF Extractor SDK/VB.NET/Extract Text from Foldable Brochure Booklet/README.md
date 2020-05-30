## How to extract text from foldable brochure booklet in VB.NET using ByteScout PDF Extractor SDK ByteScout PDF Extractor SDK is the Software Development Kit (SDK) that is designed to help developers with data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Extractor%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Extractor%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=s28W3_KMraU](https://www.youtube.com/watch?v=s28W3_KMraU)




<!-- code block begin -->

##### **ExtractTextFromFoldableBrochure.vbproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{7B47AE2F-F68A-456C-A7E3-6FFA0FCF8AED}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>ExtractTextFromFoldableBrochure</RootNamespace>
    <AssemblyName>ExtractTextFromFoldableBrochure</AssemblyName>
    <OldToolsVersion>3.5</OldToolsVersion>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Reference Include="Bytescout.PDFExtractor, Version=1.0.0.12, Culture=neutral, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
    <Compile Include="Program.vb" />
    <Content Include="..\..\SampleFoldable.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
      <Link>SampleFoldable.pdf</Link>
    </Content>
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### **Program.vb:**
    
```
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Text
Imports Bytescout.PDFExtractor

Class Program

    Friend Shared Sub Main(args As String())

        ' Set extraction regions
        ' Use Bytescout Template Editor / Bytescout PDF Multitool or other tool to know region co-ordinates
        Dim lstExtractionRegion As New List(Of RectangleF) From {
            New RectangleF(7.5F, 33.8F, 244.5F, 353.3F),
            New RectangleF(273.8F, 201.8F, 247.5F, 198.0F),
            New RectangleF(537.8F, 27.0F, 246.0F, 268.5F)
        }

        ' Ouput File
        Dim resFile As String = "result.txt"
        Dim sRes As New StringBuilder(String.Empty)

        ' Create Bytescout.PDFExtractor.TextExtractor instance
        Dim extractor As New TextExtractor With {
            .RegistrationName = "demo",
            .RegistrationKey = "demo"
        }

        ' Load sample PDF document
        extractor.LoadDocumentFromFile(".\SampleFoldable.pdf")

        '  Loop through all extraction regions, and extract text
        For Each oRegion As RectangleF In lstExtractionRegion
            sRes.AppendLine(GetTextFromRegion(extractor, oRegion))
        Next

        ' Cleanup
        extractor.Dispose()

        ' Write all result to output file
        File.WriteAllText(resFile, sRes.ToString())

        ' Open result file in default associated application (for demo purposes)
        System.Diagnostics.Process.Start(resFile)
    End Sub

    ''' <summary>
    ''' Get text from particular region
    ''' </summary>
    Friend Shared Function GetTextFromRegion(ByVal textExtractor As TextExtractor, ByVal extractionRegion As RectangleF, ByVal Optional pageIndex As Int32 = 0) As String

        ' Set Extraction Area
        textExtractor.SetExtractionArea(extractionRegion)

        ' Get Text from that region
        Return textExtractor.GetTextFromPage(pageIndex)

    End Function


End Class

```

<!-- code block end -->