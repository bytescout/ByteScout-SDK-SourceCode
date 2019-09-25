## How to batch read barcodes to csv with barcode reader sdk in VB.NET and ByteScout Barcode Suite

### How to write a robust code in VB.NET to batch read barcodes to csv with barcode reader sdk with this step-by-step tutorial

On this page you will learn from code samples for programming in VB.NET.Writing of the code to batch read barcodes to csv with barcode reader sdk in VB.NET can be executed by programmers of any level using ByteScout Barcode Suite. What is ByteScout Barcode Suite? It is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can help you to batch read barcodes to csv with barcode reader sdk in your VB.NET application.

Want to quickly learn? This fast application programming interfaces of ByteScout Barcode Suite for VB.NET plus the guidelines and the code below will help you quickly learn how to batch read barcodes to csv with barcode reader sdk. Just copy and paste the code into your VB.NET application’s code and follow the instructions. Further improvement of the code will make it more robust.

You can download free trial version of ByteScout Barcode Suite from our website to see and try many others source code samples for VB.NET.

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

##### ****ImagePDFBarcodeToCSV.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{E379C06C-FCAC-44C9-8A99-1AA4CB9FB035}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>ImagePDFBarcodeToCSV.Program</StartupObject>
    <RootNamespace>ImagePDFBarcodeToCSV</RootNamespace>
    <AssemblyName>ImagePDFBarcodeToCSV</AssemblyName>
    <FileAlignment>512</FileAlignment>
    <MyType>Console</MyType>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
    <PublishUrl>publish\</PublishUrl>
    <Install>true</Install>
    <InstallFrom>Disk</InstallFrom>
    <UpdateEnabled>false</UpdateEnabled>
    <UpdateMode>Foreground</UpdateMode>
    <UpdateInterval>7</UpdateInterval>
    <UpdateIntervalUnits>Days</UpdateIntervalUnits>
    <UpdatePeriodically>false</UpdatePeriodically>
    <UpdateRequired>false</UpdateRequired>
    <MapFileExtensions>true</MapFileExtensions>
    <ApplicationRevision>0</ApplicationRevision>
    <ApplicationVersion>1.0.0.%2a</ApplicationVersion>
    <IsWebBootstrapper>false</IsWebBootstrapper>
    <UseApplicationTrust>false</UseApplicationTrust>
    <BootstrapperEnabled>true</BootstrapperEnabled>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>ImagePDFBarcodeToCSV.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>ImagePDFBarcodeToCSV.xml</DocumentationFile>
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
    <Reference Include="Bytescout.BarCodeReader, Version=10.2.0.1799, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout BarCode Reader SDK\net2.00\Bytescout.BarCodeReader.dll</HintPath>
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
    <Content Include="BarcodeFiles\sample1.jpg">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
	<Content Include="BarcodeFiles\sample2.png">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
	<Content Include="BarcodeFiles\sample3.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <BootstrapperPackage Include="Microsoft.Net.Framework.3.5.SP1">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.vb:**
    
```
Imports Bytescout.BarCodeReader

Module Program

    Sub Main()

        Try
            'Read Barcode Process
            Dim reader As Reader = New Reader
            reader.RegistrationKey = "demo"
            reader.RegistrationName = "demo"

            ' Set Barcode type to find
            reader.BarcodeTypesToFind.SetAll()

            ' Output list
            Dim lstCSVOutput As New List(Of CSVOutputFormat)

            ' Get all files in folder, and iterate through each file
            Dim files = System.IO.Directory.GetFiles("BarcodeFiles")
            For Each fileName As String In files

                ' -----------------------------------------------------------------------
                ' NOTE: We can read barcodes from specific page to increase performance .
                ' For sample please refer to "Decoding barcodes from PDF by pages" program.
                ' ----------------------------------------------------------------------- 

                ' Read barcodes
                Dim FoundBarcodes As FoundBarcode() = reader.ReadFrom(fileName)

                For Each code As FoundBarcode In FoundBarcodes
                    lstCSVOutput.Add(
                        New CSVOutputFormat With {
                        .barcodeType = code.Type.ToString(),
                        .barcodeValue = code.Value,
                        .scanDateTime = DateTime.Now.ToString(),
                        .fileName = fileName
                        })
                Next

            Next

            Console.WriteLine("Total {0} barcode found in {1} file.", lstCSVOutput.Count, files.Length)

            ' Export to CSV
            ExportToCsv(lstCSVOutput)
			
			' Cleanup
			reader.Dispose()

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine("Press enter key to exit...")
        Console.ReadLine()

    End Sub

    Sub ExportToCsv(ByVal lstCSVOutput As List(Of CSVOutputFormat))

        Dim csvOutputContent As New System.Text.StringBuilder(String.Empty)

        csvOutputContent.Append("Barcode Value,Barcode Type,Scan DateTime,File Name")

        For Each item As CSVOutputFormat In lstCSVOutput

            csvOutputContent.AppendFormat("{0}{1},{2},{3},{4}",
                                          Environment.NewLine,
                                          item.barcodeValue,
                                          item.barcodeType,
                                          item.scanDateTime,
                                          item.fileName
                                          )

        Next

        System.IO.File.WriteAllText("output.csv", csvOutputContent.ToString())

        Process.Start("output.csv")

    End Sub


    Class CSVOutputFormat
        Public Property barcodeValue As String
        Public Property barcodeType As String
        Public Property scanDateTime As String
        Public Property fileName As String
    End Class

End Module

```

<!-- code block end -->