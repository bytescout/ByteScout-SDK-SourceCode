## How to convert vcard to QR code in C# and ByteScout QR Code

### This tutorial will show how to convert vcard to QR code in C#

ByteScout tutorials are designed to explain the code for both C# beginners and advanced programmers. ByteScout QR Code can convert vcard to QR code. It can be used from C#. ByteScout QR Code is QR Code generation library. It provides full control on the quality, features and encoding. Can embed logo image right into QR Code itself. Batch barcode generation, and many special features like vCard or URL encoding are also supported.

You will save a lot of time on writing and testing code as you may just take the C# code from ByteScout QR Code for convert vcard to QR code below and use it in your application. In your C# project or application you may simply copy & paste the code and then run your app! Enjoy writing a code with ready-to-use sample C# codes.

ByteScout free trial version is available for download from our website. It includes all these programming tutorials along with source code samples.

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
using System.Drawing.Imaging;
using System.IO;
using Bytescout.BarCode;
using Thought.vCards;

namespace GenerateVCardQRCode
{
	/// <summary>
	/// This example demonstrates generation of QR Code encoded vCard.
	/// It uses vCard library by David Pinch:
	/// 
	/// vCard Class Library for .NET (Version 0.4; LGPL license)
	/// Copyright (c) 2007-2009 David Pinch 
	/// http://www.thoughtproject.com/Libraries/vCard/
	/// 
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			// Generate vCard
			vCard vCard = new vCard();
			vCard.GivenName = "Forrest";
			vCard.FamilyName = "Gump";
			vCard.Organization = "Bubba Gump Shrimp Co.";
			vCard.Title = "Shrimp Man";
			vCard.Phones.Add(new vCardPhone("(111) 555-1212", vCardPhoneTypes.Home));
			vCard.EmailAddresses.Add(new vCardEmailAddress("forrestgump@example.com", vCardEmailAddressType.Internet));
			
			vCardDeliveryAddress address = new vCardDeliveryAddress();
			address.AddressType.Add(vCardDeliveryAddressTypes.Home);
			address.Street = "100 Waters Edge";
			address.City = "Baytown";
			address.Region = "LA";
			address.PostalCode = "30314";
			address.Country = "United States of America";
			vCard.DeliveryAddresses.Add(address);

			// Save vCard data to string
			vCardStandardWriter writer = new vCardStandardWriter();
			StringWriter stringWriter = new StringWriter();
			writer.Write(vCard, stringWriter);

			// Create and activate Bytescout.Barcode.QRCode instance
			using (QRCode barcode = new QRCode("demo", "demo"))
			{
				// Set barcode value
				barcode.Value = stringWriter.ToString();
				// Save barcode to image
				barcode.SaveImage("result.png", ImageFormat.Png);
			}

		    // Open generated barcode image in default associated application 
		    Process.Start("result.png");
        }
	}
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****packages.config:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="Thought.vCards" version="1.0.9" targetFramework="net20" requireReinstallation="true" />
</packages>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****vCardQRCode.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{2E45E9EF-7D6B-45F8-963F-AD1B246EB641}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>vCardQRCode</RootNamespace>
    <AssemblyName>vCardQRCode</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
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
    <Reference Include="Bytescout.BarCode.QRCode, Version=1.0.0.100, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout QR Code SDK\net40\Bytescout.BarCode.QRCode.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
    <Reference Include="Thought.vCards">
      <HintPath>packages\Thought.vCards.1.0.9\lib\net40\Thought.vCards.dll</HintPath>
    </Reference>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
  </ItemGroup>
  <ItemGroup>
    <None Include="packages.config" />
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

##### ****vCardQRCode.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.28010.2003
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "vCardQRCode", "vCardQRCode.csproj", "{2E45E9EF-7D6B-45F8-963F-AD1B246EB641}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{2E45E9EF-7D6B-45F8-963F-AD1B246EB641}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{2E45E9EF-7D6B-45F8-963F-AD1B246EB641}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{2E45E9EF-7D6B-45F8-963F-AD1B246EB641}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{2E45E9EF-7D6B-45F8-963F-AD1B246EB641}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {2EF74C21-75D6-4CB9-8C3B-8DE48CD63854}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->