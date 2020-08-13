## How to generate and check QR code barcode with image inside in VB.NET using ByteScout Robotic Process Automation ByteScout Robotic Process Automation is components and tools for quick RPA (Robotic Process Automation) implementation.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Robotic%20Process%20Automation%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Robotic%20Process%20Automation%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore Documentation](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Explore Source Code Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://app.pdf.co/signup?utm_source=github-readme)
[Security](https://pdf.co/security)
[Explore Web API Documentation](https://apidocs.pdf.co?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=gEjuZ0zgtHo](https://www.youtube.com/watch?v=gEjuZ0zgtHo)




<!-- code block begin -->

##### **Module1.vb:**
    
```
Imports Bytescout.BarCode
Imports Bytescout.BarCodeReader

Module Module1

	Sub Main()

		' GENERATE QR CODE WITH DECOARATION IMAGE:

		Dim decorationImageFile As String = ".\logo.png"
		Dim outputFile As String = ".\barcode.png"
		Dim barcodeValue As String = "1234567890 abcdefghijklmnopqrstuvwxyz 1234567890 abcdefghijklmnopqrstuvwxyz"

		' Create and activate barcode generator instance
		Using barcode As New Barcode("demo", "demo")

			' Set barcode type
			barcode.Symbology = Bytescout.BarCode.SymbologyType.QRCode

			' Set high QR Code error correction level
			barcode.Options.QRErrorCorrectionLevel = QRErrorCorrectionLevel.High

			' Set barcode value
			barcode.Value = barcodeValue

			' Add decoration image and scale it to 15% of the barcode square
			barcode.AddDecorationImage(decorationImageFile, 15)

			' Save generated barcode
			barcode.SaveImage(outputFile)

			Console.WriteLine("Barcode saved to " + outputFile)


			' CHECK THE BARCODE IS DECODABLE:

			' Create and activate barcode reader instance
			Using reader As New Reader("demo", "demo")

				' Enable QR Code decoding
				reader.BarcodeTypesToFind.QRCode = True

				' Read barcode from generated image
				Dim foundBarcodes = reader.ReadFrom(outputFile)

				' Check result
				If foundBarcodes.Length > 0 And foundBarcodes(0).Type = Bytescout.BarCodeReader.SymbologyType.QRCode Then
					Console.WriteLine("Barcode is decodable.")
				Else
					Console.WriteLine("Barcode is not decodable!")
				End If

			End Using

			Console.WriteLine()
			Console.WriteLine("Press any key...")
			Console.ReadKey()

		End Using

	End Sub

End Module

```

<!-- code block end -->    

<!-- code block begin -->

##### **QRCodeWithImage.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 2013
VisualStudioVersion = 12.0.40629.0
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "QRCodeWithImage", "QRCodeWithImage.vbproj", "{7ABFC3EA-D4BE-4D13-B37C-8D123CD18650}"
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

##### **QRCodeWithImage.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="12.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{7ABFC3EA-D4BE-4D13-B37C-8D123CD18650}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>QRCodeWithImage.Module1</StartupObject>
    <RootNamespace>QRCodeWithImage</RootNamespace>
    <AssemblyName>QRCodeWithImage</AssemblyName>
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
    <DocumentationFile>QRCodeWithImage.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>QRCodeWithImage.xml</DocumentationFile>
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
    <Reference Include="Bytescout.BarCodeReader, Version=10.0.0.1755, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Reader SDK\net4.00\Bytescout.BarCodeReader.dll</HintPath>
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
  <ItemGroup>
    <Content Include="logo.png">
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