## How to extract text from foldable brochure booklet in VB.NET and ByteScout Document Parser SDK What is ByteScout Document Parser SDK? It is the customizable data extraction platform for batch data extraction from documents. Relies on special templates that can be created with no special technical skills required. Supports millions of documents as input and designed to handle multiple threads. Can output data as JSON, CSV, XML or custom format.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Document%20Parser%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Document%20Parser%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=MG5FfTWWSVE](https://www.youtube.com/watch?v=MG5FfTWWSVE)




<!-- code block begin -->

##### **ExtractTextFromFoldableBrochure.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27703.2026
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "ExtractTextFromFoldableBrochure", "ExtractTextFromFoldableBrochure.vbproj", "{A5FA1293-C15B-4249-A771-ED4301658454}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{A5FA1293-C15B-4249-A771-ED4301658454}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{A5FA1293-C15B-4249-A771-ED4301658454}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{A5FA1293-C15B-4249-A771-ED4301658454}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{A5FA1293-C15B-4249-A771-ED4301658454}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {DCA85560-1523-40E0-917A-5BB3AA7E031F}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### **ExtractTextFromFoldableBrochure.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{A5FA1293-C15B-4249-A771-ED4301658454}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>ExtractTextFromFoldableBrochure.Module1</StartupObject>
    <RootNamespace>ExtractTextFromFoldableBrochure</RootNamespace>
    <AssemblyName>ExtractTextFromFoldableBrochure</AssemblyName>
    <FileAlignment>512</FileAlignment>
    <MyType>Console</MyType>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>ExtractTextFromFoldableBrochure.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>ExtractTextFromFoldableBrochure.xml</DocumentationFile>
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
    <Reference Include="ByteScout.DocumentParser, Version=1.0.0.100, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\ByteScout Document Parser SDK\net40\ByteScout.DocumentParser.dll</HintPath>
    </Reference>
    <Reference Include="Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed, processorArchitecture=MSIL">
      <HintPath>packages\Newtonsoft.Json.12.0.3\lib\net40\Newtonsoft.Json.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
  </ItemGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Collections" />
    <Import Include="System.Collections.Generic" />
    <Import Include="System.Data" />
    <Import Include="System.Diagnostics" />
    <Import Include="System.Linq" />
    <Import Include="System.Xml.Linq" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Module1.vb" />
  </ItemGroup>
  <ItemGroup>
    <None Include="..\..\SampleFoldable.pdf">
      <Link>SampleFoldable.pdf</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="SampleFoldable.yml">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="packages.config" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### **Module1.vb:**
    
```
Imports System.IO
Imports System.Text
Imports ByteScout.DocumentParser
Imports Newtonsoft.Json.Linq

Module Module1

    Sub Main()

        ' Sample document containing foldable PDF
        Dim sampleDocument As String = ".\SampleFoldable.pdf"

        ' Sample template
        Dim sampleTemplate As String = ".\SampleFoldable.yml"

        ' Output 
        Dim resFile As String = "result.txt"
        Dim sOutput As New StringBuilder(String.Empty)

        ' Create DocumentParser instance
        Using documentParser As New DocumentParser("demo", "demo")

            ' Add sample template
            documentParser.AddTemplate(sampleTemplate)

            ' Parse document data in JSON format
            Dim jsonString As String = documentParser.ParseDocument(sampleDocument, OutputFormat.JSON)

            ' Parse json to foldable structure
            Dim parsedRes = ParseJsonToFoldableStructure(jsonString)

            ' Append all parts to return output
            sOutput.AppendLine(parsedRes.Part1)
            sOutput.AppendLine(parsedRes.Part2)
            sOutput.AppendLine(parsedRes.Part3)

            ' Write output file
            File.WriteAllText(resFile, sOutput.ToString())

            Console.WriteLine($"Extracted text saved to {resFile}")

            ' Open result file with default application
            Process.Start(resFile)

        End Using

        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()

    End Sub

    ''' <summary>
    ''' Parse Json to Foldable Structure
    ''' </summary>
    Function ParseJsonToFoldableStructure(ByVal jsonData As String) As FoldableStructure

        ' Get Object data from input file
        Dim jsonObj As JObject = JObject.Parse(jsonData)

        Dim oRet = New FoldableStructure()
        oRet.Part1 = Convert.ToString(jsonObj("fields")("part1")("value"))
        oRet.Part2 = Convert.ToString(jsonObj("fields")("part2")("value"))
        oRet.Part3 = Convert.ToString(jsonObj("fields")("part3")("value"))

        Return oRet

    End Function

    Class FoldableStructure
        Public Property Part1 As String
        Public Property Part2 As String
        Public Property Part3 As String
    End Class

End Module

```

<!-- code block end -->    

<!-- code block begin -->

##### **SampleFoldable.yml:**
    
```
templateVersion: 3
templatePriority: 0
sourceId: Untitled document kind
detectionRules:
  keywords: []
fields:
  Part1:
    type: rectangle
    rectangle:
    - 7.5
    - 33.75
    - 244.5
    - 353.25
    pageIndex: 0
  Part2:
    type: rectangle
    rectangle:
    - 273.75
    - 201.75
    - 247.5
    - 198
    pageIndex: 0
  Part3:
    type: rectangle
    rectangle:
    - 537.75
    - 27
    - 246
    - 268.5
    pageIndex: 0


```

<!-- code block end -->    

<!-- code block begin -->

##### **packages.config:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="Newtonsoft.Json" version="12.0.3" targetFramework="net40" />
</packages>
```

<!-- code block end -->