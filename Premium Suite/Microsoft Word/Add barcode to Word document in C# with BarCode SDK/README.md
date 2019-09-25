## How to add barcode to word document in c# with barcode SDK in Microsoft Word using ByteScout Premium Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to add barcode to word document in c# with barcode SDK in Microsoft Word

The sample shows instructions and algorithm of how to add barcode to word document in c# with barcode SDK and how to make it run in your Microsoft Word application. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can add barcode to word document in c# with barcode SDK in Microsoft Word.

Want to quickly learn? This fast application programming interfaces of ByteScout Premium Suite for Microsoft Word plus the guidelines and the code below will help you quickly learn how to add barcode to word document in c# with barcode SDK.  Simply copy and paste in your Microsoft Word project or application you and then run your app! If you want to use these Microsoft Word sample examples in one or many applications then they can be used easily.

Trial version of ByteScout Premium Suite is available for free. Source code samples are included to help you with your Microsoft Word app.

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