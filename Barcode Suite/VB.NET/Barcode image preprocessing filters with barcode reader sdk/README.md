## barcode image preprocessing filters with barcode reader sdk in VB.NET using ByteScout Barcode Suite

### barcode image preprocessing filters with barcode reader sdk in VB.NET

The documentation is crafted to assist you to apply the features on your side easily. ByteScout Barcode Suite helps with barcode image preprocessing filters with barcode reader sdk in VB.NET. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK.

If you want to quickly learn then these fast application programming interfaces of ByteScout Barcode Suite for VB.NET plus the guideline and the VB.NET code below will help you quickly learn barcode image preprocessing filters with barcode reader sdk. If you want to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. VB.NET application implementation mostly involves various stages of the software development so even if the functionality works please check it with your data and the production environment.

Trial version along with the source code samples for VB.NET can be downloaded from our website

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

##### ****ImagePreprocessingFilters.VS2005.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{75D64BA4-2691-4BBA-A89D-B575EE05AB63}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>ImagePreprocessingFilters.Module1</StartupObject>
    <RootNamespace>ImagePreprocessingFilters</RootNamespace>
    <AssemblyName>ImagePreprocessingFilters</AssemblyName>
    <MyType>Console</MyType>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>ImagePreprocessingFilters.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>ImagePreprocessingFilters.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCodeReader, Version=8.20.0.1340, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Reader SDK\net2.00\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Collections" />
    <Import Include="System.Collections.Generic" />
    <Import Include="System.Data" />
    <Import Include="System.Diagnostics" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Module1.vb" />
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
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.targets" />
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

##### ****ImagePreprocessingFilters.VS2008.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="3.5">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.30729</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{75D64BA4-2691-4BBA-A89D-B575EE05AB63}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>ImagePreprocessingFilters.Module1</StartupObject>
    <RootNamespace>ImagePreprocessingFilters</RootNamespace>
    <AssemblyName>ImagePreprocessingFilters</AssemblyName>
    <MyType>Console</MyType>
    <OldToolsVersion>2.0</OldToolsVersion>
    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>ImagePreprocessingFilters.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>ImagePreprocessingFilters.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCodeReader, Version=8.20.0.1340, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Reader SDK\net3.50\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Collections" />
    <Import Include="System.Collections.Generic" />
    <Import Include="System.Data" />
    <Import Include="System.Diagnostics" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Module1.vb" />
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
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
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

##### ****ImagePreprocessingFilters.VS2010.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{75D64BA4-2691-4BBA-A89D-B575EE05AB63}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>ImagePreprocessingFilters.Module1</StartupObject>
    <RootNamespace>ImagePreprocessingFilters</RootNamespace>
    <AssemblyName>ImagePreprocessingFilters</AssemblyName>
    <MyType>Console</MyType>
    <OldToolsVersion>3.5</OldToolsVersion>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>ImagePreprocessingFilters.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>ImagePreprocessingFilters.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCodeReader, Version=8.20.0.1340, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Reader SDK\net4.00\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Collections" />
    <Import Include="System.Collections.Generic" />
    <Import Include="System.Data" />
    <Import Include="System.Diagnostics" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Module1.vb" />
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
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
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

##### ****Module1.vb:**
    
```
Imports Bytescout.BarCodeReader

Module Module1
    ''' <summary>
    ''' This exmaple demonstrates the use of image filters to improve the decoding or speed.
    ''' </summary>
    Sub Main()

        Using reader As New Reader("demo", "demo")

            ' Set barcode type to find
            reader.BarcodeTypesToFind.Code128 = True


            ' WORKING WITH LOW CONTRAST BARCODE IMAGES

            ' Add the contrast adjustment for the low contrast image
            reader.ImagePreprocessingFilters.AddContrast(40)

            Console.WriteLine("Image {0}", "low-contrast-barcode.png")

            ' -----------------------------------------------------------------------
            ' NOTE: We can read barcodes from specific page to increase performance .
            ' For sample please refer to "Decoding barcodes from PDF by pages" program.
            ' ----------------------------------------------------------------------- 

            Dim barcodes As FoundBarcode() = reader.ReadFrom("low-contrast-barcode.png")

            If barcodes.Length = 0 Then
                Console.WriteLine("No barcode found!")
            Else
                For Each barcode As FoundBarcode In barcodes
                    Console.WriteLine("Found barcode {0} with value '{1}'", barcode.Type, barcode.Value)
                Next
            End If

            reader.ImagePreprocessingFilters.Clear()
            Console.WriteLine()


            ' WORKING WITH NOISY BARCODE IMAGES

            ' Add the median filter to lower the noise
            reader.ImagePreprocessingFilters.AddMedian()

            Console.WriteLine("Image {0}", "noisy-barcode.png")

            barcodes = reader.ReadFrom("noisy-barcode.png")

            If barcodes.Length = 0 Then
                Console.WriteLine("No barcode found!")
            Else
                For Each barcode As FoundBarcode In barcodes
                    Console.WriteLine("Found barcode {0} with value '{1}'", barcode.Type, barcode.Value)
                Next
            End If

            reader.ImagePreprocessingFilters.Clear()
            Console.WriteLine()


            ' WORKING WITH DENSE AND ILLEGIBLE BARCODES

            ' Add the scale filter to enlarge the barcode to make gaps between bars more distinguishable
            reader.ImagePreprocessingFilters.AddScale(2) ' enlarge twice

            Console.WriteLine("Image {0}", "too-dense-barcode.png")

            barcodes = reader.ReadFrom("too-dense-barcode.png")

            If barcodes.Length = 0 Then
                Console.WriteLine("No barcode found!")
            Else
                For Each barcode As FoundBarcode In barcodes
                    Console.WriteLine("Found barcode {0} with value '{1}'", barcode.Type, barcode.Value)
                Next
            End If

            reader.ImagePreprocessingFilters.Clear()
            Console.WriteLine()


            ' REMOVE EMPTY MARGINS FROM IMAGE TO SPEED UP THE PROCESSING

            ' Add the crop filter to cut off empty margins from the image.
            ' This will not improve the recognition quality but may speed up the processing 
            ' if you enabled multiple barcode types to search. 
            reader.ImagePreprocessingFilters.AddCropDark()

            Console.WriteLine("Image {0}", "barcode-with-large-margins.png")

            barcodes = reader.ReadFrom("barcode-with-large-margins.png")

            If barcodes.Length = 0 Then
                Console.WriteLine("No barcode found!")
            Else
                For Each barcode As FoundBarcode In barcodes
                    Console.WriteLine("Found barcode {0} with value '{1}'", barcode.Type, barcode.Value)
                Next
            End If

            reader.ImagePreprocessingFilters.Clear()
            Console.WriteLine()

        End Using

        Console.WriteLine("Press any key to exit..")
        Console.ReadKey()

    End Sub

End Module

```

<!-- code block end -->