## How to generate barcode in crystalreports application vb with barcode sdk in Crystal Reports and ByteScout Premium Suite

### Learn to code in Crystal Reports to generate barcode in crystalreports application vb with barcode sdk with this step-by-step tutorial

An easy to understand guide on how to generate barcode in crystalreports application vb with barcode sdk in Crystal Reports with this source code sample. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording and you can use it to generate barcode in crystalreports application vb with barcode sdk with Crystal Reports.

Want to quickly learn? This fast application programming interfaces of ByteScout Premium Suite for Crystal Reports plus the guidelines and the code below will help you quickly learn how to generate barcode in crystalreports application vb with barcode sdk. Follow the instructions from scratch to work and copy the Crystal Reports code. Complete and detailed tutorials and documentation are available along with installed ByteScout Premium Suite if you'd like to learn more about the topic and the details of the API.

ByteScout provides the free trial version of ByteScout Premium Suite along with the documentation and source code samples.

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

##### ****BarcodeInCrystalReports.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 14
VisualStudioVersion = 14.0.25420.1
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "BarcodeInCrystalReports", "BarcodeInCrystalReports.vbproj", "{15B4BB8A-478B-4AC4-AE9F-DB6C4F76FB5A}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Debug|x86 = Debug|x86
		Release|Any CPU = Release|Any CPU
		Release|x86 = Release|x86
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{15B4BB8A-478B-4AC4-AE9F-DB6C4F76FB5A}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{15B4BB8A-478B-4AC4-AE9F-DB6C4F76FB5A}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{15B4BB8A-478B-4AC4-AE9F-DB6C4F76FB5A}.Debug|x86.ActiveCfg = Debug|x86
		{15B4BB8A-478B-4AC4-AE9F-DB6C4F76FB5A}.Debug|x86.Build.0 = Debug|x86
		{15B4BB8A-478B-4AC4-AE9F-DB6C4F76FB5A}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{15B4BB8A-478B-4AC4-AE9F-DB6C4F76FB5A}.Release|Any CPU.Build.0 = Release|Any CPU
		{15B4BB8A-478B-4AC4-AE9F-DB6C4F76FB5A}.Release|x86.ActiveCfg = Release|x86
		{15B4BB8A-478B-4AC4-AE9F-DB6C4F76FB5A}.Release|x86.Build.0 = Release|x86
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****BarcodeInCrystalReports.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{15B4BB8A-478B-4AC4-AE9F-DB6C4F76FB5A}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <StartupObject>BarcodeInCrystalReports.My.MyApplication</StartupObject>
    <RootNamespace>BarcodeInCrystalReports</RootNamespace>
    <AssemblyName>BarcodeInCrystalReports</AssemblyName>
    <MyType>WindowsForms</MyType>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <FileUpgradeFlags>
    </FileUpgradeFlags>
    <OldToolsVersion>3.5</OldToolsVersion>
    <UpgradeBackupLocation />
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
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>BarcodeInCrystalReports.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022,42353,42354,42355</NoWarn>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>BarcodeInCrystalReports.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022,42353,42354,42355</NoWarn>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
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
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Debug|x86'">
    <DebugSymbols>true</DebugSymbols>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\x86\Debug\</OutputPath>
    <DocumentationFile>BarcodeInCrystalReports.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022,42353,42354,42355</NoWarn>
    <DebugType>full</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <CodeAnalysisLogFile>bin\Debug\CrystalReportsApplication2.exe.CodeAnalysisLog.xml</CodeAnalysisLogFile>
    <CodeAnalysisUseTypeNameInSuppression>true</CodeAnalysisUseTypeNameInSuppression>
    <CodeAnalysisModuleSuppressionsFile>GlobalSuppressions.vb</CodeAnalysisModuleSuppressionsFile>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisRuleSetDirectories>;C:\Program Files (x86)\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\\Rule Sets</CodeAnalysisRuleSetDirectories>
    <CodeAnalysisIgnoreBuiltInRuleSets>true</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisRuleDirectories>;C:\Program Files (x86)\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\FxCop\\Rules</CodeAnalysisRuleDirectories>
    <CodeAnalysisIgnoreBuiltInRules>true</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Release|x86'">
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\x86\Release\</OutputPath>
    <DocumentationFile>BarcodeInCrystalReports.xml</DocumentationFile>
    <Optimize>true</Optimize>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022,42353,42354,42355</NoWarn>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <CodeAnalysisLogFile>bin\Release\CrystalReportsApplication2.exe.CodeAnalysisLog.xml</CodeAnalysisLogFile>
    <CodeAnalysisUseTypeNameInSuppression>true</CodeAnalysisUseTypeNameInSuppression>
    <CodeAnalysisModuleSuppressionsFile>GlobalSuppressions.vb</CodeAnalysisModuleSuppressionsFile>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisRuleSetDirectories>;C:\Program Files (x86)\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\\Rule Sets</CodeAnalysisRuleSetDirectories>
    <CodeAnalysisIgnoreBuiltInRuleSets>true</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisRuleDirectories>;C:\Program Files (x86)\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\FxCop\\Rules</CodeAnalysisRuleDirectories>
    <CodeAnalysisIgnoreBuiltInRules>true</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCode, Version=4.57.0.930, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Generator SDK\net4.00\Bytescout.BarCode.dll</HintPath>
    </Reference>
    <Reference Include="CrystalDecisions.CrystalReports.Engine, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304, processorArchitecture=MSIL" />
    <Reference Include="CrystalDecisions.ReportSource, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304, processorArchitecture=MSIL" />
    <Reference Include="CrystalDecisions.Shared, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304, processorArchitecture=MSIL" />
    <Reference Include="CrystalDecisions.Windows.Forms, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304, processorArchitecture=MSIL" />
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
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
    <Compile Include="CrystalReport1.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>CrystalReport1.rpt</DependentUpon>
      <SubType>Component</SubType>
    </Compile>
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
    <Compile Include="ProductsDataSet.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>ProductsDataSet.xsd</DependentUpon>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="CrystalReport1.rpt">
      <Generator>CrystalDecisions.VSDesigner.CodeGen.ReportCodeGenerator</Generator>
      <LastGenOutput>CrystalReport1.vb</LastGenOutput>
    </EmbeddedResource>
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
    <None Include="app.config" />
    <None Include="My Project\Application.myapp">
      <Generator>MyApplicationCodeGenerator</Generator>
      <LastGenOutput>Application.Designer.vb</LastGenOutput>
    </None>
    <None Include="My Project\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <CustomToolNamespace>My</CustomToolNamespace>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
    <None Include="ProductsDataSet.xsc">
      <DependentUpon>ProductsDataSet.xsd</DependentUpon>
    </None>
    <None Include="ProductsDataSet.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>ProductsDataSet.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="ProductsDataSet.xss">
      <DependentUpon>ProductsDataSet.xsd</DependentUpon>
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
  <ItemGroup>
    <Service Include="{C0C07587-41A7-46C8-8FBD-3F9C8EBE2DDC}" />
    <Service Include="{FE73BB80-53F4-4AD0-A5F9-6A0BCE662292}" />
  </ItemGroup>
  <ItemGroup>
    <BootstrapperPackage Include=".NETFramework,Version=v4.0">
      <Visible>False</Visible>
      <ProductName>Microsoft .NET Framework 4 %28x86 and x64%29</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Client.3.5">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1 Client Profile</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Framework.3.5.SP1">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Windows.Installer.3.1">
      <Visible>False</Visible>
      <ProductName>Windows Installer 3.1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
  </ItemGroup>
  <ItemGroup>
    <Content Include="products.mdb">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****CrystalReport1.vb:**
    
```
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34014
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System
Imports System.ComponentModel


Public Class CrystalReport1
    Inherits ReportClass
    
    Public Sub New()
        MyBase.New
    End Sub
    
    Public Overrides Property ResourceName() As String
        Get
            Return "CrystalReport1.rpt"
        End Get
        Set
            'Do nothing
        End Set
    End Property
    
    Public Overrides Property NewGenerator() As Boolean
        Get
            Return true
        End Get
        Set
            'Do nothing
        End Set
    End Property
    
    Public Overrides Property FullResourceName() As String
        Get
            Return "BarcodeInCrystalReports.CrystalReport1.rpt"
        End Get
        Set
            'Do nothing
        End Set
    End Property
    
    <Browsable(false),  _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public ReadOnly Property Section1() As CrystalDecisions.CrystalReports.Engine.Section
        Get
            Return Me.ReportDefinition.Sections(0)
        End Get
    End Property
    
    <Browsable(false),  _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public ReadOnly Property Section2() As CrystalDecisions.CrystalReports.Engine.Section
        Get
            Return Me.ReportDefinition.Sections(1)
        End Get
    End Property
    
    <Browsable(false),  _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public ReadOnly Property Section3() As CrystalDecisions.CrystalReports.Engine.Section
        Get
            Return Me.ReportDefinition.Sections(2)
        End Get
    End Property
    
    <Browsable(false),  _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public ReadOnly Property Section4() As CrystalDecisions.CrystalReports.Engine.Section
        Get
            Return Me.ReportDefinition.Sections(3)
        End Get
    End Property
    
    <Browsable(false),  _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public ReadOnly Property Section5() As CrystalDecisions.CrystalReports.Engine.Section
        Get
            Return Me.ReportDefinition.Sections(4)
        End Get
    End Property
End Class

<System.Drawing.ToolboxBitmapAttribute(GetType(CrystalDecisions.[Shared].ExportOptions), "report.bmp")>  _
Public Class CachedCrystalReport1
    Inherits Component
    Implements ICachedReport
    
    Public Sub New()
        MyBase.New
    End Sub
    
    <Browsable(false),  _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Overridable Property IsCacheable() As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.IsCacheable
        Get
            Return true
        End Get
        Set
            '
        End Set
    End Property
    
    <Browsable(false),  _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Overridable Property ShareDBLogonInfo() As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.ShareDBLogonInfo
        Get
            Return false
        End Get
        Set
            '
        End Set
    End Property
    
    <Browsable(false),  _
     DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Overridable Property CacheTimeOut() As System.TimeSpan Implements CrystalDecisions.ReportSource.ICachedReport.CacheTimeOut
        Get
            Return CachedReportConstants.DEFAULT_TIMEOUT
        End Get
        Set
            '
        End Set
    End Property
    
    Public Overridable Function CreateReport() As CrystalDecisions.CrystalReports.Engine.ReportDocument Implements CrystalDecisions.ReportSource.ICachedReport.CreateReport
        Dim rpt As CrystalReport1 = New CrystalReport1()
        rpt.Site = Me.Site
        Return rpt
    End Function
    
    Public Overridable Function GetCustomizedCacheKey(ByVal request As RequestContext) As String Implements CrystalDecisions.ReportSource.ICachedReport.GetCustomizedCacheKey
        Dim key As [String] = Nothing
        '// The following is the code used to generate the default
        '// cache key for caching report jobs in the ASP.NET Cache.
        '// Feel free to modify this code to suit your needs.
        '// Returning key == null causes the default cache key to
        '// be generated.
        '
        'key = RequestContext.BuildCompleteCacheKey(
        '    request,
        '    null,       // sReportFilename
        '    this.GetType(),
        '    this.ShareDBLogonInfo );
        Return key
    End Function
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Form1.Designer.vb:**
    
```
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReport11 = New BarcodeInCrystalReports.CrystalReport1()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CrystalReport11
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(792, 566)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReport11 As CrystalReport1

End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Form1.vb:**
    
```
Imports System.Data.OleDb
Imports Bytescout.BarCode

Public Class Form1

    Private Sub CrystalReportViewer1_Load(sender As System.Object, e As System.EventArgs) Handles CrystalReportViewer1.Load

        Dim connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=products.mdb")
        Dim dataAdapter As New OleDbDataAdapter("SELECT ID, ProductName, ProductDescription, ProductPrice FROM Products", connection)

        ' fill dataset
        Dim dataSet As New DataSet()
        dataAdapter.Fill(dataSet)

        connection.Close()

        'add virtual column into the result table
        dataSet.Tables(0).Columns.Add(New DataColumn("BarcodeImage", GetType(System.Byte())))

        ' create barcode object
        Dim barcode As New Barcode(SymbologyType.Code128)
        barcode.DrawCaption = False

        ' Fill BarcodeImage column with generated barcode image bytes
        For Each row As DataRow In dataSet.Tables(0).Rows

            'set barcode value
            barcode.Value = Convert.ToString(row("ID"))

            ' retrieve generated image bytes
            Dim barcodeBytes As Byte() = barcode.GetImageBytesWMF()

            ' fill virtual column with generated image bytes
            row("BarcodeImage") = barcodeBytes

        Next

        ' set filled DataSet as report's data source
        CrystalReport11.SetDataSource(dataSet.Tables(0))

    End Sub
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ProductsDataSet.Designer.vb:**
    
```
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34014
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



'''<summary>
'''Represents a strongly typed in-memory cache of data.
'''</summary>
<Global.System.Serializable(),  _
 Global.System.ComponentModel.DesignerCategoryAttribute("code"),  _
 Global.System.ComponentModel.ToolboxItem(true),  _
 Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema"),  _
 Global.System.Xml.Serialization.XmlRootAttribute("ProductsDataSet"),  _
 Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")>  _
Partial Public Class ProductsDataSet
    Inherits Global.System.Data.DataSet
    
    Private tableProducts As ProductsDataTable
    
    Private _schemaSerializationMode As Global.System.Data.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Sub New()
        MyBase.New
        Me.BeginInit
        Me.InitClass
        Dim schemaChangedHandler As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler MyBase.Relations.CollectionChanged, schemaChangedHandler
        Me.EndInit
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
        MyBase.New(info, context, false)
        If (Me.IsBinarySerialized(info, context) = true) Then
            Me.InitVars(false)
            Dim schemaChangedHandler1 As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
            AddHandler Me.Tables.CollectionChanged, schemaChangedHandler1
            AddHandler Me.Relations.CollectionChanged, schemaChangedHandler1
            Return
        End If
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(String)),String)
        If (Me.DetermineSchemaSerializationMode(info, context) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
            Dim ds As Global.System.Data.DataSet = New Global.System.Data.DataSet()
            ds.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("Products")) Is Nothing) Then
                MyBase.Tables.Add(New ProductsDataTable(ds.Tables("Products")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, Global.System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Browsable(false),  _
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Products() As ProductsDataTable
        Get
            Return Me.tableProducts
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.BrowsableAttribute(true),  _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Visible)>  _
    Public Overrides Property SchemaSerializationMode() As Global.System.Data.SchemaSerializationMode
        Get
            Return Me._schemaSerializationMode
        End Get
        Set
            Me._schemaSerializationMode = value
        End Set
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Tables() As Global.System.Data.DataTableCollection
        Get
            Return MyBase.Tables
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Relations() As Global.System.Data.DataRelationCollection
        Get
            Return MyBase.Relations
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Protected Overrides Sub InitializeDerivedDataSet()
        Me.BeginInit
        Me.InitClass
        Me.EndInit
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Overrides Function Clone() As Global.System.Data.DataSet
        Dim cln As ProductsDataSet = CType(MyBase.Clone,ProductsDataSet)
        cln.InitVars
        cln.SchemaSerializationMode = Me.SchemaSerializationMode
        Return cln
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As Global.System.Xml.XmlReader)
        If (Me.DetermineSchemaSerializationMode(reader) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
            Me.Reset
            Dim ds As Global.System.Data.DataSet = New Global.System.Data.DataSet()
            ds.ReadXml(reader)
            If (Not (ds.Tables("Products")) Is Nothing) Then
                MyBase.Tables.Add(New ProductsDataTable(ds.Tables("Products")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, Global.System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXml(reader)
            Me.InitVars
        End If
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Protected Overrides Function GetSchemaSerializable() As Global.System.Xml.Schema.XmlSchema
        Dim stream As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
        Me.WriteXmlSchema(New Global.System.Xml.XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return Global.System.Xml.Schema.XmlSchema.Read(New Global.System.Xml.XmlTextReader(stream), Nothing)
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Friend Overloads Sub InitVars()
        Me.InitVars(true)
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Friend Overloads Sub InitVars(ByVal initTable As Boolean)
        Me.tableProducts = CType(MyBase.Tables("Products"),ProductsDataTable)
        If (initTable = true) Then
            If (Not (Me.tableProducts) Is Nothing) Then
                Me.tableProducts.InitVars
            End If
        End If
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Sub InitClass()
        Me.DataSetName = "ProductsDataSet"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ProductsDataSet.xsd"
        Me.EnforceConstraints = true
        Me.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema
        Me.tableProducts = New ProductsDataTable()
        MyBase.Tables.Add(Me.tableProducts)
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Function ShouldSerializeProducts() As Boolean
        Return false
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As Global.System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = Global.System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Shared Function GetTypedDataSetSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
        Dim ds As ProductsDataSet = New ProductsDataSet()
        Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
        Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
        Dim any As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
        any.Namespace = ds.Namespace
        sequence.Items.Add(any)
        type.Particle = sequence
        Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
        If xs.Contains(dsSchema.TargetNamespace) Then
            Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
            Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
            Try 
                Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                dsSchema.Write(s1)
                Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                Do While schemas.MoveNext
                    schema = CType(schemas.Current,Global.System.Xml.Schema.XmlSchema)
                    s2.SetLength(0)
                    schema.Write(s2)
                    If (s1.Length = s2.Length) Then
                        s1.Position = 0
                        s2.Position = 0
                        
                        Do While ((s1.Position <> s1.Length)  _
                                    AndAlso (s1.ReadByte = s2.ReadByte))
                            
                            
                        Loop
                        If (s1.Position = s1.Length) Then
                            Return type
                        End If
                    End If
                    
                Loop
            Finally
                If (Not (s1) Is Nothing) Then
                    s1.Close
                End If
                If (Not (s2) Is Nothing) Then
                    s2.Close
                End If
            End Try
        End If
        xs.Add(dsSchema)
        Return type
    End Function
    
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Delegate Sub ProductsRowChangeEventHandler(ByVal sender As Object, ByVal e As ProductsRowChangeEvent)
    
    '''<summary>
    '''Represents the strongly named DataTable class.
    '''</summary>
    <Global.System.Serializable(),  _
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>  _
    Partial Public Class ProductsDataTable
        Inherits Global.System.Data.DataTable
        Implements Global.System.Collections.IEnumerable
        
        Private columnID As Global.System.Data.DataColumn
        
        Private columnProductName As Global.System.Data.DataColumn
        
        Private columnProductDescription As Global.System.Data.DataColumn
        
        Private columnProductPrice As Global.System.Data.DataColumn
        
        Private columnBarcodeImage As Global.System.Data.DataColumn
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub New()
            MyBase.New
            Me.TableName = "Products"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property IDColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnID
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property ProductNameColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnProductName
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property ProductDescriptionColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnProductDescription
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property ProductPriceColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnProductPrice
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property BarcodeImageColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnBarcodeImage
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
         Global.System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Default ReadOnly Property Item(ByVal index As Integer) As ProductsRow
            Get
                Return CType(Me.Rows(index),ProductsRow)
            End Get
        End Property
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Event ProductsRowChanging As ProductsRowChangeEventHandler
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Event ProductsRowChanged As ProductsRowChangeEventHandler
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Event ProductsRowDeleting As ProductsRowChangeEventHandler
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Event ProductsRowDeleted As ProductsRowChangeEventHandler
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Overloads Sub AddProductsRow(ByVal row As ProductsRow)
            Me.Rows.Add(row)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Overloads Function AddProductsRow(ByVal ProductName As String, ByVal ProductDescription As String, ByVal ProductPrice As String, ByVal BarcodeImage() As Byte) As ProductsRow
            Dim rowProductsRow As ProductsRow = CType(Me.NewRow,ProductsRow)
            Dim columnValuesArray() As Object = New Object() {Nothing, ProductName, ProductDescription, ProductPrice, BarcodeImage}
            rowProductsRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowProductsRow)
            Return rowProductsRow
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function FindByID(ByVal ID As Integer) As ProductsRow
            Return CType(Me.Rows.Find(New Object() {ID}),ProductsRow)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Overridable Function GetEnumerator() As Global.System.Collections.IEnumerator Implements Global.System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As ProductsDataTable = CType(MyBase.Clone,ProductsDataTable)
            cln.InitVars
            Return cln
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New ProductsDataTable()
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Friend Sub InitVars()
            Me.columnID = MyBase.Columns("ID")
            Me.columnProductName = MyBase.Columns("ProductName")
            Me.columnProductDescription = MyBase.Columns("ProductDescription")
            Me.columnProductPrice = MyBase.Columns("ProductPrice")
            Me.columnBarcodeImage = MyBase.Columns("BarcodeImage")
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Private Sub InitClass()
            Me.columnID = New Global.System.Data.DataColumn("ID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnID)
            Me.columnProductName = New Global.System.Data.DataColumn("ProductName", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnProductName)
            Me.columnProductDescription = New Global.System.Data.DataColumn("ProductDescription", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnProductDescription)
            Me.columnProductPrice = New Global.System.Data.DataColumn("ProductPrice", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnProductPrice)
            Me.columnBarcodeImage = New Global.System.Data.DataColumn("BarcodeImage", GetType(Byte()), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnBarcodeImage)
            Me.Constraints.Add(New Global.System.Data.UniqueConstraint("Constraint1", New Global.System.Data.DataColumn() {Me.columnID}, true))
            Me.columnID.AutoIncrement = true
            Me.columnID.AutoIncrementSeed = -1
            Me.columnID.AutoIncrementStep = -1
            Me.columnID.AllowDBNull = false
            Me.columnID.Unique = true
            Me.columnProductName.MaxLength = 255
            Me.columnProductDescription.MaxLength = 255
            Me.columnProductPrice.MaxLength = 255
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function NewProductsRow() As ProductsRow
            Return CType(Me.NewRow,ProductsRow)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New ProductsRow(builder)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(ProductsRow)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.ProductsRowChangedEvent) Is Nothing) Then
                RaiseEvent ProductsRowChanged(Me, New ProductsRowChangeEvent(CType(e.Row,ProductsRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.ProductsRowChangingEvent) Is Nothing) Then
                RaiseEvent ProductsRowChanging(Me, New ProductsRowChangeEvent(CType(e.Row,ProductsRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.ProductsRowDeletedEvent) Is Nothing) Then
                RaiseEvent ProductsRowDeleted(Me, New ProductsRowChangeEvent(CType(e.Row,ProductsRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.ProductsRowDeletingEvent) Is Nothing) Then
                RaiseEvent ProductsRowDeleting(Me, New ProductsRowChangeEvent(CType(e.Row,ProductsRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub RemoveProductsRow(ByVal row As ProductsRow)
            Me.Rows.Remove(row)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As ProductsDataSet = New ProductsDataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "ProductsDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try 
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current,Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0
                            
                            Do While ((s1.Position <> s1.Length)  _
                                        AndAlso (s1.ReadByte = s2.ReadByte))
                                
                                
                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If
                        
                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class
    
    '''<summary>
    '''Represents strongly named DataRow class.
    '''</summary>
    Partial Public Class ProductsRow
        Inherits Global.System.Data.DataRow
        
        Private tableProducts As ProductsDataTable
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableProducts = CType(Me.Table,ProductsDataTable)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property ID() As Integer
            Get
                Return CType(Me(Me.tableProducts.IDColumn),Integer)
            End Get
            Set
                Me(Me.tableProducts.IDColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property ProductName() As String
            Get
                Try 
                    Return CType(Me(Me.tableProducts.ProductNameColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'ProductName' in table 'Products' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableProducts.ProductNameColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property ProductDescription() As String
            Get
                Try 
                    Return CType(Me(Me.tableProducts.ProductDescriptionColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'ProductDescription' in table 'Products' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableProducts.ProductDescriptionColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property ProductPrice() As String
            Get
                Try 
                    Return CType(Me(Me.tableProducts.ProductPriceColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'ProductPrice' in table 'Products' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableProducts.ProductPriceColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property BarcodeImage() As Byte()
            Get
                Try 
                    Return CType(Me(Me.tableProducts.BarcodeImageColumn),Byte())
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'BarcodeImage' in table 'Products' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableProducts.BarcodeImageColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function IsProductNameNull() As Boolean
            Return Me.IsNull(Me.tableProducts.ProductNameColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub SetProductNameNull()
            Me(Me.tableProducts.ProductNameColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function IsProductDescriptionNull() As Boolean
            Return Me.IsNull(Me.tableProducts.ProductDescriptionColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub SetProductDescriptionNull()
            Me(Me.tableProducts.ProductDescriptionColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function IsProductPriceNull() As Boolean
            Return Me.IsNull(Me.tableProducts.ProductPriceColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub SetProductPriceNull()
            Me(Me.tableProducts.ProductPriceColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function IsBarcodeImageNull() As Boolean
            Return Me.IsNull(Me.tableProducts.BarcodeImageColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub SetBarcodeImageNull()
            Me(Me.tableProducts.BarcodeImageColumn) = Global.System.Convert.DBNull
        End Sub
    End Class
    
    '''<summary>
    '''Row event argument class
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Class ProductsRowChangeEvent
        Inherits Global.System.EventArgs
        
        Private eventRow As ProductsRow
        
        Private eventAction As Global.System.Data.DataRowAction
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub New(ByVal row As ProductsRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property Row() As ProductsRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class

Namespace ProductsDataSetTableAdapters
    
    '''<summary>
    '''Represents the connection and commands used to retrieve and save data.
    '''</summary>
    <Global.System.ComponentModel.DesignerCategoryAttribute("code"),  _
     Global.System.ComponentModel.ToolboxItem(true),  _
     Global.System.ComponentModel.DataObjectAttribute(true),  _
     Global.System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner"& _ 
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"),  _
     Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
    Partial Public Class ProductsTableAdapter
        Inherits Global.System.ComponentModel.Component
        
        Private WithEvents _adapter As Global.System.Data.OleDb.OleDbDataAdapter
        
        Private _connection As Global.System.Data.OleDb.OleDbConnection
        
        Private _commandCollection() As Global.System.Data.OleDb.OleDbCommand
        
        Private _clearBeforeFill As Boolean
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub New()
            MyBase.New
            Me.ClearBeforeFill = true
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Private ReadOnly Property Adapter() As Global.System.Data.OleDb.OleDbDataAdapter
            Get
                If (Me._adapter Is Nothing) Then
                    Me.InitAdapter
                End If
                Return Me._adapter
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Friend Property Connection() As Global.System.Data.OleDb.OleDbConnection
            Get
                If (Me._connection Is Nothing) Then
                    Me.InitConnection
                End If
                Return Me._connection
            End Get
            Set
                Me._connection = value
                If (Not (Me.Adapter.InsertCommand) Is Nothing) Then
                    Me.Adapter.InsertCommand.Connection = value
                End If
                If (Not (Me.Adapter.DeleteCommand) Is Nothing) Then
                    Me.Adapter.DeleteCommand.Connection = value
                End If
                If (Not (Me.Adapter.UpdateCommand) Is Nothing) Then
                    Me.Adapter.UpdateCommand.Connection = value
                End If
                Dim i As Integer = 0
                Do While (i < Me.CommandCollection.Length)
                    If (Not (Me.CommandCollection(i)) Is Nothing) Then
                        CType(Me.CommandCollection(i),Global.System.Data.OleDb.OleDbCommand).Connection = value
                    End If
                    i = (i + 1)
                Loop
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected ReadOnly Property CommandCollection() As Global.System.Data.OleDb.OleDbCommand()
            Get
                If (Me._commandCollection Is Nothing) Then
                    Me.InitCommandCollection
                End If
                Return Me._commandCollection
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property ClearBeforeFill() As Boolean
            Get
                Return Me._clearBeforeFill
            End Get
            Set
                Me._clearBeforeFill = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Private Sub InitAdapter()
            Me._adapter = New Global.System.Data.OleDb.OleDbDataAdapter()
            Dim tableMapping As Global.System.Data.Common.DataTableMapping = New Global.System.Data.Common.DataTableMapping()
            tableMapping.SourceTable = "Table"
            tableMapping.DataSetTable = "Products"
            tableMapping.ColumnMappings.Add("ID", "ID")
            tableMapping.ColumnMappings.Add("ProductName", "ProductName")
            tableMapping.ColumnMappings.Add("ProductDescription", "ProductDescription")
            tableMapping.ColumnMappings.Add("ProductPrice", "ProductPrice")
            Me._adapter.TableMappings.Add(tableMapping)
            Me._adapter.DeleteCommand = New Global.System.Data.OleDb.OleDbCommand()
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "DELETE FROM `Products` WHERE ((`ID` = ?) AND ((? = 1 AND `ProductName` IS NULL) O"& _ 
                "R (`ProductName` = ?)) AND ((? = 1 AND `ProductDescription` IS NULL) OR (`Produc"& _ 
                "tDescription` = ?)) AND ((? = 1 AND `ProductPrice` IS NULL) OR (`ProductPrice` ="& _ 
                " ?)))"
            Me._adapter.DeleteCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_ID", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CType(0,Byte), CType(0,Byte), "ID", Global.System.Data.DataRowVersion.Original, false, Nothing))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("IsNull_ProductName", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CType(0,Byte), CType(0,Byte), "ProductName", Global.System.Data.DataRowVersion.Original, true, Nothing))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_ProductName", Global.System.Data.OleDb.OleDbType.VarWChar, 0, Global.System.Data.ParameterDirection.Input, CType(0,Byte), CType(0,Byte), "ProductName", Global.System.Data.DataRowVersion.Original, false, Nothing))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("IsNull_ProductDescription", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CType(0,Byte), CType(0,Byte), "ProductDescription", Global.System.Data.DataRowVersion.Original, true, Nothing))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_ProductDescription", Global.System.Data.OleDb.OleDbType.VarWChar, 0, Global.System.Data.ParameterDirection.Input, CType(0,Byte), CType(0,Byte), "ProductDescription", Global.System.Data.DataRowVersion.Original, false, Nothing))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("IsNull_ProductPrice", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CType(0,Byte), CType(0,Byte), "ProductPrice", Global.System.Data.DataRowVersion.Original, true, Nothing))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_ProductPrice", Global.System.Data.OleDb.OleDbType.VarWChar, 0, Global.System.Data.ParameterDirection.Input, CType(0,Byte), CType(0,Byte), "ProductPrice", Global.System.Data.DataRowVersion.Original, false, Nothing))
            Me._adapter.InsertCommand = New Global.System.Data.OleDb.OleDbCommand()
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO `Products` (`ProductName`, `ProductDescription`, `ProductPrice`) VALU"& _ 
                "ES (?, ?, ?)"
            Me._adapter.InsertCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("ProductName", Global.System.Data.OleDb.OleDbType.VarWChar, 0, Global.System.Data.ParameterDirection.Input, CType(0,Byte), CType(0,Byte), "ProductName", Global.System.Data.DataRowVersion.Current, false, Nothing))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("ProductDescription", Global.System.Data.OleDb.OleDbType.VarWChar, 0, Global.System.Data.ParameterDirection.Input, CType(0,Byte), CType(0,Byte), "ProductDescription", Global.System.Data.DataRowVersion.Current, false, Nothing))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("ProductPrice", Global.System.Data.OleDb.OleDbType.VarWChar, 0, Global.System.Data.ParameterDirection.Input, CType(0,Byte), CType(0,Byte), "ProductPrice", Global.System.Data.DataRowVersion.Current, false, Nothing))
            Me._adapter.UpdateCommand = New Global.System.Data.OleDb.OleDbCommand()
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "UPDATE `Products` SET `ProductName` = ?, `ProductDescription` = ?, `ProductPrice`"& _ 
                " = ? WHERE ((`ID` = ?) AND ((? = 1 AND `ProductName` IS NULL) OR (`ProductName` "& _ 
                "= ?)) AND ((? = 1 AND `ProductDescription` IS NULL) OR (`ProductDescription` = ?"& _ 
                ")) AND ((? = 1 AND `ProductPrice` IS NULL) OR (`ProductPrice` = ?)))"
            Me._adapter.UpdateCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("ProductName", Global.System.Data.OleDb.OleDbType.VarWChar, 0, Global.System.Data.ParameterDirection.Input, CType(0,Byte), CType(0,Byte), "ProductName", Global.System.Data.DataRowVersion.Current, false, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("ProductDescription", Global.System.Data.OleDb.OleDbType.VarWChar, 0, Global.System.Data.ParameterDirection.Input, CType(0,Byte), CType(0,Byte), "ProductDescription", Global.System.Data.DataRowVersion.Current, false, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("ProductPrice", Global.System.Data.OleDb.OleDbType.VarWChar, 0, Global.System.Data.ParameterDirection.Input, CType(0,Byte), CType(0,Byte), "ProductPrice", Global.System.Data.DataRowVersion.Current, false, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_ID", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CType(0,Byte), CType(0,Byte), "ID", Global.System.Data.DataRowVersion.Original, false, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("IsNull_ProductName", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CType(0,Byte), CType(0,Byte), "ProductName", Global.System.Data.DataRowVersion.Original, true, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_ProductName", Global.System.Data.OleDb.OleDbType.VarWChar, 0, Global.System.Data.ParameterDirection.Input, CType(0,Byte), CType(0,Byte), "ProductName", Global.System.Data.DataRowVersion.Original, false, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("IsNull_ProductDescription", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CType(0,Byte), CType(0,Byte), "ProductDescription", Global.System.Data.DataRowVersion.Original, true, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_ProductDescription", Global.System.Data.OleDb.OleDbType.VarWChar, 0, Global.System.Data.ParameterDirection.Input, CType(0,Byte), CType(0,Byte), "ProductDescription", Global.System.Data.DataRowVersion.Original, false, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("IsNull_ProductPrice", Global.System.Data.OleDb.OleDbType.[Integer], 0, Global.System.Data.ParameterDirection.Input, CType(0,Byte), CType(0,Byte), "ProductPrice", Global.System.Data.DataRowVersion.Original, true, Nothing))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.OleDb.OleDbParameter("Original_ProductPrice", Global.System.Data.OleDb.OleDbType.VarWChar, 0, Global.System.Data.ParameterDirection.Input, CType(0,Byte), CType(0,Byte), "ProductPrice", Global.System.Data.DataRowVersion.Original, false, Nothing))
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Private Sub InitConnection()
            Me._connection = New Global.System.Data.OleDb.OleDbConnection()
            Me._connection.ConnectionString = Global.BarcodeInCrystalReports.My.MySettings.Default.productsConnectionString
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Private Sub InitCommandCollection()
            Me._commandCollection = New Global.System.Data.OleDb.OleDbCommand(0) {}
            Me._commandCollection(0) = New Global.System.Data.OleDb.OleDbCommand()
            Me._commandCollection(0).Connection = Me.Connection
            Me._commandCollection(0).CommandText = "SELECT ID, ProductName, ProductDescription, ProductPrice FROM Products"
            Me._commandCollection(0).CommandType = Global.System.Data.CommandType.Text
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
         Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),  _
         Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, true)>  _
        Public Overloads Overridable Function Fill(ByVal dataTable As ProductsDataSet.ProductsDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If (Me.ClearBeforeFill = true) Then
                dataTable.Clear
            End If
            Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
            Return returnValue
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
         Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),  _
         Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.[Select], true)>  _
        Public Overloads Overridable Function GetData() As ProductsDataSet.ProductsDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim dataTable As ProductsDataSet.ProductsDataTable = New ProductsDataSet.ProductsDataTable()
            Me.Adapter.Fill(dataTable)
            Return dataTable
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
         Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
        Public Overloads Overridable Function Update(ByVal dataTable As ProductsDataSet.ProductsDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
         Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
        Public Overloads Overridable Function Update(ByVal dataSet As ProductsDataSet) As Integer
            Return Me.Adapter.Update(dataSet, "Products")
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
         Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
        Public Overloads Overridable Function Update(ByVal dataRow As Global.System.Data.DataRow) As Integer
            Return Me.Adapter.Update(New Global.System.Data.DataRow() {dataRow})
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
         Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
        Public Overloads Overridable Function Update(ByVal dataRows() As Global.System.Data.DataRow) As Integer
            Return Me.Adapter.Update(dataRows)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
         Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),  _
         Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overloads Overridable Function Delete(ByVal Original_ID As Integer, ByVal Original_ProductName As String, ByVal Original_ProductDescription As String, ByVal Original_ProductPrice As String) As Integer
            Me.Adapter.DeleteCommand.Parameters(0).Value = CType(Original_ID,Integer)
            If (Original_ProductName Is Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(1).Value = CType(1,Object)
                Me.Adapter.DeleteCommand.Parameters(2).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(1).Value = CType(0,Object)
                Me.Adapter.DeleteCommand.Parameters(2).Value = CType(Original_ProductName,String)
            End If
            If (Original_ProductDescription Is Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(3).Value = CType(1,Object)
                Me.Adapter.DeleteCommand.Parameters(4).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(3).Value = CType(0,Object)
                Me.Adapter.DeleteCommand.Parameters(4).Value = CType(Original_ProductDescription,String)
            End If
            If (Original_ProductPrice Is Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(5).Value = CType(1,Object)
                Me.Adapter.DeleteCommand.Parameters(6).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(5).Value = CType(0,Object)
                Me.Adapter.DeleteCommand.Parameters(6).Value = CType(Original_ProductPrice,String)
            End If
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.DeleteCommand.Connection.State
            If ((Me.Adapter.DeleteCommand.Connection.State And Global.System.Data.ConnectionState.Open)  _
                        <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.DeleteCommand.Connection.Open
            End If
            Try 
                Dim returnValue As Integer = Me.Adapter.DeleteCommand.ExecuteNonQuery
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.DeleteCommand.Connection.Close
                End If
            End Try
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
         Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),  _
         Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Overloads Overridable Function Insert(ByVal ProductName As String, ByVal ProductDescription As String, ByVal ProductPrice As String) As Integer
            If (ProductName Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(0).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(0).Value = CType(ProductName,String)
            End If
            If (ProductDescription Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(1).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(1).Value = CType(ProductDescription,String)
            End If
            If (ProductPrice Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(2).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(2).Value = CType(ProductPrice,String)
            End If
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
            If ((Me.Adapter.InsertCommand.Connection.State And Global.System.Data.ConnectionState.Open)  _
                        <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.InsertCommand.Connection.Open
            End If
            Try 
                Dim returnValue As Integer = Me.Adapter.InsertCommand.ExecuteNonQuery
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.InsertCommand.Connection.Close
                End If
            End Try
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
         Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),  _
         Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Overridable Function Update(ByVal ProductName As String, ByVal ProductDescription As String, ByVal ProductPrice As String, ByVal Original_ID As Integer, ByVal Original_ProductName As String, ByVal Original_ProductDescription As String, ByVal Original_ProductPrice As String) As Integer
            If (ProductName Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(0).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(0).Value = CType(ProductName,String)
            End If
            If (ProductDescription Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(1).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(1).Value = CType(ProductDescription,String)
            End If
            If (ProductPrice Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(2).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(2).Value = CType(ProductPrice,String)
            End If
            Me.Adapter.UpdateCommand.Parameters(3).Value = CType(Original_ID,Integer)
            If (Original_ProductName Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(4).Value = CType(1,Object)
                Me.Adapter.UpdateCommand.Parameters(5).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(4).Value = CType(0,Object)
                Me.Adapter.UpdateCommand.Parameters(5).Value = CType(Original_ProductName,String)
            End If
            If (Original_ProductDescription Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(6).Value = CType(1,Object)
                Me.Adapter.UpdateCommand.Parameters(7).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(6).Value = CType(0,Object)
                Me.Adapter.UpdateCommand.Parameters(7).Value = CType(Original_ProductDescription,String)
            End If
            If (Original_ProductPrice Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(8).Value = CType(1,Object)
                Me.Adapter.UpdateCommand.Parameters(9).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(8).Value = CType(0,Object)
                Me.Adapter.UpdateCommand.Parameters(9).Value = CType(Original_ProductPrice,String)
            End If
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.UpdateCommand.Connection.State
            If ((Me.Adapter.UpdateCommand.Connection.State And Global.System.Data.ConnectionState.Open)  _
                        <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.UpdateCommand.Connection.Open
            End If
            Try 
                Dim returnValue As Integer = Me.Adapter.UpdateCommand.ExecuteNonQuery
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.UpdateCommand.Connection.Close
                End If
            End Try
        End Function
    End Class
End Namespace

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ProductsDataSet.xsc:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<!--<autogenerated>
     This code was generated by a tool.
     Changes to this file may cause incorrect behavior and will be lost if
     the code is regenerated.
</autogenerated>-->
<DataSetUISetting Version="1.00" xmlns="urn:schemas-microsoft-com:xml-msdatasource">
  <TableUISettings />
</DataSetUISetting>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ProductsDataSet.xsd:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<xs:schema id="ProductsDataSet" targetNamespace="http://tempuri.org/ProductsDataSet.xsd" xmlns:mstns="http://tempuri.org/ProductsDataSet.xsd" xmlns="http://tempuri.org/ProductsDataSet.xsd" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:msdata="urn:schemas-microsoft-com:xml-msdata" xmlns:msprop="urn:schemas-microsoft-com:xml-msprop" attributeFormDefault="qualified" elementFormDefault="qualified">
  <xs:annotation>
    <xs:appinfo source="urn:schemas-microsoft-com:xml-msdatasource">
      <DataSource DefaultConnectionIndex="0" FunctionsComponentName="QueriesTableAdapter" Modifier="AutoLayout, AnsiClass, Class, Public" SchemaSerializationMode="IncludeSchema" xmlns="urn:schemas-microsoft-com:xml-msdatasource">
        <Connections>
          <Connection AppSettingsObjectName="MySettings" AppSettingsPropertyName="productsConnectionString" ConnectionStringObject="" IsAppSettingsProperty="true" Modifier="Assembly" Name="productsConnectionString (MySettings)" PropertyReference="ApplicationSettings.CrystalReportsApplication2.My.MySettings.GlobalReference.Default.productsConnectionString" Provider="System.Data.OleDb" />
        </Connections>
        <Tables>
          <TableAdapter BaseClass="System.ComponentModel.Component" DataAccessorModifier="AutoLayout, AnsiClass, Class, Public" DataAccessorName="ProductsTableAdapter" GeneratorDataComponentClassName="ProductsTableAdapter" Name="Products" UserDataComponentName="ProductsTableAdapter">
            <MainSource>
              <DbSource ConnectionRef="productsConnectionString (MySettings)" DbObjectName="Products" DbObjectType="Table" FillMethodModifier="Public" FillMethodName="Fill" GenerateMethods="Both" GenerateShortCommands="true" GeneratorGetMethodName="GetData" GeneratorSourceName="Fill" GetMethodModifier="Public" GetMethodName="GetData" QueryType="Rowset" ScalarCallRetval="System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" UseOptimisticConcurrency="true" UserGetMethodName="GetData" UserSourceName="Fill">
                <DeleteCommand>
                  <DbCommand CommandType="Text" ModifiedByUser="false">
                    <CommandText>DELETE FROM `Products` WHERE ((`ID` = ?) AND ((? = 1 AND `ProductName` IS NULL) OR (`ProductName` = ?)) AND ((? = 1 AND `ProductDescription` IS NULL) OR (`ProductDescription` = ?)) AND ((? = 1 AND `ProductPrice` IS NULL) OR (`ProductPrice` = ?)))</CommandText>
                    <Parameters>
                      <Parameter AllowDbNull="false" AutogeneratedName="" DataSourceName="" DbType="Int32" Direction="Input" ParameterName="Original_ID" Precision="0" ProviderType="Integer" Scale="0" Size="0" SourceColumn="ID" SourceColumnNullMapping="false" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="Int32" Direction="Input" ParameterName="IsNull_ProductName" Precision="0" ProviderType="Integer" Scale="0" Size="0" SourceColumn="ProductName" SourceColumnNullMapping="true" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="Original_ProductName" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductName" SourceColumnNullMapping="false" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="Int32" Direction="Input" ParameterName="IsNull_ProductDescription" Precision="0" ProviderType="Integer" Scale="0" Size="0" SourceColumn="ProductDescription" SourceColumnNullMapping="true" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="Original_ProductDescription" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductDescription" SourceColumnNullMapping="false" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="Int32" Direction="Input" ParameterName="IsNull_ProductPrice" Precision="0" ProviderType="Integer" Scale="0" Size="0" SourceColumn="ProductPrice" SourceColumnNullMapping="true" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="Original_ProductPrice" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductPrice" SourceColumnNullMapping="false" SourceVersion="Original" />
                    </Parameters>
                  </DbCommand>
                </DeleteCommand>
                <InsertCommand>
                  <DbCommand CommandType="Text" ModifiedByUser="false">
                    <CommandText>INSERT INTO `Products` (`ProductName`, `ProductDescription`, `ProductPrice`) VALUES (?, ?, ?)</CommandText>
                    <Parameters>
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="ProductName" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductName" SourceColumnNullMapping="false" SourceVersion="Current" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="ProductDescription" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductDescription" SourceColumnNullMapping="false" SourceVersion="Current" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="ProductPrice" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductPrice" SourceColumnNullMapping="false" SourceVersion="Current" />
                    </Parameters>
                  </DbCommand>
                </InsertCommand>
                <SelectCommand>
                  <DbCommand CommandType="Text" ModifiedByUser="false">
                    <CommandText>SELECT ID, ProductName, ProductDescription, ProductPrice FROM Products</CommandText>
                    <Parameters />
                  </DbCommand>
                </SelectCommand>
                <UpdateCommand>
                  <DbCommand CommandType="Text" ModifiedByUser="false">
                    <CommandText>UPDATE `Products` SET `ProductName` = ?, `ProductDescription` = ?, `ProductPrice` = ? WHERE ((`ID` = ?) AND ((? = 1 AND `ProductName` IS NULL) OR (`ProductName` = ?)) AND ((? = 1 AND `ProductDescription` IS NULL) OR (`ProductDescription` = ?)) AND ((? = 1 AND `ProductPrice` IS NULL) OR (`ProductPrice` = ?)))</CommandText>
                    <Parameters>
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="ProductName" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductName" SourceColumnNullMapping="false" SourceVersion="Current" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="ProductDescription" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductDescription" SourceColumnNullMapping="false" SourceVersion="Current" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="ProductPrice" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductPrice" SourceColumnNullMapping="false" SourceVersion="Current" />
                      <Parameter AllowDbNull="false" AutogeneratedName="" DataSourceName="" DbType="Int32" Direction="Input" ParameterName="Original_ID" Precision="0" ProviderType="Integer" Scale="0" Size="0" SourceColumn="ID" SourceColumnNullMapping="false" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="Int32" Direction="Input" ParameterName="IsNull_ProductName" Precision="0" ProviderType="Integer" Scale="0" Size="0" SourceColumn="ProductName" SourceColumnNullMapping="true" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="Original_ProductName" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductName" SourceColumnNullMapping="false" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="Int32" Direction="Input" ParameterName="IsNull_ProductDescription" Precision="0" ProviderType="Integer" Scale="0" Size="0" SourceColumn="ProductDescription" SourceColumnNullMapping="true" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="Original_ProductDescription" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductDescription" SourceColumnNullMapping="false" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="Int32" Direction="Input" ParameterName="IsNull_ProductPrice" Precision="0" ProviderType="Integer" Scale="0" Size="0" SourceColumn="ProductPrice" SourceColumnNullMapping="true" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="Original_ProductPrice" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductPrice" SourceColumnNullMapping="false" SourceVersion="Original" />
                    </Parameters>
                  </DbCommand>
                </UpdateCommand>
              </DbSource>
            </MainSource>
            <Mappings>
              <Mapping SourceColumn="ID" DataSetColumn="ID" />
              <Mapping SourceColumn="ProductName" DataSetColumn="ProductName" />
              <Mapping SourceColumn="ProductDescription" DataSetColumn="ProductDescription" />
              <Mapping SourceColumn="ProductPrice" DataSetColumn="ProductPrice" />
            </Mappings>
            <Sources />
          </TableAdapter>
        </Tables>
        <Sources />
      </DataSource>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name="ProductsDataSet" msdata:IsDataSet="true" msdata:UseCurrentLocale="true" msprop:EnableTableAdapterManager="True" msprop:Generator_DataSetName="ProductsDataSet" msprop:Generator_UserDSName="ProductsDataSet">
    <xs:complexType>
      <xs:choice minOccurs="0" maxOccurs="unbounded">
        <xs:element name="Products" msprop:Generator_TableClassName="ProductsDataTable" msprop:Generator_TableVarName="tableProducts" msprop:Generator_RowChangedName="ProductsRowChanged" msprop:Generator_TablePropName="Products" msprop:Generator_RowDeletingName="ProductsRowDeleting" msprop:Generator_RowChangingName="ProductsRowChanging" msprop:Generator_RowEvHandlerName="ProductsRowChangeEventHandler" msprop:Generator_RowDeletedName="ProductsRowDeleted" msprop:Generator_RowClassName="ProductsRow" msprop:Generator_UserTableName="Products" msprop:Generator_RowEvArgName="ProductsRowChangeEvent">
          <xs:complexType>
            <xs:sequence>
              <xs:element name="ID" msdata:AutoIncrement="true" msdata:AutoIncrementSeed="-1" msdata:AutoIncrementStep="-1" msprop:Generator_ColumnVarNameInTable="columnID" msprop:Generator_ColumnPropNameInRow="ID" msprop:Generator_ColumnPropNameInTable="IDColumn" msprop:Generator_UserColumnName="ID" type="xs:int" />
              <xs:element name="ProductName" msprop:Generator_ColumnVarNameInTable="columnProductName" msprop:Generator_ColumnPropNameInRow="ProductName" msprop:Generator_ColumnPropNameInTable="ProductNameColumn" msprop:Generator_UserColumnName="ProductName" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="255" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="ProductDescription" msprop:Generator_ColumnVarNameInTable="columnProductDescription" msprop:Generator_ColumnPropNameInRow="ProductDescription" msprop:Generator_ColumnPropNameInTable="ProductDescriptionColumn" msprop:Generator_UserColumnName="ProductDescription" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="255" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="ProductPrice" msprop:Generator_ColumnVarNameInTable="columnProductPrice" msprop:Generator_ColumnPropNameInRow="ProductPrice" msprop:Generator_ColumnPropNameInTable="ProductPriceColumn" msprop:Generator_UserColumnName="ProductPrice" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="255" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="BarcodeImage" msprop:Generator_ColumnVarNameInTable="columnBarcodeImage" msprop:Generator_ColumnPropNameInRow="BarcodeImage" msprop:Generator_ColumnPropNameInTable="BarcodeImageColumn" msprop:Generator_UserColumnName="BarcodeImage" type="xs:base64Binary" minOccurs="0" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:choice>
    </xs:complexType>
    <xs:unique name="Constraint1" msdata:PrimaryKey="true">
      <xs:selector xpath=".//mstns:Products" />
      <xs:field xpath="mstns:ID" />
    </xs:unique>
  </xs:element>
</xs:schema>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ProductsDataSet.xss:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<!--<autogenerated>
     This code was generated by a tool to store the dataset designer's layout information.
     Changes to this file may cause incorrect behavior and will be lost if
     the code is regenerated.
</autogenerated>-->
<DiagramLayout xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" ex:showrelationlabel="False" ViewPortX="0" ViewPortY="0" xmlns:ex="urn:schemas-microsoft-com:xml-msdatasource-layout-extended" xmlns="urn:schemas-microsoft-com:xml-msdatasource-layout">
  <Shapes>
    <Shape ID="DesignTable:Products" ZOrder="1" X="70" Y="70" Height="172" Width="196" AdapterExpanded="true" DataTableExpanded="true" OldAdapterHeight="0" OldDataTableHeight="0" SplitterPosition="121" />
  </Shapes>
  <Connectors />
</DiagramLayout>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****app.config:**
    
```
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <configSections>
    </configSections>
    <connectionStrings>
        <add name="BarcodeInCrystalReports.My.MySettings.productsConnectionString"
            connectionString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\products.mdb;Persist Security Info=True"
            providerName="System.Data.OleDb" />
    </connectionStrings>
    <system.diagnostics>
        <sources>
            <!-- This section defines the logging configuration for My.Application.Log -->
            <source name="DefaultSource" switchName="DefaultSwitch">
                <listeners>
                    <add name="FileLog"/>
                    <!-- Uncomment the below section to write to the Application Event Log -->
                    <!--<add name="EventLog"/>-->
                </listeners>
            </source>
        </sources>
        <switches>
            <add name="DefaultSwitch" value="Information" />
        </switches>
        <sharedListeners>
            <add name="FileLog"
                 type="Microsoft.VisualBasic.Logging.FileLogTraceListener, Microsoft.VisualBasic, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL"
                 initializeData="FileLogWriter"/>
            <!-- Uncomment the below section and replace APPLICATION_NAME with the name of your application to write to the Application Event Log -->
            <!--<add name="EventLog" type="System.Diagnostics.EventLogTraceListener" initializeData="APPLICATION_NAME"/> -->
        </sharedListeners>
    </system.diagnostics>
    <startup useLegacyV2RuntimeActivationPolicy="true">
      <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.0"/>
    </startup>
</configuration>

```

<!-- code block end -->