## WPF UI barcode reading example in VB.NET using ByteScout BarCode Reader SDK

### Make WPF UI barcode reading example in VB.NET: ### Tutorial on how to do WPF UI barcode reading example in VB.NET

The documentation is designed to help you to implement the features on your side. ByteScout BarCode Reader SDK helps with WPF UI barcode reading example in VB.NET. ByteScout BarCode Reader SDK is the SDK for barcode decoding. Can read all popular types from Code 128, GS1, UPC and Code 39 to QR Code, Datamatrix, PDF417. Images, pdf, TIF images and live web camera are supported as input. Designed to handle documents with noise and defects. Includes optional splitter and merger for pdf and tiff based on barcodes. Batch mode is optimized for high performance with multiple threads. Decoded values can be exported to XML, JSON, CSV or into custom data format.

VB.NET code snippet like this for ByteScout BarCode Reader SDK works best when you need to quickly implement WPF UI barcode reading example in your VB.NET application. VB.NET sample code is all you need: copy and paste the code to your VB.NET application's code editor, add a reference to ByteScout BarCode Reader SDK (if you haven't added yet) and you are ready to go! Enjoy writing a code with ready-to-use sample VB.NET codes to implement WPF UI barcode reading example using ByteScout BarCode Reader SDK.

Trial version can be obtained from our website for free. It includes this and other source code samples for VB.NET.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20BarCode%20Reader%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20BarCode%20Reader%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=EARSPJFIJMU](https://www.youtube.com/watch?v=EARSPJFIJMU)




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
Imports System.Text
Imports Bytescout.BarCodeReader

Class MainWindow

    ' Select image file
    Private Sub btnBrowse_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles btnBrowse.Click

        Dim dlg = New Microsoft.Win32.OpenFileDialog
        dlg.Filter = "Supported formats (*.bmp;*.gif;*.tif;*.png;*.jpg;*.pdf)|*.bmp;*.gif;*.tif;*.tiff;*.png;*.jpg;*.jpeg;*.pdf|All Files|*.*"

        If dlg.ShowDialog() = True Then

            tbFileName.Text = dlg.FileName
            tbFoundBarcodes.Text = ""
            imageContainer.Source = Nothing

            Try
                Dim bitmapImage = New BitmapImage()
                bitmapImage.BeginInit()
                bitmapImage.UriSource = New Uri(dlg.FileName, UriKind.Absolute)
                bitmapImage.EndInit()

                imageContainer.Source = bitmapImage

            Catch ex As Exception
            End Try

        End If
    End Sub

    Private Sub btnDecode_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles btnDecode.Click

        ' Create barcode reader instance
        Dim reader = New Reader()
        reader.RegistrationName = "demo"
        reader.RegistrationKey = "demo"

        ' Specify barcode types to find
        reader.BarcodeTypesToFind.All = True
        ' Select specific barcode types to speed up the decoding process and avoid false positives.

        ' Show wait cursor
        Mouse.OverrideCursor = Cursors.Wait

        ' -----------------------------------------------------------------------
        ' NOTE: We can read barcodes from specific page to increase performance .
        ' For sample please refer to "Decoding barcodes from PDF by pages" program.
        ' ----------------------------------------------------------------------- 

        Try
            '  Search for barcodes
            reader.ReadFrom(tbFileName.Text)
        Finally
            Mouse.OverrideCursor = Nothing
        End Try

        ' Display found barcode inforamtion:

        Dim stringBuilder = New StringBuilder()

        For i As Integer = 0 To reader.FoundBarcodes.Length - 1
            Dim barcode = reader.FoundBarcodes(i)
            stringBuilder.AppendFormat("{0}) Type: {1}; Value: {2}.\r\n", i + 1, barcode.Type, barcode.Value)
        Next

        tbFoundBarcodes.Text = stringBuilder.ToString()

    End Sub

End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ReadBarcodeFromImage.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProjectGuid>{FBDB3D1A-12C4-4781-8938-8F4915B90FB0}</ProjectGuid>
    <ProjectTypeGuids>{60dc8134-eba5-43b8-bcc9-bb4bc16c2548};{F184B08F-C81C-45F6-A57F-5ABD9991F28F}</ProjectTypeGuids>
    <OutputType>WinExe</OutputType>
    <RootNamespace>ReadBarcodeFromImage</RootNamespace>
    <AssemblyName>ReadBarcodeFromImage</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <TargetFrameworkProfile>Client</TargetFrameworkProfile>
    <MyType>Custom</MyType>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <IncrementalBuild>true</IncrementalBuild>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>ReadBarcodeFromImage.xml</DocumentationFile>
    <NoWarn>41999,42016,42017,42018,42019,42020,42021,42022,42032,42036,42314</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DebugSymbols>false</DebugSymbols>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <IncrementalBuild>false</IncrementalBuild>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>ReadBarcodeFromImage.xml</DocumentationFile>
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
    <Reference Include="Bytescout.BarCodeReader">
      <HintPath>C:\Program Files\Bytescout BarCode Reader SDK\net4.00\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System.Core" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Xaml">
      <RequiredTargetFramework>4.0</RequiredTargetFramework>
    </Reference>
    <Reference Include="WindowsBase" />
    <Reference Include="PresentationCore" />
    <Reference Include="PresentationFramework" />
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
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->