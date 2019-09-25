## slice PDF by horizontal lines inside in VB.NET with Multiple ByteScout SDK

### Tutorial: how to do slice PDF by horizontal lines inside in VB.NET

On this page you will learn from code samples for programming in VB.NET. Multiple ByteScout SDK helps with slice PDF by horizontal lines inside in VB.NET. Multiple ByteScout SDK is Bundle of SDK components can be used to implement multistep workflow. For example, multiple SDKs can be used to implement 2-3 steps code like a search for keywords inside documents and highlights of results found or app that splits pdf based on visually detected lines inside documents.

VB.NET code snippet like this for Multiple ByteScout SDK works best when you need to quickly implement slice PDF by horizontal lines inside in your VB.NET application. This VB.NET sample code should be copied and pasted into your application’s code editor. Then just compile and run it to see how it works. Further enhancement of the code will make it more vigorous.

Trial version can be obtained from our website for free. It includes this and other source code samples for VB.NET.

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

##### ****Module1.vb:**
    
```
Imports System.Drawing
Imports System.IO
Imports Bytescout.PDFExtractor
Imports Bytescout.PDFRenderer
Imports Bytescout.PDF

''' <summary>
''' The example demonstrates slicing of PDF document pages by horizontal lines.
''' The example uses three products:
''' - PDF Extractor SDK (https://bytescout.com/products/developer/pdfextractorsdk/index.html) -
'''     to detect lines;
''' - PDF Renderer SDK (https://bytescout.com/products/developer/pdfrenderersdk/index.html) -
'''     to render PDF documents to raster images;
''' - PDF SDK (https://bytescout.com/products/developer/pdfsdk/index.html) -
'''     to create new PDF documentsd from sliced images.
''' </summary>
Module Module1

    Dim InputFile = ".\sample.pdf"
    Dim OutputFolder = ".\output"

    Sub Main()

        if Not Directory.Exists(OutputFolder)
            Directory.CreateDirectory(OutputFolder)
        End If

        ' Create LineDetector instance and load document
        Dim lineDetector = new LineDetector("demo", "demo")
        lineDetector.LoadDocumentFromFile(InputFile)

        ' Create RasterRenderer instance and load document
        Dim rasterRenderer = new RasterRenderer("demo", "demo")
        rasterRenderer.LoadDocumentFromFile(InputFile)

        Try
            Dim pageCount = lineDetector.GetPageCount()

            For pageIndex As Integer = 0 To pageCount - 1
                
                Console.WriteLine("Processing page #{0}", pageIndex)

                ' Find horizontal lines on the page
                Dim horzLines = lineDetector.FindLines(pageIndex, LineOrientationsToFind.OnlyHorizontal)
                ' Slice page by separating lines and create new PDF documents
                Slice(pageIndex, horzLines, rasterRenderer)

            Next
        Catch exception As Exception
            Console.WriteLine(exception)
        Finally
            ' Cleanup
            rasterRenderer.Dispose()
            lineDetector.Dispose()
        End Try


        Console.WriteLine()
        Console.WriteLine("Press any key...")
        Console.ReadKey()
        
    End Sub


    Private Sub Slice(pageIndex As Integer, lines As FoundLinesCollection, rasterRenderer As RasterRenderer)
        
        Const pdfRenderingResolution As Single = 300
        Dim lastLineY As Single = Single.NaN
        Dim sliceNum as Integer = 0

        Dim pageRect = rasterRenderer.GetPageRectangle(pageIndex)

        For Each line As FoundLine In lines
            
            If Single.IsNaN(lastLineY)
                lastLineY = line.From.Y
            Else 
                ' Compute slice rectangle
                Dim sliceRect = new RectangleF(0, lastLineY, pageRect.Width, line.From.Y - lastLineY)
                ' Set extraction rectangle for RasterRenderer
                rasterRenderer.SetExtractionArea(sliceRect)
                ' Render the page region to Image object
                Dim slice = rasterRenderer.GetImage(pageIndex, pdfRenderingResolution)

                ' Create PDF document
                Dim document = new Document With {
                    .RegistrationName = "demo",
                    .RegistrationKey = "demo"
                }

                ' Create page of A4 size
                Dim page = new Page(PaperFormat.A4)
                document.Pages.Add(page)

                ' Create PDF Image object from System.Drawing.Image
                Dim pdfImage = new Bytescout.PDF.Image(slice)
                ' Draw image on the page keeping the aspect ratio
                Dim r = new RectangleF(0, 20, page.Width, page.Width / slice.Width * slice.Height)
                page.Canvas.DrawImage(pdfImage, r.Left, r.Top, r.Width, r.Height)

                ' Save PDF document
                sliceNum = sliceNum + 1
                Dim fileName = string.Format("{0}\{1}-page{2}-slice{3}.pdf", OutputFolder, IO.Path.GetFileName(InputFile), pageIndex, sliceNum)
                document.Save(fileName)

                Console.WriteLine("Saved slice '{0}'", fileName)

                ' Cleanup
                document.Dispose()
                slice.Dispose()

                lastLineY = line.From.Y

            End If
        Next

    End Sub
End Module

```

<!-- code block end -->    

<!-- code block begin -->

##### ****SlicePdfByLinesExample.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27428.2043
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "SlicePdfByLinesExample", "SlicePdfByLinesExample.vbproj", "{8E0965B2-52B2-4221-B6D1-07900C43A1F7}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{8E0965B2-52B2-4221-B6D1-07900C43A1F7}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{8E0965B2-52B2-4221-B6D1-07900C43A1F7}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{8E0965B2-52B2-4221-B6D1-07900C43A1F7}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{8E0965B2-52B2-4221-B6D1-07900C43A1F7}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {49EC6605-CDD0-4E48-9B83-9FA437CF221D}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****SlicePdfByLinesExample.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{8E0965B2-52B2-4221-B6D1-07900C43A1F7}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>SlicePdfByLinesExample.Module1</StartupObject>
    <RootNamespace>SlicePdfByLinesExample</RootNamespace>
    <AssemblyName>SlicePdfByLinesExample</AssemblyName>
    <FileAlignment>512</FileAlignment>
    <MyType>Console</MyType>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>SlicePdfByLinesExample.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>SlicePdfByLinesExample.xml</DocumentationFile>
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
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
  </ItemGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Collections" />
    <Import Include="System.Collections.Generic" />
    <Import Include="System.Data" />
    <Import Include="System.Diagnostics" />
    <Import Include="System.Linq" />
    <Import Include="System.Xml.Linq" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Module1.vb" />
    <Compile Include="My Project\AssemblyInfo.vb" />
    <Compile Include="My Project\Application.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Application.myapp</DependentUpon>
    </Compile>
    <Compile Include="My Project\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>Resources.resx</DependentUpon>
    </Compile>
    <Compile Include="My Project\Settings.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="My Project\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
      <SubType>Designer</SubType>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="My Project\Application.myapp">
      <Generator>MyApplicationCodeGenerator</Generator>
      <LastGenOutput>Application.Designer.vb</LastGenOutput>
    </None>
    <None Include="My Project\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <CustomToolNamespace>My</CustomToolNamespace>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
    <Content Include="sample.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->