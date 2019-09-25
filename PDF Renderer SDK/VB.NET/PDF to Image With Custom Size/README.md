## How to convert PDF to PNG in VB.NET using ByteScout PDF Renderer SDK

### How to convert PDF to PNG in VB.NET

Every ByteScout tool contains example VB.NET source codes that you can find here or in the folder with installed ByteScout product. ByteScout PDF Renderer SDK is the component (SDK) that renders PDF into high quality images and thumbnails. Includes various functions like page by page processing, BMP, PNG, TIFF or stream output. Can be used from web and desktop applications. It can convert PDF to PNG in VB.NET.

This code snippet below for ByteScout PDF Renderer SDK works best when you need to quickly convert PDF to PNG in your VB.NET application. Just copy and paste the code into your VB.NET application’s code and follow the instruction. You can use these VB.NET sample examples in one or many applications.

ByteScout PDF Renderer SDK free trial version is available on our website. VB.NET and other programming languages are supported.

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

##### ****PDF2ImageWithCustomSize.VS2005.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{FD27D536-AE58-41B6-89AC-EEFF1BBFC4AD}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>PDF2ImageWithCustomSize</RootNamespace>
    <AssemblyName>PDF2ImageWithCustomSize</AssemblyName>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
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
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDFRenderer, Version=1.10.0.98, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.vb" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="..\..\multipage.pdf">
      <Link>multipage.pdf</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****PDF2ImageWithCustomSize.VS2008.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build" ToolsVersion="3.5">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.21022</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{FD27D536-AE58-41B6-89AC-EEFF1BBFC4AD}</ProjectGuid>
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
    <DefineConstants>DEBUG,TRACE</DefineConstants>
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
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDFRenderer, Version=1.10.0.98, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.vb" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="..\..\multipage.pdf">
      <Link>multipage.pdf</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****PDF2ImageWithCustomSize.VS2010.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{FD27D536-AE58-41B6-89AC-EEFF1BBFC4AD}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>PDF2ImageWithCustomSize</RootNamespace>
    <AssemblyName>PDF2ImageWithCustomSize</AssemblyName>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
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
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDFRenderer, Version=1.10.0.98, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.vb" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="..\..\multipage.pdf">
      <Link>multipage.pdf</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.vb:**
    
```
Imports System.Collections.Generic
Imports Bytescout.PDFRenderer


Class Program
    Friend Shared Sub Main(args As String())

        ' Specify Image Generation Inputs
        Dim imageGenerationInputs As New ImageGenerationInputs()

        imageGenerationInputs.AddCustomSize(width:=320, height:=420)
        imageGenerationInputs.AddCustomSize(width:=600, height:=800)

        imageGenerationInputs.EnableSaveAsPng = True
        imageGenerationInputs.EnableSaveAsJpeg = True
        imageGenerationInputs.EnableSaveAsTiff = True

        ' Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.
        Dim renderer As New RasterRenderer()
        renderer.RegistrationName = "demo"
        renderer.RegistrationKey = "demo"

        ' Load PDF document.
        renderer.LoadDocumentFromFile("multipage.pdf")

        ' Specify Rendering Options to fine tune output generation
        Dim RenderingOptions As New RenderingOptions()
        RenderingOptions.TIFFCompression = TIFFCompression.None
        RenderingOptions.VectorSmoothingMode = GraphicsTransformationQuality.HighQuality

        ' Loop through each custom size specified
        For Each itmCustomSize As KeyValuePair(Of Int32, Int32) In imageGenerationInputs.CustomSizes

            ' Loop through all pages
            For pageIndex As Integer = 0 To renderer.GetPageCount() - 1

                ' Perform save as PNG, if specified
                If imageGenerationInputs.EnableSaveAsPng Then

                    Dim pngImageName As String = $"output_{itmCustomSize.Key}x{itmCustomSize.Value}_page{pageIndex + 1}.png"

                    ' Save png image per page, per custom size
                    renderer.Save(
                            destFileName:=pngImageName,
                            outputFormat:=RasterImageFormat.PNG,
                            pageIndex:=pageIndex,
                            width:=itmCustomSize.Key,
                            height:=itmCustomSize.Value,
                            renderingOptions:=RenderingOptions
                            )

                    Console.WriteLine(pngImageName + " - Generated")

                End If

                ' Perform save as JPG, if specified
                If imageGenerationInputs.EnableSaveAsJpeg Then

                    Dim jpgImageName As String = $"output_{itmCustomSize.Key}x{itmCustomSize.Value}_page{pageIndex + 1}.jpg"

                    ' Save jpg image per page, per custom size
                    renderer.Save(
                            destFileName:=jpgImageName,
                            outputFormat:=RasterImageFormat.JPEG,
                            pageIndex:=pageIndex,
                            width:=itmCustomSize.Key,
                            height:=itmCustomSize.Value,
                            renderingOptions:=RenderingOptions
                            )

                    Console.WriteLine(jpgImageName + " - Generated")

                End If

            Next

            ' Perform save as TIFF, if specified
            If imageGenerationInputs.EnableSaveAsTiff Then

                Dim tiffImageName As String = $"output_{itmCustomSize.Key}x{itmCustomSize.Value}.tiff"

                ' Save tiff image per page, per custom size
                renderer.SaveMultipageTiff(
                        destFileName:=tiffImageName,
                        startPageIndex:=0,
                        endPageIndex:=renderer.GetPageCount() - 1,
                        width:=itmCustomSize.Key,
                        height:=itmCustomSize.Value,
                        renderingOptions:=RenderingOptions)

                Console.WriteLine(tiffImageName + " - Generated")

            End If

        Next


        ' Cleanup
        renderer.Dispose()

        Console.ReadLine()

    End Sub

End Class


Class ImageGenerationInputs

#Region "Constructors"

    Public Sub New()
        CustomSizes = New List(Of KeyValuePair(Of Integer, Integer))()
        EnableSaveAsPng = True
    End Sub

#End Region

#Region "Properties"

    Public Property CustomSizes As List(Of KeyValuePair(Of Int32, Int32))

    Public Property EnableSaveAsPng As Boolean

    Public Property EnableSaveAsJpeg As Boolean

    Public Property EnableSaveAsTiff As Boolean

#End Region

#Region "Methods"

    Public Sub AddCustomSize(ByVal width As Int32, ByVal height As Int32)

        CustomSizes.Add(New KeyValuePair(Of Integer, Integer)(width, height))

    End Sub

#End Region

End Class
```

<!-- code block end -->