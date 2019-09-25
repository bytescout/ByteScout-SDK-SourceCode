## How to generate word document with barcodes with barcode sdk in VB.NET using ByteScout Barcode Suite

### This code in VB.NET shows how to generate word document with barcodes with barcode sdk with this how to tutorial

Sample source code below will display you how to manage a complex task like generate word document with barcodes with barcode sdk in VB.NET. ByteScout Barcode Suite is the bundle that privides 3  SDK products to generate barcodes (Barcode SDK), read barcodes (Barcode Reaer SDK) and read and write spreadsheets (Spreadsheet SDK). It can be applied to generate word document with barcodes with barcode sdk using VB.NET.

This prolific sample source code in VB.NET for ByteScout Barcode Suite contains various functions and other necessary options you should do calling the API to generate word document with barcodes with barcode sdk. IF you want to implement the functionality, just copy and paste this code for VB.NET below into your code editor with your app, compile and run your application. If you want to use these VB.NET sample examples in one or many applications then they can be used easily.

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

##### ****GenerateWordDocumentWithBarcodes.VS2005_.vbproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{EACE3475-1593-4BC8-9402-5DEAD68B3E3F}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>GenerateWordDocumentWithBarcodes</RootNamespace>
    <AssemblyName>GenerateWordDocumentWithBarcodes</AssemblyName>
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
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Reference Include="Bytescout.BarCode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
    <COMReference Include="Microsoft.Office.Core">
      <Lcid>0</Lcid>
      <VersionMinor>5</VersionMinor>
      <VersionMajor>2</VersionMajor>
      <Guid>{2DF8D04C-5BFA-101B-BDE5-00AA0044DE52}</Guid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
    <COMReference Include="Microsoft.Office.Interop.Word">
      <Lcid>0</Lcid>
      <VersionMinor>5</VersionMinor>
      <VersionMajor>8</VersionMajor>
      <Guid>{00020905-0000-0000-C000-000000000046}</Guid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
    <COMReference Include="VBIDE">
      <Lcid>0</Lcid>
      <VersionMinor>3</VersionMinor>
      <VersionMajor>5</VersionMajor>
      <Guid>{0002E157-0000-0000-C000-000000000046}</Guid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****GenerateWordDocumentWithBarcodes.VS2008.vbproj:**
    
```
<Project ToolsVersion="3.5" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.30729</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{EACE3475-1593-4BC8-9402-5DEAD68B3E3F}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>GenerateWordDocumentWithBarcodes</RootNamespace>
    <AssemblyName>GenerateWordDocumentWithBarcodes</AssemblyName>
    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
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
    <Reference Include="Bytescout.BarCode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
    <COMReference Include="Microsoft.Office.Core">
      <Lcid>0</Lcid>
      <VersionMinor>5</VersionMinor>
      <VersionMajor>2</VersionMajor>
      <Guid>{2DF8D04C-5BFA-101B-BDE5-00AA0044DE52}</Guid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
    <COMReference Include="Microsoft.Office.Interop.Word">
      <Lcid>0</Lcid>
      <VersionMinor>5</VersionMinor>
      <VersionMajor>8</VersionMajor>
      <Guid>{00020905-0000-0000-C000-000000000046}</Guid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
    <COMReference Include="VBIDE">
      <Lcid>0</Lcid>
      <VersionMinor>3</VersionMinor>
      <VersionMajor>5</VersionMajor>
      <Guid>{0002E157-0000-0000-C000-000000000046}</Guid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****GenerateWordDocumentWithBarcodes.VS2010.vbproj:**
    
```
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{EACE3475-1593-4BC8-9402-5DEAD68B3E3F}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>GenerateWordDocumentWithBarcodes</RootNamespace>
    <AssemblyName>GenerateWordDocumentWithBarcodes</AssemblyName>
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
    <Reference Include="Bytescout.BarCode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
    <COMReference Include="Microsoft.Office.Core">
      <Lcid>0</Lcid>
      <VersionMinor>5</VersionMinor>
      <VersionMajor>2</VersionMajor>
      <Guid>{2DF8D04C-5BFA-101B-BDE5-00AA0044DE52}</Guid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
    <COMReference Include="Microsoft.Office.Interop.Word">
      <Lcid>0</Lcid>
      <VersionMinor>5</VersionMinor>
      <VersionMajor>8</VersionMajor>
      <Guid>{00020905-0000-0000-C000-000000000046}</Guid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
    <COMReference Include="VBIDE">
      <Lcid>0</Lcid>
      <VersionMinor>3</VersionMinor>
      <VersionMajor>5</VersionMajor>
      <Guid>{0002E157-0000-0000-C000-000000000046}</Guid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****GenerateWordDocumentWithBarcodes.VS2012.vbproj:**
    
```
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{EACE3475-1593-4BC8-9402-5DEAD68B3E3F}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>GenerateWordDocumentWithBarcodes</RootNamespace>
    <AssemblyName>GenerateWordDocumentWithBarcodes</AssemblyName>
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
    <Reference Include="Bytescout.BarCode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
    <COMReference Include="Microsoft.Office.Core">
      <Lcid>0</Lcid>
      <VersionMinor>5</VersionMinor>
      <VersionMajor>2</VersionMajor>
      <Guid>{2DF8D04C-5BFA-101B-BDE5-00AA0044DE52}</Guid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
    <COMReference Include="Microsoft.Office.Interop.Word">
      <Lcid>0</Lcid>
      <VersionMinor>5</VersionMinor>
      <VersionMajor>8</VersionMajor>
      <Guid>{00020905-0000-0000-C000-000000000046}</Guid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
    <COMReference Include="VBIDE">
      <Lcid>0</Lcid>
      <VersionMinor>3</VersionMinor>
      <VersionMajor>5</VersionMajor>
      <Guid>{0002E157-0000-0000-C000-000000000046}</Guid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****GenerateWordDocumentWithBarcodes.VS2013.vbproj:**
    
```
<Project ToolsVersion="12.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{EACE3475-1593-4BC8-9402-5DEAD68B3E3F}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>GenerateWordDocumentWithBarcodes</RootNamespace>
    <AssemblyName>GenerateWordDocumentWithBarcodes</AssemblyName>
    <TargetFrameworkVersion>v4.5</TargetFrameworkVersion>
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
    <Reference Include="Bytescout.BarCode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
    <COMReference Include="Microsoft.Office.Core">
      <Lcid>0</Lcid>
      <VersionMinor>5</VersionMinor>
      <VersionMajor>2</VersionMajor>
      <Guid>{2DF8D04C-5BFA-101B-BDE5-00AA0044DE52}</Guid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
    <COMReference Include="Microsoft.Office.Interop.Word">
      <Lcid>0</Lcid>
      <VersionMinor>5</VersionMinor>
      <VersionMajor>8</VersionMajor>
      <Guid>{00020905-0000-0000-C000-000000000046}</Guid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
    <COMReference Include="VBIDE">
      <Lcid>0</Lcid>
      <VersionMinor>3</VersionMinor>
      <VersionMajor>5</VersionMajor>
      <Guid>{0002E157-0000-0000-C000-000000000046}</Guid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****GenerateWordDocumentWithBarcodes.VS2015.vbproj:**
    
```
<Project ToolsVersion="14.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{EACE3475-1593-4BC8-9402-5DEAD68B3E3F}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>GenerateWordDocumentWithBarcodes</RootNamespace>
    <AssemblyName>GenerateWordDocumentWithBarcodes</AssemblyName>
    <TargetFrameworkVersion>v4.5</TargetFrameworkVersion>
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
    <Reference Include="Bytescout.BarCode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
    <COMReference Include="Microsoft.Office.Core">
      <Lcid>0</Lcid>
      <VersionMinor>5</VersionMinor>
      <VersionMajor>2</VersionMajor>
      <Guid>{2DF8D04C-5BFA-101B-BDE5-00AA0044DE52}</Guid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
    <COMReference Include="Microsoft.Office.Interop.Word">
      <Lcid>0</Lcid>
      <VersionMinor>5</VersionMinor>
      <VersionMajor>8</VersionMajor>
      <Guid>{00020905-0000-0000-C000-000000000046}</Guid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
    <COMReference Include="VBIDE">
      <Lcid>0</Lcid>
      <VersionMinor>3</VersionMinor>
      <VersionMajor>5</VersionMajor>
      <Guid>{0002E157-0000-0000-C000-000000000046}</Guid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.vb:**
    
```
' This example uses Word Automation to create a document, add some text, add a table, 
' fill it with random data and generate barcode images for it.

Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports Microsoft.Office.Interop.Word
Imports Word = Microsoft.Office.Interop.Word
Imports Bytescout.BarCode

Class Program
	Private Shared Sub Main(args As String())
		Dim [optional] As Object = Missing.Value
		Dim endOfDocBookmark As Object = "\endofdoc"
		' \endofdoc is a predefined bookmark 

		' start Word
		Dim word As _Application = New Application()
		word.Visible = False

		' create new document
		Dim document As _Document = word.Documents.Add([optional], [optional], [optional], [optional])

		' insert a paragraph at the beginning of the document
		Dim paragraph1 As Paragraph = document.Content.Paragraphs.Add([optional])
		paragraph1.Range.Text = "Heading 1"
		paragraph1.Range.Font.Bold = 1
		paragraph1.Format.SpaceAfter = 24
		' 24 pt spacing after paragraph
		paragraph1.Range.InsertParagraphAfter()

		' insert another paragraph
		Dim range As Object = document.Bookmarks.get_Item(endOfDocBookmark).Range
		Dim paragraph2 As Paragraph = document.Content.Paragraphs.Add(range)
		paragraph2.Range.Text = "This is a sentence of normal text. Now here is a table:"
		paragraph2.Range.Font.Bold = 0
		paragraph2.Format.SpaceAfter = 24
		paragraph2.Range.InsertParagraphAfter()


		' insert a 5 x 2 table, make the first header row bold and italic
		range = document.Bookmarks.get_Item(endOfDocBookmark).Range
		Dim table As Table = document.Tables.Add(DirectCast(range, Range), 5, 2, [optional], [optional])
		table.Cell(1, 1).Range.Text = "Value"
		' 1st column header
		table.Cell(1, 2).Range.Text = "Barcode"
		' 2nd column header
		table.Rows(1).Range.Font.Bold = 1
		table.Rows(1).Range.Font.Italic = 1
		AddBorders(table.Cell(1, 1).Range)
		AddBorders(table.Cell(1, 2).Range)

		Dim random As New Random()
		Dim tempImage As String = Path.Combine(Path.GetTempPath(), "tempImage.png")

		' create barcode object
		Dim barcode As New Barcode("demo", "demo")
		barcode.Symbology = SymbologyType.Code128
		barcode.DrawCaption = False

		' fill the table with random data and add barcode images
		For row As Integer = 2 To 5
			Dim randomValue As String = random.[Next]().ToString(CultureInfo.InvariantCulture)
			Dim cell As Range = table.Cell(row, 1).Range
			cell.Text = randomValue

			AddBorders(cell)

			' generate barcode and save it to temporary image file
			barcode.Value = randomValue
			barcode.SaveImage(tempImage)

			' put barcode image to second column
			cell = table.Cell(row, 2).Range
			cell.InlineShapes.AddPicture(tempImage, [optional], [optional], [optional])

			AddBorders(cell)
		Next


		' save document
		Dim fileName As Object = "sample.doc"
		' use full file path in your app
		document.SaveAs(fileName, [optional], [optional], [optional], [optional], [optional], _
			[optional], [optional], [optional], [optional], [optional], [optional], _
			[optional], [optional], [optional], [optional])

		' quit Word
		Dim saveChanges As Object = True
		word.Quit(saveChanges, [optional], [optional])

		System.Diagnostics.Process.Start(DirectCast(fileName, String))
	End Sub

	' Adds borders to provided Range
	Private Shared Sub AddBorders(cell As Range)
		AddressOf cell.Borders(WdBorderType.wdBorderLeft).LineStyle = WdLineStyle.wdLineStyleSingle
		AddressOf cell.Borders(WdBorderType.wdBorderTop).LineStyle = WdLineStyle.wdLineStyleSingle
		AddressOf cell.Borders(WdBorderType.wdBorderRight).LineStyle = WdLineStyle.wdLineStyleSingle
		AddressOf cell.Borders(WdBorderType.wdBorderBottom).LineStyle = WdLineStyle.wdLineStyleSingle
	End Sub
End Class

```

<!-- code block end -->