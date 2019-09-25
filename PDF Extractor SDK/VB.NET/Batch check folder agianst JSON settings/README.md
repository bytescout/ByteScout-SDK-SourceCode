## batch check folder agianst JSON settings in VB.NET with ByteScout PDF Extractor SDK

### How to code batch check folder agianst JSON settings in VB.NET: How-To tutorial

Source code documentation samples provide quick and easy way to add a required functionality into your application. ByteScout PDF Extractor SDK helps with batch check folder agianst JSON settings in VB.NET. ByteScout PDF Extractor SDK is the SDK that helps developers to extract data from unstructured documents, pdf, images, scanned and electronic forms. Includes AI functions like automatic table detection, automatic table extraction and restructuring, text recognition and text restoration from pdf and scanned documents. Includes PDF to CSV, PDF to XML, PDF to JSON, PDF to searchable PDF functions as well as methods for low level data extraction.

The SDK samples like this one below explain how to quickly make your application do batch check folder agianst JSON settings in VB.NET with the help of ByteScout PDF Extractor SDK. This VB.NET sample code should be copied and pasted into your application’s code editor. Then just compile and run it to see how it works. Further enhancement of the code will make it more vigorous.

ByteScout PDF Extractor SDK is available as free trial. You may get it from our website along with all other source code samples for VB.NET applications.

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

##### ****BatchCheckFolderAgainstJsonSettings.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27703.2026
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "BatchCheckFolderAgainstJsonSettings", "BatchCheckFolderAgainstJsonSettings.vbproj", "{EA267CB0-792B-4CBF-ACCC-7560A1451771}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{EA267CB0-792B-4CBF-ACCC-7560A1451771}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{EA267CB0-792B-4CBF-ACCC-7560A1451771}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{EA267CB0-792B-4CBF-ACCC-7560A1451771}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{EA267CB0-792B-4CBF-ACCC-7560A1451771}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {E3DD983F-D2E9-48C1-B528-A8A1B2D2E7B4}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****BatchCheckFolderAgainstJsonSettings.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{EA267CB0-792B-4CBF-ACCC-7560A1451771}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>BatchCheckFolderAgainstJsonSettings</RootNamespace>
    <AssemblyName>BatchCheckFolderAgainstJsonSettings</AssemblyName>
    <OldToolsVersion>3.5</OldToolsVersion>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
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
    <Reference Include="Bytescout.PDFExtractor, Version=1.0.0.12, Culture=neutral, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed, processorArchitecture=MSIL">
      <HintPath>packages\Newtonsoft.Json.12.0.2\lib\net40\Newtonsoft.Json.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.vb" />
    <Compile Include="SettingsVM.vb" />
  </ItemGroup>
  <ItemGroup>
    <None Include="InputFiles\sample1.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="InputFiles\sample2.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="InputFiles\sample3.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="packages.config" />
    <None Include="settings.json">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.vb:**
    
```
Imports Bytescout.PDFExtractor
Imports System.IO
Imports Newtonsoft.Json

Class Program

    Friend Shared Sub Main(args As String())

        Try

            ' Get all settings VM
            Dim allSettings As SettingsVM = GetSettingsVM("settings.json")

            ' Create Bytescout.PDFExtractor.TextExtractor instance
            Dim extractor As New TextExtractor()
            extractor.RegistrationName = "demo"
            extractor.RegistrationKey = "demo"

            For Each fileName As String In Directory.GetFiles("InputFiles")

                ' Load sample PDF document
                extractor.LoadDocumentFromFile(fileName)

                ' Enable regex search
                extractor.RegexSearch = True

                ' Get Number of pages PDF contains
                Dim pageCount As Int32 = extractor.GetPageCount()

                For iPage As Int32 = 0 To pageCount - 1

                    ' Loop through all search settings
                    For Each itmSearchSetting As Settings In allSettings.Settings

                        ' If found, then copy file to sub-category folder
                        If extractor.Find(iPage, itmSearchSetting.regex, False) Then

                            ' If Directory does Not exists, then create them
                            If (Not Directory.Exists($"{allSettings.MainFolderName}/{itmSearchSetting.category}")) Then
                                Directory.CreateDirectory($"{allSettings.MainFolderName}/{itmSearchSetting.category}")
                            End If

                            ' Copy File
                            File.Copy(fileName, $"{allSettings.MainFolderName}/{itmSearchSetting.category}/{Path.GetFileName(fileName)}", True)

                        End If
                    Next
                Next
            Next

            ' Cleanup
            extractor.Dispose()

        Catch ex As Exception

            Console.WriteLine("Error: " + ex.Message)

        End Try

        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()

    End Sub

    Shared Function GetSettingsVM(ByVal settingsFileName As String) As SettingsVM

        Dim allJson As String = File.ReadAllText(settingsFileName)

        Return JsonConvert.DeserializeObject(Of SettingsVM)(allJson)

    End Function


End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****SettingsVM.vb:**
    
```
Imports System.Collections.Generic

Public Class SettingsVM

    Public MainFolderName As String

    Public Settings As List(Of Settings)

End Class

Public Class Settings

    Public category As String
    Public regex As String

End Class
```

<!-- code block end -->    

<!-- code block begin -->

##### ****packages.config:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="Newtonsoft.Json" version="12.0.2" targetFramework="net40" />
</packages>
```

<!-- code block end -->