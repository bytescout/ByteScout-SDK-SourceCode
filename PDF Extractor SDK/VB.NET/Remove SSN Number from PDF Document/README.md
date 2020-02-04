## How to remove SSN number from PDF document in VB.NET with ByteScout PDF Extractor SDK ByteScout PDF Extractor SDK is the SDK is designed to help developers with pdf tables and pdf data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker and other utilities.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Extractor%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Extractor%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=s28W3_KMraU](https://www.youtube.com/watch?v=s28W3_KMraU)




<!-- code block begin -->

##### **Program.vb:**
    
```
Imports System.Drawing
Imports Bytescout.PDFExtractor

Module Program

    Sub Main()

        Dim inputDocument = ".\samplePDF_SSNNo.pdf"
        Dim outputDocument = ".\samplePDF_SSNNo_edited.pdf"

        Try
            ' Create Bytescout.PDFExtractor.TextExtractor instance
            Using extractor As TextExtractor = New TextExtractor("demo", "demo")
                ' Create Bytescout.PDFExtractor.Remover2 instance
                Using remover As Remover2 = New Remover2("demo", "demo")
                
                    ' Load sample PDF document
                    extractor.LoadDocumentFromFile(inputDocument)
                    remover.LoadDocumentFromFile(inputDocument)
                    
                    ' Enable the regular expression 
                    extractor.RegexSearch = True

                    Dim pageCount As Integer = extractor.GetPageCount()

                    ' Search through pages
                    For pageIndex As Integer = 0 To pageCount - 1

                        ' Search SSN in format 202-55-0130 using regular expression.
                        ' See the complete regular expressions reference at https://msdn.microsoft.com/en-us/library/az24scfc(v=vs.110).aspx
                        Dim regexPattern As String = "[0-9]{3}-[0-9]{2}-[0-9]{4}"
                        
                        ' Search each page for the pattern
                        Dim searchResults As ISearchResult() = extractor.FindAll(pageIndex, regexPattern, False)
                        
                        ' Iterate through each element in the found text
                        For Each element As ISearchResult In searchResults
                            Console.WriteLine("Found SSN No: " & element.Text)
                            ' Add rectangle of the found SSN to Remover
                            remover.AddTextToRemove(pageIndex, element.Bounds)
                        Next
                    Next

                    ' Mask replaced text with black rectangle
                    remover.MaskRemovedText = True
                    ' Change the color of the mask rectangle, if necessary
                    'remover.MaskColor = Color.Red

                    remover.PerformRemoval(outputDocument)

                    Console.WriteLine("Found SSNs removed, result saved to file """ & outputDocument & """")

                End Using
            End Using

            ' Open result file in default associated application (for the demonstration purpose)
            Dim processStartInfo As New ProcessStartInfo(outputDocument) With { .UseShellExecute = true }
            Process.Start(processStartInfo)

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Console.WriteLine()
        Console.WriteLine("Press any key...")
        Console.ReadKey()

    End Sub

End Module

```

<!-- code block end -->    

<!-- code block begin -->

##### **RemoveSNNumber.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.28307.1000
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "RemoveSNNumber", "RemoveSNNumber.vbproj", "{80667702-F68F-42E8-AF48-A3F9D8C879CF}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{80667702-F68F-42E8-AF48-A3F9D8C879CF}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{80667702-F68F-42E8-AF48-A3F9D8C879CF}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{80667702-F68F-42E8-AF48-A3F9D8C879CF}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{80667702-F68F-42E8-AF48-A3F9D8C879CF}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {BA289697-7E78-4C1D-913A-1C331F2563F8}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### **RemoveSNNumber.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{80667702-F68F-42E8-AF48-A3F9D8C879CF}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>RemoveSNNumber.Program</StartupObject>
    <RootNamespace>RemoveSNNumber</RootNamespace>
    <AssemblyName>RemoveSNNumber</AssemblyName>
    <FileAlignment>512</FileAlignment>
    <MyType>Console</MyType>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup>
    <OptionExplicit>On</OptionExplicit>
  </PropertyGroup>
  <PropertyGroup>
    <OptionCompare>Binary</OptionCompare>
  </PropertyGroup>
  <PropertyGroup>
    <OptionStrict>Off</OptionStrict>
  </PropertyGroup>
  <PropertyGroup>
    <OptionInfer>On</OptionInfer>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDFExtractor, Version=9.1.0.3170, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF Extractor SDK\net2.00\Bytescout.PDFExtractor.dll</HintPath>
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
    <Compile Include="Program.vb" />
  </ItemGroup>
  <ItemGroup>
    <None Include="samplePDF_SSNNo.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->