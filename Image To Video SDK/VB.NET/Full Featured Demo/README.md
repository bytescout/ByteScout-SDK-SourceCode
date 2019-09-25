## full featured demo in VB.NET with ByteScout Image To Video SDK

### How to code full featured demo in VB.NET: How-To tutorial

Today you are going to learn how to full featured demo in VB.NET. ByteScout Image To Video SDK was made to help with full featured demo in VB.NET. ByteScout Image To Video SDK is the SDK that is designed to generate video slideshow with 100+ 2d and 3D transition effects. Can generate WMV, AVI, WEBM video file with adjustable quality, framerate, output video size.

You will save a lot of time on writing and testing code as you may just take the code below and use it in your application. VB.NET sample code is all you need: copy and paste the code to your VB.NET application's code editor, add a reference to ByteScout Image To Video SDK (if you haven't added yet) and you are ready to go! Enjoy writing a code with ready-to-use sample VB.NET codes to add full featured demo functions using ByteScout Image To Video SDK in VB.NET.

Free trial version of ByteScout Image To Video SDK is available on our website. Get it to try other samples for VB.NET.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Image%20To%20Video%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Image%20To%20Video%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=FzPgeGFL8YA](https://www.youtube.com/watch?v=FzPgeGFL8YA)




<!-- code block begin -->

##### ****ImageToVideoDemo.VS2005.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{4DDBDEFE-C1FE-4D96-8A18-2F751E825829}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ImageToVideoDemo</RootNamespace>
    <AssemblyName>ImageToVideoDemo</AssemblyName>
    <ApplicationIcon>app.ico</ApplicationIcon>
    <StartupObject>ImageToVideoDemo.Program</StartupObject>
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
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
  </ItemGroup>
  <ItemGroup>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="MainForm.Designer.vb">
      <DependentUpon>MainForm.vb</DependentUpon>
    </Compile>
    <Compile Include="MainForm.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
    <Compile Include="Properties\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
      <DesignTime>True</DesignTime>
    </Compile>
    <Compile Include="Properties\Settings.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
    <Compile Include="SlideOptions.vb" />
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="MainForm.resx">
      <SubType>Designer</SubType>
      <DependentUpon>MainForm.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
    <None Include="Resources\add.png" />
    <None Include="Resources\arrow_down.png" />
    <None Include="Resources\arrow_up.png" />
    <None Include="Resources\bin_closed.png" />
    <None Include="Resources\delete.png" />
    <None Include="Resources\film.png" />
    <None Include="Resources\stop.png" />
    <None Include="Resources\wrench.png" />
  </ItemGroup>
  <ItemGroup>
    <COMReference Include="BytescoutImageToVideo">
      <Guid>{5212739C-A95B-4CDA-B116-F540A549B648}</Guid>
      <VersionMajor>1</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>tlbimp</WrapperTool>
      <Isolated>False</Isolated>
      <EmbedInteropTypes>True</EmbedInteropTypes>
    </COMReference>
    <COMReference Include="stdole">
      <Guid>{00020430-0000-0000-C000-000000000046}</Guid>
      <VersionMajor>2</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
  </ItemGroup>
  <ItemGroup>
    <Content Include="app.ico" />
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ImageToVideoDemo.VS2008.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build" ToolsVersion="3.5">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.21022</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{4DDBDEFE-C1FE-4D96-8A18-2F751E825829}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ImageToVideoDemo</RootNamespace>
    <AssemblyName>ImageToVideoDemo</AssemblyName>
    <ApplicationIcon>app.ico</ApplicationIcon>
    <StartupObject>ImageToVideoDemo.Program</StartupObject>
    <OldToolsVersion>2.0</OldToolsVersion>
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
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
  </ItemGroup>
  <ItemGroup>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="MainForm.Designer.vb">
      <DependentUpon>MainForm.vb</DependentUpon>
    </Compile>
    <Compile Include="MainForm.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
    <Compile Include="Properties\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
      <DesignTime>True</DesignTime>
    </Compile>
    <Compile Include="Properties\Settings.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
    <Compile Include="SlideOptions.vb" />
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="MainForm.resx">
      <SubType>Designer</SubType>
      <DependentUpon>MainForm.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
    <None Include="Resources\add.png" />
    <None Include="Resources\arrow_down.png" />
    <None Include="Resources\arrow_up.png" />
    <None Include="Resources\bin_closed.png" />
    <None Include="Resources\delete.png" />
    <None Include="Resources\film.png" />
    <None Include="Resources\stop.png" />
    <None Include="Resources\wrench.png" />
  </ItemGroup>
  <ItemGroup>
    <COMReference Include="BytescoutImageToVideo">
      <Guid>{5212739C-A95B-4CDA-B116-F540A549B648}</Guid>
      <VersionMajor>1</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>tlbimp</WrapperTool>
      <Isolated>False</Isolated>
      <EmbedInteropTypes>True</EmbedInteropTypes>
    </COMReference>
    <COMReference Include="stdole">
      <Guid>{00020430-0000-0000-C000-000000000046}</Guid>
      <VersionMajor>2</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
  </ItemGroup>
  <ItemGroup>
    <Content Include="app.ico" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ImageToVideoDemo.VS2010.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{4DDBDEFE-C1FE-4D96-8A18-2F751E825829}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ImageToVideoDemo</RootNamespace>
    <AssemblyName>ImageToVideoDemo</AssemblyName>
    <ApplicationIcon>app.ico</ApplicationIcon>
    <StartupObject>ImageToVideoDemo.Program</StartupObject>
    <OldToolsVersion>3.5</OldToolsVersion>
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
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
  </ItemGroup>
  <ItemGroup>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="MainForm.Designer.vb">
      <DependentUpon>MainForm.vb</DependentUpon>
    </Compile>
    <Compile Include="MainForm.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
    <Compile Include="Properties\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
      <DesignTime>True</DesignTime>
    </Compile>
    <Compile Include="Properties\Settings.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
    <Compile Include="SlideOptions.vb" />
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="MainForm.resx">
      <SubType>Designer</SubType>
      <DependentUpon>MainForm.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
    <None Include="Resources\add.png" />
    <None Include="Resources\arrow_down.png" />
    <None Include="Resources\arrow_up.png" />
    <None Include="Resources\bin_closed.png" />
    <None Include="Resources\delete.png" />
    <None Include="Resources\film.png" />
    <None Include="Resources\stop.png" />
    <None Include="Resources\wrench.png" />
  </ItemGroup>
  <ItemGroup>
    <COMReference Include="BytescoutImageToVideo">
      <Guid>{5212739C-A95B-4CDA-B116-F540A549B648}</Guid>
      <VersionMajor>1</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>tlbimp</WrapperTool>
      <Isolated>False</Isolated>
      <EmbedInteropTypes>True</EmbedInteropTypes>
    </COMReference>
    <COMReference Include="stdole">
      <Guid>{00020430-0000-0000-C000-000000000046}</Guid>
      <VersionMajor>2</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
  </ItemGroup>
  <ItemGroup>
    <Content Include="app.ico" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****MainForm.Designer.vb:**
    
```
Partial Class MainForm
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.lvInputFiles = New System.Windows.Forms.ListView()
		Me.columnHeader1 = New System.Windows.Forms.ColumnHeader()
		Me.columnHeader2 = New System.Windows.Forms.ColumnHeader()
		Me.btnMoveDown = New System.Windows.Forms.Button()
		Me.btnMoveUp = New System.Windows.Forms.Button()
		Me.btnRemoveAll = New System.Windows.Forms.Button()
		Me.btnRemove = New System.Windows.Forms.Button()
		Me.btnAddFolder = New System.Windows.Forms.Button()
		Me.btnAddImage = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.tbMovieWidth = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.tbMovieHeight = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.cmbVisualEffect = New System.Windows.Forms.ComboBox()
		Me.label7 = New System.Windows.Forms.Label()
		Me.cmbSlideRotation = New System.Windows.Forms.ComboBox()
		Me.label8 = New System.Windows.Forms.Label()
		Me.groupBox4 = New System.Windows.Forms.GroupBox()
		Me.nudTransitionEffectAfterDuration = New System.Windows.Forms.NumericUpDown()
		Me.label14 = New System.Windows.Forms.Label()
		Me.nudTransitionEffectBeforeDuration = New System.Windows.Forms.NumericUpDown()
		Me.label12 = New System.Windows.Forms.Label()
		Me.label15 = New System.Windows.Forms.Label()
		Me.cmbTransitionEffectAfter = New System.Windows.Forms.ComboBox()
		Me.label13 = New System.Windows.Forms.Label()
		Me.label11 = New System.Windows.Forms.Label()
		Me.cmbTransitionEffectBefore = New System.Windows.Forms.ComboBox()
		Me.label10 = New System.Windows.Forms.Label()
		Me.label16 = New System.Windows.Forms.Label()
		Me.tbBackgroundImage = New System.Windows.Forms.TextBox()
		Me.label17 = New System.Windows.Forms.Label()
		Me.btnBackgroundImageBrowse = New System.Windows.Forms.Button()
		Me.btnAudioTrackBrowse = New System.Windows.Forms.Button()
		Me.tbAudioTrack = New System.Windows.Forms.TextBox()
		Me.label18 = New System.Windows.Forms.Label()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.nudVisualEffectDuration = New System.Windows.Forms.NumericUpDown()
		Me.label20 = New System.Windows.Forms.Label()
		Me.cmbVisualEffectTransition = New System.Windows.Forms.ComboBox()
		Me.label21 = New System.Windows.Forms.Label()
		Me.label19 = New System.Windows.Forms.Label()
		Me.tabControl1 = New System.Windows.Forms.TabControl()
		Me.tabPage1 = New System.Windows.Forms.TabPage()
		Me.nudSlideDuration = New System.Windows.Forms.NumericUpDown()
		Me.tabPage2 = New System.Windows.Forms.TabPage()
		Me.groupBox3 = New System.Windows.Forms.GroupBox()
		Me.label22 = New System.Windows.Forms.Label()
		Me.tabControl2 = New System.Windows.Forms.TabControl()
		Me.tabPageWmv = New System.Windows.Forms.TabPage()
		Me.label28 = New System.Windows.Forms.Label()
		Me.label9 = New System.Windows.Forms.Label()
		Me.tbBitrate = New System.Windows.Forms.TextBox()
		Me.cmbWmvAudioFormats = New System.Windows.Forms.ComboBox()
		Me.label23 = New System.Windows.Forms.Label()
		Me.cmbWmvAudioCodecs = New System.Windows.Forms.ComboBox()
		Me.label24 = New System.Windows.Forms.Label()
		Me.cmbWmvVideoCodecs = New System.Windows.Forms.ComboBox()
		Me.label25 = New System.Windows.Forms.Label()
		Me.tabPageAvi = New System.Windows.Forms.TabPage()
		Me.cmbAviAudioCodecs = New System.Windows.Forms.ComboBox()
		Me.label26 = New System.Windows.Forms.Label()
		Me.cmbAviVideoCodecs = New System.Windows.Forms.ComboBox()
		Me.label27 = New System.Windows.Forms.Label()
		Me.btnVideoCodecProps = New System.Windows.Forms.Button()
		Me.tbFPS = New System.Windows.Forms.TextBox()
		Me.btnBackgroundColor = New System.Windows.Forms.Button()
		Me.cbKeepAspectRatio = New System.Windows.Forms.CheckBox()
		Me.cbAutoFitImages = New System.Windows.Forms.CheckBox()
		Me.cbPlayGeneratedFile = New System.Windows.Forms.CheckBox()
		Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.toolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
		Me.btnCreateMovie = New System.Windows.Forms.Button()
		Me.cbTransitionEffectBeforeRandom = New System.Windows.Forms.CheckBox()
		Me.cbTransitionEffectAfterRandom = New System.Windows.Forms.CheckBox()
		Me.linkVisitSDKHome = New System.Windows.Forms.LinkLabel()
		Me.groupBox1.SuspendLayout()
		Me.groupBox4.SuspendLayout()
		DirectCast(Me.nudTransitionEffectAfterDuration, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.nudTransitionEffectBeforeDuration, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.groupBox2.SuspendLayout()
		DirectCast(Me.nudVisualEffectDuration, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tabControl1.SuspendLayout()
		Me.tabPage1.SuspendLayout()
		DirectCast(Me.nudSlideDuration, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tabPage2.SuspendLayout()
		Me.groupBox3.SuspendLayout()
		Me.tabControl2.SuspendLayout()
		Me.tabPageWmv.SuspendLayout()
		Me.tabPageAvi.SuspendLayout()
		Me.statusStrip1.SuspendLayout()
		Me.SuspendLayout()
		' 
		' groupBox1
		' 
		Me.groupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.groupBox1.Controls.Add(Me.lvInputFiles)
		Me.groupBox1.Controls.Add(Me.btnMoveDown)
		Me.groupBox1.Controls.Add(Me.btnMoveUp)
		Me.groupBox1.Controls.Add(Me.btnRemoveAll)
		Me.groupBox1.Controls.Add(Me.btnRemove)
		Me.groupBox1.Controls.Add(Me.btnAddFolder)
		Me.groupBox1.Controls.Add(Me.btnAddImage)
		Me.groupBox1.Location = New System.Drawing.Point(12, 12)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(285, 424)
		Me.groupBox1.TabIndex = 0
		Me.groupBox1.TabStop = False
		Me.groupBox1.Text = "Input Images"
		' 
		' lvInputFiles
		' 
		Me.lvInputFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvInputFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2})
		Me.lvInputFiles.FullRowSelect = True
		Me.lvInputFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lvInputFiles.HideSelection = False
		Me.lvInputFiles.Location = New System.Drawing.Point(6, 19)
		Me.lvInputFiles.MultiSelect = False
		Me.lvInputFiles.Name = "lvInputFiles"
		Me.lvInputFiles.Size = New System.Drawing.Size(172, 398)
		Me.lvInputFiles.TabIndex = 7
		Me.lvInputFiles.UseCompatibleStateImageBehavior = False
		Me.lvInputFiles.View = System.Windows.Forms.View.Details
		AddHandler Me.lvInputFiles.SelectedIndexChanged, New System.EventHandler(AddressOf Me.lvInputFiles_SelectedIndexChanged)
		' 
		' columnHeader1
		' 
		Me.columnHeader1.Text = "#"
		Me.columnHeader1.Width = 30
		' 
		' columnHeader2
		' 
		Me.columnHeader2.Text = "File"
		Me.columnHeader2.Width = 120
		' 
		' btnMoveDown
		' 
		Me.btnMoveDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnMoveDown.Image = My.Resources.arrow_down
		Me.btnMoveDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnMoveDown.Location = New System.Drawing.Point(184, 119)
		Me.btnMoveDown.Name = "btnMoveDown"
		Me.btnMoveDown.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
		Me.btnMoveDown.Size = New System.Drawing.Size(95, 24)
		Me.btnMoveDown.TabIndex = 4
		Me.btnMoveDown.Text = "Move Down"
		Me.btnMoveDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnMoveDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.btnMoveDown.UseVisualStyleBackColor = True
		AddHandler Me.btnMoveDown.Click, New System.EventHandler(AddressOf Me.btnMoveDown_Click)
		' 
		' btnMoveUp
		' 
		Me.btnMoveUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnMoveUp.Image = My.Resources.arrow_up
		Me.btnMoveUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnMoveUp.Location = New System.Drawing.Point(184, 89)
		Me.btnMoveUp.Name = "btnMoveUp"
		Me.btnMoveUp.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
		Me.btnMoveUp.Size = New System.Drawing.Size(95, 24)
		Me.btnMoveUp.TabIndex = 3
		Me.btnMoveUp.Text = "Move Up"
		Me.btnMoveUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnMoveUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.btnMoveUp.UseVisualStyleBackColor = True
		AddHandler Me.btnMoveUp.Click, New System.EventHandler(AddressOf Me.btnMoveUp_Click)
		' 
		' btnRemoveAll
		' 
		Me.btnRemoveAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnRemoveAll.Image = My.Resources.bin_closed
		Me.btnRemoveAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnRemoveAll.Location = New System.Drawing.Point(184, 190)
		Me.btnRemoveAll.Name = "btnRemoveAll"
		Me.btnRemoveAll.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
		Me.btnRemoveAll.Size = New System.Drawing.Size(95, 24)
		Me.btnRemoveAll.TabIndex = 6
		Me.btnRemoveAll.Text = "Remove All"
		Me.btnRemoveAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnRemoveAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.btnRemoveAll.UseVisualStyleBackColor = True
		AddHandler Me.btnRemoveAll.Click, New System.EventHandler(AddressOf Me.btnRemoveAll_Click)
		' 
		' btnRemove
		' 
		Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnRemove.Image = My.Resources.delete
		Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnRemove.Location = New System.Drawing.Point(184, 160)
		Me.btnRemove.Name = "btnRemove"
		Me.btnRemove.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
		Me.btnRemove.Size = New System.Drawing.Size(95, 24)
		Me.btnRemove.TabIndex = 5
		Me.btnRemove.Text = "Remove"
		Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.btnRemove.UseVisualStyleBackColor = True
		AddHandler Me.btnRemove.Click, New System.EventHandler(AddressOf Me.btnRemove_Click)
		' 
		' btnAddFolder
		' 
		Me.btnAddFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnAddFolder.Image = My.Resources.add
		Me.btnAddFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnAddFolder.Location = New System.Drawing.Point(184, 49)
		Me.btnAddFolder.Name = "btnAddFolder"
		Me.btnAddFolder.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
		Me.btnAddFolder.Size = New System.Drawing.Size(95, 24)
		Me.btnAddFolder.TabIndex = 2
		Me.btnAddFolder.Text = "Add Folder"
		Me.btnAddFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnAddFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.btnAddFolder.UseVisualStyleBackColor = True
		AddHandler Me.btnAddFolder.Click, New System.EventHandler(AddressOf Me.btnAddFolder_Click)
		' 
		' btnAddImage
		' 
		Me.btnAddImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnAddImage.Image = My.Resources.add
		Me.btnAddImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnAddImage.Location = New System.Drawing.Point(184, 19)
		Me.btnAddImage.Name = "btnAddImage"
		Me.btnAddImage.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
		Me.btnAddImage.Size = New System.Drawing.Size(95, 24)
		Me.btnAddImage.TabIndex = 1
		Me.btnAddImage.Text = "Add Image"
		Me.btnAddImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnAddImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.btnAddImage.UseVisualStyleBackColor = True
		AddHandler Me.btnAddImage.Click, New System.EventHandler(AddressOf Me.btnAddImage_Click)
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(6, 14)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(47, 13)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Duration"
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(145, 14)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(20, 13)
		Me.label2.TabIndex = 2
		Me.label2.Text = "ms"
		' 
		' tbMovieWidth
		' 
		Me.tbMovieWidth.Location = New System.Drawing.Point(109, 108)
		Me.tbMovieWidth.Name = "tbMovieWidth"
		Me.tbMovieWidth.Size = New System.Drawing.Size(40, 20)
		Me.tbMovieWidth.TabIndex = 5
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Location = New System.Drawing.Point(6, 111)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(67, 13)
		Me.label3.TabIndex = 3
		Me.label3.Text = "Movie Width"
		' 
		' tbMovieHeight
		' 
		Me.tbMovieHeight.Location = New System.Drawing.Point(109, 134)
		Me.tbMovieHeight.Name = "tbMovieHeight"
		Me.tbMovieHeight.Size = New System.Drawing.Size(40, 20)
		Me.tbMovieHeight.TabIndex = 6
		' 
		' label4
		' 
		Me.label4.AutoSize = True
		Me.label4.Location = New System.Drawing.Point(6, 137)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(70, 13)
		Me.label4.TabIndex = 5
		Me.label4.Text = "Movie Height"
		' 
		' label5
		' 
		Me.label5.AutoSize = True
		Me.label5.Location = New System.Drawing.Point(155, 111)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(18, 13)
		Me.label5.TabIndex = 3
		Me.label5.Text = "px"
		' 
		' label6
		' 
		Me.label6.AutoSize = True
		Me.label6.Location = New System.Drawing.Point(155, 137)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(18, 13)
		Me.label6.TabIndex = 7
		Me.label6.Text = "px"
		' 
		' cmbVisualEffect
		' 
		Me.cmbVisualEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbVisualEffect.FormattingEnabled = True
		Me.cmbVisualEffect.Items.AddRange(New Object() {"None", "Grayscale", "Sepia"})
		Me.cmbVisualEffect.Location = New System.Drawing.Point(78, 19)
		Me.cmbVisualEffect.Name = "cmbVisualEffect"
		Me.cmbVisualEffect.Size = New System.Drawing.Size(180, 21)
		Me.cmbVisualEffect.TabIndex = 0
		' 
		' label7
		' 
		Me.label7.AutoSize = True
		Me.label7.Location = New System.Drawing.Point(6, 22)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(35, 13)
		Me.label7.TabIndex = 4
		Me.label7.Text = "Effect"
		' 
		' cmbSlideRotation
		' 
		Me.cmbSlideRotation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbSlideRotation.FormattingEnabled = True
		Me.cmbSlideRotation.Items.AddRange(New Object() {"0", "90", "180", "270"})
		Me.cmbSlideRotation.Location = New System.Drawing.Point(84, 37)
		Me.cmbSlideRotation.Name = "cmbSlideRotation"
		Me.cmbSlideRotation.Size = New System.Drawing.Size(55, 21)
		Me.cmbSlideRotation.TabIndex = 1
		' 
		' label8
		' 
		Me.label8.AutoSize = True
		Me.label8.Location = New System.Drawing.Point(6, 40)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(47, 13)
		Me.label8.TabIndex = 6
		Me.label8.Text = "Rotation"
		' 
		' groupBox4
		' 
		Me.groupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.groupBox4.Controls.Add(Me.cbTransitionEffectAfterRandom)
		Me.groupBox4.Controls.Add(Me.cbTransitionEffectBeforeRandom)
		Me.groupBox4.Controls.Add(Me.nudTransitionEffectAfterDuration)
		Me.groupBox4.Controls.Add(Me.label14)
		Me.groupBox4.Controls.Add(Me.nudTransitionEffectBeforeDuration)
		Me.groupBox4.Controls.Add(Me.label12)
		Me.groupBox4.Controls.Add(Me.label15)
		Me.groupBox4.Controls.Add(Me.cmbTransitionEffectAfter)
		Me.groupBox4.Controls.Add(Me.label13)
		Me.groupBox4.Controls.Add(Me.label11)
		Me.groupBox4.Controls.Add(Me.cmbTransitionEffectBefore)
		Me.groupBox4.Controls.Add(Me.label10)
		Me.groupBox4.Location = New System.Drawing.Point(6, 172)
		Me.groupBox4.Name = "groupBox4"
		Me.groupBox4.Size = New System.Drawing.Size(439, 132)
		Me.groupBox4.TabIndex = 3
		Me.groupBox4.TabStop = False
		Me.groupBox4.Text = "Transition Effects"
		' 
		' nudTransitionEffectAfterDuration
		' 
		Me.nudTransitionEffectAfterDuration.Increment = New Decimal(New Integer() {100, 0, 0, 0})
		Me.nudTransitionEffectAfterDuration.Location = New System.Drawing.Point(78, 100)
		Me.nudTransitionEffectAfterDuration.Maximum = New Decimal(New Integer() {20000, 0, 0, 0})
		Me.nudTransitionEffectAfterDuration.Name = "nudTransitionEffectAfterDuration"
		Me.nudTransitionEffectAfterDuration.Size = New System.Drawing.Size(55, 20)
		Me.nudTransitionEffectAfterDuration.TabIndex = 20
		' 
		' label14
		' 
		Me.label14.AutoSize = True
		Me.label14.Location = New System.Drawing.Point(139, 102)
		Me.label14.Name = "label14"
		Me.label14.Size = New System.Drawing.Size(20, 13)
		Me.label14.TabIndex = 21
		Me.label14.Text = "ms"
		' 
		' nudTransitionEffectBeforeDuration
		' 
		Me.nudTransitionEffectBeforeDuration.Increment = New Decimal(New Integer() {100, 0, 0, 0})
		Me.nudTransitionEffectBeforeDuration.Location = New System.Drawing.Point(78, 47)
		Me.nudTransitionEffectBeforeDuration.Maximum = New Decimal(New Integer() {20000, 0, 0, 0})
		Me.nudTransitionEffectBeforeDuration.Name = "nudTransitionEffectBeforeDuration"
		Me.nudTransitionEffectBeforeDuration.Size = New System.Drawing.Size(55, 20)
		Me.nudTransitionEffectBeforeDuration.TabIndex = 18
		' 
		' label12
		' 
		Me.label12.AutoSize = True
		Me.label12.Location = New System.Drawing.Point(139, 49)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(20, 13)
		Me.label12.TabIndex = 19
		Me.label12.Text = "ms"
		' 
		' label15
		' 
		Me.label15.AutoSize = True
		Me.label15.Location = New System.Drawing.Point(6, 102)
		Me.label15.Name = "label15"
		Me.label15.Size = New System.Drawing.Size(47, 13)
		Me.label15.TabIndex = 12
		Me.label15.Text = "Duration"
		' 
		' cmbTransitionEffectAfter
		' 
		Me.cmbTransitionEffectAfter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbTransitionEffectAfter.Items.AddRange(New Object() {"None", "Simple Fade", "Wipe Left", "Wipe Right", "Wipe Up", "Wipe Down", _
			"Wipe Top Left", "Wipe Top Right", "Wipe Bottom Left", "Wipe Bottom Right", "Cover Left", "Cover Right", _
			"Cover Up", "Cover Down", "Cover Left Up", "Cover Left Down", "Cover Right Up", "Cover Right Down", _
			"Uncover Left", "Uncover Right", "Uncover Up", "Uncover Down", "Uncover Left Up", "Uncover Left Down", _
			"Uncover Right Up", "Uncover Right Down", "Uncover Push Left", "Uncover Push Right", "Uncover Push Up", "Uncover Push Down", _
			"Box In", "Box Out", "Wheel 1", "Wheel 2", "Wheel 3", "Wheel 4", _
			"Wheel 5", "Wheel 6", "Wheel 7", "Wheel 8", "Horz Blinds 5", "Horz Blinds 10", _
			"Horz Blinds 20", "Vert Blinds 5", "Vert Blinds 10", "Vert Blinds 20", "Strip Left Up", "Strip Left Down", _
			"Strip Right Up", "Strip Right Down", "Shape Circle", "Shape Plus", "Shape Diamond", "Shape Checks Horz", _
			"Shape Checks Vert", "Split Horz In", "Split Horz Out", "Split Vert In", "Split Vert Out", "Wedge", _
			"Clock Clockwise", "Clock Counterclockwise", "Cut", "Cut Through Black", "Random Bars Horz", "Random Bars Vert", _
			"Fade", "News Flash", "Dissolve", "Switch Left", "Switch Right", "Box 3D Left", _
			"Box 3D Right", "Box 3D Up", "Box 3D Down", "Cube Left", "Cube Right", "Cube Up", _
			"Cube Down", "Flip Left", "Flip Right", "Ripple Top Left", "Ripple Top Right", "Ripple Bottom Left", _
			"Ripple Bottom Right", "Ripple Center", "Gallery Left", "Gallery Right", "Zoom In", "Zoom Out", _
			"Doors Horz", "Doors Vert", "Windows Horz", "Windows Vert", "Fade Through Black", "Honeycomb", _
			"Blinds 3D Horz", "Blinds 3D Vert", "Checker Board 3D Horz", "Checker Board 3D Vert", "Comb Horizontal", "Comb Vertical", _
			"Glitter Left", "Glitter Right", "Glitter Up", "Glitter Down", "Glitter Diamond Left", "Glitter Diamond Right", _
			"Glitter Diamond Up", "Glitter Diamond Down", "Shred Strip In", "Shred Strip Out", "Shred Particle In", "Shred Particle Out", _
			"Vortex Left", "Vortex Right", "Vortex Up", "Vortex Down", "Reveal Left", "Reveal Right", _
			"Reveal Through Black Left", "Reveal Through Black Right", "Cover 3D Left", "Cover 3D Right", "Cover 3D Up", "Cover 3D Down", _
			"Cover 3D Left Up", "Cover 3D Left Down", "Cover 3D Right Up", "Cover 3D Right Down", "Uncover 3D Left", "Uncover 3D Right", _
			"Uncover 3D Up", "Uncover 3D Down", "Uncover 3D Left Up", "Uncover 3D Left Down", "Uncover 3D Right Up", "Uncover 3D Right Down", _
			"Flash", "Fly Through", "Orbit", "Rotate"})
		Me.cmbTransitionEffectAfter.Location = New System.Drawing.Point(78, 73)
		Me.cmbTransitionEffectAfter.MaxDropDownItems = 16
		Me.cmbTransitionEffectAfter.Name = "cmbTransitionEffectAfter"
		Me.cmbTransitionEffectAfter.Size = New System.Drawing.Size(180, 21)
		Me.cmbTransitionEffectAfter.TabIndex = 2
		' 
		' label13
		' 
		Me.label13.AutoSize = True
		Me.label13.Location = New System.Drawing.Point(6, 49)
		Me.label13.Name = "label13"
		Me.label13.Size = New System.Drawing.Size(47, 13)
		Me.label13.TabIndex = 9
		Me.label13.Text = "Duration"
		' 
		' label11
		' 
		Me.label11.AutoSize = True
		Me.label11.Location = New System.Drawing.Point(6, 76)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(29, 13)
		Me.label11.TabIndex = 10
		Me.label11.Text = "After"
		' 
		' cmbTransitionEffectBefore
		' 
		Me.cmbTransitionEffectBefore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbTransitionEffectBefore.Items.AddRange(New Object() {"None", "Simple Fade", "Wipe Left", "Wipe Right", "Wipe Up", "Wipe Down", _
			"Wipe Top Left", "Wipe Top Right", "Wipe Bottom Left", "Wipe Bottom Right", "Cover Left", "Cover Right", _
			"Cover Up", "Cover Down", "Cover Left Up", "Cover Left Down", "Cover Right Up", "Cover Right Down", _
			"Uncover Left", "Uncover Right", "Uncover Up", "Uncover Down", "Uncover Left Up", "Uncover Left Down", _
			"Uncover Right Up", "Uncover Right Down", "Uncover Push Left", "Uncover Push Right", "Uncover Push Up", "Uncover Push Down", _
			"Box In", "Box Out", "Wheel 1", "Wheel 2", "Wheel 3", "Wheel 4", _
			"Wheel 5", "Wheel 6", "Wheel 7", "Wheel 8", "Horz Blinds 5", "Horz Blinds 10", _
			"Horz Blinds 20", "Vert Blinds 5", "Vert Blinds 10", "Vert Blinds 20", "Strip Left Up", "Strip Left Down", _
			"Strip Right Up", "Strip Right Down", "Shape Circle", "Shape Plus", "Shape Diamond", "Shape Checks Horz", _
			"Shape Checks Vert", "Split Horz In", "Split Horz Out", "Split Vert In", "Split Vert Out", "Wedge", _
			"Clock Clockwise", "Clock Counterclockwise", "Cut", "Cut Through Black", "Random Bars Horz", "Random Bars Vert", _
			"Fade", "News Flash", "Dissolve", "Switch Left", "Switch Right", "Box 3D Left", _
			"Box 3D Right", "Box 3D Up", "Box 3D Down", "Cube Left", "Cube Right", "Cube Up", _
			"Cube Down", "Flip Left", "Flip Right", "Ripple Top Left", "Ripple Top Right", "Ripple Bottom Left", _
			"Ripple Bottom Right", "Ripple Center", "Gallery Left", "Gallery Right", "Zoom In", "Zoom Out", _
			"Doors Horz", "Doors Vert", "Windows Horz", "Windows Vert", "Fade Through Black", "Honeycomb", _
			"Blinds 3D Horz", "Blinds 3D Vert", "Checker Board 3D Horz", "Checker Board 3D Vert", "Comb Horizontal", "Comb Vertical", _
			"Glitter Left", "Glitter Right", "Glitter Up", "Glitter Down", "Glitter Diamond Left", "Glitter Diamond Right", _
			"Glitter Diamond Up", "Glitter Diamond Down", "Shred Strip In", "Shred Strip Out", "Shred Particle In", "Shred Particle Out", _
			"Vortex Left", "Vortex Right", "Vortex Up", "Vortex Down", "Reveal Left", "Reveal Right", _
			"Reveal Through Black Left", "Reveal Through Black Right", "Cover 3D Left", "Cover 3D Right", "Cover 3D Up", "Cover 3D Down", _
			"Cover 3D Left Up", "Cover 3D Left Down", "Cover 3D Right Up", "Cover 3D Right Down", "Uncover 3D Left", "Uncover 3D Right", _
			"Uncover 3D Up", "Uncover 3D Down", "Uncover 3D Left Up", "Uncover 3D Left Down", "Uncover 3D Right Up", "Uncover 3D Right Down", _
			"Flash", "Fly Through", "Orbit", "Rotate"})
		Me.cmbTransitionEffectBefore.Location = New System.Drawing.Point(78, 19)
		Me.cmbTransitionEffectBefore.MaxDropDownItems = 16
		Me.cmbTransitionEffectBefore.Name = "cmbTransitionEffectBefore"
		Me.cmbTransitionEffectBefore.Size = New System.Drawing.Size(180, 21)
		Me.cmbTransitionEffectBefore.TabIndex = 0
		' 
		' label10
		' 
		Me.label10.AutoSize = True
		Me.label10.Location = New System.Drawing.Point(6, 22)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(38, 13)
		Me.label10.TabIndex = 9
		Me.label10.Text = "Before"
		' 
		' label16
		' 
		Me.label16.AutoSize = True
		Me.label16.Location = New System.Drawing.Point(6, 60)
		Me.label16.Name = "label16"
		Me.label16.Size = New System.Drawing.Size(92, 13)
		Me.label16.TabIndex = 15
		Me.label16.Text = "Background Color"
		' 
		' tbBackgroundImage
		' 
		Me.tbBackgroundImage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbBackgroundImage.Location = New System.Drawing.Point(109, 82)
		Me.tbBackgroundImage.Name = "tbBackgroundImage"
		Me.tbBackgroundImage.[ReadOnly] = True
		Me.tbBackgroundImage.Size = New System.Drawing.Size(306, 20)
		Me.tbBackgroundImage.TabIndex = 3
		' 
		' label17
		' 
		Me.label17.AutoSize = True
		Me.label17.Location = New System.Drawing.Point(6, 85)
		Me.label17.Name = "label17"
		Me.label17.Size = New System.Drawing.Size(97, 13)
		Me.label17.TabIndex = 9
		Me.label17.Text = "Background Image"
		' 
		' btnBackgroundImageBrowse
		' 
		Me.btnBackgroundImageBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnBackgroundImageBrowse.Location = New System.Drawing.Point(421, 80)
		Me.btnBackgroundImageBrowse.Name = "btnBackgroundImageBrowse"
		Me.btnBackgroundImageBrowse.Size = New System.Drawing.Size(24, 23)
		Me.btnBackgroundImageBrowse.TabIndex = 4
		Me.btnBackgroundImageBrowse.Text = "..."
		Me.btnBackgroundImageBrowse.UseVisualStyleBackColor = True
		AddHandler Me.btnBackgroundImageBrowse.Click, New System.EventHandler(AddressOf Me.btnBackgroundImageBrowse_Click)
		' 
		' btnAudioTrackBrowse
		' 
		Me.btnAudioTrackBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnAudioTrackBrowse.Location = New System.Drawing.Point(421, 158)
		Me.btnAudioTrackBrowse.Name = "btnAudioTrackBrowse"
		Me.btnAudioTrackBrowse.Size = New System.Drawing.Size(24, 23)
		Me.btnAudioTrackBrowse.TabIndex = 8
		Me.btnAudioTrackBrowse.Text = "..."
		Me.btnAudioTrackBrowse.UseVisualStyleBackColor = True
		AddHandler Me.btnAudioTrackBrowse.Click, New System.EventHandler(AddressOf Me.btnAudioTrackBrowse_Click)
		' 
		' tbAudioTrack
		' 
		Me.tbAudioTrack.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbAudioTrack.Location = New System.Drawing.Point(109, 160)
		Me.tbAudioTrack.Name = "tbAudioTrack"
		Me.tbAudioTrack.[ReadOnly] = True
		Me.tbAudioTrack.Size = New System.Drawing.Size(306, 20)
		Me.tbAudioTrack.TabIndex = 7
		' 
		' label18
		' 
		Me.label18.AutoSize = True
		Me.label18.Location = New System.Drawing.Point(6, 163)
		Me.label18.Name = "label18"
		Me.label18.Size = New System.Drawing.Size(65, 13)
		Me.label18.TabIndex = 17
		Me.label18.Text = "Audio Track"
		' 
		' groupBox2
		' 
		Me.groupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.groupBox2.Controls.Add(Me.nudVisualEffectDuration)
		Me.groupBox2.Controls.Add(Me.label20)
		Me.groupBox2.Controls.Add(Me.cmbVisualEffectTransition)
		Me.groupBox2.Controls.Add(Me.label21)
		Me.groupBox2.Controls.Add(Me.label19)
		Me.groupBox2.Controls.Add(Me.cmbVisualEffect)
		Me.groupBox2.Controls.Add(Me.label7)
		Me.groupBox2.Location = New System.Drawing.Point(6, 64)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(439, 102)
		Me.groupBox2.TabIndex = 2
		Me.groupBox2.TabStop = False
		Me.groupBox2.Text = "Visual Effect"
		' 
		' nudVisualEffectDuration
		' 
		Me.nudVisualEffectDuration.Increment = New Decimal(New Integer() {100, 0, 0, 0})
		Me.nudVisualEffectDuration.Location = New System.Drawing.Point(78, 74)
		Me.nudVisualEffectDuration.Maximum = New Decimal(New Integer() {20000, 0, 0, 0})
		Me.nudVisualEffectDuration.Name = "nudVisualEffectDuration"
		Me.nudVisualEffectDuration.Size = New System.Drawing.Size(55, 20)
		Me.nudVisualEffectDuration.TabIndex = 8
		' 
		' label20
		' 
		Me.label20.AutoSize = True
		Me.label20.Location = New System.Drawing.Point(139, 76)
		Me.label20.Name = "label20"
		Me.label20.Size = New System.Drawing.Size(20, 13)
		Me.label20.TabIndex = 17
		Me.label20.Text = "ms"
		' 
		' cmbVisualEffectTransition
		' 
		Me.cmbVisualEffectTransition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbVisualEffectTransition.FormattingEnabled = True
		Me.cmbVisualEffectTransition.Items.AddRange(New Object() {"None", "Ease In", "Ease Out"})
		Me.cmbVisualEffectTransition.Location = New System.Drawing.Point(78, 46)
		Me.cmbVisualEffectTransition.Name = "cmbVisualEffectTransition"
		Me.cmbVisualEffectTransition.Size = New System.Drawing.Size(180, 21)
		Me.cmbVisualEffectTransition.TabIndex = 1
		' 
		' label21
		' 
		Me.label21.AutoSize = True
		Me.label21.Location = New System.Drawing.Point(6, 76)
		Me.label21.Name = "label21"
		Me.label21.Size = New System.Drawing.Size(47, 13)
		Me.label21.TabIndex = 15
		Me.label21.Text = "Duration"
		' 
		' label19
		' 
		Me.label19.AutoSize = True
		Me.label19.Location = New System.Drawing.Point(6, 49)
		Me.label19.Name = "label19"
		Me.label19.Size = New System.Drawing.Size(53, 13)
		Me.label19.TabIndex = 6
		Me.label19.Text = "Transition"
		' 
		' tabControl1
		' 
		Me.tabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tabControl1.Controls.Add(Me.tabPage1)
		Me.tabControl1.Controls.Add(Me.tabPage2)
		Me.tabControl1.Location = New System.Drawing.Point(303, 17)
		Me.tabControl1.Name = "tabControl1"
		Me.tabControl1.SelectedIndex = 0
		Me.tabControl1.Size = New System.Drawing.Size(459, 419)
		Me.tabControl1.TabIndex = 1
		' 
		' tabPage1
		' 
		Me.tabPage1.Controls.Add(Me.nudSlideDuration)
		Me.tabPage1.Controls.Add(Me.groupBox2)
		Me.tabPage1.Controls.Add(Me.label1)
		Me.tabPage1.Controls.Add(Me.groupBox4)
		Me.tabPage1.Controls.Add(Me.label8)
		Me.tabPage1.Controls.Add(Me.label2)
		Me.tabPage1.Controls.Add(Me.cmbSlideRotation)
		Me.tabPage1.Location = New System.Drawing.Point(4, 22)
		Me.tabPage1.Name = "tabPage1"
		Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage1.Size = New System.Drawing.Size(451, 393)
		Me.tabPage1.TabIndex = 0
		Me.tabPage1.Text = "Slide Options"
		Me.tabPage1.UseVisualStyleBackColor = True
		' 
		' nudSlideDuration
		' 
		Me.nudSlideDuration.Increment = New Decimal(New Integer() {100, 0, 0, 0})
		Me.nudSlideDuration.Location = New System.Drawing.Point(84, 12)
		Me.nudSlideDuration.Maximum = New Decimal(New Integer() {20000, 0, 0, 0})
		Me.nudSlideDuration.Name = "nudSlideDuration"
		Me.nudSlideDuration.Size = New System.Drawing.Size(55, 20)
		Me.nudSlideDuration.TabIndex = 7
		' 
		' tabPage2
		' 
		Me.tabPage2.Controls.Add(Me.groupBox3)
		Me.tabPage2.Controls.Add(Me.btnBackgroundColor)
		Me.tabPage2.Controls.Add(Me.cbKeepAspectRatio)
		Me.tabPage2.Controls.Add(Me.cbAutoFitImages)
		Me.tabPage2.Controls.Add(Me.label16)
		Me.tabPage2.Controls.Add(Me.label3)
		Me.tabPage2.Controls.Add(Me.tbMovieWidth)
		Me.tabPage2.Controls.Add(Me.label4)
		Me.tabPage2.Controls.Add(Me.label17)
		Me.tabPage2.Controls.Add(Me.btnAudioTrackBrowse)
		Me.tabPage2.Controls.Add(Me.tbMovieHeight)
		Me.tabPage2.Controls.Add(Me.tbAudioTrack)
		Me.tabPage2.Controls.Add(Me.tbBackgroundImage)
		Me.tabPage2.Controls.Add(Me.label18)
		Me.tabPage2.Controls.Add(Me.label5)
		Me.tabPage2.Controls.Add(Me.label6)
		Me.tabPage2.Controls.Add(Me.btnBackgroundImageBrowse)
		Me.tabPage2.Location = New System.Drawing.Point(4, 22)
		Me.tabPage2.Name = "tabPage2"
		Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage2.Size = New System.Drawing.Size(451, 393)
		Me.tabPage2.TabIndex = 1
		Me.tabPage2.Text = "Movie Options"
		Me.tabPage2.UseVisualStyleBackColor = True
		' 
		' groupBox3
		' 
		Me.groupBox3.Controls.Add(Me.label22)
		Me.groupBox3.Controls.Add(Me.tabControl2)
		Me.groupBox3.Controls.Add(Me.tbFPS)
		Me.groupBox3.Location = New System.Drawing.Point(6, 190)
		Me.groupBox3.Name = "groupBox3"
		Me.groupBox3.Size = New System.Drawing.Size(439, 192)
		Me.groupBox3.TabIndex = 9
		Me.groupBox3.TabStop = False
		Me.groupBox3.Text = "Audio and Video Settings"
		' 
		' label22
		' 
		Me.label22.AutoSize = True
		Me.label22.Location = New System.Drawing.Point(16, 167)
		Me.label22.Name = "label22"
		Me.label22.Size = New System.Drawing.Size(27, 13)
		Me.label22.TabIndex = 29
		Me.label22.Text = "FPS"
		' 
		' tabControl2
		' 
		Me.tabControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tabControl2.Controls.Add(Me.tabPageWmv)
		Me.tabControl2.Controls.Add(Me.tabPageAvi)
		Me.tabControl2.Location = New System.Drawing.Point(6, 19)
		Me.tabControl2.Name = "tabControl2"
		Me.tabControl2.SelectedIndex = 0
		Me.tabControl2.Size = New System.Drawing.Size(427, 139)
		Me.tabControl2.TabIndex = 25
		' 
		' tabPageWmv
		' 
		Me.tabPageWmv.Controls.Add(Me.label28)
		Me.tabPageWmv.Controls.Add(Me.label9)
		Me.tabPageWmv.Controls.Add(Me.tbBitrate)
		Me.tabPageWmv.Controls.Add(Me.cmbWmvAudioFormats)
		Me.tabPageWmv.Controls.Add(Me.label23)
		Me.tabPageWmv.Controls.Add(Me.cmbWmvAudioCodecs)
		Me.tabPageWmv.Controls.Add(Me.label24)
		Me.tabPageWmv.Controls.Add(Me.cmbWmvVideoCodecs)
		Me.tabPageWmv.Controls.Add(Me.label25)
		Me.tabPageWmv.Location = New System.Drawing.Point(4, 22)
		Me.tabPageWmv.Name = "tabPageWmv"
		Me.tabPageWmv.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPageWmv.Size = New System.Drawing.Size(419, 113)
		Me.tabPageWmv.TabIndex = 1
		Me.tabPageWmv.Text = "WMV Format"
		Me.tabPageWmv.UseVisualStyleBackColor = True
		' 
		' label28
		' 
		Me.label28.AutoSize = True
		Me.label28.Location = New System.Drawing.Point(96, 90)
		Me.label28.Name = "label28"
		Me.label28.Size = New System.Drawing.Size(30, 13)
		Me.label28.TabIndex = 18
		Me.label28.Text = "kbps"
		' 
		' label9
		' 
		Me.label9.AutoSize = True
		Me.label9.Location = New System.Drawing.Point(6, 90)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(37, 13)
		Me.label9.TabIndex = 27
		Me.label9.Text = "Bitrate"
		' 
		' tbBitrate
		' 
		Me.tbBitrate.Location = New System.Drawing.Point(50, 87)
		Me.tbBitrate.Name = "tbBitrate"
		Me.tbBitrate.Size = New System.Drawing.Size(40, 20)
		Me.tbBitrate.TabIndex = 3
		Me.tbBitrate.Text = "1000"
		' 
		' cmbWmvAudioFormats
		' 
		Me.cmbWmvAudioFormats.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbWmvAudioFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbWmvAudioFormats.FormattingEnabled = True
		Me.cmbWmvAudioFormats.Location = New System.Drawing.Point(50, 33)
		Me.cmbWmvAudioFormats.Name = "cmbWmvAudioFormats"
		Me.cmbWmvAudioFormats.Size = New System.Drawing.Size(363, 21)
		Me.cmbWmvAudioFormats.TabIndex = 1
		' 
		' label23
		' 
		Me.label23.AutoSize = True
		Me.label23.Location = New System.Drawing.Point(6, 36)
		Me.label23.Name = "label23"
		Me.label23.Size = New System.Drawing.Size(39, 13)
		Me.label23.TabIndex = 14
		Me.label23.Text = "Format"
		' 
		' cmbWmvAudioCodecs
		' 
		Me.cmbWmvAudioCodecs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbWmvAudioCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbWmvAudioCodecs.FormattingEnabled = True
		Me.cmbWmvAudioCodecs.Location = New System.Drawing.Point(50, 6)
		Me.cmbWmvAudioCodecs.Name = "cmbWmvAudioCodecs"
		Me.cmbWmvAudioCodecs.Size = New System.Drawing.Size(363, 21)
		Me.cmbWmvAudioCodecs.TabIndex = 0
		AddHandler Me.cmbWmvAudioCodecs.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cmbWmvAudioCodecs_SelectedIndexChanged)
		' 
		' label24
		' 
		Me.label24.AutoSize = True
		Me.label24.Location = New System.Drawing.Point(6, 63)
		Me.label24.Name = "label24"
		Me.label24.Size = New System.Drawing.Size(34, 13)
		Me.label24.TabIndex = 12
		Me.label24.Text = "Video"
		' 
		' cmbWmvVideoCodecs
		' 
		Me.cmbWmvVideoCodecs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbWmvVideoCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbWmvVideoCodecs.FormattingEnabled = True
		Me.cmbWmvVideoCodecs.Location = New System.Drawing.Point(50, 60)
		Me.cmbWmvVideoCodecs.Name = "cmbWmvVideoCodecs"
		Me.cmbWmvVideoCodecs.Size = New System.Drawing.Size(363, 21)
		Me.cmbWmvVideoCodecs.TabIndex = 2
		' 
		' label25
		' 
		Me.label25.AutoSize = True
		Me.label25.Location = New System.Drawing.Point(6, 9)
		Me.label25.Name = "label25"
		Me.label25.Size = New System.Drawing.Size(34, 13)
		Me.label25.TabIndex = 11
		Me.label25.Text = "Audio"
		' 
		' tabPageAvi
		' 
		Me.tabPageAvi.Controls.Add(Me.cmbAviAudioCodecs)
		Me.tabPageAvi.Controls.Add(Me.label26)
		Me.tabPageAvi.Controls.Add(Me.cmbAviVideoCodecs)
		Me.tabPageAvi.Controls.Add(Me.label27)
		Me.tabPageAvi.Controls.Add(Me.btnVideoCodecProps)
		Me.tabPageAvi.Location = New System.Drawing.Point(4, 22)
		Me.tabPageAvi.Name = "tabPageAvi"
		Me.tabPageAvi.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPageAvi.Size = New System.Drawing.Size(419, 113)
		Me.tabPageAvi.TabIndex = 2
		Me.tabPageAvi.Text = "AVI format"
		Me.tabPageAvi.UseVisualStyleBackColor = True
		' 
		' cmbAviAudioCodecs
		' 
		Me.cmbAviAudioCodecs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbAviAudioCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbAviAudioCodecs.FormattingEnabled = True
		Me.cmbAviAudioCodecs.Location = New System.Drawing.Point(50, 6)
		Me.cmbAviAudioCodecs.Name = "cmbAviAudioCodecs"
		Me.cmbAviAudioCodecs.Size = New System.Drawing.Size(332, 21)
		Me.cmbAviAudioCodecs.TabIndex = 0
		' 
		' label26
		' 
		Me.label26.AutoSize = True
		Me.label26.Location = New System.Drawing.Point(6, 36)
		Me.label26.Name = "label26"
		Me.label26.Size = New System.Drawing.Size(34, 13)
		Me.label26.TabIndex = 7
		Me.label26.Text = "Video"
		' 
		' cmbAviVideoCodecs
		' 
		Me.cmbAviVideoCodecs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbAviVideoCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbAviVideoCodecs.FormattingEnabled = True
		Me.cmbAviVideoCodecs.Location = New System.Drawing.Point(50, 33)
		Me.cmbAviVideoCodecs.Name = "cmbAviVideoCodecs"
		Me.cmbAviVideoCodecs.Size = New System.Drawing.Size(332, 21)
		Me.cmbAviVideoCodecs.TabIndex = 1
		' 
		' label27
		' 
		Me.label27.AutoSize = True
		Me.label27.Location = New System.Drawing.Point(6, 9)
		Me.label27.Name = "label27"
		Me.label27.Size = New System.Drawing.Size(34, 13)
		Me.label27.TabIndex = 5
		Me.label27.Text = "Audio"
		' 
		' btnVideoCodecProps
		' 
		Me.btnVideoCodecProps.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnVideoCodecProps.Image = My.Resources.wrench
		Me.btnVideoCodecProps.Location = New System.Drawing.Point(388, 29)
		Me.btnVideoCodecProps.Name = "btnVideoCodecProps"
		Me.btnVideoCodecProps.Size = New System.Drawing.Size(26, 26)
		Me.btnVideoCodecProps.TabIndex = 2
		Me.btnVideoCodecProps.UseVisualStyleBackColor = True
		AddHandler Me.btnVideoCodecProps.Click, New System.EventHandler(AddressOf Me.btnVideoCodecProps_Click)
		' 
		' tbFPS
		' 
		Me.tbFPS.Location = New System.Drawing.Point(60, 164)
		Me.tbFPS.Name = "tbFPS"
		Me.tbFPS.Size = New System.Drawing.Size(40, 20)
		Me.tbFPS.TabIndex = 0
		' 
		' btnBackgroundColor
		' 
		Me.btnBackgroundColor.BackColor = System.Drawing.Color.White
		Me.btnBackgroundColor.Location = New System.Drawing.Point(109, 55)
		Me.btnBackgroundColor.Name = "btnBackgroundColor"
		Me.btnBackgroundColor.Size = New System.Drawing.Size(23, 23)
		Me.btnBackgroundColor.TabIndex = 2
		Me.btnBackgroundColor.UseVisualStyleBackColor = False
		AddHandler Me.btnBackgroundColor.Click, New System.EventHandler(AddressOf Me.btnBackgroundColor_Click)
		' 
		' cbKeepAspectRatio
		' 
		Me.cbKeepAspectRatio.AutoSize = True
		Me.cbKeepAspectRatio.Location = New System.Drawing.Point(27, 33)
		Me.cbKeepAspectRatio.Name = "cbKeepAspectRatio"
		Me.cbKeepAspectRatio.Size = New System.Drawing.Size(115, 17)
		Me.cbKeepAspectRatio.TabIndex = 1
		Me.cbKeepAspectRatio.Text = "Keep Aspect Ratio"
		Me.cbKeepAspectRatio.UseVisualStyleBackColor = True
		' 
		' cbAutoFitImages
		' 
		Me.cbAutoFitImages.AutoSize = True
		Me.cbAutoFitImages.Location = New System.Drawing.Point(9, 10)
		Me.cbAutoFitImages.Name = "cbAutoFitImages"
		Me.cbAutoFitImages.Size = New System.Drawing.Size(99, 17)
		Me.cbAutoFitImages.TabIndex = 0
		Me.cbAutoFitImages.Text = "Auto-Fit Images"
		Me.cbAutoFitImages.UseVisualStyleBackColor = True
		' 
		' cbPlayGeneratedFile
		' 
		Me.cbPlayGeneratedFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbPlayGeneratedFile.AutoSize = True
		Me.cbPlayGeneratedFile.Checked = True
		Me.cbPlayGeneratedFile.CheckState = System.Windows.Forms.CheckState.Checked
		Me.cbPlayGeneratedFile.Location = New System.Drawing.Point(434, 454)
		Me.cbPlayGeneratedFile.Name = "cbPlayGeneratedFile"
		Me.cbPlayGeneratedFile.Size = New System.Drawing.Size(137, 17)
		Me.cbPlayGeneratedFile.TabIndex = 4
		Me.cbPlayGeneratedFile.Text = "Auto-play generated file"
		Me.cbPlayGeneratedFile.UseVisualStyleBackColor = True
		' 
		' statusStrip1
		' 
		Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1, Me.toolStripProgressBar1})
		Me.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
		Me.statusStrip1.Location = New System.Drawing.Point(0, 484)
		Me.statusStrip1.Name = "statusStrip1"
		Me.statusStrip1.Size = New System.Drawing.Size(774, 22)
		Me.statusStrip1.SizingGrip = False
		Me.statusStrip1.TabIndex = 5
		Me.statusStrip1.Text = "statusStrip1"
		' 
		' toolStripStatusLabel1
		' 
		Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
		Me.toolStripStatusLabel1.Size = New System.Drawing.Size(39, 17)
		Me.toolStripStatusLabel1.Text = "Ready"
		' 
		' toolStripProgressBar1
		' 
		Me.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.toolStripProgressBar1.AutoSize = False
		Me.toolStripProgressBar1.Name = "toolStripProgressBar1"
		Me.toolStripProgressBar1.Size = New System.Drawing.Size(152, 16)
		' 
		' btnCreateMovie
		' 
		Me.btnCreateMovie.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnCreateMovie.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.btnCreateMovie.Image = My.Resources.film
		Me.btnCreateMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnCreateMovie.Location = New System.Drawing.Point(606, 442)
		Me.btnCreateMovie.Name = "btnCreateMovie"
		Me.btnCreateMovie.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.btnCreateMovie.Size = New System.Drawing.Size(155, 39)
		Me.btnCreateMovie.TabIndex = 2
		Me.btnCreateMovie.Text = "Create Movie"
		Me.btnCreateMovie.UseVisualStyleBackColor = True
		AddHandler Me.btnCreateMovie.Click, New System.EventHandler(AddressOf Me.btnCreateMovie_Click)
		' 
		' cbTransitionEffectBeforeRandom
		' 
		Me.cbTransitionEffectBeforeRandom.AutoSize = True
		Me.cbTransitionEffectBeforeRandom.Location = New System.Drawing.Point(264, 21)
		Me.cbTransitionEffectBeforeRandom.Name = "cbTransitionEffectBeforeRandom"
		Me.cbTransitionEffectBeforeRandom.Size = New System.Drawing.Size(66, 17)
		Me.cbTransitionEffectBeforeRandom.TabIndex = 22
		Me.cbTransitionEffectBeforeRandom.Text = "Random"
		Me.cbTransitionEffectBeforeRandom.UseVisualStyleBackColor = True
		' 
		' cbTransitionEffectAfterRandom
		' 
		Me.cbTransitionEffectAfterRandom.AutoSize = True
		Me.cbTransitionEffectAfterRandom.Location = New System.Drawing.Point(264, 75)
		Me.cbTransitionEffectAfterRandom.Name = "cbTransitionEffectAfterRandom"
		Me.cbTransitionEffectAfterRandom.Size = New System.Drawing.Size(66, 17)
		Me.cbTransitionEffectAfterRandom.TabIndex = 23
		Me.cbTransitionEffectAfterRandom.Text = "Random"
		Me.cbTransitionEffectAfterRandom.UseVisualStyleBackColor = True
		' 
		' linkVisitSDKHome
		' 
		Me.linkVisitSDKHome.AutoSize = True
		Me.linkVisitSDKHome.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.linkVisitSDKHome.Location = New System.Drawing.Point(9, 455)
		Me.linkVisitSDKHome.Name = "linkVisitSDKHome"
		Me.linkVisitSDKHome.Size = New System.Drawing.Size(363, 13)
		Me.linkVisitSDKHome.TabIndex = 6
		Me.linkVisitSDKHome.TabStop = True
		Me.linkVisitSDKHome.Text = "Powered by Bytescout Images To Video SDK - click to find more"
		AddHandler Me.linkVisitSDKHome.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.linkVisitSDKHome_LinkClicked)
		' 
		' MainForm
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(774, 506)
		Me.Controls.Add(Me.linkVisitSDKHome)
		Me.Controls.Add(Me.statusStrip1)
		Me.Controls.Add(Me.cbPlayGeneratedFile)
		Me.Controls.Add(Me.tabControl1)
		Me.Controls.Add(Me.btnCreateMovie)
		Me.Controls.Add(Me.groupBox1)
		Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Bytescout ImageToVideo Demo"
		Me.groupBox1.ResumeLayout(False)
		Me.groupBox4.ResumeLayout(False)
		Me.groupBox4.PerformLayout()
		DirectCast(Me.nudTransitionEffectAfterDuration, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.nudTransitionEffectBeforeDuration, System.ComponentModel.ISupportInitialize).EndInit()
		Me.groupBox2.ResumeLayout(False)
		Me.groupBox2.PerformLayout()
		DirectCast(Me.nudVisualEffectDuration, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tabControl1.ResumeLayout(False)
		Me.tabPage1.ResumeLayout(False)
		Me.tabPage1.PerformLayout()
		DirectCast(Me.nudSlideDuration, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tabPage2.ResumeLayout(False)
		Me.tabPage2.PerformLayout()
		Me.groupBox3.ResumeLayout(False)
		Me.groupBox3.PerformLayout()
		Me.tabControl2.ResumeLayout(False)
		Me.tabPageWmv.ResumeLayout(False)
		Me.tabPageWmv.PerformLayout()
		Me.tabPageAvi.ResumeLayout(False)
		Me.tabPageAvi.PerformLayout()
		Me.statusStrip1.ResumeLayout(False)
		Me.statusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private groupBox1 As System.Windows.Forms.GroupBox
	Private WithEvents btnRemoveAll As System.Windows.Forms.Button
	Private WithEvents btnRemove As System.Windows.Forms.Button
	Private WithEvents btnAddFolder As System.Windows.Forms.Button
	Private WithEvents btnAddImage As System.Windows.Forms.Button
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private WithEvents tbMovieHeight As System.Windows.Forms.TextBox
	Private label4 As System.Windows.Forms.Label
	Private WithEvents tbMovieWidth As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private WithEvents btnCreateMovie As System.Windows.Forms.Button
	Private label7 As System.Windows.Forms.Label
	Private WithEvents cmbVisualEffect As System.Windows.Forms.ComboBox
	Private label8 As System.Windows.Forms.Label
	Private WithEvents cmbSlideRotation As System.Windows.Forms.ComboBox
	Private groupBox4 As System.Windows.Forms.GroupBox
	Private WithEvents cmbTransitionEffectAfter As System.Windows.Forms.ComboBox
	Private label11 As System.Windows.Forms.Label
	Private WithEvents cmbTransitionEffectBefore As System.Windows.Forms.ComboBox
	Private label10 As System.Windows.Forms.Label
	Private label15 As System.Windows.Forms.Label
	Private label13 As System.Windows.Forms.Label
	Private WithEvents tbBackgroundImage As System.Windows.Forms.TextBox
	Private label17 As System.Windows.Forms.Label
	Private label16 As System.Windows.Forms.Label
	Private WithEvents btnBackgroundImageBrowse As System.Windows.Forms.Button
	Private WithEvents btnAudioTrackBrowse As System.Windows.Forms.Button
	Private WithEvents tbAudioTrack As System.Windows.Forms.TextBox
	Private label18 As System.Windows.Forms.Label
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private label20 As System.Windows.Forms.Label
	Private WithEvents cmbVisualEffectTransition As System.Windows.Forms.ComboBox
	Private label21 As System.Windows.Forms.Label
	Private label19 As System.Windows.Forms.Label
	Private WithEvents btnMoveDown As System.Windows.Forms.Button
	Private WithEvents btnMoveUp As System.Windows.Forms.Button
	Private WithEvents tabControl1 As System.Windows.Forms.TabControl
	Private tabPage1 As System.Windows.Forms.TabPage
	Private tabPage2 As System.Windows.Forms.TabPage
	Private WithEvents cbKeepAspectRatio As System.Windows.Forms.CheckBox
	Private WithEvents cbAutoFitImages As System.Windows.Forms.CheckBox
	Private WithEvents btnBackgroundColor As System.Windows.Forms.Button
	Private WithEvents tabControl2 As System.Windows.Forms.TabControl
	Private tabPageWmv As System.Windows.Forms.TabPage
	Private WithEvents cmbWmvAudioFormats As System.Windows.Forms.ComboBox
	Private label23 As System.Windows.Forms.Label
	Private WithEvents cmbWmvAudioCodecs As System.Windows.Forms.ComboBox
	Private label24 As System.Windows.Forms.Label
	Private WithEvents cmbWmvVideoCodecs As System.Windows.Forms.ComboBox
	Private label25 As System.Windows.Forms.Label
	Private tabPageAvi As System.Windows.Forms.TabPage
	Private WithEvents cmbAviAudioCodecs As System.Windows.Forms.ComboBox
	Private WithEvents btnVideoCodecProps As System.Windows.Forms.Button
	Private label26 As System.Windows.Forms.Label
	Private WithEvents cmbAviVideoCodecs As System.Windows.Forms.ComboBox
	Private label27 As System.Windows.Forms.Label
	Private label9 As System.Windows.Forms.Label
	Private WithEvents tbBitrate As System.Windows.Forms.TextBox
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private label22 As System.Windows.Forms.Label
	Private WithEvents tbFPS As System.Windows.Forms.TextBox
	Private WithEvents lvInputFiles As System.Windows.Forms.ListView
	Private columnHeader1 As System.Windows.Forms.ColumnHeader
	Private columnHeader2 As System.Windows.Forms.ColumnHeader
	Private label28 As System.Windows.Forms.Label
	Private WithEvents cbPlayGeneratedFile As System.Windows.Forms.CheckBox
	Private statusStrip1 As System.Windows.Forms.StatusStrip
	Private toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
	Private toolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
	Private WithEvents nudSlideDuration As System.Windows.Forms.NumericUpDown
	Private WithEvents nudVisualEffectDuration As System.Windows.Forms.NumericUpDown
	Private WithEvents nudTransitionEffectBeforeDuration As System.Windows.Forms.NumericUpDown
	Private label12 As System.Windows.Forms.Label
	Private WithEvents nudTransitionEffectAfterDuration As System.Windows.Forms.NumericUpDown
	Private label14 As System.Windows.Forms.Label
	Private WithEvents cbTransitionEffectBeforeRandom As System.Windows.Forms.CheckBox
	Private WithEvents cbTransitionEffectAfterRandom As System.Windows.Forms.CheckBox
	Private linkVisitSDKHome As System.Windows.Forms.LinkLabel
End Class


```

<!-- code block end -->    

<!-- code block begin -->

##### ****MainForm.vb:**
    
```
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Threading
Imports System.Windows.Forms
Imports BytescoutImageToVideo
Imports ImageToVideoDemo.Properties

Public Partial Class MainForm
	Inherits Form
	Public Const WM_APP As Integer = &H8000
	Public Const WM_CONVERSION_PROGRESS As Integer = WM_APP + 1

	Private _imageToVideo As New ImageToVideo()
	Private _outputFile As String = ""
	Private _randomGenerator As New Random()

	Public Sub New()
		InitializeComponent()

		_imageToVideo.RegistrationName = "demo"
		_imageToVideo.RegistrationKey = "demo"

		AddHandler Application.Idle, AddressOf Application_Idle
	End Sub

	Protected Overrides Sub OnLoad(e As EventArgs)
		cbAutoFitImages.Checked = _imageToVideo.AutoFitImages
		cbKeepAspectRatio.Checked = _imageToVideo.KeepAspectRatio
		btnBackgroundColor.BackColor = ColorTranslator.FromOle(CInt(_imageToVideo.BackgroundColor))
		tbMovieWidth.Text = _imageToVideo.OutputWidth.ToString(CultureInfo.InvariantCulture)
		tbMovieHeight.Text = _imageToVideo.OutputHeight.ToString(CultureInfo.InvariantCulture)

		' Get list of available AVI audio codecs
		For i As Integer = 0 To _imageToVideo.AudioCodecsCount - 1
			cmbAviAudioCodecs.Items.Add(_imageToVideo.GetAudioCodecName(i))
		Next
		' Select current AVI audio codec
		cmbAviAudioCodecs.SelectedIndex = _imageToVideo.CurrentAudioCodec

		' Get list of available AVI video codecs
		For i As Integer = 0 To _imageToVideo.VideoCodecsCount - 1
			cmbAviVideoCodecs.Items.Add(_imageToVideo.GetVideoCodecName(i))
		Next
		' Select current AVI video codec
		cmbAviVideoCodecs.SelectedIndex = _imageToVideo.CurrentVideoCodec

		' Get list of available WMV audio codecs
		For i As Integer = 0 To _imageToVideo.WMVAudioCodecsCount - 1
			cmbWmvAudioCodecs.Items.Add(_imageToVideo.GetWMVAudioCodecName(i))
		Next
		' Select current WMV audio codec
		cmbWmvAudioCodecs.SelectedIndex = _imageToVideo.CurrentWMVAudioCodec

		' Get list of available WMV video codecs
		For i As Integer = 0 To _imageToVideo.WMVVideoCodecsCount - 1
			cmbWmvVideoCodecs.Items.Add(_imageToVideo.GetWMVVideoCodecName(i))
		Next
		' Select current WMV video codec
		cmbWmvVideoCodecs.SelectedIndex = _imageToVideo.CurrentWMVVideoCodec

		tbFPS.Text = _imageToVideo.FPS.ToString(CultureInfo.InvariantCulture)

		MyBase.OnLoad(e)
	End Sub

	Private Sub Application_Idle(sender As Object, e As EventArgs)
		Dim imageIsSelected As Boolean = lvInputFiles.SelectedIndices.Count > 0
		Dim imagesAdded As Boolean = lvInputFiles.Items.Count > 0

		btnMoveUp.Enabled = imageIsSelected
		btnMoveDown.Enabled = imageIsSelected
		btnRemove.Enabled = imageIsSelected
		btnRemoveAll.Enabled = imagesAdded

		nudSlideDuration.Enabled = imageIsSelected
		cmbSlideRotation.Enabled = imageIsSelected
		cmbVisualEffect.Enabled = imageIsSelected
		cmbVisualEffectTransition.Enabled = imageIsSelected
		nudVisualEffectDuration.Enabled = imageIsSelected
		cmbTransitionEffectBefore.Enabled = imageIsSelected AndAlso Not cbTransitionEffectBeforeRandom.Checked
		nudTransitionEffectBeforeDuration.Enabled = imageIsSelected
		cbTransitionEffectBeforeRandom.Enabled = imageIsSelected
		cmbTransitionEffectAfter.Enabled = imageIsSelected AndAlso Not cbTransitionEffectAfterRandom.Checked
		nudTransitionEffectAfterDuration.Enabled = imageIsSelected
		cbTransitionEffectAfterRandom.Enabled = imageIsSelected

		btnCreateMovie.Enabled = imagesAdded
	End Sub

	Private Sub btnAddImage_Click(sender As Object, e As EventArgs)
		Dim firstAddedItem As ListViewItem = Nothing

		Dim dlg As New OpenFileDialog()
		dlg.CheckFileExists = False
		dlg.CheckPathExists = False
		dlg.Filter = "Image Files(*.JPG;*.PNG;*.BMP)|*.JPG;*.JPEG;*.PNG;*.BMP;|JPEG Files(*.JPG)|*.JPG;*.JPEG|PNG Files(*.PNG)|*.PNG|BMP Files(*.BMP)|*.BMP|All files (*.*)|*.*"
		dlg.Multiselect = True
		dlg.SupportMultiDottedExtensions = True
		dlg.Title = "Select Files"

		If String.IsNullOrEmpty(Settings.Default.LastUsedFolder) Then
			Settings.Default.LastUsedFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
		End If

		dlg.InitialDirectory = Settings.Default.LastUsedFolder

		If dlg.ShowDialog() = DialogResult.OK Then
			Settings.Default.LastUsedFolder = Path.GetDirectoryName(dlg.FileNames(0))

			Cursor = Cursors.WaitCursor
			lvInputFiles.BeginUpdate()

			Try
				For Each file As String In dlg.FileNames
					Dim slideOptions As New SlideOptions()
					slideOptions.ImageFile = file

					Dim item As New ListViewItem(Convert.ToString(lvInputFiles.Items.Count + 1))
					item.SubItems.Add(Path.GetFileName(file))
					item.Tag = slideOptions

					lvInputFiles.Items.Add(item)

					If firstAddedItem Is Nothing Then
						firstAddedItem = item
					End If
				Next

				If firstAddedItem IsNot Nothing Then
					lvInputFiles.SelectedItems.Clear()
					firstAddedItem.Selected = True
					firstAddedItem.EnsureVisible()
				End If
			Finally
				lvInputFiles.EndUpdate()
				Cursor = Cursors.Default
			End Try

			lvInputFiles.Select()
		End If
	End Sub

	Private Sub btnAddFolder_Click(sender As Object, e As EventArgs)
		Dim dlg As New FolderBrowserDialog()

		dlg.Description = "Select Folder"
		dlg.ShowNewFolderButton = False

		If String.IsNullOrEmpty(Settings.Default.LastUsedFolder) Then
			Settings.Default.LastUsedFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
		End If

		dlg.SelectedPath = Settings.Default.LastUsedFolder

		If dlg.ShowDialog() = DialogResult.OK Then
			Settings.Default.LastUsedFolder = dlg.SelectedPath

			Dim dir As New DirectoryInfo(dlg.SelectedPath)
			Dim firstAddedItem As ListViewItem = Nothing

			Cursor = Cursors.WaitCursor
			Application.DoEvents()
			lvInputFiles.BeginUpdate()

			Try
				Dim files As FileInfo() = dir.GetFiles()

				For Each file As FileInfo In files
					Dim ext As String = file.Extension.ToLower()

					If ext = ".jpg" OrElse ext = ".jpeg" OrElse ext = ".png" OrElse ext = ".bmp" Then
						Dim slideOptions As New SlideOptions()
						slideOptions.ImageFile = file.FullName

						Dim item As New ListViewItem(Convert.ToString(lvInputFiles.Items.Count + 1))
						item.SubItems.Add(Path.GetFileName(file.FullName))
						item.Tag = slideOptions
						lvInputFiles.Items.Add(item)

						If firstAddedItem Is Nothing Then
							firstAddedItem = item
						End If
					End If
				Next

				If firstAddedItem IsNot Nothing Then
					lvInputFiles.SelectedItems.Clear()
					firstAddedItem.Selected = True
					firstAddedItem.EnsureVisible()
				End If
			Finally
				lvInputFiles.EndUpdate()
				Cursor = Cursors.Default
			End Try

			lvInputFiles.Select()
		End If
	End Sub

	Private Sub btnMoveUp_Click(sender As Object, e As EventArgs)
		Dim selectedItem As ListViewItem = lvInputFiles.SelectedItems(0)
		Dim x As Integer = selectedItem.Index

		If x > 0 Then
			lvInputFiles.BeginUpdate()

			Try
				lvInputFiles.Items.Remove(selectedItem)
				lvInputFiles.Items.Insert(x - 1, selectedItem)
				selectedItem.EnsureVisible()

				For Each item As ListViewItem In lvInputFiles.Items
					item.SubItems(0).Text = Convert.ToString(item.Index + 1)
				Next
			Finally
				lvInputFiles.EndUpdate()
			End Try
		End If

		lvInputFiles.Select()
	End Sub

	Private Sub btnMoveDown_Click(sender As Object, e As EventArgs)
		Dim selectedItem As ListViewItem = lvInputFiles.SelectedItems(0)
		Dim x As Integer = selectedItem.Index

		If x < lvInputFiles.Items.Count - 1 Then
			lvInputFiles.BeginUpdate()

			Try
				lvInputFiles.Items.Remove(selectedItem)
				lvInputFiles.Items.Insert(x + 1, selectedItem)
				selectedItem.EnsureVisible()

				For Each item As ListViewItem In lvInputFiles.Items
					item.SubItems(0).Text = Convert.ToString(item.Index + 1)
				Next
			Finally
				lvInputFiles.EndUpdate()
			End Try
		End If

		lvInputFiles.Select()
	End Sub

	Private Sub btnRemove_Click(sender As Object, e As EventArgs)
		Dim selectedItem As ListViewItem = lvInputFiles.SelectedItems(0)
		Dim x As Integer = selectedItem.Index

		lvInputFiles.BeginUpdate()

		Try
			lvInputFiles.Items.Remove(selectedItem)

			For Each item As ListViewItem In lvInputFiles.Items
				item.SubItems(0).Text = Convert.ToString(item.Index + 1)
			Next
		Finally
			lvInputFiles.EndUpdate()
		End Try

		If x > 0 Then
			lvInputFiles.Items(x - 1).Selected = True
		ElseIf x < lvInputFiles.Items.Count Then
			lvInputFiles.Items(x).Selected = True
		End If

		lvInputFiles.Select()
	End Sub

	Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs)
		lvInputFiles.BeginUpdate()

		Try
			lvInputFiles.Items.Clear()
			_imageToVideo.Slides.Clear()
		Finally
			lvInputFiles.EndUpdate()
		End Try
	End Sub

	Private Sub lvInputFiles_SelectedIndexChanged(sender As Object, e As EventArgs)
		RemoveHandler nudSlideDuration.ValueChanged, AddressOf nudSlideDuration_ValueChanged
		RemoveHandler cmbSlideRotation.SelectedIndexChanged, AddressOf cmbSlideRotation_SelectedIndexChanged
		RemoveHandler cmbVisualEffect.SelectedIndexChanged, AddressOf cmbVisualEffect_SelectedIndexChanged
		RemoveHandler cmbVisualEffectTransition.SelectedIndexChanged, AddressOf cmbVisualEffectTransition_SelectedIndexChanged
		RemoveHandler nudVisualEffectDuration.ValueChanged, AddressOf nudVisualEffectDuration_ValueChanged
		RemoveHandler cmbTransitionEffectBefore.SelectedIndexChanged, AddressOf cmbTransitionEffectBefore_SelectedIndexChanged
		RemoveHandler nudTransitionEffectBeforeDuration.ValueChanged, AddressOf nudTransitionEffectBeforeDuration_ValueChanged
		RemoveHandler cbTransitionEffectBeforeRandom.CheckedChanged, AddressOf cbTransitionEffectBeforeRandom_CheckedChanged
		RemoveHandler cmbTransitionEffectAfter.SelectedIndexChanged, AddressOf cmbTransitionEffectAfter_SelectedIndexChanged
		RemoveHandler nudTransitionEffectAfterDuration.ValueChanged, AddressOf nudTransitionEffectAfterDuration_ValueChanged
		RemoveHandler cbTransitionEffectAfterRandom.CheckedChanged, AddressOf cbTransitionEffectAfterRandom_CheckedChanged

		Dim selectedItems As ListView.SelectedListViewItemCollection = lvInputFiles.SelectedItems

		If selectedItems.Count > 0 Then
			Dim slideOptions As SlideOptions = DirectCast(selectedItems(0).Tag, SlideOptions)

			nudSlideDuration.Value = slideOptions.SlideDuration
			cmbSlideRotation.SelectedIndex = CInt(slideOptions.SlideRotation)
			cmbVisualEffect.SelectedIndex = CInt(slideOptions.VisualEffect)
			cmbVisualEffectTransition.SelectedIndex = CInt(slideOptions.VisualEffectTransition)
			nudVisualEffectDuration.Value = slideOptions.VisualEffectDuration
			cmbTransitionEffectBefore.SelectedIndex = CInt(slideOptions.TransitionEffectBefore) + 1
			nudTransitionEffectBeforeDuration.Value = slideOptions.TransitionEffectBeforeDuration
			cbTransitionEffectBeforeRandom.Checked = slideOptions.RandomTransitionEffectBefore
			cmbTransitionEffectAfter.SelectedIndex = CInt(slideOptions.TransitionEffectAfter) + 1
			nudTransitionEffectAfterDuration.Value = slideOptions.TransitionEffectAfterDuration
			cbTransitionEffectAfterRandom.Checked = slideOptions.RandomTransitionEffectAfter

			AddHandler nudSlideDuration.ValueChanged, AddressOf nudSlideDuration_ValueChanged
			AddHandler cmbSlideRotation.SelectedIndexChanged, AddressOf cmbSlideRotation_SelectedIndexChanged
			AddHandler cmbVisualEffect.SelectedIndexChanged, AddressOf cmbVisualEffect_SelectedIndexChanged
			AddHandler cmbVisualEffectTransition.SelectedIndexChanged, AddressOf cmbVisualEffectTransition_SelectedIndexChanged
			AddHandler nudVisualEffectDuration.ValueChanged, AddressOf nudVisualEffectDuration_ValueChanged
			AddHandler cmbTransitionEffectBefore.SelectedIndexChanged, AddressOf cmbTransitionEffectBefore_SelectedIndexChanged
			AddHandler nudTransitionEffectBeforeDuration.ValueChanged, AddressOf nudTransitionEffectBeforeDuration_ValueChanged
			AddHandler cbTransitionEffectBeforeRandom.CheckedChanged, AddressOf cbTransitionEffectBeforeRandom_CheckedChanged
			AddHandler cmbTransitionEffectAfter.SelectedIndexChanged, AddressOf cmbTransitionEffectAfter_SelectedIndexChanged
			AddHandler nudTransitionEffectAfterDuration.ValueChanged, AddressOf nudTransitionEffectAfterDuration_ValueChanged
			AddHandler cbTransitionEffectAfterRandom.CheckedChanged, AddressOf cbTransitionEffectAfterRandom_CheckedChanged
		End If
	End Sub

	Private Sub nudSlideDuration_ValueChanged(sender As Object, e As EventArgs)
		Dim slideOptions As SlideOptions = DirectCast(lvInputFiles.SelectedItems(0).Tag, SlideOptions)
		slideOptions.SlideDuration = CInt(Math.Truncate(nudSlideDuration.Value))
	End Sub

	Private Sub cmbSlideRotation_SelectedIndexChanged(sender As Object, e As EventArgs)
		Dim slideOptions As SlideOptions = DirectCast(lvInputFiles.SelectedItems(0).Tag, SlideOptions)
		slideOptions.SlideRotation = DirectCast(cmbSlideRotation.SelectedIndex, RotationAngle)
	End Sub

	Private Sub cmbVisualEffect_SelectedIndexChanged(sender As Object, e As EventArgs)
		Dim slideOptions As SlideOptions = DirectCast(lvInputFiles.SelectedItems(0).Tag, SlideOptions)
		slideOptions.VisualEffect = DirectCast(cmbVisualEffect.SelectedIndex, VisualEffectType)
	End Sub

	Private Sub cmbVisualEffectTransition_SelectedIndexChanged(sender As Object, e As EventArgs)
		Dim slideOptions As SlideOptions = DirectCast(lvInputFiles.SelectedItems(0).Tag, SlideOptions)
		slideOptions.VisualEffectTransition = DirectCast(cmbVisualEffectTransition.SelectedIndex, SlideEffectType)
	End Sub

	Private Sub nudVisualEffectDuration_ValueChanged(sender As Object, e As EventArgs)
		Dim slideOptions As SlideOptions = DirectCast(lvInputFiles.SelectedItems(0).Tag, SlideOptions)
		slideOptions.VisualEffectDuration = CInt(Math.Truncate(nudVisualEffectDuration.Value))
	End Sub

	Private Sub cmbTransitionEffectBefore_SelectedIndexChanged(sender As Object, e As EventArgs)
		Dim slideOptions As SlideOptions = DirectCast(lvInputFiles.SelectedItems(0).Tag, SlideOptions)
		slideOptions.TransitionEffectBefore = DirectCast(cmbTransitionEffectBefore.SelectedIndex - 1, TransitionEffectType)
	End Sub

	Private Sub nudTransitionEffectBeforeDuration_ValueChanged(sender As Object, e As EventArgs)
		Dim slideOptions As SlideOptions = DirectCast(lvInputFiles.SelectedItems(0).Tag, SlideOptions)
		slideOptions.TransitionEffectBeforeDuration = CInt(Math.Truncate(nudTransitionEffectBeforeDuration.Value))
	End Sub

	Private Sub cmbTransitionEffectAfter_SelectedIndexChanged(sender As Object, e As EventArgs)
		Dim slideOptions As SlideOptions = DirectCast(lvInputFiles.SelectedItems(0).Tag, SlideOptions)
		slideOptions.TransitionEffectAfter = DirectCast(cmbTransitionEffectAfter.SelectedIndex - 1, TransitionEffectType)
	End Sub

	Private Sub nudTransitionEffectAfterDuration_ValueChanged(sender As Object, e As EventArgs)
		Dim slideOptions As SlideOptions = DirectCast(lvInputFiles.SelectedItems(0).Tag, SlideOptions)
		slideOptions.TransitionEffectAfterDuration = CInt(Math.Truncate(nudTransitionEffectAfterDuration.Value))
	End Sub

	Private Sub cbTransitionEffectBeforeRandom_CheckedChanged(sender As Object, e As EventArgs)
		Dim slideOptions As SlideOptions = DirectCast(lvInputFiles.SelectedItems(0).Tag, SlideOptions)
		slideOptions.RandomTransitionEffectBefore = cbTransitionEffectBeforeRandom.Checked
	End Sub

	Private Sub cbTransitionEffectAfterRandom_CheckedChanged(sender As Object, e As EventArgs)
		Dim slideOptions As SlideOptions = DirectCast(lvInputFiles.SelectedItems(0).Tag, SlideOptions)
		slideOptions.RandomTransitionEffectAfter = cbTransitionEffectAfterRandom.Checked
	End Sub

	Private Sub btnVideoCodecProps_Click(sender As Object, e As EventArgs)
		Try
			_imageToVideo.ShowVideoCodecSettingsDialogModal(Handle.ToInt32())
		Catch generatedExceptionName As Exception
		End Try
	End Sub

	Private Sub cmbWmvAudioCodecs_SelectedIndexChanged(sender As Object, e As EventArgs)
		_imageToVideo.CurrentWMVAudioCodecName = cmbWmvAudioCodecs.SelectedItem.ToString()

		cmbWmvAudioFormats.Items.Clear()

		' Get list of available WMV audio formats
		For i As Integer = 0 To _imageToVideo.WMVAudioFormatCount - 1
			cmbWmvAudioFormats.Items.Add(_imageToVideo.GetWMVAudioFormatDescription(i))
		Next
		' Select current WMV audio format
		cmbWmvAudioFormats.SelectedIndex = _imageToVideo.CurrentWMVAudioFormat
	End Sub

	Protected Overrides Sub OnClosing(e As System.ComponentModel.CancelEventArgs)
		Settings.Default.Save()

		MyBase.OnClosing(e)
	End Sub

	Private Sub btnBackgroundImageBrowse_Click(sender As Object, e As EventArgs)
		Dim dlg As New OpenFileDialog()
		dlg.CheckFileExists = False
		dlg.CheckPathExists = False
		dlg.Multiselect = False
		dlg.Filter = "Image Files(*.JPG;*.PNG;*.BMP)|*.JPG;*.JPEG;*.PNG;*.BMP;|JPEG Files(*.JPG)|*.JPG;*.JPEG|PNG Files(*.PNG)|*.PNG|BMP Files(*.BMP)|*.BMP|All files (*.*)|*.*"
		dlg.Multiselect = True
		dlg.SupportMultiDottedExtensions = True
		dlg.Title = "Select background image"

		If String.IsNullOrEmpty(Settings.Default.LastUsedFolder) Then
			Settings.Default.LastUsedFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
		End If

		dlg.InitialDirectory = Settings.Default.LastUsedFolder

		If dlg.ShowDialog() = DialogResult.OK Then
			Settings.Default.LastUsedFolder = Path.GetDirectoryName(dlg.FileNames(0))
			tbBackgroundImage.Text = dlg.FileName
		End If
	End Sub

	Private Sub btnAudioTrackBrowse_Click(sender As Object, e As EventArgs)
		Dim dlg As New OpenFileDialog()
		dlg.CheckFileExists = False
		dlg.CheckPathExists = False
		dlg.Multiselect = False
		dlg.Filter = "Sound Files(*.MP3;*.WAV)|*.MP3;*.WAV|MP3 Files(*.MP3)|*.MP3|WAV Files(*.WAV)|*.WAV|All files (*.*)|*.*"
		dlg.Multiselect = True
		dlg.SupportMultiDottedExtensions = True
		dlg.Title = "Select background image"

		If String.IsNullOrEmpty(Settings.Default.LastUsedFolder) Then
			Settings.Default.LastUsedFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
		End If

		dlg.InitialDirectory = Settings.Default.LastUsedFolder

		If dlg.ShowDialog() = DialogResult.OK Then
			Settings.Default.LastUsedFolder = Path.GetDirectoryName(dlg.FileNames(0))
			tbAudioTrack.Text = dlg.FileName
		End If
	End Sub

	Private Sub btnBackgroundColor_Click(sender As Object, e As EventArgs)
		Dim colorDialog As New ColorDialog()
		colorDialog.Color = btnBackgroundColor.BackColor

		If colorDialog.ShowDialog() = DialogResult.OK Then
			btnBackgroundColor.BackColor = colorDialog.Color
		End If
	End Sub

	Protected Overrides Sub WndProc(ByRef m As Message)
		If m.HWnd = Handle AndAlso m.Msg = WM_CONVERSION_PROGRESS Then
			' Show progress
			Dim progress As Integer = m.WParam.ToInt32()
			toolStripProgressBar1.Value = progress

			' Finished!
			If progress = 100 AndAlso _imageToVideo.IsRunning Then
				' wait a bit the converter finished and released resources
				While _imageToVideo.IsRunning
					Thread.Sleep(200)
				End While

				toolStripStatusLabel1.Text = "Saved to file " & _outputFile
				btnCreateMovie.Text = "Create Movie"
				btnCreateMovie.Image = My.Resources.film
				toolStripProgressBar1.Value = 0

				' Open folder containing the generated file
				Process.Start("explorer.exe", "/select,""" & _outputFile & """")

				' Play generated file
				If cbPlayGeneratedFile.Checked Then
					Try
						Dim process As New Process()
						process.StartInfo.FileName = _outputFile
						process.StartInfo.UseShellExecute = True
						process.Start()
					Catch
					End Try
				End If
			End If
		End If

		MyBase.WndProc(m)
	End Sub

	Private Sub btnCreateMovie_Click(sender As Object, e As EventArgs)
		If Not _imageToVideo.IsRunning Then
			Dim dlg As New SaveFileDialog()
			dlg.Filter = "WMV files (*.wmv)|*.wmv|AVI files (*.avi)|*.avi|All files (*.*)|*.*"

			If tabControl2.SelectedIndex = 0 Then
				dlg.DefaultExt = "*.wmv"
				dlg.FilterIndex = 1
			Else
				dlg.DefaultExt = "*.avi"
				dlg.FilterIndex = 2
			End If

			dlg.FileName = "movie"
			dlg.Title = "Save generated video as"

			If String.IsNullOrEmpty(Settings.Default.LastUsedFolder2) Then
				Settings.Default.LastUsedFolder2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
			End If

			dlg.InitialDirectory = Settings.Default.LastUsedFolder2

			If dlg.ShowDialog() = DialogResult.OK Then
				Settings.Default.LastUsedFolder2 = Path.GetDirectoryName(dlg.FileName)

				Dim intValue As Integer
				Dim floatValue As Single

				_imageToVideo.AutoFitImages = cbAutoFitImages.Checked
				_imageToVideo.KeepAspectRatio = cbKeepAspectRatio.Checked
				_imageToVideo.BackgroundColor = CUInt(ColorTranslator.ToOle(btnBackgroundColor.BackColor))

				If tbBackgroundImage.Text.Length > 0 Then
					_imageToVideo.SetBackgroundPictureFileName(tbBackgroundImage.Text)
				End If

				If Integer.TryParse(tbMovieWidth.Text, intValue) Then
					_imageToVideo.OutputWidth = intValue
				End If
				If Integer.TryParse(tbMovieHeight.Text, intValue) Then
					_imageToVideo.OutputHeight = intValue
				End If

				If tbAudioTrack.Text.Length > 0 Then
					_imageToVideo.ExternalAudioTrackFromFileName = tbAudioTrack.Text
				End If

				_imageToVideo.CurrentAudioCodec = cmbAviAudioCodecs.SelectedIndex
				_imageToVideo.CurrentVideoCodec = cmbAviVideoCodecs.SelectedIndex
				_imageToVideo.CurrentWMVAudioCodec = cmbWmvAudioCodecs.SelectedIndex
				_imageToVideo.CurrentWMVAudioFormat = cmbWmvAudioFormats.SelectedIndex
				_imageToVideo.CurrentWMVVideoCodec = cmbWmvVideoCodecs.SelectedIndex

				If Integer.TryParse(tbBitrate.Text, intValue) Then
					_imageToVideo.WMVVideoBitrate = intValue * 1024
				End If

				If Single.TryParse(tbFPS.Text, floatValue) Then
					_imageToVideo.FPS = floatValue
				End If

				_outputFile = dlg.FileName
				_imageToVideo.OutputVideoFileName = _outputFile
				_imageToVideo.SetProgressNotifyWindow(Handle.ToInt32(), WM_CONVERSION_PROGRESS, 0)

				_imageToVideo.Slides.Clear()

				For Each item As ListViewItem In lvInputFiles.Items
					Dim slideInfo As SlideOptions = DirectCast(item.Tag, SlideOptions)
					Dim slide As Slide = _imageToVideo.AddImageFromFileName(slideInfo.ImageFile)
					slide.Duration = slideInfo.SlideDuration
					slide.RotationAngle = slideInfo.SlideRotation
					slide.VisualEffect = slideInfo.VisualEffect
					slide.Effect = slideInfo.VisualEffectTransition
					slide.EffectDuration = slideInfo.VisualEffectDuration
					slide.InEffect = CType(IIf(slideInfo.RandomTransitionEffectBefore, GetRandomEffect(), slideInfo.TransitionEffectBefore), TransitionEffectType)
					slide.InEffectDuration = slideInfo.TransitionEffectBeforeDuration
					slide.OutEffect = CType(IIf(slideInfo.RandomTransitionEffectAfter, GetRandomEffect(), slideInfo.TransitionEffectAfter), TransitionEffectType)
					slide.OutEffectDuration = slideInfo.TransitionEffectAfterDuration
				Next

				_imageToVideo.Run()

				toolStripStatusLabel1.Text = "Generating video..."
				btnCreateMovie.Text = "Stop"
				btnCreateMovie.Image = My.Resources._stop
			End If
		Else
			' Stop generation
			_imageToVideo.Stop()

			' wait a bit the converter finished and released resources
			While _imageToVideo.IsRunning
				Thread.Sleep(200)
			End While

			toolStripStatusLabel1.Text = "Interrupted by user."
			btnCreateMovie.Text = "Create Movie"
			btnCreateMovie.Image = My.Resources.film
			toolStripProgressBar1.Value = 0
		End If
	End Sub

	Private Function GetRandomEffect() As TransitionEffectType
		Return DirectCast(_randomGenerator.Next(0, 140), TransitionEffectType)
	End Function

	Private Sub linkVisitSDKHome_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
		Try
			Dim process As New Process()
			process.StartInfo.FileName = "http://bytescout.com/products/developer/imagetovideosdk/imagetovideosdk.html"
			process.StartInfo.UseShellExecute = True
			process.Start()
		Catch exception As Exception
			MessageBox.Show(exception.Message)
		End Try
	End Sub
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.vb:**
    
```
Imports System.Collections.Generic
Imports System.Windows.Forms

NotInheritable Class Program
	Private Sub New()
	End Sub
	''' <summary>
	''' The main entry point for the application.
	''' </summary>
	<STAThread> _
	Friend Shared Sub Main()
		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)
		Application.Run(New MainForm())
	End Sub
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****SlideOptions.vb:**
    
```
Imports System.Collections.Generic
Imports System.Text
Imports BytescoutImageToVideo

Public Class SlideOptions
	' Image file path
	Public ImageFile As String

	' Slide properties
	Public SlideDuration As Integer = 3000
	Public SlideRotation As RotationAngle = RotationAngle.raNone
	Public VisualEffect As VisualEffectType = VisualEffectType.veNone
	Public VisualEffectTransition As SlideEffectType = SlideEffectType.seNone
	Public VisualEffectDuration As Integer = 1000
	Public TransitionEffectBefore As TransitionEffectType = TransitionEffectType.teNone
	Public TransitionEffectBeforeDuration As Integer = 1000
	Public RandomTransitionEffectBefore As Boolean = True
	Public TransitionEffectAfter As TransitionEffectType = TransitionEffectType.teNone
	Public TransitionEffectAfterDuration As Integer = 1000
	Public RandomTransitionEffectAfter As Boolean = True
End Class

```

<!-- code block end -->