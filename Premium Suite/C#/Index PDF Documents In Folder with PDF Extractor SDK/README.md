## How to index PDF documents in folder with PDF extractor SDK in C# with ByteScout Premium Suite

### How to write a robust code in C# to index PDF documents in folder with PDF extractor SDK with this step-by-step tutorial

The sample source codes on this page shows how to index PDF documents in folder with PDF extractor SDK in C#. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording and you can use it to index PDF documents in folder with PDF extractor SDK with C#.

Want to quickly learn? This fast application programming interfaces of ByteScout Premium Suite for C# plus the guidelines and the code below will help you quickly learn how to index PDF documents in folder with PDF extractor SDK. IF you want to implement the functionality, just copy and paste this code for C# below into your code editor with your app, compile and run your application. Applying C# application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

The trial version of ByteScout Premium Suite can be downloaded for free from our website. It also includes source code samples for C# and other programming languages.

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

##### ****IndexDocsInFolder.NETCore.csproj:**
    
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
    <None Include="Files\ImageSample.png">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="Files\SampleFile1.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="Files\SampleFile2.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <ItemGroup>
    <PackageReference Include="Microsoft.Windows.Compatibility" Version="2.0.0" />
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDFExtractor">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF Extractor SDK\netcoreapp2.0\Bytescout.PDFExtractor.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.PDFExtractor.OCRExtension">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF Extractor SDK\netcoreapp2.0\Bytescout.PDFExtractor.OCRExtension.dll</HintPath>
    </Reference>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****IndexDocsInFolder.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{99735776-2956-463D-9795-EBCE16928C30}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>IndexDocsInFolder</RootNamespace>
    <AssemblyName>IndexDocsInFolder</AssemblyName>
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
    <Reference Include="Bytescout.PDFExtractor, Version=9.1.0.3170, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\..\..\..\..\..\..\..\..\Program Files\Bytescout PDF Extractor SDK\net2.00\Bytescout.PDFExtractor.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup />
  <ItemGroup>
    <Content Include="Files\ImageSample.png">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <Content Include="Files\SampleFile1.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="Files\SampleFile2.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.cs:**
    
```
using Bytescout.PDFExtractor;
using System;
using System.Collections.Generic;
using System.IO;

namespace IndexDocsInFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Output file list
                var lstAllFilesInfo = new List<FileIndexOutput>();

                // Get all files inside directory
                var allFiles = Directory.GetFiles(@".\Files", "*.*");

                // Iterate all files, and get details
                foreach (var itmFile in allFiles)
                {
                    // Get basic file information
                    FileInfo fileInfo = new FileInfo(itmFile);

                    // Check whether file is supported
                    if (_IsFileSupported(fileInfo))
                    {
                        // Fill file index model
                        var oFileIndex = new FileIndexOutput();
                        oFileIndex.fileName = fileInfo.Name;
                        oFileIndex.fileDate = fileInfo.CreationTime;
                        oFileIndex.content = _GetFileContent(fileInfo);

                        // Add to final list
                        lstAllFilesInfo.Add(oFileIndex);
                    }
                }

                // Print all output
                Console.WriteLine("Total {0} files indexed\n", lstAllFilesInfo.Count);
                foreach (var itmFileInfo in lstAllFilesInfo)
                {
                    Console.WriteLine("fileName: {0}", itmFileInfo.fileName);
                    Console.WriteLine("fileDate: {0}", itmFileInfo.fileDate.ToString("MMM dd yyyy hh:mm:ss"));
                    Console.WriteLine("content: {0}", itmFileInfo.content.Trim());
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

        /// <summary>
        /// Get File Content
        /// </summary>
        private static string _GetFileContent(FileInfo fileInfo)
        {
            string fileExtension = System.IO.Path.GetExtension(fileInfo.FullName);

            if (fileExtension == ".pdf")
            {
                return _GetPdfFileContent(fileInfo);
            }
            else if (fileExtension == ".png" || fileExtension == ".jpg")
            {
                return _GetImageContet(fileInfo);
            }

            throw new Exception("File not supported.");
        }

        /// <summary>
        /// Get PDF File Content
        /// </summary>
        private static string _GetPdfFileContent(FileInfo fileInfo)
        {
            //Read all file content...
            using (TextExtractor textExtractor = new TextExtractor("demo","demo"))
            {
                //Load Document
                textExtractor.LoadDocumentFromFile(fileInfo.FullName);

                return textExtractor.GetText();
            }
        }

        /// <summary>
        /// Get Image Contents
        /// </summary>
        private static string _GetImageContet(FileInfo fileInfo)
        {
            //Read all file content...
            using (TextExtractor extractor = new TextExtractor())
            {
                // Load document
                extractor.LoadDocumentFromFile(fileInfo.FullName);

                //Set option to repair text
                extractor.OCRMode = OCRMode.TextFromImagesAndVectorsAndRepairedFonts;

                // Enable Optical Character Recognition (OCR)
                // in .Auto mode (SDK automatically checks if needs to use OCR or not)
                extractor.OCRMode = OCRMode.Auto;

                // Set the location of OCR language data files
                extractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\";

                // Set OCR language
                extractor.OCRLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
                // Find more language files at https://github.com/bytescout/ocrdata

                // Set PDF document rendering resolution
                extractor.OCRResolution = 300;

                // Read all text
                return extractor.GetText();
            }
        }

        /// <summary>
        /// Check whether file is valid
        /// </summary>
        private static bool _IsFileSupported(FileInfo fileInfo)
        {
            //Get File Extension
            string fileExtension = Path.GetExtension(fileInfo.Name);

            //Check whether file extension is valid
            return (fileExtension == ".pdf" || fileExtension == ".png" || fileExtension == ".jpg");
        }

    }

    /// <summary>
    /// FileIndexOutput class
    /// </summary>
    public class FileIndexOutput
    {
        public string fileName { get; set; }

        public DateTime fileDate { get; set; }

        public string content { get; set; }
    }

}

```

<!-- code block end -->