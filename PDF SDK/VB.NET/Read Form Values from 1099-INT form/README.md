## How to read form values from 1099 INT form in VB.NET using ByteScout PDF SDK

### The tutorial shows how to read form values from 1099 INT form in VB.NET

Learn how to read form values from 1099 INT form in VB.NET with this source code sample. Want to read form values from 1099 INT form in your VB.NET app? ByteScout PDF SDK is designed for it. ByteScout PDF SDK is the library for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings.

You will save a lot of time on writing and testing code as you may just take the VB.NET code from ByteScout PDF SDK for read form values from 1099 INT form below and use it in your application. This VB.NET sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Test VB.NET sample code examples whether they respond your needs and requirements for the project.

Download free trial version of ByteScout PDF SDK from our website with this and other source code samples for VB.NET.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=gdsQ0EAqwGQ](https://www.youtube.com/watch?v=gdsQ0EAqwGQ)




<!-- code block begin -->

##### ****Program.vb:**
    
```
Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how to get PDF form values programmatically.
''' </summary>
Class Program

    Shared Sub Main()

        ' Load PDF form
        Dim pdfDocument = New Document("f1099int_filled.pdf")
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"

        ' Read from second page
        Dim page = pdfDocument.Pages(1)


        Console.WriteLine("F1099int_filled Form values are as follows")

        ' Is Void
        Dim lIsVoid = DirectCast(page.Annotations("c2_1[0]"), CheckBox).Checked
        Console.WriteLine($"Is Void: {lIsVoid}")

        ' Payer's info
        Dim cPayerInfo = DirectCast(page.Annotations("f2_1[0]"), EditBox).Text
        Console.WriteLine($"Payer Info: {cPayerInfo}")

        ' Payer's TIN
        Dim cPayerTin = DirectCast(page.Annotations("f2_2[0]"), EditBox).Text
        Console.WriteLine($"Payer TIN: {cPayerTin}")

        ' Recipient's TIN
        Dim cRecipientTin = DirectCast(page.Annotations("f2_4[0]"), EditBox).Text
        Console.WriteLine($"Recipient TIN: {cRecipientTin}")

        ' Street Address 1
        Dim cStreetAddress1 = DirectCast(page.Annotations("f2_5[0]"), EditBox).Text
        Console.WriteLine($"Street Address - 1: {cStreetAddress1}")

        ' Street Address 2
        Dim cStreetAddress2 = DirectCast(page.Annotations("f2_6[0]"), EditBox).Text
        Console.WriteLine($"Street Address - 2: {cStreetAddress2}")

        ' Cleanup 
        pdfDocument.Dispose()

        Console.WriteLine()
        Console.WriteLine("Press any key to exit....")
        Console.ReadLine()

    End Sub

End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ReadForm.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.28010.2003
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "ReadForm", "ReadForm.vbproj", "{951C634C-4684-40A5-919C-741C5CA61EA4}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{951C634C-4684-40A5-919C-741C5CA61EA4}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{951C634C-4684-40A5-919C-741C5CA61EA4}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{951C634C-4684-40A5-919C-741C5CA61EA4}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{951C634C-4684-40A5-919C-741C5CA61EA4}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {FD305C5A-563D-4A00-ABC4-AD68B49DD925}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ReadForm.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="14.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{951C634C-4684-40A5-919C-741C5CA61EA4}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>Sub Main</StartupObject>
    <RootNamespace>ReadForm</RootNamespace>
    <AssemblyName>ReadForm</AssemblyName>
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
    <Reference Include="Bytescout.PDF, Version=1.0.0.15, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
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
    <Content Include="f1099int_filled.pdf">
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