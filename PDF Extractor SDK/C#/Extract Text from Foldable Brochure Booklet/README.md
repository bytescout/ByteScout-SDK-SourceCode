## How to extract text from foldable brochure booklet in C# using ByteScout PDF Extractor SDK ByteScout PDF Extractor SDK is the Software Development Kit (SDK) that is designed to help developers with data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker.

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

##### **ExtractTextFromFoldableBrochure.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{25E68A98-BA0D-428D-99F4-0ED8C42DD41C}</ProjectGuid>
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
    <DefineConstants>DEBUG;TRACE</DefineConstants>
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
  <ItemGroup>
    <Reference Include="Bytescout.PDFExtractor, Version=1.0.0.12, Culture=neutral, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="..\..\SampleFoldable.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
      <Link>SampleFoldable.pdf</Link>
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

##### **Program.cs:**
    
```
using Bytescout.PDFExtractor;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;

namespace ExtractTextFromFoldableBrochure
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set extraction regions
            // Use Bytescout Template Editor / Bytescout PDF Multitool or other tool to know region co-ordinates
            var lstExtractionRegion = new List<RectangleF>();
            lstExtractionRegion.Add(new RectangleF(7.5f, 33.8f, 244.5f, 353.3f));
            lstExtractionRegion.Add(new RectangleF(273.8f, 201.8f, 247.5f, 198.0f));
            lstExtractionRegion.Add(new RectangleF(537.8f, 27.0f, 246.0f, 268.5f));

            // Ouput File
            var resFile = "result.txt";
            var sRes = new StringBuilder(string.Empty);

            // Create Bytescout.PDFExtractor.TextExtractor instance
            TextExtractor extractor = new TextExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Load sample PDF document
            extractor.LoadDocumentFromFile(@".\SampleFoldable.pdf");

            // Loop through all extraction regions, and extract text
            foreach (var oRegion in lstExtractionRegion)
            {
                var extractedText = GetTextFromRegion(extractor, oRegion);
                sRes.AppendLine(extractedText);
            }

            // Cleanup
            extractor.Dispose();

            // Write all reslut to output file
            File.WriteAllText(resFile, sRes.ToString());

            // Open result file in default associated application
            ProcessStartInfo processStartInfo = new ProcessStartInfo(@".\result.txt");
            Process.Start(processStartInfo);
        }

        /// <summary>
        /// Get text from particular region
        /// </summary>
        private static string GetTextFromRegion(TextExtractor textExtractor, RectangleF extractionRegion, int pageIndex = 0)
        {
            // Set Extraction Area
            textExtractor.SetExtractionArea(extractionRegion);

            // Get Text from that region
            return textExtractor.GetTextFromPage(pageIndex);
        }
    }
}

```

<!-- code block end -->