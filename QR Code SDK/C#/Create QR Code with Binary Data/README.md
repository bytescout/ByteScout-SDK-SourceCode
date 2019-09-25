## How to create QR code with binary data in C# using ByteScout QR Code

### Tutorial on how to create QR code with binary data in C#

Every ByteScout tool contains example C# source codes that you can find here or in the folder with installed ByteScout product. ByteScout QR Code is the SDK for QR Code barcode generation. This SDK provides full set of features to control output barcodes quality, encoding, size, features. You may change output zize, set an image to be embedded into QR Code barcode generated. Includes special features to encode contact card, URL, phone and other information into QR Code barcode. Can run in batch barcode generation mode. It can create QR code with binary data in C#.

C# code samples for C# developers help to speed up coding of your application when using ByteScout QR Code. In your C# project or application you may simply copy & paste the code and then run your app! Further enhancement of the code will make it more vigorous.

Trial version of ByteScout QR Code is available for free. Source code samples are included to help you with your C# app.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20QR%20Code%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20QR%20Code%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=A5hB9ul3tX0](https://www.youtube.com/watch?v=A5hB9ul3tX0)




<!-- code block begin -->

##### ****Program.cs:**
    
```
using System.Diagnostics;
using System.Text;
using Bytescout.BarCode;

namespace QRCodeWithBinaryData
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create and activate QRCode component instance
			using (QRCode barcode = new QRCode())
			{
				barcode.RegistrationName = "demo";
				barcode.RegistrationKey = "demo";

				// Sample byte array to use as value 
				byte[] byteArray = new byte[] { 0, 10, 11, 12, 13, 14, 15, 0xFF };

				// Set value by converting byte array to string 
				barcode.Value = Encoding.ASCII.GetString(byteArray);

				// Save barcode image
				barcode.SaveImage("result.png");

				// Open the image in default associated application (for the demo purpose)
				Process.Start("result.png");
			}
		}
	}
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****QRCodeWithBinaryData.csproj:**
    
```
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{52554423-9A7B-456A-8026-845D1846585E}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>QRCodeWithBinaryData</RootNamespace>
    <AssemblyName>QRCodeWithBinaryData</AssemblyName>
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
    <Reference Include="Bytescout.BarCode.QRCode, Version=1.0.0.100, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout QR Code SDK\net40\Bytescout.BarCode.QRCode.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
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

##### ****QRCodeWithBinaryData.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 11.00
# Visual Studio 2010
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "QRCodeWithBinaryData", "QRCodeWithBinaryData.csproj", "{52554423-9A7B-456A-8026-845D1846585E}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{52554423-9A7B-456A-8026-845D1846585E}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{52554423-9A7B-456A-8026-845D1846585E}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{52554423-9A7B-456A-8026-845D1846585E}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{52554423-9A7B-456A-8026-845D1846585E}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
EndGlobal

```

<!-- code block end -->