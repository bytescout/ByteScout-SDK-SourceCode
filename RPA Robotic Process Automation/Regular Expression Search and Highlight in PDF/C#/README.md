## How to regular expression search and highlight in PDF in C# using Multiple ByteScout SDK

### This code in C# shows how to regular expression search and highlight in PDF with this how to tutorial

The documentation is designed to help you to implement the features on your side. Multiple ByteScout SDK is the set of few ByteScout SDK libraries that is used in apps performing multi-step workflows like searching for keywords or phrases inside existing documents with highlighting of results, or adding e-signature to existing document pdf based on the analysis of visual content in another document. It can regular expression search and highlight in PDF in C#.

C# code samples for C# developers help to speed up coding of your application when using Multiple ByteScout SDK. In order to implement the functionality, you should copy and paste this code for C# below into your code editor with your app, compile and run your application. Test C# sample code examples whether they respond your needs and requirements for the project.

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

##### ****Program.cs:**
    
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