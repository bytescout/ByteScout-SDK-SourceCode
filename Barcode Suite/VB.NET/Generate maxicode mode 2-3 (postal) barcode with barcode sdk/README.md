## How to generate maxicode mode 2 3 (postal) barcode with barcode sdk in VB.NET with ByteScout Barcode Suite

### If you want to learn more then this tutorial will show how to generate maxicode mode 2 3 (postal) barcode with barcode sdk in VB.NET

The documentation is designed for a specific purpose to help you to apply the features on your side. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can generate maxicode mode 2 3 (postal) barcode with barcode sdk in VB.NET.

This prolific sample source code in VB.NET for ByteScout Barcode Suite contains various functions and other necessary options you should do calling the API to generate maxicode mode 2 3 (postal) barcode with barcode sdk.  Simply copy and paste in your VB.NET project or application you and then run your app! Enjoy writing a code with ready-to-use sample VB.NET codes.

ByteScout Barcode Suite free trial version is available on our website. VB.NET and other programming languages are supported.

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

##### ****Module1.vb:**
    
```
Imports Bytescout.BarCode

Module Module1

	Sub Main()

		' Create and activate Barcode object instance
		Dim barcode = New Barcode()
		barcode.RegistrationName = "demo"
		barcode.RegistrationKey = "demo"

		' Set barcode symbology (type) 
		barcode.Symbology = SymbologyType.MaxiCode
		' Set MaxiCode mode
		barcode.Options.MaxiCodeMode = 2 ' 2 or 3 depending on the postal code

		' Make barcode dots larger (5 pixels)
		barcode.NarrowBarWidth = 5


		' Prepare barcode value:

		' Special data signatures
		Dim mode23Signature = "[)>" + ChrW(&H1E) + "01" + ChrW(&H1D) + "96"
		Dim separator = ChrW(&H1D)
		Dim endingSignature = ChrW(&H1E) + ChrW(&H4)

		' Mandatory data part.
		Dim postalCode = "123456789" ' 5 or 9 digits in the USA (Mode 2); 1-6 alphanumeric characters in other countries (Mode 3)
		Dim countryCode = "840"	' 3 digits (840 for USA) 
		Dim classOfService = "001" ' 3 digits 
		Dim trackingNumber = "S1Z12345678G"	' 10-character alphanumeric
		Dim upsStandardCarrierAlphaCode = "UPSN"

		' Optional data part.
		' Note, you can use empty strings for unneeded field values like `packageInShipment` or `weightInPounds` 
		' but they should delimited with the separator anyway.
		Dim upsShipperNumber = "S06X610" ' 6-character alphanumeric 
		Dim julianDayOfPickup = "159" ' 3 digits 
		Dim shipmentIdNumber = "1234567" ' 1-30 character alphanumeric 
		Dim packageInShipment = "1/2" ' 1-4 digits “/” 1-4 digits 
		Dim weightInPounds = "3.1" ' 1-5 digits
		Dim addressValidation = "Y"	' “Y” or “N”
		Dim shipToAddress = "S123 MAIN ST" ' 1-35 alphanumeric
		Dim shipToCity = "YORK"	' 1 - 35 alphanumeric
		Dim shipToState = "PA" ' 2-character alpha


		' Generate minimal postal code:

		Dim minimalValue = mode23Signature +
							postalCode + separator +
							countryCode + separator +
							classOfService + separator +
							trackingNumber + separator +
							upsStandardCarrierAlphaCode +
							endingSignature

		barcode.Value = minimalValue
		barcode.SaveImage("postal-maxicode-min.png")


		' Generate full postal code:

		Dim fullValue = mode23Signature +
						postalCode + separator +
						countryCode + separator +
						classOfService + separator +
						trackingNumber + separator +
						upsStandardCarrierAlphaCode + separator +
						upsShipperNumber + separator +
						julianDayOfPickup + separator +
						shipmentIdNumber + separator +
						packageInShipment + separator +
						weightInPounds + separator +
						addressValidation + separator +
						shipToAddress + separator +
						shipToCity + separator +
						shipToState +
						endingSignature

		barcode.Value = fullValue
		barcode.SaveImage("postal-maxicode-full.png")

	End Sub

End Module

```

<!-- code block end -->    

<!-- code block begin -->

##### ****PostalMaxiCode.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 2013
VisualStudioVersion = 12.0.40629.0
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "PostalMaxiCode", "PostalMaxiCode.vbproj", "{6BC7477D-3D40-4CD7-8A26-718250EA0BE0}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{6BC7477D-3D40-4CD7-8A26-718250EA0BE0}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{6BC7477D-3D40-4CD7-8A26-718250EA0BE0}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{6BC7477D-3D40-4CD7-8A26-718250EA0BE0}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{6BC7477D-3D40-4CD7-8A26-718250EA0BE0}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****PostalMaxiCode.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="12.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{6BC7477D-3D40-4CD7-8A26-718250EA0BE0}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>PostalMaxiCode.Module1</StartupObject>
    <RootNamespace>PostalMaxiCode</RootNamespace>
    <AssemblyName>PostalMaxiCode</AssemblyName>
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
    <DocumentationFile>PostalMaxiCode.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>PostalMaxiCode.xml</DocumentationFile>
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
    <Reference Include="Bytescout.BarCode, Version=100.0.0.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Generator SDK\net2.00\Bytescout.BarCode.dll</HintPath>
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