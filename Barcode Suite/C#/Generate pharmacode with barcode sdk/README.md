## How to generate pharmacode with barcode sdk in C# using ByteScout Barcode Suite

### This code in C# shows how to generate pharmacode with barcode sdk with this how to tutorial

Source code documentation samples give simple and easy method to install a needed feature into your application. Want to generate pharmacode with barcode sdk in your C# app? ByteScout Barcode Suite is designed for it. ByteScout Barcode Suite is the bundle that privides 3  SDK products to generate barcodes (Barcode SDK), read barcodes (Barcode Reaer SDK) and read and write spreadsheets (Spreadsheet SDK).

The SDK samples given below describe how to quickly make your application do generate pharmacode with barcode sdk in C# with the help of ByteScout Barcode Suite. Follow the instructions from scratch to work and copy the C# code. Applying C# application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

ByteScout provides the free trial version of ByteScout Barcode Suite along with the documentation and source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20Suite%20Question) 

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

##### ****GeneratePharmaCode.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{99735776-2956-463D-9795-EBCE16928C30}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>GeneratePharmaCode</RootNamespace>
    <AssemblyName>GeneratePharmaCode</AssemblyName>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
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
    <Reference Include="Bytescout.BarCode, Version=4.80.0.993, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout BarCode Generator SDK\net2.00\Bytescout.BarCode.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Drawing" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.cs:**
    
```
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using Bytescout.BarCode;

namespace GeneratePharmaCode
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create new barcode
                using (Barcode barcode = new Barcode())
                {
                    barcode.RegistrationName = "demo";
                    barcode.RegistrationKey = "demo";

                    // Set symbology
                    barcode.Symbology = SymbologyType.PharmaCode;

                    // optional margins
                    barcode.Margins = new Margins(5, 5, 5, 5);

                    // Set Value
                    barcode.Value = "12345";

                    // Set PharmaCode options:
                    //barcode.Options.PharmaCodeSupplementaryCode = true;
                    //barcode.Options.PharmaCodeSupplementaryBarColor = Color.Orange;
                    //barcode.Options.PharmaCodeMiniature = true;
                    //barcode.Options.PharmaCodeTwoTrack = true;

                    // Save 300 DPI Image
                    barcode.ResolutionX = barcode.ResolutionY = 300;
                    barcode.SaveImage("300dpi.png", ImageFormat.Png);

                    // Save 600 DPI Image
                    barcode.ResolutionX = barcode.ResolutionY = 600;
                    barcode.SaveImage("600dpi.png", ImageFormat.Png);
                }

                // Show image in default image viewer
                Process.Start("300dpi.png");
                Process.Start("600dpi.png");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press enter key to exit...");
            Console.ReadLine();
        }
    }
}
```

<!-- code block end -->