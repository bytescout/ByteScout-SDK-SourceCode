## slice PDF by horizontal lines inside in C# using Multiple ByteScout SDK

### How to use Multiple ByteScout SDK for slice PDF by horizontal lines inside in C#

Sample source codes below will show you how to cope with a difficult task, for example, slice PDF by horizontal lines inside in C#. Multiple ByteScout SDK was made to help with slice PDF by horizontal lines inside in C#. Multiple ByteScout SDK is the combination of one or more ByteScout SDK components to perform complex workflows like searching for text inside documents and highlighting found results and saving as new document or splitting pdf based on visually detected horizontal lines.

This rich sample source code in C# for Multiple ByteScout SDK includes the number of functions and options you should do calling the API to implement slice PDF by horizontal lines inside. In order to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Enjoy writing a code with ready-to-use sample C# codes to implement slice PDF by horizontal lines inside using Multiple ByteScout SDK.

Visit our website provides for free trial version of Multiple ByteScout SDK. Free trial includes lots of source code samples to help you with your C# project.

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
using System.Drawing;
using System.IO;
using Bytescout.PDF;
using Bytescout.PDFExtractor;
using Bytescout.PDFRenderer;
using Image = System.Drawing.Image;
using Path = System.IO.Path;

namespace SlicePdfByLinesExample
{
    /// <summary>
    /// The example demonstrates slicing of PDF document pages by horizontal lines.
    /// The example uses three products:
    /// - PDF Extractor SDK (https://bytescout.com/products/developer/pdfextractorsdk/index.html) -
    ///     to detect lines;
    /// - PDF Renderer SDK (https://bytescout.com/products/developer/pdfrenderersdk/index.html) -
    ///     to render PDF documents to raster images;
    /// - PDF SDK (https://bytescout.com/products/developer/pdfsdk/index.html) -
    ///     to create new PDF documentsd from sliced images.
    /// </summary>
    class Program
    {
        static string InputFile = @".\sample.pdf";
        static string OutputFolder = @".\output";

        static void Main(string[] args)
        {
            if (!Directory.Exists(OutputFolder))
                Directory.CreateDirectory(OutputFolder);

            // Create LineDetector instance and load document
            LineDetector lineDetector = new LineDetector("demo", "demo");
            lineDetector.LoadDocumentFromFile(InputFile);

            // Create RasterRenderer instance and load document
            RasterRenderer rasterRenderer = new RasterRenderer("demo", "demo");
            rasterRenderer.LoadDocumentFromFile(InputFile);
            
            try
            {
                int pageCount = lineDetector.GetPageCount();

                for (int pageIndex = 0; pageIndex < pageCount; pageIndex++)
                {
                    Console.WriteLine("Processing page #{0}", pageIndex);

                    // Find horizontal lines on the page
                    FoundLinesCollection horzLines = lineDetector.FindLines(pageIndex, LineOrientationsToFind.OnlyHorizontal);
                    // Slice page by separating lines and create new PDF documents
                    Slice(pageIndex, horzLines, rasterRenderer);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            finally
            {
                // Cleanup
                rasterRenderer.Dispose();
                lineDetector.Dispose();
            }


            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        static void Slice(int pageIndex, FoundLinesCollection lines, RasterRenderer rasterRenderer)
        {
            const float pdfRenderingResolution = 300;
            float lastLineY = float.NaN;
            int sliceNum = 0;

            RectangleF pageRect = rasterRenderer.GetPageRectangle(pageIndex);

            foreach (FoundLine line in lines)
            {
                if (float.IsNaN(lastLineY))
                {
                    lastLineY = line.From.Y;
                }
                else
                {
                    // Compute slice rectangle
                    RectangleF sliceRect = new RectangleF(0, lastLineY, pageRect.Width, line.From.Y - lastLineY);
                    // Set extraction rectangle for RasterRenderer
                    rasterRenderer.SetExtractionArea(sliceRect);
                    // Render the page region to Image object
                    Image slice = rasterRenderer.GetImage(pageIndex, pdfRenderingResolution);

                    // Create PDF document
                    Document document = new Document
                    {
                        RegistrationName = "demo",
                        RegistrationKey = "demo"
                    };

                    // Create page of A4 size
                    Page page = new Page(PaperFormat.A4);
                    document.Pages.Add(page);

                    // Create PDF Image object from System.Drawing.Image
                    Bytescout.PDF.Image pdfImage = new Bytescout.PDF.Image(slice);
                    // Draw image on the page keeping the aspect ratio
                    RectangleF r = new RectangleF(0, 20, page.Width, page.Width / slice.Width * slice.Height);
                    page.Canvas.DrawImage(pdfImage, r.Left, r.Top, r.Width, r.Height);

                    // Save PDF document
                    string fileName = string.Format(@"{0}\{1}-page{2}-slice{3}.pdf", OutputFolder, Path.GetFileName(InputFile), pageIndex, ++sliceNum);
                    document.Save(fileName);

                    Console.WriteLine("Saved slice '{0}'", fileName);

                    // Cleanup
                    document.Dispose();
                    slice.Dispose();

                    lastLineY = line.From.Y;
                }
            }
        }
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****SlicePdfByLinesExample.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{11A7C946-41EC-4FD5-8414-EAAA0FB9FC48}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>SlicePdfByLinesExample</RootNamespace>
    <AssemblyName>SlicePdfByLinesExample</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
    <AutoGenerateBindingRedirects>true</AutoGenerateBindingRedirects>
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
    <Reference Include="Bytescout.PDF, Version=1.8.1.246, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout PDF SDK\net4.0\Bytescout.PDF.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.PDFExtractor, Version=9.0.0.3087, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout PDF Extractor SDK\net4.00\Bytescout.PDFExtractor.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.PDFRenderer, Version=9.0.0.3081, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout PDF Renderer SDK\net4.00\Bytescout.PDFRenderer.dll</HintPath>
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
    <Content Include="sample.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup />
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****SlicePdfByLinesExample.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27428.2037
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "SlicePdfByLinesExample", "SlicePdfByLinesExample.csproj", "{11A7C946-41EC-4FD5-8414-EAAA0FB9FC48}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{11A7C946-41EC-4FD5-8414-EAAA0FB9FC48}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{11A7C946-41EC-4FD5-8414-EAAA0FB9FC48}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{11A7C946-41EC-4FD5-8414-EAAA0FB9FC48}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{11A7C946-41EC-4FD5-8414-EAAA0FB9FC48}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {59CACFB0-9FC2-47A5-8E3B-C6497F97B068}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->