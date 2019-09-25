## How to generate qr code barcode with calenderentry with barcode sdk in VB.NET with ByteScout Barcode Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to generate qr code barcode with calenderentry with barcode sdk in VB.NET

On this page you will learn from code samples for programming in VB.NET.Writing of the code to generate qr code barcode with calenderentry with barcode sdk in VB.NET can be executed by programmers of any level using ByteScout Barcode Suite. What is ByteScout Barcode Suite? It is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can help you to generate qr code barcode with calenderentry with barcode sdk in your VB.NET application.

The SDK samples given below describe how to quickly make your application do generate qr code barcode with calenderentry with barcode sdk in VB.NET with the help of ByteScout Barcode Suite. This VB.NET sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! This basic programming language sample code for VB.NET will do the whole work for you to generate qr code barcode with calenderentry with barcode sdk.

Our website gives trial version of ByteScout Barcode Suite for free. It also includes documentation and source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20Suite%20Question) 

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

##### ****Program.vb:**
    
```
Imports Bytescout.BarCode

Module Program

    Sub Main()

        Try
            ' Create new barcode
            Dim barcode As Barcode = New Barcode

            ' Set symbology
            barcode.Symbology = SymbologyType.QRCode

            ' Get QRCode value in CalenderEntry format
            barcode.Value = GetCalenderEntryFormatText()

            ' Save barcode to image
            barcode.SaveImage("result.png")

            ' Show image in default image viewer
            Process.Start("result.png")

        Catch ex As Exception
            Console.WriteLine("Error: " + ex.Message)

            Console.WriteLine("Press enter key to exit...")
            Console.ReadLine()
        End Try

    End Sub

    ''' <summary>
    ''' Return Calender Entry Format
    ''' </summary>
    ''' <returns></returns>
    Private Function GetCalenderEntryFormatText() As String
        Return "BEGIN:VCALENDAR
BEGIN:VEVENT
DTSTART:20181113T100000Z
DTEND:20181113T150000Z
SUMMARY:New Calendar Entry
DESCRIPTION:Description Text
LOCATION:Chicago
RRULE:FREQ=YEARLY;BYDAY=-1SU;BYMONTH=3
END:VEVENT
END:VCALENDAR"
    End Function

End Module

```

<!-- code block end -->    

<!-- code block begin -->

##### ****QRCodeWithCalenderEntry.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{375CB266-4769-4E60-9A0A-F60C1CF83381}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>QRCodeWithCalenderEntry.Program</StartupObject>
    <RootNamespace>QRCodeWithCalenderEntry</RootNamespace>
    <AssemblyName>QRCodeWithCalenderEntry</AssemblyName>
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
    <DocumentationFile>QRCodeWithCalenderEntry.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>QRCodeWithCalenderEntry.xml</DocumentationFile>
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
    <Reference Include="Bytescout.BarCode, Version=4.80.0.993, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout BarCode Reader SDK\net2.00\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
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
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->