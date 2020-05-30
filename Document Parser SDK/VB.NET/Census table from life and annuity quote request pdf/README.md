## census table from life and annuity quote request pdf in VB.NET and ByteScout Document Parser SDK What is ByteScout Document Parser SDK? It is the customizable data extraction platform for batch data extraction from documents. Relies on special templates that can be created with no special technical skills required. Supports millions of documents as input and designed to handle multiple threads. Can output data as JSON, CSV, XML or custom format.

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

##### **LifeAndAnnuityQuoteRequest.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27703.2026
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "LifeAndAnnuityQuoteRequest", "LifeAndAnnuityQuoteRequest.vbproj", "{A5FA1293-C15B-4249-A771-ED4301658454}"
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

##### **LifeAndAnnuityQuoteRequest.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{A5FA1293-C15B-4249-A771-ED4301658454}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>LifeAndAnnuityQuoteRequest.Module1</StartupObject>
    <RootNamespace>LifeAndAnnuityQuoteRequest</RootNamespace>
    <AssemblyName>LifeAndAnnuityQuoteRequest</AssemblyName>
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
    <DocumentationFile>LifeAndAnnuityQuoteRequest.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>LifeAndAnnuityQuoteRequest.xml</DocumentationFile>
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
    <None Include="..\..\SampleGroupDisabilityForm.pdf">
      <Link>SampleGroupDisabilityForm.pdf</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="SampleGroupDisabilityForm.yml">
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

        ' Sample document containing life and annuity quote request form
        Dim sampleDocument As String = ".\SampleGroupDisabilityForm.pdf"

        ' Sample template
        Dim sampleTemplate As String = ".\SampleGroupDisabilityForm.yml"

        ' Create DocumentParser instance
        Using documentParser As New DocumentParser("demo", "demo")

            ' Add sample template
            documentParser.AddTemplate(sampleTemplate)

            ' Parse document data in JSON format
            Dim jsonString As String = documentParser.ParseDocument(sampleDocument, OutputFormat.JSON)

            ' Parse to Json Fields
            Dim oRet = ParseJsonFields(jsonString)

            ' Display some of data to console
            Console.WriteLine($"Parsing Details:{Environment.NewLine}------------------------")

            Console.WriteLine($"Contact Person: {oRet.ContactPerson}")
            Console.WriteLine($"Business Name: {oRet.BusinessName}")
            Console.WriteLine($"Business Address: {oRet.BusinessAddress}")
            Console.WriteLine($"Business Type: {oRet.BusinessType}")
            Console.WriteLine($"Phone: {oRet.Phone}")
            Console.WriteLine($"Email: {oRet.Email}")

            ' Export list of census to csv format
            Dim csvOutputFile As String = "result.csv"

            Dim csvString = ConvertToCsv(oRet.lstCensusTable)
            File.WriteAllText(csvOutputFile, csvString)

            Console.WriteLine($"{Environment.NewLine}{csvOutputFile} generated successfully!")

        End Using

        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()

    End Sub

    ''' <summary>
    ''' Parse Json Fields
    ''' </summary>
    Function ParseJsonFields(ByVal jsonInput As String) As FormVM

        Dim jsonObj As JObject = JObject.Parse(jsonInput)

        Dim oRet As New FormVM()
        oRet.ContactPerson = CStr(jsonObj("fields")("contactPerson")("value"))
        oRet.BusinessName = CStr(jsonObj("fields")("businessName")("value"))
        oRet.BusinessAddress = CStr(jsonObj("fields")("businessAddress")("value"))
        oRet.BusinessType = CStr(jsonObj("fields")("businessType")("value"))
        oRet.Phone = CStr(jsonObj("fields")("phone")("value"))
        oRet.Email = CStr(jsonObj("fields")("email")("value"))

        Dim censusTable = jsonObj("tables").Where(Function(p) p.Value(Of String)("name") = "CencusTable")

        If Not censusTable Is Nothing Then

            Dim rows = censusTable.Values("rows").First()

            If Not rows Is Nothing And rows.Count() > 0 Then

                For i As Int32 = 1 To rows.Count() - 1
                    Dim oCensus As New CensusTableVm()

                    ' Parse individual data
                    oCensus.SrNo = rows.ElementAt(i).ElementAt(0).ElementAt(0).Value(Of String)("value")
                    oCensus.DOB = rows.ElementAt(i).ElementAt(1).ElementAt(0).Value(Of String)("value")
                    oCensus.Gender = rows.ElementAt(i).ElementAt(2).ElementAt(0).Value(Of String)("value")
                    oCensus.Occupation = rows.ElementAt(i).ElementAt(3).ElementAt(0).Value(Of String)("value")
                    oCensus.Salary = rows.ElementAt(i).ElementAt(4).ElementAt(0).Value(Of String)("value")
                    oCensus.IsShortTermDisability = rows.ElementAt(i).ElementAt(5).ElementAt(0).Value(Of String)("value")
                    oCensus.IsLongTernDisability = rows.ElementAt(i).ElementAt(6).ElementAt(0).Value(Of String)("value")
                    oCensus.LifeInsuCoverAmt = rows.ElementAt(i).ElementAt(7).ElementAt(0).Value(Of String)("value")

                    oRet.lstCensusTable.Add(oCensus)
                Next

            End If

        End If

        Return oRet

    End Function

    ''' <summary>
    ''' Convert to Csv Format
    ''' </summary>
    Function ConvertToCsv(ByVal lstCensusTable As List(Of CensusTableVm)) As String

        Dim oRet As New StringBuilder(String.Empty)

        ' Get Header Row
        oRet.AppendLine(getCsvTitleRow())

        ' Put Child Rows
        For Each item In lstCensusTable
            oRet.AppendLine(item.ToString())
        Next

        Return oRet.ToString()

    End Function


    Class FormVM

        Public Property ContactPerson As String
        Public Property BusinessName As String
        Public Property BusinessAddress As String
        Public Property BusinessType As String
        Public Property Phone As String
        Public Property Email As String

        Public Property lstCensusTable As List(Of CensusTableVm) = New List(Of CensusTableVm)()

    End Class

    Class CensusTableVm

        Public Property SrNo As String
        Public Property DOB As String
        Public Property Gender As String
        Public Property Occupation As String
        Public Property Salary As String
        Public Property IsShortTermDisability As String
        Public Property IsLongTernDisability As String
        Public Property LifeInsuCoverAmt As String

        Public Overrides Function ToString() As String
            Return $"{SrNo},{DOB},{Gender},{Occupation},{Salary},{IsShortTermDisability},{IsLongTernDisability},{LifeInsuCoverAmt}"
        End Function

    End Class

    Public Function getCsvTitleRow() As String
        Return "SrNo,DOB,Gender,Occupation,Salary,IsShortTermDisability,IsLongTermDisability,LifeInsuCoverAmt"
    End Function

End Module

```

<!-- code block end -->    

<!-- code block begin -->

##### **SampleGroupDisabilityForm.yml:**
    
```
templateVersion: 3
templatePriority: 0
sourceId: Untitled document kind
detectionRules:
  keywords: []
fields:
  CencusTable:
    type: rectangle
    dataType: table
    rectangle:
    - 27
    - 324.75
    - 554.25
    - 358.5
    pageIndex: 0
    rowMergingRule: byBorders
  ContactPerson:
    type: rectangle
    rectangle:
    - 178.5
    - 111
    - 76.5
    - 15
    pageIndex: 0
  BusinessName:
    type: rectangle
    rectangle:
    - 177.75
    - 126
    - 105
    - 17.25
    pageIndex: 0
  BusinessAddress:
    type: rectangle
    rectangle:
    - 183
    - 144.75
    - 187.5
    - 24
    pageIndex: 0
  BusinessType:
    type: rectangle
    rectangle:
    - 183.75
    - 206.25
    - 77.25
    - 19.5
    pageIndex: 0
  Phone:
    type: rectangle
    rectangle:
    - 181.5
    - 236.25
    - 86.25
    - 15
    pageIndex: 0
  Email:
    type: rectangle
    rectangle:
    - 182.25
    - 250.5
    - 112.5
    - 17.25
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