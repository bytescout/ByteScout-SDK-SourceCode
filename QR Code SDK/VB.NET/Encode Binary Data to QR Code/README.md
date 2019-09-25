## encode binary data to QR code in VB.NET and ByteScout QR Code

### How to code encode binary data to QR code in VB.NET: How-To tutorial

Writing of the code to encode binary data to QR code in VB.NET can be done by developers of any level using ByteScout QR Code. ByteScout QR Code was made to help with encode binary data to QR code in VB.NET. ByteScout QR Code is QR Code generation library. It provides full control on the quality, features and encoding. Can embed logo image right into QR Code itself. Batch barcode generation, and many special features like vCard or URL encoding are also supported.

You will save a lot of time on writing and testing code as you may just take the code below and use it in your application. VB.NET sample code is all you need: copy and paste the code to your VB.NET application's code editor, add a reference to ByteScout QR Code (if you haven't added yet) and you are ready to go! Enjoy writing a code with ready-to-use sample VB.NET codes to implement encode binary data to QR code using ByteScout QR Code.

Trial version can be downloaded from our website. Source code samples for VB.NET and documentation are included.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20QR%20Code%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20QR%20Code%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=A5hB9ul3tX0](https://www.youtube.com/watch?v=A5hB9ul3tX0)




<!-- code block begin -->

##### ****Program.vb:**
    
```
Imports System.Diagnostics
Imports System.Text
Imports Bytescout.BarCode

Class Program

    Friend Shared Sub Main(ByVal args As String())

        ' Create and activate QRCode component instance
        Using barcode As New QRCode()

            barcode.RegistrationName = "demo"
            barcode.RegistrationKey = "demo"
            
            ' Sample byte array to use as value  
            Dim byteArray As Byte() = New Byte() {0, 10, 11, 12, 13, 14, 15, &HFF}

            ' Set value by converting byte array to string  
            barcode.Value = Encoding.ASCII.GetString(byteArray)

            ' Save barcode image
            barcode.SaveImage("result.png")

        End Using

        ' Open the image in default associated application (for the demo purpose)
        Process.Start("result.png")

    End Sub

End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****QRCodeWithBinaryData.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 11.00
# Visual Studio 2010
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "QRCodeWithBinaryData", "QRCodeWithBinaryData.vbproj", "{0F5DF480-9BF6-4FD2-91C6-D9F524E10B62}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{0F5DF480-9BF6-4FD2-91C6-D9F524E10B62}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{0F5DF480-9BF6-4FD2-91C6-D9F524E10B62}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{0F5DF480-9BF6-4FD2-91C6-D9F524E10B62}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{0F5DF480-9BF6-4FD2-91C6-D9F524E10B62}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****QRCodeWithBinaryData.vbproj:**
    
```
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{0F5DF480-9BF6-4FD2-91C6-D9F524E10B62}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>QRCodeWithBinaryData</RootNamespace>
    <AssemblyName>QRCodeWithBinaryData</AssemblyName>
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
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Reference Include="Bytescout.BarCode.QRCode, Version=1.0.0.100, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout QR Code SDK\net40\Bytescout.BarCode.QRCode.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
  </ItemGroup>
</Project>
```

<!-- code block end -->