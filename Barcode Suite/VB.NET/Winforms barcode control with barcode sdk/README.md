## winforms barcode control with barcode sdk in VB.NET with ByteScout Barcode Suite

### Learn winforms barcode control with barcode sdk in VB.NET

An easy to understand guide to learn how to winforms barcode control with barcode sdk in VB.NET. ByteScout Barcode Suite helps with winforms barcode control with barcode sdk in VB.NET. ByteScout Barcode Suite is the bundle that privides 3  SDK products to generate barcodes (Barcode SDK), read barcodes (Barcode Reaer SDK) and read and write spreadsheets (Spreadsheet SDK).

Save time on writing and testing code by using the code below and use it in your application. To use winforms barcode control with barcode sdk in your VB.NET project or application just copy & paste the code and then run your app! Want to see how it works with your data then code testing will allow the function to be tested and work properly.

 If you want to try other samples for VB.NET then free trial version of ByteScout Barcode Suite is available on our website.

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

##### ****Form1.Designer.vb:**
    
```
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Margins1 As Bytescout.BarCode.Margins = New Bytescout.BarCode.Margins
        Dim SymbologyOptions1 As Bytescout.BarCode.SymbologyOptions = New Bytescout.BarCode.SymbologyOptions
        Me.BarcodeControl1 = New Bytescout.BarCode.BarcodeControl
        Me.SuspendLayout()
        '
        'BarcodeControl1
        '
        Me.BarcodeControl1.AddChecksum = False
        Me.BarcodeControl1.AddChecksumToCaption = False
        Me.BarcodeControl1.AdditionalCaption = ""
        Me.BarcodeControl1.AdditionalCaptionFont = New System.Drawing.Font("Arial", 12.0!)
        Me.BarcodeControl1.AdditionalCaptionPosition = Bytescout.BarCode.CaptionPosition.Above
        Me.BarcodeControl1.Angle = Bytescout.BarCode.RotationAngle.Degrees0
        Me.BarcodeControl1.BarHeight = 50
        Me.BarcodeControl1.CaptionFont = New System.Drawing.Font("Arial", 12.0!)
        Me.BarcodeControl1.CaptionPosition = Bytescout.BarCode.CaptionPosition.Below
        Me.BarcodeControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BarcodeControl1.DrawCaption = True
        Me.BarcodeControl1.HorizontalAlignment = Bytescout.BarCode.BarcodeHorizontalAlignment.Center
        Me.BarcodeControl1.Location = New System.Drawing.Point(0, 0)
        Margins1.Bottom = 0
        Margins1.Left = 0
        Margins1.Right = 0
        Margins1.Top = 0
        Me.BarcodeControl1.Margins = Margins1
        Me.BarcodeControl1.Name = "BarcodeControl1"
        Me.BarcodeControl1.NarrowBarWidth = 3
        SymbologyOptions1.CodabarChecksumAlgorithm = Bytescout.BarCode.CodabarChecksumAlgorithm.Modulo9
        SymbologyOptions1.CodabarStartSymbol = Bytescout.BarCode.CodabarSpecialSymbol.A
        SymbologyOptions1.CodabarStopSymbol = Bytescout.BarCode.CodabarSpecialSymbol.A
        SymbologyOptions1.Code128Alphabet = Bytescout.BarCode.Code128Alphabet.[Auto]
        SymbologyOptions1.DrawIntercharacterGap = True
        SymbologyOptions1.ShowStartStop = False
        Me.BarcodeControl1.Options = SymbologyOptions1
        Me.BarcodeControl1.RegistrationKey = ""
        Me.BarcodeControl1.RegistrationName = ""
        Me.BarcodeControl1.RenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.BarcodeControl1.Size = New System.Drawing.Size(284, 264)
        Me.BarcodeControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        Me.BarcodeControl1.Symbology = Bytescout.BarCode.SymbologyType.Code39
        Me.BarcodeControl1.TabIndex = 0
        Me.BarcodeControl1.Value = "5712349"
        Me.BarcodeControl1.VerticalAlignment = Bytescout.BarCode.BarcodeVerticalAlignment.Middle
        Me.BarcodeControl1.WideToNarrowRatio = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.BarcodeControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarcodeControl1 As Bytescout.BarCode.BarcodeControl

End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Form1.vb:**
    
```
Public Class Form1

End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****VBControlTester.VS2005.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{3C361A9E-C6D0-41C7-8A8D-25A6206045CE}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <StartupObject>VBControlTester.My.MyApplication</StartupObject>
    <RootNamespace>VBControlTester</RootNamespace>
    <AssemblyName>VBControlTester</AssemblyName>
    <MyType>WindowsForms</MyType>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>VBControlTester.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>VBControlTester.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCode, Version=1.0.0.0, Culture=neutral, processorArchitecture=MSIL">
      <HintPath>C:\Program Files\Bytescout BarCode SDK\net2.00\Bytescout.BarCode.dll</HintPath>
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="Bytescout.BarCode.WinForms, Version=1.0.0.0, Culture=neutral, processorArchitecture=MSIL">
      <HintPath>C:\Program Files\Bytescout BarCode SDK\net2.00\Bytescout.BarCode.WinForms.dll</HintPath>
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Design" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Web" />
    <Reference Include="System.Windows.Forms" />
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
    <Import Include="System.Drawing" />
    <Import Include="System.Diagnostics" />
    <Import Include="System.Windows.Forms" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Form1.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form1.Designer.vb">
      <DependentUpon>Form1.vb</DependentUpon>
      <SubType>Form</SubType>
    </Compile>
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
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
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

##### ****VBControlTester.VS2008.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="3.5">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.21022</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{3C361A9E-C6D0-41C7-8A8D-25A6206045CE}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <StartupObject>VBControlTester.My.MyApplication</StartupObject>
    <RootNamespace>VBControlTester</RootNamespace>
    <AssemblyName>VBControlTester</AssemblyName>
    <MyType>WindowsForms</MyType>
    <OldToolsVersion>2.0</OldToolsVersion>
    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>VBControlTester.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>VBControlTester.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCode, Version=1.0.0.0, Culture=neutral, processorArchitecture=MSIL">
      <HintPath>C:\Program Files\Bytescout BarCode SDK\net3.50\Bytescout.BarCode.dll</HintPath>
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="Bytescout.BarCode.WinForms, Version=1.0.0.0, Culture=neutral, processorArchitecture=MSIL">
      <HintPath>C:\Program Files\Bytescout BarCode SDK\net3.50\Bytescout.BarCode.WinForms.dll</HintPath>
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Design" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Web" />
    <Reference Include="System.Windows.Forms" />
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
    <Import Include="System.Drawing" />
    <Import Include="System.Diagnostics" />
    <Import Include="System.Windows.Forms" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Form1.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form1.Designer.vb">
      <DependentUpon>Form1.vb</DependentUpon>
      <SubType>Form</SubType>
    </Compile>
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
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
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

##### ****VBControlTester.VS2010.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{3C361A9E-C6D0-41C7-8A8D-25A6206045CE}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <StartupObject>VBControlTester.My.MyApplication</StartupObject>
    <RootNamespace>VBControlTester</RootNamespace>
    <AssemblyName>VBControlTester</AssemblyName>
    <MyType>WindowsForms</MyType>
    <OldToolsVersion>3.5</OldToolsVersion>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>VBControlTester.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>VBControlTester.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCode, Version=1.0.0.0, Culture=neutral, processorArchitecture=MSIL">
      <HintPath>C:\Program Files\Bytescout BarCode SDK\net4.00\Bytescout.BarCode.dll</HintPath>
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="Bytescout.BarCode.WinForms, Version=1.0.0.0, Culture=neutral, processorArchitecture=MSIL">
      <HintPath>C:\Program Files\Bytescout BarCode SDK\net4.00\Bytescout.BarCode.WinForms.dll</HintPath>
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Design" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Web" />
    <Reference Include="System.Windows.Forms" />
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
    <Import Include="System.Drawing" />
    <Import Include="System.Diagnostics" />
    <Import Include="System.Windows.Forms" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Form1.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form1.Designer.vb">
      <DependentUpon>Form1.vb</DependentUpon>
      <SubType>Form</SubType>
    </Compile>
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
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
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