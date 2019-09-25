## How to generate and check QR code barcode with image inside in C# and Multiple ByteScout SDK

### The tutorial shows how to generate and check QR code barcode with image inside in C#

The sample source codes on this page shows how to generate and check QR code barcode with image inside in C#. Multiple ByteScout SDK is the combination of one or more ByteScout SDK components to perform complex workflows like searching for text inside documents and highlighting found results and saving as new document or splitting pdf based on visually detected horizontal lines and you can use it to generate and check QR code barcode with image inside with C#.

You will save a lot of time on writing and testing code as you may just take the C# code from Multiple ByteScout SDK for generate and check QR code barcode with image inside below and use it in your application. Just copy and paste the code into your C# application’s code and follow the instruction. Implementing C# application typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

Trial version of Multiple ByteScout SDK can be downloaded for free from our website. It also includes source code samples for C# and other programming languages.

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
using Bytescout.BarCode;
using Bytescout.BarCodeReader;


namespace QRCodeWithImage
{
	class Program
	{
		static void Main(string[] args)
		{
			// GENERATE QR CODE WITH DECOARATION IMAGE:

			const string decorationImageFile = @".\logo.png";
			const string outputFile = @".\barcode.png";
			const string barcodeValue = "1234567890 abcdefghijklmnopqrstuvwxyz 1234567890 abcdefghijklmnopqrstuvwxyz";
			
			// Create and activate barcode generator instance
			using (Barcode barcode = new Barcode("demo", "demo"))
			{
				// Set barcode type
				barcode.Symbology = Bytescout.BarCode.SymbologyType.QRCode;

				// Set high QR Code error correction level
				barcode.Options.QRErrorCorrectionLevel = QRErrorCorrectionLevel.High;

				// Set barcode value
				barcode.Value = barcodeValue;

				// Add decoration image and scale it to 15% of the barcode square
				barcode.AddDecorationImage(decorationImageFile, 15);

				// Save generated barcode
				barcode.SaveImage(outputFile);

				Console.WriteLine("Barcode saved to " + outputFile);


				// CHECK THE BARCODE IS DECODABLE:

				// Create and activate barcode reader instance
				using (Reader reader = new Reader("demo", "demo"))
				{
					// Enable QR Code decoding
					reader.BarcodeTypesToFind.QRCode = true;

					// Read barcode from generated image
					FoundBarcode[] foundBarcodes = reader.ReadFrom(outputFile);

					// Check result
					if (foundBarcodes.Length > 0 && foundBarcodes[0].Type == Bytescout.BarCodeReader.SymbologyType.QRCode)
						Console.WriteLine("Barcode is decodable.");
					else
						Console.WriteLine("Barcode is not decodable!");
				}

				Console.WriteLine();
				Console.WriteLine("Press any key...");
				Console.ReadKey();
			}
		}
	}
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****QRCodeWithImage.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="12.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{0EC915DC-3599-492C-9D20-E78F45EE834C}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>QRCodeWithImage</RootNamespace>
    <AssemblyName>QRCodeWithImage</AssemblyName>
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
    <Reference Include="Bytescout.BarCode, Version=4.63.0.972, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\..\Program Files\Bytescout BarCode Generator SDK\net4.00\Bytescout.BarCode.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.BarCodeReader, Version=10.0.0.1755, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\..\Program Files\Bytescout BarCode Reader SDK\net4.00\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Core" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="logo.png">
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

##### ****QRCodeWithImage.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 2013
VisualStudioVersion = 12.0.40629.0
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "QRCodeWithImage", "QRCodeWithImage.csproj", "{0EC915DC-3599-492C-9D20-E78F45EE834C}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{0EC915DC-3599-492C-9D20-E78F45EE834C}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{0EC915DC-3599-492C-9D20-E78F45EE834C}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{0EC915DC-3599-492C-9D20-E78F45EE834C}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{0EC915DC-3599-492C-9D20-E78F45EE834C}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
EndGlobal

```

<!-- code block end -->