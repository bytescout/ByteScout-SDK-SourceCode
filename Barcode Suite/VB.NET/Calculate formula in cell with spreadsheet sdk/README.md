## How to calculate formula in cell with spreadsheet sdk in VB.NET using ByteScout Barcode Suite

### Step-by-step tutorial on how to calculate formula in cell with spreadsheet sdk in VB.NET

Quickly learn how to calculate formula in cell with spreadsheet sdk in VB.NET with this sample source code. ByteScout Barcode Suite is the bundle that privides 3  SDK products to generate barcodes (Barcode SDK), read barcodes (Barcode Reaer SDK) and read and write spreadsheets (Spreadsheet SDK). It can calculate formula in cell with spreadsheet sdk in VB.NET.

The SDK samples given below describe how to quickly make your application do calculate formula in cell with spreadsheet sdk in VB.NET with the help of ByteScout Barcode Suite. This VB.NET sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Applying VB.NET application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

The trial version of ByteScout Barcode Suite can be downloaded for free from our website. It also includes source code samples for VB.NET and other programming languages.

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

##### ****Calculate Formula In Cell.VS2005.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{AB89C332-58F7-4985-A112-465608D6BCF6}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>VB.NET.Module1</StartupObject>
    <RootNamespace>VB.NET</RootNamespace>
    <AssemblyName>VB.NET</AssemblyName>
    <MyType>Console</MyType>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>VB.NET.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>VB.NET.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.Spreadsheet, Version=0.0.0.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\..\..\..\..\..\..\Program Files\Bytescout Spreadsheet SDK\Bytescout.Spreadsheet.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
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
    <Compile Include="My Project\AssemblyInfo.vb" />
    <Compile Include="My Project\Application.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Application.myapp</DependentUpon>
    </Compile>
    <Compile Include="My Project\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>Resources.resx</DependentUpon>
    </Compile>
    <Compile Include="My Project\Settings.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="My Project\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
      <SubType>Designer</SubType>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="My Project\Application.myapp">
      <Generator>MyApplicationCodeGenerator</Generator>
      <LastGenOutput>Application.Designer.vb</LastGenOutput>
    </None>
    <None Include="My Project\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <CustomToolNamespace>My</CustomToolNamespace>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.targets" />
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

##### ****Calculate Formula In Cell.VS2008.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="3.5">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.21022</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{AB89C332-58F7-4985-A112-465608D6BCF6}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>VB.NET.Module1</StartupObject>
    <RootNamespace>VB.NET</RootNamespace>
    <AssemblyName>VB.NET</AssemblyName>
    <MyType>Console</MyType>
    <OldToolsVersion>2.0</OldToolsVersion>
    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>VB.NET.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>VB.NET.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.Spreadsheet, Version=0.0.0.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\..\..\..\..\..\..\Program Files\Bytescout Spreadsheet SDK\Bytescout.Spreadsheet.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
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
    <Compile Include="My Project\AssemblyInfo.vb" />
    <Compile Include="My Project\Application.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Application.myapp</DependentUpon>
    </Compile>
    <Compile Include="My Project\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>Resources.resx</DependentUpon>
    </Compile>
    <Compile Include="My Project\Settings.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="My Project\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
      <SubType>Designer</SubType>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="My Project\Application.myapp">
      <Generator>MyApplicationCodeGenerator</Generator>
      <LastGenOutput>Application.Designer.vb</LastGenOutput>
    </None>
    <None Include="My Project\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <CustomToolNamespace>My</CustomToolNamespace>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
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

##### ****Calculate Formula In Cell.VS2010.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{AB89C332-58F7-4985-A112-465608D6BCF6}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>VB.NET.Module1</StartupObject>
    <RootNamespace>VB.NET</RootNamespace>
    <AssemblyName>VB.NET</AssemblyName>
    <MyType>Console</MyType>
    <OldToolsVersion>3.5</OldToolsVersion>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>VB.NET.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>VB.NET.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.Spreadsheet, Version=0.0.0.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\..\..\..\..\..\..\Program Files\Bytescout Spreadsheet SDK\Bytescout.Spreadsheet.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
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
    <Compile Include="My Project\AssemblyInfo.vb" />
    <Compile Include="My Project\Application.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Application.myapp</DependentUpon>
    </Compile>
    <Compile Include="My Project\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>Resources.resx</DependentUpon>
    </Compile>
    <Compile Include="My Project\Settings.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="My Project\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
      <SubType>Designer</SubType>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="My Project\Application.myapp">
      <Generator>MyApplicationCodeGenerator</Generator>
      <LastGenOutput>Application.Designer.vb</LastGenOutput>
    </None>
    <None Include="My Project\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <CustomToolNamespace>My</CustomToolNamespace>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
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

##### ****Module1.vb:**
    
```
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.IO
Imports System.Diagnostics

Imports Bytescout.Spreadsheet

Module Module1
    Sub Main()
			' Create new spreadsheet
			Dim spreadsheet As New Spreadsheet()

			' Add new worksheet
			Dim sheet As Worksheet = spreadsheet.Workbook.Worksheets.Add()

			' Get decimal separator. Decimal separator depends from locale.
			Dim dsep As String = spreadsheet.Workbook.Locale.NumberFormat.CurrencyDecimalSeparator

			' Get list separator. List separator depends from locale.
			Dim lsep As String = spreadsheet.Workbook.Locale.TextInfo.ListSeparator

			' Set starting row
			Dim rowNumber As Integer = 1

			' Example on SIN() function in formula
			sheet.Cell(rowNumber, 0).Value = "SIN(30)"
			sheet.Cell(rowNumber, 1).Value = "=SIN(30)"

			rowNumber += 2

			' Example on COS() function in formula
			sheet.Cell(rowNumber, 0).Value = "COS(30)"
			sheet.Cell(rowNumber, 1).Value = "=COS(30)"

			rowNumber += 2

			' Example on TAN() function in formula
			sheet.Cell(rowNumber, 0).Value = "TAN(30)"
			sheet.Cell(rowNumber, 1).Value = "=TAN(30)"

			rowNumber += 2

			' Example on ATAN() function in formula
			sheet.Cell(rowNumber, 0).Value = "ATAN(0" + dsep + "5)"
			sheet.Cell(rowNumber, 1).Value = "=ATAN(0" + dsep + "5)"

			rowNumber += 2

			' Example on ATAN2() function in formula
			sheet.Cell(rowNumber, 0).Value = "ATAN2(0" + dsep + "3" + lsep + "0.1)"
			sheet.Cell(rowNumber, 1).Value = "=ATAN2(0" + dsep + "3" + lsep + "0.1)"

			rowNumber += 2

			' Example on ASIN() function in formula
			sheet.Cell(rowNumber, 0).Value = "ASIN(0" + dsep + "5)"
			sheet.Cell(rowNumber, 1).Value = "=ASIN(0" + dsep + "5)"

			rowNumber += 2

			' Example on ACOS() function in formula
			sheet.Cell(rowNumber, 0).Value = "ACOS(0" + dsep + "5)"
			sheet.Cell(rowNumber, 1).Value = "=ACOS(0" + dsep + "5)"

			rowNumber += 2

			' Example on EXP() function in formula
			sheet.Cell(rowNumber, 0).Value = "EXP(5)"
			sheet.Cell(rowNumber, 1).Value = "=EXP(5)"

			rowNumber += 2

			' Example on SQRT() function in formula
			sheet.Cell(rowNumber, 0).Value = "SQRT(5)"
			sheet.Cell(rowNumber, 1).Value = "=SQRT(5)"

			rowNumber += 2

			' Example on LN() function in formula
			sheet.Cell(rowNumber, 0).Value = "LN(5)"
			sheet.Cell(rowNumber, 1).Value = "=LN(5)"

			rowNumber += 2

			' Example on LOG10() function in formula
			sheet.Cell(rowNumber, 0).Value = "LOG10(5)"
			sheet.Cell(rowNumber, 1).Value = "=LOG10(5)"

			rowNumber += 2

			' Example on SUM() function in formula
			sheet.Cell(rowNumber, 0).Value = "SUM(5" + lsep + "3)"
			sheet.Cell(rowNumber, 1).Value = "=SUM(5" + lsep + "3)"

			rowNumber += 2

			' Example on PRODUCT() function in formula
			sheet.Cell(rowNumber, 0).Value = "PRODUCT(5" + lsep + "3)"
			sheet.Cell(rowNumber, 1).Value = "=PRODUCT(5" + lsep + "3)"

			rowNumber += 2

			' Example on VAR() function in formula
			sheet.Cell(rowNumber, 0).Value = "VAR(5" + lsep + "3)"
			sheet.Cell(rowNumber, 1).Value = "=VAR(5" + lsep + "3)"

			rowNumber += 2

			' Example on VARP() function in formula
			sheet.Cell(rowNumber, 0).Value = "VARP(5" + lsep + "3)"
			sheet.Cell(rowNumber, 1).Value = "=VARP(5" + lsep + "3)"

			rowNumber += 2

			' Example on STDEV() function in formula
			sheet.Cell(rowNumber, 0).Value = "STDEV(5" + lsep + "3)"
			sheet.Cell(rowNumber, 1).Value = "=STDEV(5" + lsep + "3)"

			rowNumber += 2

			' Example on STDEVP() function in formula
			sheet.Cell(rowNumber, 0).Value = "STDEVP(5" + lsep + "3)"
			sheet.Cell(rowNumber, 1).Value = "=STDEVP(5" + lsep + "3)"

			rowNumber += 2

			' Example on AVERAGE() function in formula
			sheet.Cell(rowNumber, 0).Value = "AVERAGE(50" + lsep + "30)"
			sheet.Cell(rowNumber, 1).Value = "=AVERAGE(50" + lsep + "30)"

			rowNumber += 2

			' Example on MIN() function in formula
			sheet.Cell(rowNumber, 0).Value = "MIN(50" + lsep + "30)"
			sheet.Cell(rowNumber, 1).Value = "=MIN(50" + lsep + "30)"

			rowNumber += 2

			' Example on MAX() function in formula
			sheet.Cell(rowNumber, 0).Value = "MAX(50" + lsep + "30)"
			sheet.Cell(rowNumber, 1).Value = "=MAX(50" + lsep + "30)"

			rowNumber += 2

			' Example on PI() function in formula
			sheet.Cell(rowNumber, 0).Value = "PI()"
			sheet.Cell(rowNumber, 1).Value = "=PI()"

			rowNumber += 2

			' Example on ABS() function in formula
			sheet.Cell(rowNumber, 0).Value = "ABS(-5)"
			sheet.Cell(rowNumber, 1).Value = "=ABS(-5)"

			rowNumber += 2

			' Example on RAND() function in formula
			sheet.Cell(rowNumber, 0).Value = "RAND()"
			sheet.Cell(rowNumber, 1).Value = "=RAND()"

			rowNumber += 2

			' Example on MOD() function in formula
			sheet.Cell(rowNumber, 0).Value = "MOD(10" + dsep + "8" + lsep + "2)"
			sheet.Cell(rowNumber, 1).Value = "=MOD(10" + dsep + "8" + lsep + "2)"

			rowNumber += 2

			' Example on INT() function in formula
			sheet.Cell(rowNumber, 0).Value = "INT(10" + dsep + "8)"
			sheet.Cell(rowNumber, 1).Value = "=INT(10" + dsep + "8)"

			rowNumber += 2

			' Example on SIGN() function in formula
			sheet.Cell(rowNumber, 0).Value = "SIGN(10" + dsep + "8)"
			sheet.Cell(rowNumber, 1).Value = "=SIGN(10" + dsep + "8)"

			rowNumber += 2

			' Example on ROUND() function in formula
			sheet.Cell(rowNumber, 0).Value = "ROUND(10" + dsep + "862456" + lsep + "4)"
			sheet.Cell(rowNumber, 1).Value = "=ROUND(10" + dsep + "862456" + lsep + "4)"

			rowNumber += 2

			' Example on RADIANS() function in formula
			sheet.Cell(rowNumber, 0).Value = "RADIANS(180)"
			sheet.Cell(rowNumber, 1).Value = "=RADIANS(180)"

			rowNumber += 2

			' Example on DEGREES() function in formula
			sheet.Cell(rowNumber, 0).Value = "DEGREES(3" + dsep + "14)"
			sheet.Cell(rowNumber, 1).Value = "=DEGREES(3" + dsep + "14)"

			rowNumber += 2

			' Example on LEN() function in formula
			sheet.Cell(rowNumber, 0).Value = "LEN(""Bytescout"")"
			sheet.Cell(rowNumber, 1).Value = "=LEN(""Bytescout"")"

			rowNumber += 2

			' Example on MID() function in formula
			sheet.Cell(rowNumber, 0).Value = "MID(""Bytescout""" + lsep + "5" + lsep + "5)"
			sheet.Cell(rowNumber, 1).Value = "=MID(""Bytescout""" + lsep + "5" + lsep + "5)"

			rowNumber += 2

			' Example on NOW() function in formula
			sheet.Cell(rowNumber, 0).Value = "NOW()"
			sheet.Cell(rowNumber, 1).Value = "=NOW()"

			rowNumber += 2

			' Example on DATE() function in formula
			sheet.Cell(rowNumber, 0).Value = "DATE(2009" + lsep + "1" + lsep + "2)"
			sheet.Cell(rowNumber, 1).Value = "=DATE(2009" + lsep + "1" + lsep + "2)"

			rowNumber += 2

			' Example on TIME() function in formula
			sheet.Cell(rowNumber, 0).Value = "TIME(1" + lsep + "1" + lsep + "2)"
			sheet.Cell(rowNumber, 1).Value = "=TIME(1" + lsep + "1" + lsep + "2)"

			rowNumber += 2

			' Example on SECOND() function in formula
			sheet.Cell(rowNumber, 0).Value = "SECOND(""18:45:02"")"
			sheet.Cell(rowNumber, 1).Value = "=SECOND(""18:45:02"")"

			rowNumber += 2

			' Example on MINUTE() function in formula
			sheet.Cell(rowNumber, 0).Value = "MINUTE(""18:45:02"")"
			sheet.Cell(rowNumber, 1).Value = "=MINUTE(""18:45:02"")"

			rowNumber += 2

			' Example on HOUR() function in formula
			sheet.Cell(rowNumber, 0).Value = "HOUR(""18:45:02"")"
			sheet.Cell(rowNumber, 1).Value = "=HOUR(""18:45:02"")"

			rowNumber += 2

			' Example on YEAR() function in formula
			sheet.Cell(rowNumber, 0).Value = "YEAR(NOW())"
			sheet.Cell(rowNumber, 1).Value = "=YEAR(NOW())"

			rowNumber += 2

			' Example on MONTH() function in formula
			sheet.Cell(rowNumber, 0).Value = "MONTH(NOW())"
			sheet.Cell(rowNumber, 1).Value = "=MONTH(NOW())"

			rowNumber += 2

			' Example on DAY() function in formula
			sheet.Cell(rowNumber, 0).Value = "DAY(NOW())"
			sheet.Cell(rowNumber, 1).Value = "=DAY(NOW())"

			rowNumber += 2

			' Example on WEEKDAY() function in formula
			sheet.Cell(rowNumber, 0).Value = "WEEKDAY(NOW())"
			sheet.Cell(rowNumber, 1).Value = "=WEEKDAY(NOW())"

			rowNumber += 2

			' Example on FALSE in formula
			sheet.Cell(rowNumber, 0).Value = "FALSE"
			sheet.Cell(rowNumber, 1).Value = "=FALSE"

			rowNumber += 2

			' Example on TRUE in formula
			sheet.Cell(rowNumber, 0).Value = "TRUE"
			sheet.Cell(rowNumber, 1).Value = "=TRUE"

			rowNumber += 2

			' Example on AND() function in formula
			sheet.Cell(rowNumber, 0).Value = "AND"
			sheet.Cell(rowNumber, 1).Value = "=AND(10>1" + lsep + "10<100)"

			rowNumber += 2

			' Example on OR() function in formula
			sheet.Cell(rowNumber, 0).Value = "OR(10>1" + lsep + "10<100)"
			sheet.Cell(rowNumber, 1).Value = "=OR(10>1" + lsep + "10<100)"

			rowNumber += 2

			' Example on NOT() function in formula
			sheet.Cell(rowNumber, 0).Value = "NOT(1+1=2)"
			sheet.Cell(rowNumber, 1).Value = "=NOT(1+1=2)"

			rowNumber += 2

			' Example on ISNA() function in formula
			sheet.Cell(rowNumber, 0).Value = "ISNA(NA())"
			sheet.Cell(rowNumber, 1).Value = "=ISNA(NA())"

			rowNumber += 2

			' Example on NA() function in formula
			sheet.Cell(rowNumber, 0).Value = "NA()"
			sheet.Cell(rowNumber, 1).Value = "=NA()"

			rowNumber += 2

			' Example on ISERROR() function in formula
			sheet.Cell(rowNumber, 0).Value = "ISERROR(1/0)"
			sheet.Cell(rowNumber, 1).Value = "=ISERROR(1/0)"

			rowNumber += 2

			' Example on ROW() function in formula
			sheet.Cell(rowNumber, 0).Value = "ROW()"
			sheet.Cell(rowNumber, 1).Value = "=ROW()"

			rowNumber += 2

			' Example on COLUMN() function in formula
			sheet.Cell(rowNumber, 0).Value = "COLUMN()"
			sheet.Cell(rowNumber, 1).Value = "=COLUMN()"

			rowNumber += 2

			' Example on COUNT() function in formula
			sheet.Cell(rowNumber, 0).Value = "COUNT(B1:B10)"
			sheet.Cell(rowNumber, 1).Value = "=COUNT(B1:B10)"

			rowNumber += 2

			' Example on COUNTA() function in formula
			sheet.Cell(rowNumber, 0).Value = "COUNTA(B1:B10)"
			sheet.Cell(rowNumber, 1).Value = "=COUNTA(B1:B10)"

			rowNumber += 2

			' Example on COUNTA() function in formula
			sheet.Cell(rowNumber, 0).Value = "IF(1=1" + lsep + "TRUE" + lsep + "FALSE)"
			sheet.Cell(rowNumber, 1).Value = "=IF(1=1" + lsep + "TRUE" + lsep + "FALSE)"

			rowNumber += 2

			' Example on COUNTA() function in formula
			sheet.Cell(rowNumber, 0).Value = "NPV(10%" + lsep + "10000" + lsep + "1000" + lsep + "2000" + lsep + "300)"
			sheet.Cell(rowNumber, 1).Value = "=NPV(10%" + lsep + "10000" + lsep + "1000" + lsep + "2000" + lsep + "300)"

			Try
				System.IO.File.Delete("output.xls")
			Catch ex As Exception
			End Try

			spreadsheet.SaveAs("output.xls")

			spreadsheet.Close()

			System.Diagnostics.Process.Start("output.xls")
    End Sub
End Module

```

<!-- code block end -->