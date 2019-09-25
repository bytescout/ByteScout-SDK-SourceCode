## PDF viewer control hosted in WPF with PDF viewer SDK in VB.NET with ByteScout Premium Suite

### Simple tutorial on how to do PDF viewer control hosted in WPF with PDF viewer SDK in VB.NET

Writing of the code to PDF viewer control hosted in WPF with PDF viewer SDK in VB.NET can be done by developers of any level using ByteScout Premium Suite. PDF viewer control hosted in WPF with PDF viewer SDK in VB.NET can be applied with ByteScout Premium Suite. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

VB.NET code snippet like this for ByteScout Premium Suite works best when you need to quickly implement PDF viewer control hosted in WPF with PDF viewer SDK in your VB.NET application. To use PDF viewer control hosted in WPF with PDF viewer SDK in your VB.NET project or application just copy & paste the code and then run your app! Want to see how it works with your data then code testing will allow the function to be tested and work properly.

Trial version can be downloaded from our website for free. It contains this and other source code samples for VB.NET.

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

##### ****Application.xaml.vb:**
    
```
Class Application

    ' Application-level events, such as Startup, Exit, and DispatcherUnhandledException
    ' can be handled in this file.

End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****MainWindow.xaml.vb:**
    
```
Class MainWindow

	Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

		' Load a sample document on startup
		pdfViewerControl1.InputFile = "sample.pdf"

	End Sub

	Private Sub menuItemOpen_Click(sender As Object, e As RoutedEventArgs)

		Dim dlg = New Microsoft.Win32.OpenFileDialog()
		dlg.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*"

		Dim result As Boolean? = dlg.ShowDialog()

		If result = True Then
			pdfViewerControl1.InputFile = dlg.FileName
		End If

	End Sub
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****PdfViewerInWpf.VS2010.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{33F91A24-6904-4546-91A8-A480C51759E6}</ProjectGuid>
    <ProjectTypeGuids>{60dc8134-eba5-43b8-bcc9-bb4bc16c2548};{F184B08F-C81C-45F6-A57F-5ABD9991F28F}</ProjectTypeGuids>
    <OutputType>WinExe</OutputType>
    <RootNamespace>PdfViewerInWpf</RootNamespace>
    <AssemblyName>PdfViewerInWpf</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <MyType>Custom</MyType>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <IncrementalBuild>true</IncrementalBuild>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>PdfViewerInWpf.xml</DocumentationFile>
    <NoWarn>41999,42016,42017,42018,42019,42020,42021,42022,42032,42036,42314</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DebugSymbols>false</DebugSymbols>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <IncrementalBuild>false</IncrementalBuild>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>PdfViewerInWpf.xml</DocumentationFile>
    <NoWarn>41999,42016,42017,42018,42019,42020,42021,42022,42032,42036,42314</NoWarn>
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
    <Reference Include="Bytescout.PDFViewer, Version=8.0.0.2544, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\Program Files\Bytescout PDF Viewer SDK\net4.00\Bytescout.PDFViewer.dll</HintPath>
    </Reference>
    <Reference Include="System.Core" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Xaml">
      <RequiredTargetFramework>4.0</RequiredTargetFramework>
    </Reference>
    <Reference Include="UIAutomationProvider" />
    <Reference Include="WindowsBase" />
    <Reference Include="PresentationCore" />
    <Reference Include="PresentationFramework" />
    <Reference Include="WindowsFormsIntegration" />
  </ItemGroup>
  <ItemGroup>
    <ApplicationDefinition Include="Application.xaml">
      <Generator>MSBuild:Compile</Generator>
      <SubType>Designer</SubType>
    </ApplicationDefinition>
    <Page Include="MainWindow.xaml">
      <Generator>MSBuild:Compile</Generator>
      <SubType>Designer</SubType>
    </Page>
    <Compile Include="Application.xaml.vb">
      <DependentUpon>Application.xaml</DependentUpon>
      <SubType>Code</SubType>
    </Compile>
    <Compile Include="MainWindow.xaml.vb">
      <DependentUpon>MainWindow.xaml</DependentUpon>
      <SubType>Code</SubType>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <Import Include="System.Threading.Tasks" />
    <Import Include="System.Linq" />
    <Import Include="System.Xml.Linq" />
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Collections" />
    <Import Include="System.Collections.Generic" />
    <Import Include="System.Diagnostics" />
    <Import Include="System.Windows" />
    <Import Include="System.Windows.Controls" />
    <Import Include="System.Windows.Data" />
    <Import Include="System.Windows.Documents" />
    <Import Include="System.Windows.Input" />
    <Import Include="System.Windows.Shapes" />
    <Import Include="System.Windows.Media" />
    <Import Include="System.Windows.Media.Imaging" />
    <Import Include="System.Windows.Navigation" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="My Project\AssemblyInfo.vb">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include="My Project\MyExtensions\MyWpfExtension.vb">
      <VBMyExtensionTemplateID>Microsoft.VisualBasic.WPF.MyExtension</VBMyExtensionTemplateID>
      <VBMyExtensionTemplateVersion>1.0.0.0</VBMyExtensionTemplateVersion>
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
    <EmbeddedResource Include="My Project\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
    </EmbeddedResource>
    <None Include="My Project\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
    <AppDesigner Include="My Project\" />
    <Content Include="sample.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****PdfViewerInWpf.VS2012.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{33F91A24-6904-4546-91A8-A480C51759E6}</ProjectGuid>
    <ProjectTypeGuids>{60dc8134-eba5-43b8-bcc9-bb4bc16c2548};{F184B08F-C81C-45F6-A57F-5ABD9991F28F}</ProjectTypeGuids>
    <OutputType>WinExe</OutputType>
    <RootNamespace>PdfViewerInWpf</RootNamespace>
    <AssemblyName>PdfViewerInWpf</AssemblyName>
    <TargetFrameworkVersion>v4.5</TargetFrameworkVersion>
    <MyType>Custom</MyType>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <IncrementalBuild>true</IncrementalBuild>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>PdfViewerInWpf.xml</DocumentationFile>
    <NoWarn>41999,42016,42017,42018,42019,42020,42021,42022,42032,42036,42314</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DebugSymbols>false</DebugSymbols>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <IncrementalBuild>false</IncrementalBuild>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>PdfViewerInWpf.xml</DocumentationFile>
    <NoWarn>41999,42016,42017,42018,42019,42020,42021,42022,42032,42036,42314</NoWarn>
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
    <Reference Include="Bytescout.PDFViewer, Version=8.0.0.2544, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\Program Files\Bytescout PDF Viewer SDK\net4.00\Bytescout.PDFViewer.dll</HintPath>
    </Reference>
    <Reference Include="System.Core" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Xaml">
      <RequiredTargetFramework>4.0</RequiredTargetFramework>
    </Reference>
    <Reference Include="UIAutomationProvider" />
    <Reference Include="WindowsBase" />
    <Reference Include="PresentationCore" />
    <Reference Include="PresentationFramework" />
    <Reference Include="WindowsFormsIntegration" />
  </ItemGroup>
  <ItemGroup>
    <ApplicationDefinition Include="Application.xaml">
      <Generator>MSBuild:Compile</Generator>
      <SubType>Designer</SubType>
    </ApplicationDefinition>
    <Page Include="MainWindow.xaml">
      <Generator>MSBuild:Compile</Generator>
      <SubType>Designer</SubType>
    </Page>
    <Compile Include="Application.xaml.vb">
      <DependentUpon>Application.xaml</DependentUpon>
      <SubType>Code</SubType>
    </Compile>
    <Compile Include="MainWindow.xaml.vb">
      <DependentUpon>MainWindow.xaml</DependentUpon>
      <SubType>Code</SubType>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <Import Include="System.Threading.Tasks" />
    <Import Include="System.Linq" />
    <Import Include="System.Xml.Linq" />
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Collections" />
    <Import Include="System.Collections.Generic" />
    <Import Include="System.Diagnostics" />
    <Import Include="System.Windows" />
    <Import Include="System.Windows.Controls" />
    <Import Include="System.Windows.Data" />
    <Import Include="System.Windows.Documents" />
    <Import Include="System.Windows.Input" />
    <Import Include="System.Windows.Shapes" />
    <Import Include="System.Windows.Media" />
    <Import Include="System.Windows.Media.Imaging" />
    <Import Include="System.Windows.Navigation" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="My Project\AssemblyInfo.vb">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include="My Project\MyExtensions\MyWpfExtension.vb">
      <VBMyExtensionTemplateID>Microsoft.VisualBasic.WPF.MyExtension</VBMyExtensionTemplateID>
      <VBMyExtensionTemplateVersion>1.0.0.0</VBMyExtensionTemplateVersion>
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
    <EmbeddedResource Include="My Project\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
    </EmbeddedResource>
    <None Include="My Project\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
    <AppDesigner Include="My Project\" />
    <Content Include="sample.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****PdfViewerInWpf.VS2013.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="12.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{33F91A24-6904-4546-91A8-A480C51759E6}</ProjectGuid>
    <ProjectTypeGuids>{60dc8134-eba5-43b8-bcc9-bb4bc16c2548};{F184B08F-C81C-45F6-A57F-5ABD9991F28F}</ProjectTypeGuids>
    <OutputType>WinExe</OutputType>
    <RootNamespace>PdfViewerInWpf</RootNamespace>
    <AssemblyName>PdfViewerInWpf</AssemblyName>
    <TargetFrameworkVersion>v4.5</TargetFrameworkVersion>
    <MyType>Custom</MyType>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <IncrementalBuild>true</IncrementalBuild>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>PdfViewerInWpf.xml</DocumentationFile>
    <NoWarn>41999,42016,42017,42018,42019,42020,42021,42022,42032,42036,42314</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DebugSymbols>false</DebugSymbols>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <IncrementalBuild>false</IncrementalBuild>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>PdfViewerInWpf.xml</DocumentationFile>
    <NoWarn>41999,42016,42017,42018,42019,42020,42021,42022,42032,42036,42314</NoWarn>
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
    <Reference Include="Bytescout.PDFViewer, Version=8.0.0.2544, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\Program Files\Bytescout PDF Viewer SDK\net4.00\Bytescout.PDFViewer.dll</HintPath>
    </Reference>
    <Reference Include="System.Core" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Xaml">
      <RequiredTargetFramework>4.0</RequiredTargetFramework>
    </Reference>
    <Reference Include="UIAutomationProvider" />
    <Reference Include="WindowsBase" />
    <Reference Include="PresentationCore" />
    <Reference Include="PresentationFramework" />
    <Reference Include="WindowsFormsIntegration" />
  </ItemGroup>
  <ItemGroup>
    <ApplicationDefinition Include="Application.xaml">
      <Generator>MSBuild:Compile</Generator>
      <SubType>Designer</SubType>
    </ApplicationDefinition>
    <Page Include="MainWindow.xaml">
      <Generator>MSBuild:Compile</Generator>
      <SubType>Designer</SubType>
    </Page>
    <Compile Include="Application.xaml.vb">
      <DependentUpon>Application.xaml</DependentUpon>
      <SubType>Code</SubType>
    </Compile>
    <Compile Include="MainWindow.xaml.vb">
      <DependentUpon>MainWindow.xaml</DependentUpon>
      <SubType>Code</SubType>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <Import Include="System.Threading.Tasks" />
    <Import Include="System.Linq" />
    <Import Include="System.Xml.Linq" />
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Collections" />
    <Import Include="System.Collections.Generic" />
    <Import Include="System.Diagnostics" />
    <Import Include="System.Windows" />
    <Import Include="System.Windows.Controls" />
    <Import Include="System.Windows.Data" />
    <Import Include="System.Windows.Documents" />
    <Import Include="System.Windows.Input" />
    <Import Include="System.Windows.Shapes" />
    <Import Include="System.Windows.Media" />
    <Import Include="System.Windows.Media.Imaging" />
    <Import Include="System.Windows.Navigation" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="My Project\AssemblyInfo.vb">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include="My Project\MyExtensions\MyWpfExtension.vb">
      <VBMyExtensionTemplateID>Microsoft.VisualBasic.WPF.MyExtension</VBMyExtensionTemplateID>
      <VBMyExtensionTemplateVersion>1.0.0.0</VBMyExtensionTemplateVersion>
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
    <EmbeddedResource Include="My Project\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
    </EmbeddedResource>
    <None Include="My Project\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
    <AppDesigner Include="My Project\" />
    <Content Include="sample.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****PdfViewerInWpf.VS2015.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="14.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{33F91A24-6904-4546-91A8-A480C51759E6}</ProjectGuid>
    <ProjectTypeGuids>{60dc8134-eba5-43b8-bcc9-bb4bc16c2548};{F184B08F-C81C-45F6-A57F-5ABD9991F28F}</ProjectTypeGuids>
    <OutputType>WinExe</OutputType>
    <RootNamespace>PdfViewerInWpf</RootNamespace>
    <AssemblyName>PdfViewerInWpf</AssemblyName>
    <TargetFrameworkVersion>v4.5</TargetFrameworkVersion>
    <MyType>Custom</MyType>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <IncrementalBuild>true</IncrementalBuild>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>PdfViewerInWpf.xml</DocumentationFile>
    <NoWarn>41999,42016,42017,42018,42019,42020,42021,42022,42032,42036,42314</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DebugSymbols>false</DebugSymbols>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <IncrementalBuild>false</IncrementalBuild>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>PdfViewerInWpf.xml</DocumentationFile>
    <NoWarn>41999,42016,42017,42018,42019,42020,42021,42022,42032,42036,42314</NoWarn>
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
    <Reference Include="Bytescout.PDFViewer, Version=8.0.0.2544, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\Program Files\Bytescout PDF Viewer SDK\net4.00\Bytescout.PDFViewer.dll</HintPath>
    </Reference>
    <Reference Include="System.Core" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Xaml">
      <RequiredTargetFramework>4.0</RequiredTargetFramework>
    </Reference>
    <Reference Include="UIAutomationProvider" />
    <Reference Include="WindowsBase" />
    <Reference Include="PresentationCore" />
    <Reference Include="PresentationFramework" />
    <Reference Include="WindowsFormsIntegration" />
  </ItemGroup>
  <ItemGroup>
    <ApplicationDefinition Include="Application.xaml">
      <Generator>MSBuild:Compile</Generator>
      <SubType>Designer</SubType>
    </ApplicationDefinition>
    <Page Include="MainWindow.xaml">
      <Generator>MSBuild:Compile</Generator>
      <SubType>Designer</SubType>
    </Page>
    <Compile Include="Application.xaml.vb">
      <DependentUpon>Application.xaml</DependentUpon>
      <SubType>Code</SubType>
    </Compile>
    <Compile Include="MainWindow.xaml.vb">
      <DependentUpon>MainWindow.xaml</DependentUpon>
      <SubType>Code</SubType>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <Import Include="System.Threading.Tasks" />
    <Import Include="System.Linq" />
    <Import Include="System.Xml.Linq" />
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Collections" />
    <Import Include="System.Collections.Generic" />
    <Import Include="System.Diagnostics" />
    <Import Include="System.Windows" />
    <Import Include="System.Windows.Controls" />
    <Import Include="System.Windows.Data" />
    <Import Include="System.Windows.Documents" />
    <Import Include="System.Windows.Input" />
    <Import Include="System.Windows.Shapes" />
    <Import Include="System.Windows.Media" />
    <Import Include="System.Windows.Media.Imaging" />
    <Import Include="System.Windows.Navigation" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="My Project\AssemblyInfo.vb">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include="My Project\MyExtensions\MyWpfExtension.vb">
      <VBMyExtensionTemplateID>Microsoft.VisualBasic.WPF.MyExtension</VBMyExtensionTemplateID>
      <VBMyExtensionTemplateVersion>1.0.0.0</VBMyExtensionTemplateVersion>
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
    <EmbeddedResource Include="My Project\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
    </EmbeddedResource>
    <None Include="My Project\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
    <AppDesigner Include="My Project\" />
    <Content Include="sample.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->