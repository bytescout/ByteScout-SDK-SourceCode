## full featured demo in C# using ByteScout Image To Video SDK

### Write code in C# to make full featured demo with this How-To tutorial

Sample source codes below will show you how to cope with a difficult task, for example, full featured demo in C#. ByteScout Image To Video SDK helps with full featured demo in C#. ByteScout Image To Video SDK is the library for conversion of images into video slideshow. Provides built-in support for more than hundred of 2D and 3D transition effects. Output formats supported are AVI,WMV and WEBM video files. You may adjust output video size, quality, framerate and add audio.

Fast application programming interfaces of ByteScout Image To Video SDK for C# plus the instruction and the C# code below will help you quickly learn full featured demo. To do full featured demo in your C# project or application you may simply copy & paste the code and then run your app! This basic programming language sample code for C# will do the whole work for you in implementing full featured demo in your app.

Our website provides free trial version of ByteScout Image To Video SDK. It comes along with all these source code samples with the goal to help you with your C# application implementation.

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

##### ****ImageToVideoDemo.VS2005.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{1A229BF3-0BD1-4642-9E7E-DD7EBAA0D35C}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ImageToVideoDemo</RootNamespace>
    <AssemblyName>ImageToVideoDemo</AssemblyName>
    <ApplicationIcon>app.ico</ApplicationIcon>
    <SignAssembly>true</SignAssembly>
    <AssemblyOriginatorKeyFile>key.snk</AssemblyOriginatorKeyFile>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
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
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="MainForm.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="MainForm.Designer.cs">
      <DependentUpon>MainForm.cs</DependentUpon>
    </Compile>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
    <EmbeddedResource Include="MainForm.resx">
      <SubType>Designer</SubType>
      <DependentUpon>MainForm.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>ResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.cs</LastGenOutput>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <Compile Include="Properties\Resources.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
      <DesignTime>True</DesignTime>
    </Compile>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.cs</LastGenOutput>
    </None>
    <Compile Include="Properties\Settings.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
    <Compile Include="SlideOptions.cs" />
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
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\add.png" />
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\arrow_up.png" />
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\arrow_down.png" />
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\delete.png" />
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\bin_closed.png" />
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\film.png" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="app.ico" />
    <None Include="key.snk" />
    <None Include="Resources\stop.png" />
    <None Include="Resources\wrench.png" />
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.CSharp.targets" />
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

##### ****ImageToVideoDemo.VS2008.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="3.5">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.21022</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{1A229BF3-0BD1-4642-9E7E-DD7EBAA0D35C}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ImageToVideoDemo</RootNamespace>
    <AssemblyName>ImageToVideoDemo</AssemblyName>
    <ApplicationIcon>app.ico</ApplicationIcon>
    <OldToolsVersion>2.0</OldToolsVersion>
    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
    <SignAssembly>true</SignAssembly>
    <AssemblyOriginatorKeyFile>key.snk</AssemblyOriginatorKeyFile>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
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
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="MainForm.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="MainForm.Designer.cs">
      <DependentUpon>MainForm.cs</DependentUpon>
    </Compile>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
    <EmbeddedResource Include="MainForm.resx">
      <SubType>Designer</SubType>
      <DependentUpon>MainForm.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>ResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.cs</LastGenOutput>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <Compile Include="Properties\Resources.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
      <DesignTime>True</DesignTime>
    </Compile>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.cs</LastGenOutput>
    </None>
    <Compile Include="Properties\Settings.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
    <Compile Include="SlideOptions.cs" />
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
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\add.png" />
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\arrow_up.png" />
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\arrow_down.png" />
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\delete.png" />
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\bin_closed.png" />
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\film.png" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="app.ico" />
    <None Include="key.snk" />
    <None Include="Resources\stop.png" />
    <None Include="Resources\wrench.png" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
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

##### ****ImageToVideoDemo.VS2010.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{1A229BF3-0BD1-4642-9E7E-DD7EBAA0D35C}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ImageToVideoDemo</RootNamespace>
    <AssemblyName>ImageToVideoDemo</AssemblyName>
    <ApplicationIcon>app.ico</ApplicationIcon>
    <OldToolsVersion>3.5</OldToolsVersion>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <SignAssembly>true</SignAssembly>
    <AssemblyOriginatorKeyFile>key.snk</AssemblyOriginatorKeyFile>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
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
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="MainForm.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="MainForm.Designer.cs">
      <DependentUpon>MainForm.cs</DependentUpon>
    </Compile>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
    <EmbeddedResource Include="MainForm.resx">
      <SubType>Designer</SubType>
      <DependentUpon>MainForm.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>ResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.cs</LastGenOutput>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <Compile Include="Properties\Resources.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
      <DesignTime>True</DesignTime>
    </Compile>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.cs</LastGenOutput>
    </None>
    <Compile Include="Properties\Settings.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
    <Compile Include="SlideOptions.cs" />
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
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\add.png" />
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\arrow_up.png" />
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\arrow_down.png" />
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\delete.png" />
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\bin_closed.png" />
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\film.png" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="app.ico" />
    <None Include="key.snk" />
    <None Include="Resources\stop.png" />
    <None Include="Resources\wrench.png" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
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

##### ****MainForm.Designer.cs:**
    
```
namespace ImageToVideoDemo
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lvInputFiles = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.btnMoveDown = new System.Windows.Forms.Button();
			this.btnMoveUp = new System.Windows.Forms.Button();
			this.btnRemoveAll = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnAddFolder = new System.Windows.Forms.Button();
			this.btnAddImage = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbMovieWidth = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbMovieHeight = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbVisualEffect = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbSlideRotation = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.nudTransitionEffectAfterDuration = new System.Windows.Forms.NumericUpDown();
			this.label14 = new System.Windows.Forms.Label();
			this.nudTransitionEffectBeforeDuration = new System.Windows.Forms.NumericUpDown();
			this.label12 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.cmbTransitionEffectAfter = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.cmbTransitionEffectBefore = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.tbBackgroundImage = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.btnBackgroundImageBrowse = new System.Windows.Forms.Button();
			this.btnAudioTrackBrowse = new System.Windows.Forms.Button();
			this.tbAudioTrack = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.nudVisualEffectDuration = new System.Windows.Forms.NumericUpDown();
			this.label20 = new System.Windows.Forms.Label();
			this.cmbVisualEffectTransition = new System.Windows.Forms.ComboBox();
			this.label21 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.nudSlideDuration = new System.Windows.Forms.NumericUpDown();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label22 = new System.Windows.Forms.Label();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPageWmv = new System.Windows.Forms.TabPage();
			this.label28 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tbBitrate = new System.Windows.Forms.TextBox();
			this.cmbWmvAudioFormats = new System.Windows.Forms.ComboBox();
			this.label23 = new System.Windows.Forms.Label();
			this.cmbWmvAudioCodecs = new System.Windows.Forms.ComboBox();
			this.label24 = new System.Windows.Forms.Label();
			this.cmbWmvVideoCodecs = new System.Windows.Forms.ComboBox();
			this.label25 = new System.Windows.Forms.Label();
			this.tabPageAvi = new System.Windows.Forms.TabPage();
			this.cmbAviAudioCodecs = new System.Windows.Forms.ComboBox();
			this.label26 = new System.Windows.Forms.Label();
			this.cmbAviVideoCodecs = new System.Windows.Forms.ComboBox();
			this.label27 = new System.Windows.Forms.Label();
			this.btnVideoCodecProps = new System.Windows.Forms.Button();
			this.tbFPS = new System.Windows.Forms.TextBox();
			this.btnBackgroundColor = new System.Windows.Forms.Button();
			this.cbKeepAspectRatio = new System.Windows.Forms.CheckBox();
			this.cbAutoFitImages = new System.Windows.Forms.CheckBox();
			this.cbPlayGeneratedFile = new System.Windows.Forms.CheckBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.btnCreateMovie = new System.Windows.Forms.Button();
			this.cbTransitionEffectBeforeRandom = new System.Windows.Forms.CheckBox();
			this.cbTransitionEffectAfterRandom = new System.Windows.Forms.CheckBox();
			this.linkVisitSDKHome = new System.Windows.Forms.LinkLabel();
			this.groupBox1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.nudTransitionEffectAfterDuration)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.nudTransitionEffectBeforeDuration)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.nudVisualEffectDuration)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.nudSlideDuration)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.tabPageWmv.SuspendLayout();
			this.tabPageAvi.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.Controls.Add(this.lvInputFiles);
			this.groupBox1.Controls.Add(this.btnMoveDown);
			this.groupBox1.Controls.Add(this.btnMoveUp);
			this.groupBox1.Controls.Add(this.btnRemoveAll);
			this.groupBox1.Controls.Add(this.btnRemove);
			this.groupBox1.Controls.Add(this.btnAddFolder);
			this.groupBox1.Controls.Add(this.btnAddImage);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(285, 424);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Input Images";
			// 
			// lvInputFiles
			// 
			this.lvInputFiles.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lvInputFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.lvInputFiles.FullRowSelect = true;
			this.lvInputFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvInputFiles.HideSelection = false;
			this.lvInputFiles.Location = new System.Drawing.Point(6, 19);
			this.lvInputFiles.MultiSelect = false;
			this.lvInputFiles.Name = "lvInputFiles";
			this.lvInputFiles.Size = new System.Drawing.Size(172, 398);
			this.lvInputFiles.TabIndex = 7;
			this.lvInputFiles.UseCompatibleStateImageBehavior = false;
			this.lvInputFiles.View = System.Windows.Forms.View.Details;
			this.lvInputFiles.SelectedIndexChanged += new System.EventHandler(this.lvInputFiles_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "#";
			this.columnHeader1.Width = 30;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "File";
			this.columnHeader2.Width = 120;
			// 
			// btnMoveDown
			// 
			this.btnMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMoveDown.Image = global::ImageToVideoDemo.Properties.Resources.arrow_down;
			this.btnMoveDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMoveDown.Location = new System.Drawing.Point(184, 119);
			this.btnMoveDown.Name = "btnMoveDown";
			this.btnMoveDown.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.btnMoveDown.Size = new System.Drawing.Size(95, 24);
			this.btnMoveDown.TabIndex = 4;
			this.btnMoveDown.Text = "Move Down";
			this.btnMoveDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnMoveDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMoveDown.UseVisualStyleBackColor = true;
			this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
			// 
			// btnMoveUp
			// 
			this.btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMoveUp.Image = global::ImageToVideoDemo.Properties.Resources.arrow_up;
			this.btnMoveUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMoveUp.Location = new System.Drawing.Point(184, 89);
			this.btnMoveUp.Name = "btnMoveUp";
			this.btnMoveUp.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.btnMoveUp.Size = new System.Drawing.Size(95, 24);
			this.btnMoveUp.TabIndex = 3;
			this.btnMoveUp.Text = "Move Up";
			this.btnMoveUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnMoveUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMoveUp.UseVisualStyleBackColor = true;
			this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
			// 
			// btnRemoveAll
			// 
			this.btnRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemoveAll.Image = global::ImageToVideoDemo.Properties.Resources.bin_closed;
			this.btnRemoveAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemoveAll.Location = new System.Drawing.Point(184, 190);
			this.btnRemoveAll.Name = "btnRemoveAll";
			this.btnRemoveAll.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.btnRemoveAll.Size = new System.Drawing.Size(95, 24);
			this.btnRemoveAll.TabIndex = 6;
			this.btnRemoveAll.Text = "Remove All";
			this.btnRemoveAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRemoveAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRemoveAll.UseVisualStyleBackColor = true;
			this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemove.Image = global::ImageToVideoDemo.Properties.Resources.delete;
			this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemove.Location = new System.Drawing.Point(184, 160);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.btnRemove.Size = new System.Drawing.Size(95, 24);
			this.btnRemove.TabIndex = 5;
			this.btnRemove.Text = "Remove";
			this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnAddFolder
			// 
			this.btnAddFolder.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddFolder.Image = global::ImageToVideoDemo.Properties.Resources.add;
			this.btnAddFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddFolder.Location = new System.Drawing.Point(184, 49);
			this.btnAddFolder.Name = "btnAddFolder";
			this.btnAddFolder.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.btnAddFolder.Size = new System.Drawing.Size(95, 24);
			this.btnAddFolder.TabIndex = 2;
			this.btnAddFolder.Text = "Add Folder";
			this.btnAddFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAddFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAddFolder.UseVisualStyleBackColor = true;
			this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
			// 
			// btnAddImage
			// 
			this.btnAddImage.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddImage.Image = global::ImageToVideoDemo.Properties.Resources.add;
			this.btnAddImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddImage.Location = new System.Drawing.Point(184, 19);
			this.btnAddImage.Name = "btnAddImage";
			this.btnAddImage.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.btnAddImage.Size = new System.Drawing.Size(95, 24);
			this.btnAddImage.TabIndex = 1;
			this.btnAddImage.Text = "Add Image";
			this.btnAddImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAddImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAddImage.UseVisualStyleBackColor = true;
			this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Duration";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(145, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(20, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "ms";
			// 
			// tbMovieWidth
			// 
			this.tbMovieWidth.Location = new System.Drawing.Point(109, 108);
			this.tbMovieWidth.Name = "tbMovieWidth";
			this.tbMovieWidth.Size = new System.Drawing.Size(40, 20);
			this.tbMovieWidth.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Movie Width";
			// 
			// tbMovieHeight
			// 
			this.tbMovieHeight.Location = new System.Drawing.Point(109, 134);
			this.tbMovieHeight.Name = "tbMovieHeight";
			this.tbMovieHeight.Size = new System.Drawing.Size(40, 20);
			this.tbMovieHeight.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 137);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Movie Height";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(155, 111);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(18, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "px";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(155, 137);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(18, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "px";
			// 
			// cmbVisualEffect
			// 
			this.cmbVisualEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbVisualEffect.FormattingEnabled = true;
			this.cmbVisualEffect.Items.AddRange(new object[] {
            "None",
            "Grayscale",
            "Sepia"});
			this.cmbVisualEffect.Location = new System.Drawing.Point(78, 19);
			this.cmbVisualEffect.Name = "cmbVisualEffect";
			this.cmbVisualEffect.Size = new System.Drawing.Size(180, 21);
			this.cmbVisualEffect.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 22);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "Effect";
			// 
			// cmbSlideRotation
			// 
			this.cmbSlideRotation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSlideRotation.FormattingEnabled = true;
			this.cmbSlideRotation.Items.AddRange(new object[] {
            "0",
            "90",
            "180",
            "270"});
			this.cmbSlideRotation.Location = new System.Drawing.Point(84, 37);
			this.cmbSlideRotation.Name = "cmbSlideRotation";
			this.cmbSlideRotation.Size = new System.Drawing.Size(55, 21);
			this.cmbSlideRotation.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 40);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(47, 13);
			this.label8.TabIndex = 6;
			this.label8.Text = "Rotation";
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.cbTransitionEffectAfterRandom);
			this.groupBox4.Controls.Add(this.cbTransitionEffectBeforeRandom);
			this.groupBox4.Controls.Add(this.nudTransitionEffectAfterDuration);
			this.groupBox4.Controls.Add(this.label14);
			this.groupBox4.Controls.Add(this.nudTransitionEffectBeforeDuration);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.label15);
			this.groupBox4.Controls.Add(this.cmbTransitionEffectAfter);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Controls.Add(this.cmbTransitionEffectBefore);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Location = new System.Drawing.Point(6, 172);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(439, 132);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Transition Effects";
			// 
			// nudTransitionEffectAfterDuration
			// 
			this.nudTransitionEffectAfterDuration.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.nudTransitionEffectAfterDuration.Location = new System.Drawing.Point(78, 100);
			this.nudTransitionEffectAfterDuration.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
			this.nudTransitionEffectAfterDuration.Name = "nudTransitionEffectAfterDuration";
			this.nudTransitionEffectAfterDuration.Size = new System.Drawing.Size(55, 20);
			this.nudTransitionEffectAfterDuration.TabIndex = 20;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(139, 102);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(20, 13);
			this.label14.TabIndex = 21;
			this.label14.Text = "ms";
			// 
			// nudTransitionEffectBeforeDuration
			// 
			this.nudTransitionEffectBeforeDuration.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.nudTransitionEffectBeforeDuration.Location = new System.Drawing.Point(78, 47);
			this.nudTransitionEffectBeforeDuration.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
			this.nudTransitionEffectBeforeDuration.Name = "nudTransitionEffectBeforeDuration";
			this.nudTransitionEffectBeforeDuration.Size = new System.Drawing.Size(55, 20);
			this.nudTransitionEffectBeforeDuration.TabIndex = 18;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(139, 49);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(20, 13);
			this.label12.TabIndex = 19;
			this.label12.Text = "ms";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(6, 102);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(47, 13);
			this.label15.TabIndex = 12;
			this.label15.Text = "Duration";
			// 
			// cmbTransitionEffectAfter
			// 
			this.cmbTransitionEffectAfter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTransitionEffectAfter.Items.AddRange(new object[] {
            "None",
            "Simple Fade",
            "Wipe Left",
            "Wipe Right",
            "Wipe Up",
            "Wipe Down",
            "Wipe Top Left",
            "Wipe Top Right",
            "Wipe Bottom Left",
            "Wipe Bottom Right",
            "Cover Left",
            "Cover Right",
            "Cover Up",
            "Cover Down",
            "Cover Left Up",
            "Cover Left Down",
            "Cover Right Up",
            "Cover Right Down",
            "Uncover Left",
            "Uncover Right",
            "Uncover Up",
            "Uncover Down",
            "Uncover Left Up",
            "Uncover Left Down",
            "Uncover Right Up",
            "Uncover Right Down",
            "Uncover Push Left",
            "Uncover Push Right",
            "Uncover Push Up",
            "Uncover Push Down",
            "Box In",
            "Box Out",
            "Wheel 1",
            "Wheel 2",
            "Wheel 3",
            "Wheel 4",
            "Wheel 5",
            "Wheel 6",
            "Wheel 7",
            "Wheel 8",
            "Horz Blinds 5",
            "Horz Blinds 10",
            "Horz Blinds 20",
            "Vert Blinds 5",
            "Vert Blinds 10",
            "Vert Blinds 20",
            "Strip Left Up",
            "Strip Left Down",
            "Strip Right Up",
            "Strip Right Down",
            "Shape Circle",
            "Shape Plus",
            "Shape Diamond",
            "Shape Checks Horz",
            "Shape Checks Vert",
            "Split Horz In",
            "Split Horz Out",
            "Split Vert In",
            "Split Vert Out",
            "Wedge",
            "Clock Clockwise",
            "Clock Counterclockwise",
            "Cut",
            "Cut Through Black",
            "Random Bars Horz",
            "Random Bars Vert",
            "Fade",
            "News Flash",
            "Dissolve",
            "Switch Left",
            "Switch Right",
            "Box 3D Left",
            "Box 3D Right",
            "Box 3D Up",
            "Box 3D Down",
            "Cube Left",
            "Cube Right",
            "Cube Up",
            "Cube Down",
            "Flip Left",
            "Flip Right",
            "Ripple Top Left",
            "Ripple Top Right",
            "Ripple Bottom Left",
            "Ripple Bottom Right",
            "Ripple Center",
            "Gallery Left",
            "Gallery Right",
            "Zoom In",
            "Zoom Out",
            "Doors Horz",
            "Doors Vert",
            "Windows Horz",
            "Windows Vert",
            "Fade Through Black",
            "Honeycomb",
            "Blinds 3D Horz",
            "Blinds 3D Vert",
            "Checker Board 3D Horz",
            "Checker Board 3D Vert",
            "Comb Horizontal",
            "Comb Vertical",
            "Glitter Left",
            "Glitter Right",
            "Glitter Up",
            "Glitter Down",
            "Glitter Diamond Left",
            "Glitter Diamond Right",
            "Glitter Diamond Up",
            "Glitter Diamond Down",
            "Shred Strip In",
            "Shred Strip Out",
            "Shred Particle In",
            "Shred Particle Out",
            "Vortex Left",
            "Vortex Right",
            "Vortex Up",
            "Vortex Down",
            "Reveal Left",
            "Reveal Right",
            "Reveal Through Black Left",
            "Reveal Through Black Right",
            "Cover 3D Left",
            "Cover 3D Right",
            "Cover 3D Up",
            "Cover 3D Down",
            "Cover 3D Left Up",
            "Cover 3D Left Down",
            "Cover 3D Right Up",
            "Cover 3D Right Down",
            "Uncover 3D Left",
            "Uncover 3D Right",
            "Uncover 3D Up",
            "Uncover 3D Down",
            "Uncover 3D Left Up",
            "Uncover 3D Left Down",
            "Uncover 3D Right Up",
            "Uncover 3D Right Down",
            "Flash",
            "Fly Through",
            "Orbit",
            "Rotate"});
			this.cmbTransitionEffectAfter.Location = new System.Drawing.Point(78, 73);
			this.cmbTransitionEffectAfter.MaxDropDownItems = 16;
			this.cmbTransitionEffectAfter.Name = "cmbTransitionEffectAfter";
			this.cmbTransitionEffectAfter.Size = new System.Drawing.Size(180, 21);
			this.cmbTransitionEffectAfter.TabIndex = 2;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(6, 49);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(47, 13);
			this.label13.TabIndex = 9;
			this.label13.Text = "Duration";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 76);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(29, 13);
			this.label11.TabIndex = 10;
			this.label11.Text = "After";
			// 
			// cmbTransitionEffectBefore
			// 
			this.cmbTransitionEffectBefore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTransitionEffectBefore.Items.AddRange(new object[] {
            "None",
            "Simple Fade",
            "Wipe Left",
            "Wipe Right",
            "Wipe Up",
            "Wipe Down",
            "Wipe Top Left",
            "Wipe Top Right",
            "Wipe Bottom Left",
            "Wipe Bottom Right",
            "Cover Left",
            "Cover Right",
            "Cover Up",
            "Cover Down",
            "Cover Left Up",
            "Cover Left Down",
            "Cover Right Up",
            "Cover Right Down",
            "Uncover Left",
            "Uncover Right",
            "Uncover Up",
            "Uncover Down",
            "Uncover Left Up",
            "Uncover Left Down",
            "Uncover Right Up",
            "Uncover Right Down",
            "Uncover Push Left",
            "Uncover Push Right",
            "Uncover Push Up",
            "Uncover Push Down",
            "Box In",
            "Box Out",
            "Wheel 1",
            "Wheel 2",
            "Wheel 3",
            "Wheel 4",
            "Wheel 5",
            "Wheel 6",
            "Wheel 7",
            "Wheel 8",
            "Horz Blinds 5",
            "Horz Blinds 10",
            "Horz Blinds 20",
            "Vert Blinds 5",
            "Vert Blinds 10",
            "Vert Blinds 20",
            "Strip Left Up",
            "Strip Left Down",
            "Strip Right Up",
            "Strip Right Down",
            "Shape Circle",
            "Shape Plus",
            "Shape Diamond",
            "Shape Checks Horz",
            "Shape Checks Vert",
            "Split Horz In",
            "Split Horz Out",
            "Split Vert In",
            "Split Vert Out",
            "Wedge",
            "Clock Clockwise",
            "Clock Counterclockwise",
            "Cut",
            "Cut Through Black",
            "Random Bars Horz",
            "Random Bars Vert",
            "Fade",
            "News Flash",
            "Dissolve",
            "Switch Left",
            "Switch Right",
            "Box 3D Left",
            "Box 3D Right",
            "Box 3D Up",
            "Box 3D Down",
            "Cube Left",
            "Cube Right",
            "Cube Up",
            "Cube Down",
            "Flip Left",
            "Flip Right",
            "Ripple Top Left",
            "Ripple Top Right",
            "Ripple Bottom Left",
            "Ripple Bottom Right",
            "Ripple Center",
            "Gallery Left",
            "Gallery Right",
            "Zoom In",
            "Zoom Out",
            "Doors Horz",
            "Doors Vert",
            "Windows Horz",
            "Windows Vert",
            "Fade Through Black",
            "Honeycomb",
            "Blinds 3D Horz",
            "Blinds 3D Vert",
            "Checker Board 3D Horz",
            "Checker Board 3D Vert",
            "Comb Horizontal",
            "Comb Vertical",
            "Glitter Left",
            "Glitter Right",
            "Glitter Up",
            "Glitter Down",
            "Glitter Diamond Left",
            "Glitter Diamond Right",
            "Glitter Diamond Up",
            "Glitter Diamond Down",
            "Shred Strip In",
            "Shred Strip Out",
            "Shred Particle In",
            "Shred Particle Out",
            "Vortex Left",
            "Vortex Right",
            "Vortex Up",
            "Vortex Down",
            "Reveal Left",
            "Reveal Right",
            "Reveal Through Black Left",
            "Reveal Through Black Right",
            "Cover 3D Left",
            "Cover 3D Right",
            "Cover 3D Up",
            "Cover 3D Down",
            "Cover 3D Left Up",
            "Cover 3D Left Down",
            "Cover 3D Right Up",
            "Cover 3D Right Down",
            "Uncover 3D Left",
            "Uncover 3D Right",
            "Uncover 3D Up",
            "Uncover 3D Down",
            "Uncover 3D Left Up",
            "Uncover 3D Left Down",
            "Uncover 3D Right Up",
            "Uncover 3D Right Down",
            "Flash",
            "Fly Through",
            "Orbit",
            "Rotate"});
			this.cmbTransitionEffectBefore.Location = new System.Drawing.Point(78, 19);
			this.cmbTransitionEffectBefore.MaxDropDownItems = 16;
			this.cmbTransitionEffectBefore.Name = "cmbTransitionEffectBefore";
			this.cmbTransitionEffectBefore.Size = new System.Drawing.Size(180, 21);
			this.cmbTransitionEffectBefore.TabIndex = 0;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 22);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(38, 13);
			this.label10.TabIndex = 9;
			this.label10.Text = "Before";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(6, 60);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(92, 13);
			this.label16.TabIndex = 15;
			this.label16.Text = "Background Color";
			// 
			// tbBackgroundImage
			// 
			this.tbBackgroundImage.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbBackgroundImage.Location = new System.Drawing.Point(109, 82);
			this.tbBackgroundImage.Name = "tbBackgroundImage";
			this.tbBackgroundImage.ReadOnly = true;
			this.tbBackgroundImage.Size = new System.Drawing.Size(306, 20);
			this.tbBackgroundImage.TabIndex = 3;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(6, 85);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(97, 13);
			this.label17.TabIndex = 9;
			this.label17.Text = "Background Image";
			// 
			// btnBackgroundImageBrowse
			// 
			this.btnBackgroundImageBrowse.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBackgroundImageBrowse.Location = new System.Drawing.Point(421, 80);
			this.btnBackgroundImageBrowse.Name = "btnBackgroundImageBrowse";
			this.btnBackgroundImageBrowse.Size = new System.Drawing.Size(24, 23);
			this.btnBackgroundImageBrowse.TabIndex = 4;
			this.btnBackgroundImageBrowse.Text = "...";
			this.btnBackgroundImageBrowse.UseVisualStyleBackColor = true;
			this.btnBackgroundImageBrowse.Click += new System.EventHandler(this.btnBackgroundImageBrowse_Click);
			// 
			// btnAudioTrackBrowse
			// 
			this.btnAudioTrackBrowse.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAudioTrackBrowse.Location = new System.Drawing.Point(421, 158);
			this.btnAudioTrackBrowse.Name = "btnAudioTrackBrowse";
			this.btnAudioTrackBrowse.Size = new System.Drawing.Size(24, 23);
			this.btnAudioTrackBrowse.TabIndex = 8;
			this.btnAudioTrackBrowse.Text = "...";
			this.btnAudioTrackBrowse.UseVisualStyleBackColor = true;
			this.btnAudioTrackBrowse.Click += new System.EventHandler(this.btnAudioTrackBrowse_Click);
			// 
			// tbAudioTrack
			// 
			this.tbAudioTrack.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbAudioTrack.Location = new System.Drawing.Point(109, 160);
			this.tbAudioTrack.Name = "tbAudioTrack";
			this.tbAudioTrack.ReadOnly = true;
			this.tbAudioTrack.Size = new System.Drawing.Size(306, 20);
			this.tbAudioTrack.TabIndex = 7;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(6, 163);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(65, 13);
			this.label18.TabIndex = 17;
			this.label18.Text = "Audio Track";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.nudVisualEffectDuration);
			this.groupBox2.Controls.Add(this.label20);
			this.groupBox2.Controls.Add(this.cmbVisualEffectTransition);
			this.groupBox2.Controls.Add(this.label21);
			this.groupBox2.Controls.Add(this.label19);
			this.groupBox2.Controls.Add(this.cmbVisualEffect);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new System.Drawing.Point(6, 64);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(439, 102);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Visual Effect";
			// 
			// nudVisualEffectDuration
			// 
			this.nudVisualEffectDuration.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.nudVisualEffectDuration.Location = new System.Drawing.Point(78, 74);
			this.nudVisualEffectDuration.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
			this.nudVisualEffectDuration.Name = "nudVisualEffectDuration";
			this.nudVisualEffectDuration.Size = new System.Drawing.Size(55, 20);
			this.nudVisualEffectDuration.TabIndex = 8;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(139, 76);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(20, 13);
			this.label20.TabIndex = 17;
			this.label20.Text = "ms";
			// 
			// cmbVisualEffectTransition
			// 
			this.cmbVisualEffectTransition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbVisualEffectTransition.FormattingEnabled = true;
			this.cmbVisualEffectTransition.Items.AddRange(new object[] {
            "None",
            "Ease In",
            "Ease Out"});
			this.cmbVisualEffectTransition.Location = new System.Drawing.Point(78, 46);
			this.cmbVisualEffectTransition.Name = "cmbVisualEffectTransition";
			this.cmbVisualEffectTransition.Size = new System.Drawing.Size(180, 21);
			this.cmbVisualEffectTransition.TabIndex = 1;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(6, 76);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(47, 13);
			this.label21.TabIndex = 15;
			this.label21.Text = "Duration";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(6, 49);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(53, 13);
			this.label19.TabIndex = 6;
			this.label19.Text = "Transition";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(303, 17);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(459, 419);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.nudSlideDuration);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.groupBox4);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.cmbSlideRotation);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(451, 393);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Slide Options";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// nudSlideDuration
			// 
			this.nudSlideDuration.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.nudSlideDuration.Location = new System.Drawing.Point(84, 12);
			this.nudSlideDuration.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
			this.nudSlideDuration.Name = "nudSlideDuration";
			this.nudSlideDuration.Size = new System.Drawing.Size(55, 20);
			this.nudSlideDuration.TabIndex = 7;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox3);
			this.tabPage2.Controls.Add(this.btnBackgroundColor);
			this.tabPage2.Controls.Add(this.cbKeepAspectRatio);
			this.tabPage2.Controls.Add(this.cbAutoFitImages);
			this.tabPage2.Controls.Add(this.label16);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.tbMovieWidth);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.label17);
			this.tabPage2.Controls.Add(this.btnAudioTrackBrowse);
			this.tabPage2.Controls.Add(this.tbMovieHeight);
			this.tabPage2.Controls.Add(this.tbAudioTrack);
			this.tabPage2.Controls.Add(this.tbBackgroundImage);
			this.tabPage2.Controls.Add(this.label18);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.btnBackgroundImageBrowse);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(451, 393);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Movie Options";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label22);
			this.groupBox3.Controls.Add(this.tabControl2);
			this.groupBox3.Controls.Add(this.tbFPS);
			this.groupBox3.Location = new System.Drawing.Point(6, 190);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(439, 192);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Audio and Video Settings";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(16, 167);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(27, 13);
			this.label22.TabIndex = 29;
			this.label22.Text = "FPS";
			// 
			// tabControl2
			// 
			this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl2.Controls.Add(this.tabPageWmv);
			this.tabControl2.Controls.Add(this.tabPageAvi);
			this.tabControl2.Location = new System.Drawing.Point(6, 19);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(427, 139);
			this.tabControl2.TabIndex = 25;
			// 
			// tabPageWmv
			// 
			this.tabPageWmv.Controls.Add(this.label28);
			this.tabPageWmv.Controls.Add(this.label9);
			this.tabPageWmv.Controls.Add(this.tbBitrate);
			this.tabPageWmv.Controls.Add(this.cmbWmvAudioFormats);
			this.tabPageWmv.Controls.Add(this.label23);
			this.tabPageWmv.Controls.Add(this.cmbWmvAudioCodecs);
			this.tabPageWmv.Controls.Add(this.label24);
			this.tabPageWmv.Controls.Add(this.cmbWmvVideoCodecs);
			this.tabPageWmv.Controls.Add(this.label25);
			this.tabPageWmv.Location = new System.Drawing.Point(4, 22);
			this.tabPageWmv.Name = "tabPageWmv";
			this.tabPageWmv.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageWmv.Size = new System.Drawing.Size(419, 113);
			this.tabPageWmv.TabIndex = 1;
			this.tabPageWmv.Text = "WMV Format";
			this.tabPageWmv.UseVisualStyleBackColor = true;
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(96, 90);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(30, 13);
			this.label28.TabIndex = 18;
			this.label28.Text = "kbps";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 90);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(37, 13);
			this.label9.TabIndex = 27;
			this.label9.Text = "Bitrate";
			// 
			// tbBitrate
			// 
			this.tbBitrate.Location = new System.Drawing.Point(50, 87);
			this.tbBitrate.Name = "tbBitrate";
			this.tbBitrate.Size = new System.Drawing.Size(40, 20);
			this.tbBitrate.TabIndex = 3;
			this.tbBitrate.Text = "1000";
			// 
			// cmbWmvAudioFormats
			// 
			this.cmbWmvAudioFormats.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cmbWmvAudioFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbWmvAudioFormats.FormattingEnabled = true;
			this.cmbWmvAudioFormats.Location = new System.Drawing.Point(50, 33);
			this.cmbWmvAudioFormats.Name = "cmbWmvAudioFormats";
			this.cmbWmvAudioFormats.Size = new System.Drawing.Size(363, 21);
			this.cmbWmvAudioFormats.TabIndex = 1;
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(6, 36);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(39, 13);
			this.label23.TabIndex = 14;
			this.label23.Text = "Format";
			// 
			// cmbWmvAudioCodecs
			// 
			this.cmbWmvAudioCodecs.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cmbWmvAudioCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbWmvAudioCodecs.FormattingEnabled = true;
			this.cmbWmvAudioCodecs.Location = new System.Drawing.Point(50, 6);
			this.cmbWmvAudioCodecs.Name = "cmbWmvAudioCodecs";
			this.cmbWmvAudioCodecs.Size = new System.Drawing.Size(363, 21);
			this.cmbWmvAudioCodecs.TabIndex = 0;
			this.cmbWmvAudioCodecs.SelectedIndexChanged += new System.EventHandler(this.cmbWmvAudioCodecs_SelectedIndexChanged);
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(6, 63);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(34, 13);
			this.label24.TabIndex = 12;
			this.label24.Text = "Video";
			// 
			// cmbWmvVideoCodecs
			// 
			this.cmbWmvVideoCodecs.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cmbWmvVideoCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbWmvVideoCodecs.FormattingEnabled = true;
			this.cmbWmvVideoCodecs.Location = new System.Drawing.Point(50, 60);
			this.cmbWmvVideoCodecs.Name = "cmbWmvVideoCodecs";
			this.cmbWmvVideoCodecs.Size = new System.Drawing.Size(363, 21);
			this.cmbWmvVideoCodecs.TabIndex = 2;
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(6, 9);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(34, 13);
			this.label25.TabIndex = 11;
			this.label25.Text = "Audio";
			// 
			// tabPageAvi
			// 
			this.tabPageAvi.Controls.Add(this.cmbAviAudioCodecs);
			this.tabPageAvi.Controls.Add(this.label26);
			this.tabPageAvi.Controls.Add(this.cmbAviVideoCodecs);
			this.tabPageAvi.Controls.Add(this.label27);
			this.tabPageAvi.Controls.Add(this.btnVideoCodecProps);
			this.tabPageAvi.Location = new System.Drawing.Point(4, 22);
			this.tabPageAvi.Name = "tabPageAvi";
			this.tabPageAvi.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAvi.Size = new System.Drawing.Size(419, 113);
			this.tabPageAvi.TabIndex = 2;
			this.tabPageAvi.Text = "AVI format";
			this.tabPageAvi.UseVisualStyleBackColor = true;
			// 
			// cmbAviAudioCodecs
			// 
			this.cmbAviAudioCodecs.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cmbAviAudioCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAviAudioCodecs.FormattingEnabled = true;
			this.cmbAviAudioCodecs.Location = new System.Drawing.Point(50, 6);
			this.cmbAviAudioCodecs.Name = "cmbAviAudioCodecs";
			this.cmbAviAudioCodecs.Size = new System.Drawing.Size(332, 21);
			this.cmbAviAudioCodecs.TabIndex = 0;
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(6, 36);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(34, 13);
			this.label26.TabIndex = 7;
			this.label26.Text = "Video";
			// 
			// cmbAviVideoCodecs
			// 
			this.cmbAviVideoCodecs.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cmbAviVideoCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAviVideoCodecs.FormattingEnabled = true;
			this.cmbAviVideoCodecs.Location = new System.Drawing.Point(50, 33);
			this.cmbAviVideoCodecs.Name = "cmbAviVideoCodecs";
			this.cmbAviVideoCodecs.Size = new System.Drawing.Size(332, 21);
			this.cmbAviVideoCodecs.TabIndex = 1;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(6, 9);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(34, 13);
			this.label27.TabIndex = 5;
			this.label27.Text = "Audio";
			// 
			// btnVideoCodecProps
			// 
			this.btnVideoCodecProps.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnVideoCodecProps.Image = global::ImageToVideoDemo.Properties.Resources.wrench;
			this.btnVideoCodecProps.Location = new System.Drawing.Point(388, 29);
			this.btnVideoCodecProps.Name = "btnVideoCodecProps";
			this.btnVideoCodecProps.Size = new System.Drawing.Size(26, 26);
			this.btnVideoCodecProps.TabIndex = 2;
			this.btnVideoCodecProps.UseVisualStyleBackColor = true;
			this.btnVideoCodecProps.Click += new System.EventHandler(this.btnVideoCodecProps_Click);
			// 
			// tbFPS
			// 
			this.tbFPS.Location = new System.Drawing.Point(60, 164);
			this.tbFPS.Name = "tbFPS";
			this.tbFPS.Size = new System.Drawing.Size(40, 20);
			this.tbFPS.TabIndex = 0;
			// 
			// btnBackgroundColor
			// 
			this.btnBackgroundColor.BackColor = System.Drawing.Color.White;
			this.btnBackgroundColor.Location = new System.Drawing.Point(109, 55);
			this.btnBackgroundColor.Name = "btnBackgroundColor";
			this.btnBackgroundColor.Size = new System.Drawing.Size(23, 23);
			this.btnBackgroundColor.TabIndex = 2;
			this.btnBackgroundColor.UseVisualStyleBackColor = false;
			this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
			// 
			// cbKeepAspectRatio
			// 
			this.cbKeepAspectRatio.AutoSize = true;
			this.cbKeepAspectRatio.Location = new System.Drawing.Point(27, 33);
			this.cbKeepAspectRatio.Name = "cbKeepAspectRatio";
			this.cbKeepAspectRatio.Size = new System.Drawing.Size(115, 17);
			this.cbKeepAspectRatio.TabIndex = 1;
			this.cbKeepAspectRatio.Text = "Keep Aspect Ratio";
			this.cbKeepAspectRatio.UseVisualStyleBackColor = true;
			// 
			// cbAutoFitImages
			// 
			this.cbAutoFitImages.AutoSize = true;
			this.cbAutoFitImages.Location = new System.Drawing.Point(9, 10);
			this.cbAutoFitImages.Name = "cbAutoFitImages";
			this.cbAutoFitImages.Size = new System.Drawing.Size(99, 17);
			this.cbAutoFitImages.TabIndex = 0;
			this.cbAutoFitImages.Text = "Auto-Fit Images";
			this.cbAutoFitImages.UseVisualStyleBackColor = true;
			// 
			// cbPlayGeneratedFile
			// 
			this.cbPlayGeneratedFile.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cbPlayGeneratedFile.AutoSize = true;
			this.cbPlayGeneratedFile.Checked = true;
			this.cbPlayGeneratedFile.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbPlayGeneratedFile.Location = new System.Drawing.Point(434, 454);
			this.cbPlayGeneratedFile.Name = "cbPlayGeneratedFile";
			this.cbPlayGeneratedFile.Size = new System.Drawing.Size(137, 17);
			this.cbPlayGeneratedFile.TabIndex = 4;
			this.cbPlayGeneratedFile.Text = "Auto-play generated file";
			this.cbPlayGeneratedFile.UseVisualStyleBackColor = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
			this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.statusStrip1.Location = new System.Drawing.Point(0, 484);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(774, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
			this.toolStripStatusLabel1.Text = "Ready";
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripProgressBar1.AutoSize = false;
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(152, 16);
			// 
			// btnCreateMovie
			// 
			this.btnCreateMovie.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCreateMovie.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.btnCreateMovie.Image = global::ImageToVideoDemo.Properties.Resources.film;
			this.btnCreateMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCreateMovie.Location = new System.Drawing.Point(606, 442);
			this.btnCreateMovie.Name = "btnCreateMovie";
			this.btnCreateMovie.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.btnCreateMovie.Size = new System.Drawing.Size(155, 39);
			this.btnCreateMovie.TabIndex = 2;
			this.btnCreateMovie.Text = "Create Movie";
			this.btnCreateMovie.UseVisualStyleBackColor = true;
			this.btnCreateMovie.Click += new System.EventHandler(this.btnCreateMovie_Click);
			// 
			// cbTransitionEffectBeforeRandom
			// 
			this.cbTransitionEffectBeforeRandom.AutoSize = true;
			this.cbTransitionEffectBeforeRandom.Location = new System.Drawing.Point(264, 21);
			this.cbTransitionEffectBeforeRandom.Name = "cbTransitionEffectBeforeRandom";
			this.cbTransitionEffectBeforeRandom.Size = new System.Drawing.Size(66, 17);
			this.cbTransitionEffectBeforeRandom.TabIndex = 22;
			this.cbTransitionEffectBeforeRandom.Text = "Random";
			this.cbTransitionEffectBeforeRandom.UseVisualStyleBackColor = true;
			// 
			// cbTransitionEffectAfterRandom
			// 
			this.cbTransitionEffectAfterRandom.AutoSize = true;
			this.cbTransitionEffectAfterRandom.Location = new System.Drawing.Point(264, 75);
			this.cbTransitionEffectAfterRandom.Name = "cbTransitionEffectAfterRandom";
			this.cbTransitionEffectAfterRandom.Size = new System.Drawing.Size(66, 17);
			this.cbTransitionEffectAfterRandom.TabIndex = 23;
			this.cbTransitionEffectAfterRandom.Text = "Random";
			this.cbTransitionEffectAfterRandom.UseVisualStyleBackColor = true;
			// 
			// linkVisitSDKHome
			// 
			this.linkVisitSDKHome.AutoSize = true;
			this.linkVisitSDKHome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.linkVisitSDKHome.Location = new System.Drawing.Point(9, 455);
			this.linkVisitSDKHome.Name = "linkVisitSDKHome";
			this.linkVisitSDKHome.Size = new System.Drawing.Size(363, 13);
			this.linkVisitSDKHome.TabIndex = 6;
			this.linkVisitSDKHome.TabStop = true;
			this.linkVisitSDKHome.Text = "Powered by Bytescout Images To Video SDK - click to find more";
			this.linkVisitSDKHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVisitSDKHome_LinkClicked);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(774, 506);
			this.Controls.Add(this.linkVisitSDKHome);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.cbPlayGeneratedFile);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.btnCreateMovie);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bytescout ImageToVideo Demo";
			this.groupBox1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.nudTransitionEffectAfterDuration)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.nudTransitionEffectBeforeDuration)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.nudVisualEffectDuration)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.nudSlideDuration)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.tabControl2.ResumeLayout(false);
			this.tabPageWmv.ResumeLayout(false);
			this.tabPageWmv.PerformLayout();
			this.tabPageAvi.ResumeLayout(false);
			this.tabPageAvi.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnRemoveAll;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnAddFolder;
		private System.Windows.Forms.Button btnAddImage;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbMovieHeight;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbMovieWidth;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnCreateMovie;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbVisualEffect;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmbSlideRotation;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ComboBox cmbTransitionEffectAfter;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cmbTransitionEffectBefore;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox tbBackgroundImage;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button btnBackgroundImageBrowse;
		private System.Windows.Forms.Button btnAudioTrackBrowse;
		private System.Windows.Forms.TextBox tbAudioTrack;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.ComboBox cmbVisualEffectTransition;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Button btnMoveDown;
		private System.Windows.Forms.Button btnMoveUp;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.CheckBox cbKeepAspectRatio;
		private System.Windows.Forms.CheckBox cbAutoFitImages;
		private System.Windows.Forms.Button btnBackgroundColor;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage tabPageWmv;
		private System.Windows.Forms.ComboBox cmbWmvAudioFormats;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.ComboBox cmbWmvAudioCodecs;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.ComboBox cmbWmvVideoCodecs;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.TabPage tabPageAvi;
		private System.Windows.Forms.ComboBox cmbAviAudioCodecs;
		private System.Windows.Forms.Button btnVideoCodecProps;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.ComboBox cmbAviVideoCodecs;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbBitrate;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox tbFPS;
		private System.Windows.Forms.ListView lvInputFiles;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.CheckBox cbPlayGeneratedFile;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.NumericUpDown nudSlideDuration;
		private System.Windows.Forms.NumericUpDown nudVisualEffectDuration;
		private System.Windows.Forms.NumericUpDown nudTransitionEffectBeforeDuration;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown nudTransitionEffectAfterDuration;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.CheckBox cbTransitionEffectBeforeRandom;
		private System.Windows.Forms.CheckBox cbTransitionEffectAfterRandom;
		private System.Windows.Forms.LinkLabel linkVisitSDKHome;
	}
}


```

<!-- code block end -->    

<!-- code block begin -->

##### ****MainForm.cs:**
    
```
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using BytescoutImageToVideo;
using ImageToVideoDemo.Properties;

namespace ImageToVideoDemo
{
	public partial class MainForm : Form
	{
		public const int WM_APP = 0x8000;
		public const int WM_CONVERSION_PROGRESS = WM_APP + 1;

		private ImageToVideo _imageToVideo = new ImageToVideo();
		private string _outputFile = "";
		private Random _randomGenerator = new Random();

		public MainForm()
		{
			InitializeComponent();

			_imageToVideo.RegistrationName = "demo";
			_imageToVideo.RegistrationKey = "demo";

			Application.Idle += Application_Idle;
		}

		protected override void OnLoad(EventArgs e)
		{
			cbAutoFitImages.Checked = _imageToVideo.AutoFitImages;
			cbKeepAspectRatio.Checked = _imageToVideo.KeepAspectRatio;
			btnBackgroundColor.BackColor = ColorTranslator.FromOle((int) _imageToVideo.BackgroundColor);
			tbMovieWidth.Text = _imageToVideo.OutputWidth.ToString(CultureInfo.InvariantCulture);
			tbMovieHeight.Text = _imageToVideo.OutputHeight.ToString(CultureInfo.InvariantCulture);

			// Get list of available AVI audio codecs
			for (int i = 0; i < _imageToVideo.AudioCodecsCount; i++)
				cmbAviAudioCodecs.Items.Add(_imageToVideo.GetAudioCodecName(i));
			// Select current AVI audio codec
			cmbAviAudioCodecs.SelectedIndex = _imageToVideo.CurrentAudioCodec;

			// Get list of available AVI video codecs
			for (int i = 0; i < _imageToVideo.VideoCodecsCount; i++)
				cmbAviVideoCodecs.Items.Add(_imageToVideo.GetVideoCodecName(i));
			// Select current AVI video codec
			cmbAviVideoCodecs.SelectedIndex = _imageToVideo.CurrentVideoCodec;

			// Get list of available WMV audio codecs
			for (int i = 0; i < _imageToVideo.WMVAudioCodecsCount; i++)
				cmbWmvAudioCodecs.Items.Add(_imageToVideo.GetWMVAudioCodecName(i));
			// Select current WMV audio codec
			cmbWmvAudioCodecs.SelectedIndex = _imageToVideo.CurrentWMVAudioCodec;

			// Get list of available WMV video codecs
			for (int i = 0; i < _imageToVideo.WMVVideoCodecsCount; i++)
				cmbWmvVideoCodecs.Items.Add(_imageToVideo.GetWMVVideoCodecName(i));
			// Select current WMV video codec
			cmbWmvVideoCodecs.SelectedIndex = _imageToVideo.CurrentWMVVideoCodec;

			tbFPS.Text = _imageToVideo.FPS.ToString(CultureInfo.InvariantCulture);

			base.OnLoad(e);
		}

		private void Application_Idle(object sender, EventArgs e)
		{
			bool imageIsSelected = lvInputFiles.SelectedIndices.Count > 0;
			bool imagesAdded = lvInputFiles.Items.Count > 0;

			btnMoveUp.Enabled = imageIsSelected;
			btnMoveDown.Enabled = imageIsSelected;
			btnRemove.Enabled = imageIsSelected;
			btnRemoveAll.Enabled = imagesAdded;

			nudSlideDuration.Enabled = imageIsSelected;
			cmbSlideRotation.Enabled = imageIsSelected;
			cmbVisualEffect.Enabled = imageIsSelected;
			cmbVisualEffectTransition.Enabled = imageIsSelected;
			nudVisualEffectDuration.Enabled = imageIsSelected;
			cmbTransitionEffectBefore.Enabled = imageIsSelected && !cbTransitionEffectBeforeRandom.Checked;
			nudTransitionEffectBeforeDuration.Enabled = imageIsSelected;
			cbTransitionEffectBeforeRandom.Enabled = imageIsSelected;
			cmbTransitionEffectAfter.Enabled = imageIsSelected && !cbTransitionEffectAfterRandom.Checked;
			nudTransitionEffectAfterDuration.Enabled = imageIsSelected;
			cbTransitionEffectAfterRandom.Enabled = imageIsSelected;

			btnCreateMovie.Enabled = imagesAdded;
		}

		private void btnAddImage_Click(object sender, EventArgs e)
		{
			ListViewItem firstAddedItem = null;

			OpenFileDialog dlg = new OpenFileDialog();
			dlg.CheckFileExists = false;
			dlg.CheckPathExists = false;
			dlg.Filter =
				"Image Files(*.JPG;*.PNG;*.BMP)|*.JPG;*.JPEG;*.PNG;*.BMP;|JPEG Files(*.JPG)|*.JPG;*.JPEG|PNG Files(*.PNG)|*.PNG|BMP Files(*.BMP)|*.BMP|All files (*.*)|*.*";
			dlg.Multiselect = true;
			dlg.SupportMultiDottedExtensions = true;
			dlg.Title = "Select Files";

			if (String.IsNullOrEmpty(Settings.Default.LastUsedFolder))
				Settings.Default.LastUsedFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

			dlg.InitialDirectory = Settings.Default.LastUsedFolder;

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				Settings.Default.LastUsedFolder = Path.GetDirectoryName(dlg.FileNames[0]);

				Cursor = Cursors.WaitCursor;
				lvInputFiles.BeginUpdate();

				try
				{
					foreach (string file in dlg.FileNames)
					{
						SlideOptions slideOptions = new SlideOptions();
						slideOptions.ImageFile = file;

						ListViewItem item = new ListViewItem(Convert.ToString(lvInputFiles.Items.Count + 1));
						item.SubItems.Add(Path.GetFileName(file));
						item.Tag = slideOptions;
						
						lvInputFiles.Items.Add(item);

						if (firstAddedItem == null)
							firstAddedItem = item;
					}

					if (firstAddedItem != null)
					{
						lvInputFiles.SelectedItems.Clear();
						firstAddedItem.Selected = true;
						firstAddedItem.EnsureVisible();
					}
				}
				finally
				{
					lvInputFiles.EndUpdate();
					Cursor = Cursors.Default;
				}

				lvInputFiles.Select();
			}
		}

		private void btnAddFolder_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dlg = new FolderBrowserDialog();

			dlg.Description = "Select Folder";
			dlg.ShowNewFolderButton = false;

			if (String.IsNullOrEmpty(Settings.Default.LastUsedFolder))
				Settings.Default.LastUsedFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

			dlg.SelectedPath = Settings.Default.LastUsedFolder;

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				Settings.Default.LastUsedFolder = dlg.SelectedPath;

				DirectoryInfo dir = new DirectoryInfo(dlg.SelectedPath);
				ListViewItem firstAddedItem = null;

				Cursor = Cursors.WaitCursor;
				Application.DoEvents();
				lvInputFiles.BeginUpdate();

				try
				{
					FileInfo[] files = dir.GetFiles();

					foreach (FileInfo file in files)
					{
						string ext = file.Extension.ToLower();

						if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp")
						{
							SlideOptions slideOptions = new SlideOptions();
							slideOptions.ImageFile = file.FullName;

							ListViewItem item = new ListViewItem(Convert.ToString(lvInputFiles.Items.Count + 1));
							item.SubItems.Add(Path.GetFileName(file.FullName));
							item.Tag = slideOptions;
							lvInputFiles.Items.Add(item);

							if (firstAddedItem == null)
								firstAddedItem = item;
						}
					}

					if (firstAddedItem != null)
					{
						lvInputFiles.SelectedItems.Clear();
						firstAddedItem.Selected = true;
						firstAddedItem.EnsureVisible();
					}
				}
				finally
				{
					lvInputFiles.EndUpdate();
					Cursor = Cursors.Default;
				}

				lvInputFiles.Select();
			}
		}

		private void btnMoveUp_Click(object sender, EventArgs e)
		{
			ListViewItem selectedItem = lvInputFiles.SelectedItems[0];
			int x = selectedItem.Index;

			if (x > 0)
			{
				lvInputFiles.BeginUpdate();

				try
				{
					lvInputFiles.Items.Remove(selectedItem);
					lvInputFiles.Items.Insert(x - 1, selectedItem);
					selectedItem.EnsureVisible();

					foreach (ListViewItem item in lvInputFiles.Items)
						item.SubItems[0].Text = Convert.ToString(item.Index + 1);
				}
				finally
				{
					lvInputFiles.EndUpdate();
				}
			}

			lvInputFiles.Select();
		}

		private void btnMoveDown_Click(object sender, EventArgs e)
		{
			ListViewItem selectedItem = lvInputFiles.SelectedItems[0];
			int x = selectedItem.Index;

			if (x < lvInputFiles.Items.Count - 1)
			{
				lvInputFiles.BeginUpdate();

				try
				{
					lvInputFiles.Items.Remove(selectedItem);
					lvInputFiles.Items.Insert(x + 1, selectedItem);
					selectedItem.EnsureVisible();

					foreach (ListViewItem item in lvInputFiles.Items)
						item.SubItems[0].Text = Convert.ToString(item.Index + 1);
				}
				finally
				{
					lvInputFiles.EndUpdate();
				}
			}

			lvInputFiles.Select();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			ListViewItem selectedItem = lvInputFiles.SelectedItems[0];
			int x = selectedItem.Index;

			lvInputFiles.BeginUpdate();

			try
			{
				lvInputFiles.Items.Remove(selectedItem);
				
				foreach (ListViewItem item in lvInputFiles.Items)
					item.SubItems[0].Text = Convert.ToString(item.Index + 1);
			}
			finally
			{
				lvInputFiles.EndUpdate();
			}

			if (x > 0)
				lvInputFiles.Items[x - 1].Selected = true;
			else if (x < lvInputFiles.Items.Count)
				lvInputFiles.Items[x].Selected = true;

			lvInputFiles.Select();
		}

		private void btnRemoveAll_Click(object sender, EventArgs e)
		{
			lvInputFiles.BeginUpdate();

			try
			{
				lvInputFiles.Items.Clear();
				_imageToVideo.Slides.Clear();
			}
			finally
			{
				lvInputFiles.EndUpdate();
			}
		}

		private void lvInputFiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			nudSlideDuration.ValueChanged -= nudSlideDuration_ValueChanged;
			cmbSlideRotation.SelectedIndexChanged -= cmbSlideRotation_SelectedIndexChanged;
			cmbVisualEffect.SelectedIndexChanged -= cmbVisualEffect_SelectedIndexChanged;
			cmbVisualEffectTransition.SelectedIndexChanged -= cmbVisualEffectTransition_SelectedIndexChanged;
			nudVisualEffectDuration.ValueChanged -= nudVisualEffectDuration_ValueChanged;
			cmbTransitionEffectBefore.SelectedIndexChanged -= cmbTransitionEffectBefore_SelectedIndexChanged;
			nudTransitionEffectBeforeDuration.ValueChanged -= nudTransitionEffectBeforeDuration_ValueChanged;
			cbTransitionEffectBeforeRandom.CheckedChanged -= cbTransitionEffectBeforeRandom_CheckedChanged;
			cmbTransitionEffectAfter.SelectedIndexChanged -= cmbTransitionEffectAfter_SelectedIndexChanged;
			nudTransitionEffectAfterDuration.ValueChanged -= nudTransitionEffectAfterDuration_ValueChanged;
			cbTransitionEffectAfterRandom.CheckedChanged -= cbTransitionEffectAfterRandom_CheckedChanged;

			ListView.SelectedListViewItemCollection selectedItems = lvInputFiles.SelectedItems;

			if (selectedItems.Count > 0)
			{
				SlideOptions slideOptions = (SlideOptions) selectedItems[0].Tag;

				nudSlideDuration.Value = slideOptions.SlideDuration;
				cmbSlideRotation.SelectedIndex = (int) slideOptions.SlideRotation;
				cmbVisualEffect.SelectedIndex = (int) slideOptions.VisualEffect;
				cmbVisualEffectTransition.SelectedIndex = (int) slideOptions.VisualEffectTransition;
				nudVisualEffectDuration.Value = slideOptions.VisualEffectDuration;
				cmbTransitionEffectBefore.SelectedIndex = (int) slideOptions.TransitionEffectBefore + 1;
				nudTransitionEffectBeforeDuration.Value = slideOptions.TransitionEffectBeforeDuration;
				cbTransitionEffectBeforeRandom.Checked = slideOptions.RandomTransitionEffectBefore;
				cmbTransitionEffectAfter.SelectedIndex = (int) slideOptions.TransitionEffectAfter + 1;
				nudTransitionEffectAfterDuration.Value = slideOptions.TransitionEffectAfterDuration;
				cbTransitionEffectAfterRandom.Checked = slideOptions.RandomTransitionEffectAfter;

				nudSlideDuration.ValueChanged += nudSlideDuration_ValueChanged;
				cmbSlideRotation.SelectedIndexChanged += cmbSlideRotation_SelectedIndexChanged;
				cmbVisualEffect.SelectedIndexChanged += cmbVisualEffect_SelectedIndexChanged;
				cmbVisualEffectTransition.SelectedIndexChanged += cmbVisualEffectTransition_SelectedIndexChanged;
				nudVisualEffectDuration.ValueChanged += nudVisualEffectDuration_ValueChanged;
				cmbTransitionEffectBefore.SelectedIndexChanged += cmbTransitionEffectBefore_SelectedIndexChanged;
				nudTransitionEffectBeforeDuration.ValueChanged += nudTransitionEffectBeforeDuration_ValueChanged;
				cbTransitionEffectBeforeRandom.CheckedChanged += cbTransitionEffectBeforeRandom_CheckedChanged;
				cmbTransitionEffectAfter.SelectedIndexChanged += cmbTransitionEffectAfter_SelectedIndexChanged;
				nudTransitionEffectAfterDuration.ValueChanged += nudTransitionEffectAfterDuration_ValueChanged;
				cbTransitionEffectAfterRandom.CheckedChanged += cbTransitionEffectAfterRandom_CheckedChanged;
			}
		}

		private void nudSlideDuration_ValueChanged(object sender, EventArgs e)
		{
			SlideOptions slideOptions = (SlideOptions) lvInputFiles.SelectedItems[0].Tag;
			slideOptions.SlideDuration = (int) nudSlideDuration.Value;
		}

		private void cmbSlideRotation_SelectedIndexChanged(object sender, EventArgs e)
		{
			SlideOptions slideOptions = (SlideOptions) lvInputFiles.SelectedItems[0].Tag;
			slideOptions.SlideRotation = (RotationAngle) cmbSlideRotation.SelectedIndex;
		}

		private void cmbVisualEffect_SelectedIndexChanged(object sender, EventArgs e)
		{
			SlideOptions slideOptions = (SlideOptions) lvInputFiles.SelectedItems[0].Tag;
			slideOptions.VisualEffect = (VisualEffectType) cmbVisualEffect.SelectedIndex;
		}

		private void cmbVisualEffectTransition_SelectedIndexChanged(object sender, EventArgs e)
		{
			SlideOptions slideOptions = (SlideOptions) lvInputFiles.SelectedItems[0].Tag;
			slideOptions.VisualEffectTransition = (SlideEffectType) cmbVisualEffectTransition.SelectedIndex;
		}

		private void nudVisualEffectDuration_ValueChanged(object sender, EventArgs e)
		{
			SlideOptions slideOptions = (SlideOptions) lvInputFiles.SelectedItems[0].Tag;
			slideOptions.VisualEffectDuration = (int) nudVisualEffectDuration.Value;
		}

		private void cmbTransitionEffectBefore_SelectedIndexChanged(object sender, EventArgs e)
		{
			SlideOptions slideOptions = (SlideOptions) lvInputFiles.SelectedItems[0].Tag;
			slideOptions.TransitionEffectBefore = (TransitionEffectType) (cmbTransitionEffectBefore.SelectedIndex - 1);
		}

		private void nudTransitionEffectBeforeDuration_ValueChanged(object sender, EventArgs e)
		{
			SlideOptions slideOptions = (SlideOptions) lvInputFiles.SelectedItems[0].Tag;
			slideOptions.TransitionEffectBeforeDuration = (int) nudTransitionEffectBeforeDuration.Value;
		}

		private void cmbTransitionEffectAfter_SelectedIndexChanged(object sender, EventArgs e)
		{
			SlideOptions slideOptions = (SlideOptions) lvInputFiles.SelectedItems[0].Tag;
			slideOptions.TransitionEffectAfter = (TransitionEffectType) (cmbTransitionEffectAfter.SelectedIndex - 1);
		}

		private void nudTransitionEffectAfterDuration_ValueChanged(object sender, EventArgs e)
		{
			SlideOptions slideOptions = (SlideOptions) lvInputFiles.SelectedItems[0].Tag;
			slideOptions.TransitionEffectAfterDuration = (int) nudTransitionEffectAfterDuration.Value;
		}

		void cbTransitionEffectBeforeRandom_CheckedChanged(object sender, EventArgs e)
		{
			SlideOptions slideOptions = (SlideOptions) lvInputFiles.SelectedItems[0].Tag;
			slideOptions.RandomTransitionEffectBefore = cbTransitionEffectBeforeRandom.Checked;
		}

		void cbTransitionEffectAfterRandom_CheckedChanged(object sender, EventArgs e)
		{
			SlideOptions slideOptions = (SlideOptions) lvInputFiles.SelectedItems[0].Tag;
			slideOptions.RandomTransitionEffectAfter = cbTransitionEffectAfterRandom.Checked;
		}

		private void btnVideoCodecProps_Click(object sender, EventArgs e)
		{
			try
			{
				_imageToVideo.ShowVideoCodecSettingsDialogModal(Handle.ToInt32());
			}
			catch (Exception)
			{
			}
		}

		private void cmbWmvAudioCodecs_SelectedIndexChanged(object sender, EventArgs e)
		{
			_imageToVideo.CurrentWMVAudioCodecName = cmbWmvAudioCodecs.SelectedItem.ToString();

			cmbWmvAudioFormats.Items.Clear();

			// Get list of available WMV audio formats
			for (int i = 0; i < _imageToVideo.WMVAudioFormatCount; i++)
				cmbWmvAudioFormats.Items.Add(_imageToVideo.GetWMVAudioFormatDescription(i));
			// Select current WMV audio format
			cmbWmvAudioFormats.SelectedIndex = _imageToVideo.CurrentWMVAudioFormat;
		}

		protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
		{
			Settings.Default.Save();

			base.OnClosing(e);
		}

		private void btnBackgroundImageBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.CheckFileExists = false;
			dlg.CheckPathExists = false;
			dlg.Multiselect = false;
			dlg.Filter = "Image Files(*.JPG;*.PNG;*.BMP)|*.JPG;*.JPEG;*.PNG;*.BMP;|JPEG Files(*.JPG)|*.JPG;*.JPEG|PNG Files(*.PNG)|*.PNG|BMP Files(*.BMP)|*.BMP|All files (*.*)|*.*";
			dlg.Multiselect = true;
			dlg.SupportMultiDottedExtensions = true;
			dlg.Title = "Select background image";

			if (String.IsNullOrEmpty(Settings.Default.LastUsedFolder))
				Settings.Default.LastUsedFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

			dlg.InitialDirectory = Settings.Default.LastUsedFolder;

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				Settings.Default.LastUsedFolder = Path.GetDirectoryName(dlg.FileNames[0]);
				tbBackgroundImage.Text = dlg.FileName;
			}
		}

		private void btnAudioTrackBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.CheckFileExists = false;
			dlg.CheckPathExists = false;
			dlg.Multiselect = false;
			dlg.Filter = "Sound Files(*.MP3;*.WAV)|*.MP3;*.WAV|MP3 Files(*.MP3)|*.MP3|WAV Files(*.WAV)|*.WAV|All files (*.*)|*.*";
			dlg.Multiselect = true;
			dlg.SupportMultiDottedExtensions = true;
			dlg.Title = "Select background image";

			if (String.IsNullOrEmpty(Settings.Default.LastUsedFolder))
				Settings.Default.LastUsedFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

			dlg.InitialDirectory = Settings.Default.LastUsedFolder;

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				Settings.Default.LastUsedFolder = Path.GetDirectoryName(dlg.FileNames[0]);
				tbAudioTrack.Text = dlg.FileName;
			}
		}

		private void btnBackgroundColor_Click(object sender, EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.Color = btnBackgroundColor.BackColor;

			if (colorDialog.ShowDialog() == DialogResult.OK)
				btnBackgroundColor.BackColor = colorDialog.Color;
		}

		protected override void WndProc(ref Message m)
		{
			if (m.HWnd == Handle && m.Msg == WM_CONVERSION_PROGRESS)
			{
				// Show progress
				int progress = m.WParam.ToInt32();
				toolStripProgressBar1.Value = progress;

				// Finished!
				if (progress == 100 && _imageToVideo.IsRunning)
				{
					// wait a bit the converter finished and released resources
					while (_imageToVideo.IsRunning)
						Thread.Sleep(200);

					toolStripStatusLabel1.Text = "Saved to file " + _outputFile;
					btnCreateMovie.Text = "Create Movie";
					btnCreateMovie.Image = Resources.film;
					toolStripProgressBar1.Value = 0;

					// Open folder containing the generated file
					Process.Start("explorer.exe", "/select,\"" + _outputFile + "\"");

					// Play generated file
					if (cbPlayGeneratedFile.Checked)
					{
						try
						{
							Process process = new Process();
							process.StartInfo.FileName = _outputFile;
							process.StartInfo.UseShellExecute = true;
							process.Start();
						}
						catch
						{
						}
					}
				}
			}

			base.WndProc(ref m);
		}

		private void btnCreateMovie_Click(object sender, EventArgs e)
		{
			if (!_imageToVideo.IsRunning)
			{
				SaveFileDialog dlg = new SaveFileDialog();
				dlg.Filter = "WMV files (*.wmv)|*.wmv|AVI files (*.avi)|*.avi|All files (*.*)|*.*";

				if (tabControl2.SelectedIndex == 0)
				{
					dlg.DefaultExt = "*.wmv";
					dlg.FilterIndex = 1;
				}
				else
				{
					dlg.DefaultExt = "*.avi";
					dlg.FilterIndex = 2;
				}

				dlg.FileName = "movie";
				dlg.Title = "Save generated video as";

				if (String.IsNullOrEmpty(Settings.Default.LastUsedFolder2))
					Settings.Default.LastUsedFolder2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

				dlg.InitialDirectory = Settings.Default.LastUsedFolder2;

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					Settings.Default.LastUsedFolder2 = Path.GetDirectoryName(dlg.FileName);

					int intValue;
					float floatValue;

					_imageToVideo.AutoFitImages = cbAutoFitImages.Checked;
					_imageToVideo.KeepAspectRatio = cbKeepAspectRatio.Checked;
					_imageToVideo.BackgroundColor = (uint) ColorTranslator.ToOle(btnBackgroundColor.BackColor);

					if (tbBackgroundImage.Text.Length > 0)
						_imageToVideo.SetBackgroundPictureFileName(tbBackgroundImage.Text);

					if (int.TryParse(tbMovieWidth.Text, out intValue))
						_imageToVideo.OutputWidth = intValue;
					if (int.TryParse(tbMovieHeight.Text, out intValue))
						_imageToVideo.OutputHeight = intValue;

					if (tbAudioTrack.Text.Length > 0)
						_imageToVideo.ExternalAudioTrackFromFileName = tbAudioTrack.Text;

					_imageToVideo.CurrentAudioCodec = cmbAviAudioCodecs.SelectedIndex;
					_imageToVideo.CurrentVideoCodec = cmbAviVideoCodecs.SelectedIndex;
					_imageToVideo.CurrentWMVAudioCodec = cmbWmvAudioCodecs.SelectedIndex;
					_imageToVideo.CurrentWMVAudioFormat = cmbWmvAudioFormats.SelectedIndex;
					_imageToVideo.CurrentWMVVideoCodec = cmbWmvVideoCodecs.SelectedIndex;

					if (int.TryParse(tbBitrate.Text, out intValue))
						_imageToVideo.WMVVideoBitrate = intValue * 1024;

					if (float.TryParse(tbFPS.Text, out floatValue))
						_imageToVideo.FPS = floatValue;

					_outputFile = dlg.FileName;
					_imageToVideo.OutputVideoFileName = _outputFile;
					_imageToVideo.SetProgressNotifyWindow(Handle.ToInt32(), WM_CONVERSION_PROGRESS, 0);

					_imageToVideo.Slides.Clear();

					foreach (ListViewItem item in lvInputFiles.Items)
					{
						SlideOptions slideInfo = (SlideOptions) item.Tag;
						Slide slide = _imageToVideo.AddImageFromFileName(slideInfo.ImageFile);
						slide.Duration = slideInfo.SlideDuration;
						slide.RotationAngle = slideInfo.SlideRotation;
						slide.VisualEffect = slideInfo.VisualEffect;
						slide.Effect = slideInfo.VisualEffectTransition;
						slide.EffectDuration = slideInfo.VisualEffectDuration;
						slide.InEffect = slideInfo.RandomTransitionEffectBefore ? GetRandomEffect() : slideInfo.TransitionEffectBefore;
						slide.InEffectDuration = slideInfo.TransitionEffectBeforeDuration;
						slide.OutEffect = slideInfo.RandomTransitionEffectAfter ? GetRandomEffect() : slideInfo.TransitionEffectAfter;
						slide.OutEffectDuration = slideInfo.TransitionEffectAfterDuration;
					}

					_imageToVideo.Run();
					
					toolStripStatusLabel1.Text = "Generating video...";
					btnCreateMovie.Text = "Stop";
					btnCreateMovie.Image = Resources.stop;
				}
			}
			else
			{
				// Stop generation
				_imageToVideo.Stop();
				
				// wait a bit the converter finished and released resources
				while (_imageToVideo.IsRunning)
					Thread.Sleep(200);
				
				toolStripStatusLabel1.Text = "Interrupted by user.";
				btnCreateMovie.Text = "Create Movie";
				btnCreateMovie.Image = Resources.film;
				toolStripProgressBar1.Value = 0;
			}
		}

		private TransitionEffectType GetRandomEffect()
		{
			return (TransitionEffectType) _randomGenerator.Next(0, 140);
		}

		private void linkVisitSDKHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = @"http://bytescout.com/products/developer/imagetovideosdk/imagetovideosdk.html";
				process.StartInfo.UseShellExecute = true;
				process.Start();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}
	}
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.cs:**
    
```
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace ImageToVideoDemo
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ThreadException += Thread_UnhandledException;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject != null)
            {
                ThreadExceptionDialog exceptionDialog = new ThreadExceptionDialog((Exception) e.ExceptionObject);

                if (exceptionDialog.ShowDialog() == DialogResult.Abort)
                {
                    Application.Exit();
                }
            }
        }

        private static void Thread_UnhandledException(object sender, ThreadExceptionEventArgs e)
        {
            if (e.Exception != null)
            {
                ThreadExceptionDialog exceptionDialog = new ThreadExceptionDialog(e.Exception);

                if (exceptionDialog.ShowDialog() == DialogResult.Abort)
                {
                    Application.Exit();
                }
            }
        }
	}
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****SlideOptions.cs:**
    
```
using System;
using System.Collections.Generic;
using System.Text;
using BytescoutImageToVideo;

namespace ImageToVideoDemo
{
	public class SlideOptions
	{
		// Image file path
		public string ImageFile;

		// Slide properties
		public int SlideDuration = 1500;
		public RotationAngle SlideRotation = RotationAngle.raNone;
		public VisualEffectType VisualEffect = VisualEffectType.veNone;
		public SlideEffectType VisualEffectTransition = SlideEffectType.seNone;
		public int VisualEffectDuration = 1000;
		public TransitionEffectType TransitionEffectBefore = TransitionEffectType.teNone;
		public int TransitionEffectBeforeDuration = 1000;
		public bool RandomTransitionEffectBefore = true;
		public TransitionEffectType TransitionEffectAfter = TransitionEffectType.teNone;
		public int TransitionEffectAfterDuration = 1000;
		public bool RandomTransitionEffectAfter = true;
	}
}

```

<!-- code block end -->