## image preprocessing filters in C# with ByteScout BarCode Reader SDK

### Make image preprocessing filters in C#: ### Tutorial on how to do image preprocessing filters in C#

Every ByteScout tool contains example C# source codes that you can find here or in the folder with installed ByteScout product. ByteScout BarCode Reader SDK helps with image preprocessing filters in C#. ByteScout BarCode Reader SDK is the SDK for reading of barcodes from PDF, images and live camera or video. Almost every common type like Code 39, Code 128, GS1, UPC, QR Code, Datamatrix, PDF417 and many others are supported. Supports noisy and defective images and docs. Includes optional documents splitter and merger for pdf and tiff based on found barcodess. Batch mode is supported for superior performance using multiple threads. Decoded values are easily exported to JSON, CSV, XML and to custom format.

You will save a lot of time on writing and testing code as you may just take the code below and use it in your application. This C# sample code should be copied and pasted into your application’s code editor. Then just compile and run it to see how it works. This basic programming language sample code for C# will do the whole work for you in implementing image preprocessing filters in your app.

ByteScout BarCode Reader SDK is available as free trial. You may get it from our website along with all other source code samples for C# applications.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20BarCode%20Reader%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20BarCode%20Reader%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=EARSPJFIJMU](https://www.youtube.com/watch?v=EARSPJFIJMU)




<!-- code block begin -->

##### ****ImagePreprocessingFilters.NETCore.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp2.0</TargetFramework>
    <EnableDefaultCompileItems>false</EnableDefaultCompileItems>
    <GenerateAssemblyCompanyAttribute>false</GenerateAssemblyCompanyAttribute>
    <GenerateAssemblyConfigurationAttribute>false</GenerateAssemblyConfigurationAttribute>
    <GenerateAssemblyFileVersionAttribute>false</GenerateAssemblyFileVersionAttribute>
    <GenerateAssemblyInformationalVersionAttribute>false</GenerateAssemblyInformationalVersionAttribute>
    <GenerateAssemblyProductAttribute>false</GenerateAssemblyProductAttribute>
    <GenerateAssemblyTitleAttribute>false</GenerateAssemblyTitleAttribute>
    <GenerateAssemblyVersionAttribute>false</GenerateAssemblyVersionAttribute>
    <GenerateAssemblyCopyrightAttribute>false</GenerateAssemblyCopyrightAttribute>
    <GenerateAssemblyTrademarkAttribute>false</GenerateAssemblyTrademarkAttribute>
    <GenerateAssemblyCultureAttribute>false</GenerateAssemblyCultureAttribute>
    <GenerateAssemblyDescriptionAttribute>false</GenerateAssemblyDescriptionAttribute>
  </PropertyGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <None Include="barcode-with-large-margins.png">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="low-contrast-barcode.png">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="noisy-barcode.png">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="too-dense-barcode.png">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <ItemGroup>
    <PackageReference Include="Microsoft.Windows.Compatibility" Version="2.0.0" />
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCodeReader">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout BarCode Reader SDK\netcoreapp2.0\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ImagePreprocessingFilters.VS2005.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{C664E764-C424-4CD5-AF69-F6B05FB17BA8}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>ImagePreprocessingFilters</RootNamespace>
    <AssemblyName>ImagePreprocessingFilters</AssemblyName>
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
    <Reference Include="Bytescout.BarCodeReader, Version=8.20.0.1340, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Reader SDK\net2.00\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="barcode-with-large-margins.png">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="low-contrast-barcode.png">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="noisy-barcode.png">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="too-dense-barcode.png">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.CSharp.targets" />
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

##### ****ImagePreprocessingFilters.VS2008.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="3.5">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.30729</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{C664E764-C424-4CD5-AF69-F6B05FB17BA8}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>ImagePreprocessingFilters</RootNamespace>
    <AssemblyName>ImagePreprocessingFilters</AssemblyName>
    <OldToolsVersion>2.0</OldToolsVersion>
    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
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
    <Reference Include="Bytescout.BarCodeReader, Version=8.20.0.1340, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Reader SDK\net3.50\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="barcode-with-large-margins.png">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="low-contrast-barcode.png">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="noisy-barcode.png">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="too-dense-barcode.png">
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

##### ****ImagePreprocessingFilters.VS2010.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{C664E764-C424-4CD5-AF69-F6B05FB17BA8}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>ImagePreprocessingFilters</RootNamespace>
    <AssemblyName>ImagePreprocessingFilters</AssemblyName>
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
    <Reference Include="Bytescout.BarCodeReader">
      <HintPath>C:\Program Files\Bytescout BarCode Reader SDK\net4.00\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="barcode-with-large-margins.png">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="low-contrast-barcode.png">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="noisy-barcode.png">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="too-dense-barcode.png">
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

##### ****Program.cs:**
    
```
using System;
using Bytescout.BarCodeReader;

namespace ImagePreprocessingFilters
{
    /// <summary>
    /// This exmaple demonstrates the use of image filters to improve the decoding or speed.
    /// </summary>
    class Program
    {
        static void Main()
        {
            using (Reader reader = new Reader("demo", "demo"))
            {
                // Set barcode type to find
                reader.BarcodeTypesToFind.Code128 = true;


                // WORKING WITH LOW CONTRAST BARCODE IMAGES

                // Add contrast adjustment for low-contrast image
                reader.ImagePreprocessingFilters.AddContrast(40);

                Console.WriteLine("Image {0}", "low-contrast-barcode.png");
                
                FoundBarcode[] barcodes = reader.ReadFrom("low-contrast-barcode.png");

                if (barcodes.Length == 0)
                    Console.WriteLine("No barcode found!");
                else 
                    foreach (FoundBarcode barcode in barcodes)
                        Console.WriteLine("Found barcode {0} with value '{1}'", barcode.Type, barcode.Value);

                reader.ImagePreprocessingFilters.Clear();
                Console.WriteLine();


                // WORKING WITH NOISY BARCODE IMAGES

                // Add the median filter to lower the noise
                reader.ImagePreprocessingFilters.AddMedian();

                Console.WriteLine("Image {0}", "noisy-barcode.png");

                /* -----------------------------------------------------------------------
                NOTE: We can read barcodes from specific page to increase performance.
                For sample please refer to "Decoding barcodes from PDF by pages" program.
                ----------------------------------------------------------------------- */

                barcodes = reader.ReadFrom("noisy-barcode.png");

                if (barcodes.Length == 0)
                    Console.WriteLine("No barcode found!");
                else
                    foreach (FoundBarcode barcode in barcodes)
                        Console.WriteLine("Found barcode {0} with value '{1}'", barcode.Type, barcode.Value);

                reader.ImagePreprocessingFilters.Clear();
                Console.WriteLine();


                // WORKING WITH DENSE AND ILLEGIBLE BARCODES

                // Add the scale filter to enlarge the barcode to make gaps between bars more distinguishable
                reader.ImagePreprocessingFilters.AddScale(2d); // enlarge twice

                Console.WriteLine("Image {0}", "too-dense-barcode.png");

                barcodes = reader.ReadFrom("too-dense-barcode.png");

                if (barcodes.Length == 0)
                    Console.WriteLine("No barcode found!");
                else
                    foreach (FoundBarcode barcode in barcodes)
                        Console.WriteLine("Found barcode {0} with value '{1}'", barcode.Type, barcode.Value);

                reader.ImagePreprocessingFilters.Clear();
                Console.WriteLine();
                
                
                // REMOVE EMPTY MARGINS FROM IMAGE TO SPEED UP THE PROCESSING

                // Add the crop filter to cut off empty margins from the image.
                // This will not improve the recognition quality but may speed up the processing 
                // if you enabled multiple barcode types to search. 
                reader.ImagePreprocessingFilters.AddCropDark();

                Console.WriteLine("Image {0}", "barcode-with-large-margins.png");

                barcodes = reader.ReadFrom("barcode-with-large-margins.png");

                if (barcodes.Length == 0)
                    Console.WriteLine("No barcode found!");
                else
                    foreach (FoundBarcode barcode in barcodes)
                        Console.WriteLine("Found barcode {0} with value '{1}'", barcode.Type, barcode.Value);

                reader.ImagePreprocessingFilters.Clear();
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
    }
}

```

<!-- code block end -->