## How to create QR code with unicode value in C# using ByteScout QR Code

### Write code in C# to create QR code with unicode value with this step-by-step tutorial

With this source code sample you may quickly learn how to create QR code with unicode value in C#. ByteScout QR Code is QR Code barcode generator SDK with tunnable quality and features like QR Code embedded logo or images. Supports batch generation and specialized features like encoding of vCard and other structures inside QR Code barcodes. It can be used to create QR code with unicode value using C#.

Fast application programming interfaces of ByteScout QR Code for C# plus the instruction and the code below will help you quickly learn how to create QR code with unicode value. Just copy and paste the code into your C# application’s code and follow the instruction. Test C# sample code examples whether they respond your needs and requirements for the project.

Free trial version of ByteScout QR Code is available on our website. Documentation and source code samples are included.

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
using System.Text;
using System.Diagnostics;
using Bytescout.BarCode;

namespace UnicodeValue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and activate QRCode instance 
            using (QRCode barcode = new QRCode("demo", "demo"))
            {
                // Set the character encoding to UTF8
                barcode.CharacterEncoding = Encoding.UTF8;

                // Set Unicode barcode value
                barcode.Value = "日本";

                // Show barcode caption (optional)
                barcode.DrawCaption = true;

                // Save barcode image to file
                barcode.SaveImage("result.png");
            }

            // Open the image in default image viewer (for the demo purpose)
            Process.Start("result.png");
        }
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****UnicodeValue.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{A657F388-7D2A-4C05-9E04-6F6FAFF16F0C}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>UnicodeValue</RootNamespace>
    <AssemblyName>UnicodeValue</AssemblyName>
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
    <Reference Include="Bytescout.BarCode.QRCode, Version=1.0.0.100, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout QR Code SDK\net40\Bytescout.BarCode.QRCode.dll</HintPath>
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

##### ****UnicodeValue.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 11.00
# Visual Studio 2010
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "UnicodeValue", "UnicodeValue.csproj", "{A657F388-7D2A-4C05-9E04-6F6FAFF16F0C}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{A657F388-7D2A-4C05-9E04-6F6FAFF16F0C}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{A657F388-7D2A-4C05-9E04-6F6FAFF16F0C}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{A657F388-7D2A-4C05-9E04-6F6FAFF16F0C}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{A657F388-7D2A-4C05-9E04-6F6FAFF16F0C}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
EndGlobal

```

<!-- code block end -->