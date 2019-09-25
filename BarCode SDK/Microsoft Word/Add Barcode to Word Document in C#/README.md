## How to add barcode to word document in c# in Microsoft Word with ByteScout Barcode SDK

### The tutorial shows how to add barcode to word document in c# in Microsoft Word

Add barcode to word document in c# is easy to implement in Microsoft Word if you use these source codes below. ByteScout Barcode SDK is the fully featured library to generate barcodes. Supports QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix and many other barcode types. Includes various options for barcode generation to ensure output quality, add barcodes to new or existing pdf files and images. It can be used to add barcode to word document in c# using Microsoft Word.

You will save a lot of time on writing and testing code as you may just take the Microsoft Word code from ByteScout Barcode SDK for add barcode to word document in c# below and use it in your application. Just copy and paste the code into your Microsoft Word application’s code and follow the instruction. You can use these Microsoft Word sample examples in one or many applications.

You can download free trial version of ByteScout Barcode SDK from our website to see and try many others source code samples for Microsoft Word.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=REnj3A-oSPI](https://www.youtube.com/watch?v=REnj3A-oSPI)




<!-- code block begin -->

##### ****InsertIntoMicrosoftWordDocument.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="3.5" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.21022</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{5E6D16A0-8122-4755-96BE-EAC44222D7BF}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>InsertIntoMicrosoftWordDocument</RootNamespace>
    <AssemblyName>InsertIntoMicrosoftWordDocument</AssemblyName>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
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
    <Reference Include="Bytescout.BarCode, Version=1.0.0.0, Culture=neutral, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
  </ItemGroup>
  <ItemGroup>
    <COMReference Include="Microsoft.Office.Core">
      <Guid>{2DF8D04C-5BFA-101B-BDE5-00AA0044DE52}</Guid>
      <VersionMajor>2</VersionMajor>
      <VersionMinor>3</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
    <COMReference Include="VBIDE">
      <Guid>{0002E157-0000-0000-C000-000000000046}</Guid>
      <VersionMajor>5</VersionMajor>
      <VersionMinor>3</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
    <COMReference Include="Word">
      <Guid>{00020905-0000-0000-C000-000000000046}</Guid>
      <VersionMajor>8</VersionMajor>
      <VersionMinor>3</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
  </ItemGroup>

  <ItemGroup>
    <Content Include="input.doc">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>

  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
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
/*
 IMPORTANT:
 Copy input.doc to your my documents folder
 and change the path to "input.doc" below 
 Word requires to provide absolute path to input files
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

using Bytescout.BarCode;

namespace InsertIntoMicrosoftWordDocument
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // Create new barcode
            Barcode barcode = new Barcode();

            // Set symbology
            barcode.Symbology = SymbologyType.Codabar;
            // Set value
            barcode.Value = "123456";

            // Add checksum to barcode
            barcode.AddChecksum = true;

            // Create word instance
            Microsoft.Office.Interop.Word.Application appWord = new Microsoft.Office.Interop.Word.Application();

            // Hide word
            appWord.Visible = false;

            // Create missing object
            object mis = System.Reflection.Missing.Value;
            // Template file - change to the appropraite path where you copied input.doc
            object fileInput = @"C:\input.doc";
            // Template file - change to the appropraite path where you copied input.doc
            object fileOutput = @"C:\output.doc";

            // Open document
            Microsoft.Office.Interop.Word.Document docWord = appWord.Documents.Open(ref fileInput, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis);

            // Set bookmark name
            object bookmarkName = "MyBookmark";

            // Get bookmark location
            Microsoft.Office.Interop.Word.Range bookmarkLocation = docWord.Bookmarks.get_Item(ref bookmarkName).Range;

            // Get barcode image
            Bitmap image = (Bitmap)barcode.GetImage();

            // Copy image to the clipboard
            Clipboard.SetDataObject(image);

            // Paste barcode image to the document
            bookmarkLocation.Paste();

            // Save to the new document
            docWord.SaveAs(ref fileOutput, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis); 

            // We needn't save changes
            object saveChanges = false;

            // Close word application
            appWord.Quit(ref saveChanges, ref mis, ref mis);

            // Release COM object
            System.Runtime.InteropServices.Marshal.ReleaseComObject(appWord);
        }
    }
}

```

<!-- code block end -->