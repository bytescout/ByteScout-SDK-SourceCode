## pdf to image with custom size with pdf renderer sdk in VB.NET using ByteScout Premium Suite

### Learn to code pdf to image with custom size with pdf renderer sdk in VB.NET: How-To tutorial

ByteScout tutorials describe the stuff for programmers who use VB.NET. ByteScout Premium Suite was made to help with pdf to image with custom size with pdf renderer sdk in VB.NET. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

 Want to speed up the application development? Then this VB.NET, code samples for VB.NET, developers help to speed up the application development and writing a code when using ByteScout Premium Suite.  Just copy and paste this VB.NET sample code to your VB.NET application's code editor, add a reference to ByteScout Premium Suite (if you haven't added yet) and you are ready to go! Enjoy writing a code with ready-to-use sample VB.NET codes to implement pdf to image with custom size with pdf renderer sdk using ByteScout Premium Suite.

ByteScout Premium Suite is available as a free trial. You may get it from our website along with all other source code samples for VB.NET applications.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Premium%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Premium%20Suite%20Question) 

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