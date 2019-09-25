## How to convert PDF to PNG in C# using ByteScout PDF Renderer SDK

### Write code in C# to convert PDF to PNG with this step-by-step tutorial

The code below will help you to implement an C# app to convert PDF to PNG. ByteScout PDF Renderer SDK is the component (SDK) that renders PDF into high quality images and thumbnails. Includes various functions like page by page processing, BMP, PNG, TIFF or stream output. Can be used from web and desktop applications. It can convert PDF to PNG in C#.

C# code samples for C# developers help to speed up coding of your application when using ByteScout PDF Renderer SDK. In order to implement the functionality, you should copy and paste this code for C# below into your code editor with your app, compile and run your application. Test C# sample code examples whether they respond your needs and requirements for the project.

Free trial version of ByteScout PDF Renderer SDK is available on our website. Documentation and source code samples are included.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Renderer%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Renderer%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=eenhl7106lA](https://www.youtube.com/watch?v=eenhl7106lA)




<!-- code block begin -->

##### ****PDF2ImageWithCustomSize.NETCore.csproj:**
    
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
    <None Include="..\..\multipage.pdf" Link="multipage.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <ItemGroup>
    <PackageReference Include="Microsoft.Windows.Compatibility" Version="2.0.0" />
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDFRenderer">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF Renderer SDK\netcoreapp2.0\Bytescout.PDFRenderer.dll</HintPath>
    </Reference>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****PDF2ImageWithCustomSize.VS2005.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{4DC92621-B013-4A93-982B-22AAB223A267}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>PDF2ImageWithCustomSize</RootNamespace>
    <AssemblyName>PDF2ImageWithCustomSize</AssemblyName>
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
    <Reference Include="Bytescout.PDFRenderer, Version=1.10.0.98, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="..\..\multipage.pdf">
      <Link>multipage.pdf</Link>
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

##### ****PDF2ImageWithCustomSize.VS2008.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="3.5">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.21022</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{4DC92621-B013-4A93-982B-22AAB223A267}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>PDF2ImageWithCustomSize</RootNamespace>
    <AssemblyName>PDF2ImageWithCustomSize</AssemblyName>
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
    <Reference Include="Bytescout.PDFRenderer, Version=1.10.0.98, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="..\..\multipage.pdf">
      <Link>multipage.pdf</Link>
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

##### ****PDF2ImageWithCustomSize.VS2010.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{4DC92621-B013-4A93-982B-22AAB223A267}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>PDF2ImageWithCustomSize</RootNamespace>
    <AssemblyName>PDF2ImageWithCustomSize</AssemblyName>
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
    <Reference Include="Bytescout.PDFRenderer, Version=1.10.0.98, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="..\..\multipage.pdf">
      <Link>multipage.pdf</Link>
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
using System.Collections.Generic;
using System.Diagnostics;
using Bytescout.PDFRenderer;


namespace PDF2ImageWithCustomSize
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify Image Generation Inputs
            ImageGenerationInputs imageGenerationInputs = new ImageGenerationInputs();

            imageGenerationInputs.AddCustomSize(width: 320, height: 420);
            imageGenerationInputs.AddCustomSize(width: 600, height: 800);

            imageGenerationInputs.EnableSaveAsPng = true;
            imageGenerationInputs.EnableSaveAsJpeg = true;
            imageGenerationInputs.EnableSaveAsTiff = true;

            // Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it
            RasterRenderer renderer = new RasterRenderer();
            renderer.RegistrationName = "demo";
            renderer.RegistrationKey = "demo";

            // Load PDF document
            renderer.LoadDocumentFromFile("multipage.pdf");

            // Specify Rendering Options to fine tune output generation
            RenderingOptions renderingOptions = new RenderingOptions();
            renderingOptions.TIFFCompression = TIFFCompression.None;
            renderingOptions.VectorSmoothingMode = GraphicsTransformationQuality.HighQuality;

            // Loop through each custom size specified
            foreach (var itmCustomSize in imageGenerationInputs.CustomSizes)
            {
                // Loop through all pages
                for (int pageIndex = 0; pageIndex < renderer.GetPageCount(); pageIndex++)
                {
                    // Perform save as PNG, if specified
                    if (imageGenerationInputs.EnableSaveAsPng)
                    {
                        var pngImageName = $"output_{itmCustomSize.Key}x{itmCustomSize.Value}_page{pageIndex + 1}.png";

                        // Save png image per page, per custom size
                        renderer.Save(
                            destFileName: pngImageName,
                            outputFormat: RasterImageFormat.PNG,
                            pageIndex: pageIndex,
                            width: itmCustomSize.Key,
                            height: itmCustomSize.Value,
                            renderingOptions: renderingOptions
                            );

                        Console.WriteLine(pngImageName + " - Generated");
                    }

                    // Perform save as JPG, if specified
                    if (imageGenerationInputs.EnableSaveAsJpeg)
                    {
                        var jpgImageName = $"output_{itmCustomSize.Key}x{itmCustomSize.Value}_page{pageIndex + 1}.jpg";

                        // Save jpg image per page, per custom size
                        renderer.Save(
                            destFileName: jpgImageName,
                            outputFormat: RasterImageFormat.JPEG,
                            pageIndex: pageIndex,
                            width: itmCustomSize.Key,
                            height: itmCustomSize.Value,
                            renderingOptions: renderingOptions
                            );

                        Console.WriteLine(jpgImageName + " - Generated");
                    }
                }

                // Perform save as TIFF, if specified
                if (imageGenerationInputs.EnableSaveAsTiff)
                {
                    var tiffImageName = $"output_{itmCustomSize.Key}x{itmCustomSize.Value}.tiff";

                    // Save tiff image per page, per custom size
                    renderer.SaveMultipageTiff(
                        destFileName: tiffImageName,
                        startPageIndex: 0,
                        endPageIndex: renderer.GetPageCount() - 1,
                        width: itmCustomSize.Key,
                        height: itmCustomSize.Value,
                        renderingOptions: renderingOptions);

                    Console.WriteLine(tiffImageName + " - Generated");
                }
            }

            // Cleanup
            renderer.Dispose();

            Console.ReadLine();
        }
    }

    class ImageGenerationInputs
    {
        #region Constructor

        public ImageGenerationInputs()
        {
            CustomSizes = new List<KeyValuePair<int, int>>();
            EnableSaveAsPng = true;
        }

        #endregion

        #region Properties

        public List<KeyValuePair<int, int>> CustomSizes { get; set; }

        public bool EnableSaveAsPng { get; set; }

        public bool EnableSaveAsJpeg { get; set; }

        public bool EnableSaveAsTiff { get; set; }

        #endregion

        #region Methods

        public void AddCustomSize(int width, int height)
        {
            this.CustomSizes.Add(new KeyValuePair<int, int>(width, height));
        }

        #endregion
    }

}

```

<!-- code block end -->