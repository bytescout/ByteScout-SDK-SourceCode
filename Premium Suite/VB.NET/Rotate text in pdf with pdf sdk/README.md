## How to rotate text in pdf with pdf sdk in VB.NET with ByteScout Premium Suite

### Learn to code in VB.NET to rotate text in pdf with pdf sdk with this step-by-step tutorial

The sample source codes on this page shows how to rotate text in pdf with pdf sdk in VB.NET. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording and you can use it to rotate text in pdf with pdf sdk with VB.NET.

Want to quickly learn? This fast application programming interfaces of ByteScout Premium Suite for VB.NET plus the guidelines and the code below will help you quickly learn how to rotate text in pdf with pdf sdk. Just copy and paste the code into your VB.NET application’s code and follow the instructions. Applying VB.NET application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

The trial version of ByteScout Premium Suite can be downloaded for free from our website. It also includes source code samples for VB.NET and other programming languages.

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

##### ****Module1.vb:**
    
```
Imports Bytescout.PDF

Module Module1

    Sub Main()

        ' Create PDF document
        Dim document = New Document()
        document.RegistrationName = "demo"
        document.RegistrationKey = "demo"

        ' Create page
        Dim page = New Page(PaperFormat.A4)

        ' Add page to document
        document.Pages.Add(page)

        Dim canvas = page.Canvas

        ' Prepare font and brush
        Dim font = New Bytescout.PDF.Font(StandardFonts.Helvetica, 24)
        Dim blackBrush = New Bytescout.PDF.SolidBrush()


        ' Draw simple text
        canvas.DrawString("Simple text.", font, blackBrush, 50, 100)

        ' Save canvas state
        canvas.SaveGraphicsState()

        ' Move canvas origin (0,0) point to (50,100)
        canvas.TranslateTransform(50, 100)

        ' Rotate canvas at 45 deg around of the origin point
        canvas.RotateTransform(45)
        canvas.DrawString("Rotated 45", font, blackBrush, 0, 0)

        ' Rotate another 45 deg
        canvas.RotateTransform(45)
        canvas.DrawString("Rotated 90", font, blackBrush, 0, 0)

        ' Restore canvas state to reset all transformations
        canvas.RestoreGraphicsState()
        

        ' Save document
        document.Save("result.pdf")

        ' Open PDF document in default associated application (for demo puprpose)
        Process.Start("result.pdf")

    End Sub

End Module

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Text Rotation.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>
    </SchemaVersion>
    <ProjectGuid>{3890059E-B799-4C3D-988F-75718ECE6AF5}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>Text_Rotation.Module1</StartupObject>
    <RootNamespace>Text_Rotation</RootNamespace>
    <AssemblyName>Text Rotation</AssemblyName>
    <FileAlignment>512</FileAlignment>
    <MyType>Console</MyType>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
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
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Debug|AnyCPU'">
    <DebugSymbols>true</DebugSymbols>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>Text Rotation.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
    <DebugType>full</DebugType>
    <PlatformTarget>AnyCPU</PlatformTarget>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Release|AnyCPU'">
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>Text Rotation.xml</DocumentationFile>
    <Optimize>true</Optimize>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>AnyCPU</PlatformTarget>
    <CodeAnalysisIgnoreBuiltInRuleSets>false</CodeAnalysisIgnoreBuiltInRuleSets>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDF, Version=1.7.0.223, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout PDF SDK\net2.0\Bytescout.PDF.dll</HintPath>
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