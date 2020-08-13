## How to regular expression search and highlight in PDF in C# using ByteScout Robotic Process Automation ByteScout Robotic Process Automation is set of integrated APIs for quick replaccement of manual data processing with robotic process automations.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Robotic%20Process%20Automation%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Robotic%20Process%20Automation%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore Documentation](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Explore Source Code Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://app.pdf.co/signup?utm_source=github-readme)
[Security](https://pdf.co/security)
[Explore Web API Documentation](https://apidocs.pdf.co?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=gEjuZ0zgtHo](https://www.youtube.com/watch?v=gEjuZ0zgtHo)




<!-- code block begin -->

##### **Program.cs:**
    
```
using System.Diagnostics;
using System.Drawing;
using Bytescout.PDFExtractor;
using Bytescout.PDF;
using Pen = Bytescout.PDF.Pen;
using SolidBrush = Bytescout.PDF.SolidBrush;

namespace SearchAndHighlightExample
{
	class Program
	{
		static void Main(string[] args)
		{
			const string inputFile = @"sample.pdf";
			const int pageIndex = 0;
			const string searchPattern = "\\d+\\.\\d+";

			// Prepare TextExtractor
			using (TextExtractor textExtractor = new TextExtractor("demo", "demo"))
			{
				textExtractor.RegexSearch = true;
				textExtractor.LoadDocumentFromFile(inputFile);

				// Load document with PDF SDK
				using (Document pdfDocument = new Document(inputFile))
				{
					pdfDocument.RegistrationName = "demo";
                	pdfDocument.RegistrationKey = "demo";

					Page pdfDocumentPage = pdfDocument.Pages[pageIndex];
					Canvas canvas = pdfDocumentPage.Canvas;

					SolidBrush fillBrush = new SolidBrush(new ColorRGB(255, 0, 0));
					fillBrush.Opacity = 50; // make the brush transparent

					// Search for pattern and highlight found pieces
					if (textExtractor.Find(pageIndex, searchPattern, caseSensitive: false))
					{
						do
						{
							foreach (var foundPiece in textExtractor.FoundText.Elements)
							{
								// Inflate the rectangle a bit
								RectangleF rect = RectangleF.Inflate(foundPiece.Bounds, 1, 2);
								// Draw rectangle over the PDF page
								canvas.DrawRectangle(fillBrush, rect);
							}
						} while (textExtractor.FindNext());
					}

					// Save as new PDF document
					pdfDocument.Save("result.pdf");

					// Open result document in default associated application (for demo purposes)
					Process.Start("result.pdf");
				}
			}
		}
	}
}

```

<!-- code block end -->    

<!-- code block begin -->

##### **SearchAndHighlightExample.csproj:**
    
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
    <Reference Include="Bytescout.PDF, Version=1.5.0.190, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\Program Files\Bytescout PDF SDK\net4.0\Bytescout.PDF.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.PDFExtractor, Version=8.5.0.2863, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\Program Files\Bytescout PDF Extractor SDK\net4.00\Bytescout.PDFExtractor.dll</HintPath>
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

##### **SearchAndHighlightExample.sln:**
    
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