## QR code with vcard in VB.NET with ByteScout Barcode SDK What is ByteScout Barcode SDK? It is the fully featured library to generate barcodes. Supports QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix and many other barcode types. Includes various options for barcode generation to ensure output quality, add barcodes to new or existing pdf files and images.

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

##### **Module1.vb:**
    
```
Imports Bytescout.BarCode

Module Module1

    Sub Main()

        ' Create and activate barcode generator instance
        Using barcode As New Barcode("demo", "demo")

            ' Set barcode type
            barcode.Symbology = SymbologyType.QRCode

            ' Inputs
            Dim inpEmail = New QrCodeVCardTemplate With {
                .FirstName = "Forest",
                .LastName = "Gump",
                .Company = "Bubba Gump Shrimp Co.",
                .Job = "Shrimp Man",
                .Phone = "+1-111-555-1212",
                .Fax = "+1-404-555-1212",
                .Email = "forrestgump@example.com",
                .Street = "100 Waters Edge",
                .City = "Baytown",
                .State = "LA",
                .Country = "USA",
                .ZipCode = "30314"
            }

            ' Set barcode value
            barcode.Value = inpEmail.ToString()

            ' Save generated barcode
            barcode.SaveImage("result.png")

            ' Open generated barcode image with associated application
            Process.Start("result.png")

        End Using

    End Sub

End Module

```

<!-- code block end -->    

<!-- code block begin -->

##### **QRCodeGeneration.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 2013
VisualStudioVersion = 12.0.40629.0
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "QRCodeGeneration", "QRCodeGeneration.vbproj", "{7ABFC3EA-D4BE-4D13-B37C-8D123CD18650}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{7ABFC3EA-D4BE-4D13-B37C-8D123CD18650}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{7ABFC3EA-D4BE-4D13-B37C-8D123CD18650}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{7ABFC3EA-D4BE-4D13-B37C-8D123CD18650}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{7ABFC3EA-D4BE-4D13-B37C-8D123CD18650}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### **QRCodeGeneration.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="12.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{7ABFC3EA-D4BE-4D13-B37C-8D123CD18650}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>QRCodeGeneration.Module1</StartupObject>
    <RootNamespace>QRCodeGeneration</RootNamespace>
    <AssemblyName>QRCodeGeneration</AssemblyName>
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
    <DocumentationFile>QRCodeGeneration.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>QRCodeGeneration.xml</DocumentationFile>
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
    <Reference Include="Bytescout.BarCode, Version=4.63.0.972, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Generator SDK\net4.00\Bytescout.BarCode.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
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
    <Compile Include="QrCodeVCardTemplate.vb" />
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

##### **QrCodeVCardTemplate.vb:**
    
```
Public Class QrCodeVCardTemplate

#Region "Constructors"

    Public Sub New()
    End Sub

    Public Sub New(ByVal FirstName As String, ByVal LastName As String, ByVal Phone As String, ByVal Fax As String, ByVal Email As String, ByVal Company As String, ByVal Job As String, ByVal Street As String, ByVal City As String, ByVal State As String, ByVal ZipCode As String, ByVal Country As String)
        Me.FirstName = FirstName
        Me.LastName = LastName
        Me.Phone = Phone
        Me.Fax = Fax
        Me.Email = Email
        Me.Company = Company
        Me.Job = Job
        Me.State = State
        Me.City = City
        Me.Street = Street
        Me.Country = Country
        Me.ZipCode = ZipCode
    End Sub

#End Region


#Region "Properties"

    Public Property FirstName As String
    Public Property LastName As String

    Public Property Phone As String
    Public Property Fax As String
    Public Property Email As String

    Public Property Company As String
    Public Property Job As String

    Public Property Street As String
    Public Property City As String
    Public Property State As String
    Public Property Country As String
    Public Property ZipCode As String

#End Region

#Region "Overloaded Methods"

    Public Overrides Function ToString() As String

        If String.IsNullOrEmpty(FirstName) AndAlso String.IsNullOrEmpty(LastName) Then Return MyBase.ToString()

        Return $"BEGIN:VCARD
VERSION:2.1
N:{LastName};{FirstName};;
FN:{FirstName} {LastName}
ORG:{Company}
TITLE:{Job}
TEL;WORK;VOICE:{Phone}
TEL;FAX;VOICE:{Fax}
ADR;WORK;PREF:;;{Street};{City};{State};{ZipCode};{Country}
LABEL;WORK;PREF;ENCODING=QUOTED-PRINTABLE;CHARSET=UTF-8
EMAIL:{Email}
END:VCARD
"

    End Function

#End Region


End Class

```

<!-- code block end -->