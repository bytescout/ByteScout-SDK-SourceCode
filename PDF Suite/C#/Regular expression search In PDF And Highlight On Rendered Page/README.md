## How to regular expression search in PDF and highlight on rendered page in C# and ByteScout PDF Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to regular expression search in PDF and highlight on rendered page in C#

We made thousands of pre-made source code pieces for easy implementation in your own programming projects. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can regular expression search in PDF and highlight on rendered page in C#.

The SDK samples given below describe how to quickly make your application do regular expression search in PDF and highlight on rendered page in C# with the help of ByteScout PDF Suite.  Simply copy and paste in your C# project or application you and then run your app! Complete and detailed tutorials and documentation are available along with installed ByteScout PDF Suite if you'd like to learn more about the topic and the details of the API.

Trial version of ByteScout PDF Suite is available for free. Source code samples are included to help you with your C# app.

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

##### ****Program.cs:**
    
```
using System.Diagnostics;
using System.Drawing;
using Bytescout.PDFExtractor;
using Bytescout.PDFRenderer;

namespace SearchAndHighlightExample
{
	class Program
	{
		static void Main(string[] args)
		{
			const string inputFile = @"sample.pdf";
			const int pageIndex = 0;
			const float renderingResolution = 300f;
			const string searchPattern = "\\d+\\.\\d+";

			// Prepare TextExtractor
			using (TextExtractor textExtractor = new TextExtractor("demo", "demo"))
			{
				textExtractor.RegexSearch = true;
				textExtractor.LoadDocumentFromFile(inputFile);

				// Preapre RasterRenderer
				using (RasterRenderer rasterRenderer = new RasterRenderer("demo", "demo"))
				{
					rasterRenderer.LoadDocumentFromFile(inputFile);

					// Render document page to image
					Image image = rasterRenderer.GetImage(pageIndex, renderingResolution);

					// Prepare highlight brush
					Brush highlightBrush = new SolidBrush(Color.FromArgb(128, Color.Yellow));

					using (Graphics graphics = Graphics.FromImage(image))
					{
						// Search for pattern and paint found piecese
						if (textExtractor.Find(pageIndex, searchPattern, caseSensitive: false))
						{
							do
							{
								foreach (var foundPiece in textExtractor.FoundText.Elements)
								{
									// Convert from document Points to pixels
									Rectangle pixelRect = new Rectangle(
										(int) (foundPiece.Bounds.Left / 72f * renderingResolution),
										(int) (foundPiece.Bounds.Top / 72f * renderingResolution),
										(int) (foundPiece.Bounds.Width / 72f * renderingResolution),
										(int) (foundPiece.Bounds.Height / 72f * renderingResolution)
									);

									// Paint rectangle
									graphics.FillRectangle(highlightBrush, pixelRect);
								}
							} while (textExtractor.FindNext());
						}
					}

					image.Save("result.png");
					Process.Start("result.png");
				}
			}
		}
	}
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****SearchAndHighlightExample.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="12.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{8378FE44-D33E-4759-AF78-8BAF35E80587}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>SearchAndHighlightExample</RootNamespace>
    <AssemblyName>SearchAndHighlightExample</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
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
    <Reference Include="Bytescout.PDFExtractor, Version=8.5.0.2863, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\Program Files\Bytescout PDF Extractor SDK\net4.00\Bytescout.PDFExtractor.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.PDFRenderer, Version=8.5.0.2860, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\Program Files\Bytescout PDF Renderer SDK\net4.00\Bytescout.PDFRenderer.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Core" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
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

##### ****SearchAndHighlightExample.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 2013
VisualStudioVersion = 12.0.40629.0
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "SearchAndHighlightExample", "SearchAndHighlightExample.csproj", "{8378FE44-D33E-4759-AF78-8BAF35E80587}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{8378FE44-D33E-4759-AF78-8BAF35E80587}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{8378FE44-D33E-4759-AF78-8BAF35E80587}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{8378FE44-D33E-4759-AF78-8BAF35E80587}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{8378FE44-D33E-4759-AF78-8BAF35E80587}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
EndGlobal

```

<!-- code block end -->