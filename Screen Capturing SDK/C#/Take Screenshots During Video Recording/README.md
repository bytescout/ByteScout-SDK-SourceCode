## take screenshots during video recording in C# and ByteScout Screen Capturing SDK

### take screenshots during video recording in C#

Sample source codes below will show you how to cope with a difficult task, for example, take screenshots during video recording in C#. ByteScout Screen Capturing SDK was made to help with take screenshots during video recording in C#. ByteScout Screen Capturing SDK is the SDK for developers for quick implementation of screen video recording. The SDK records screen into video or into a series of screenshots. Can also record audio. Saves video into AVI,WMV and Google's WebM. Output video quality, size, resolution or framerate can be adjusted easily. Provides additional tools for privacy features like blacking out on scren areas with sensitive information on screen right during recording. Supports web camera as input and can add instant text and images into video output.

Fast application programming interfaces of ByteScout Screen Capturing SDK for C# plus the instruction and the C# code below will help you quickly learn take screenshots during video recording. To do take screenshots during video recording in your C# project or application you may simply copy & paste the code and then run your app! You can use these C# sample examples in one or many applications.

ByteScout Screen Capturing SDK free trial version is available for download from our website. Free trial also includes programming tutorials along with source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Screen%20Capturing%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Screen%20Capturing%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=fujkvtWUVCw](https://www.youtube.com/watch?v=fujkvtWUVCw)




<!-- code block begin -->

##### ****Form1.Designer.cs:**
    
```
namespace ScreenCapturingExample
{
	partial class Form1
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
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonStop = new System.Windows.Forms.Button();
			this.buttonScreenshot = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(28, 26);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(75, 23);
			this.buttonStart.TabIndex = 0;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// buttonStop
			// 
			this.buttonStop.Enabled = false;
			this.buttonStop.Location = new System.Drawing.Point(28, 55);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(75, 23);
			this.buttonStop.TabIndex = 1;
			this.buttonStop.Text = "Stop";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
			// 
			// buttonScreenshot
			// 
			this.buttonScreenshot.Enabled = false;
			this.buttonScreenshot.Location = new System.Drawing.Point(109, 38);
			this.buttonScreenshot.Name = "buttonScreenshot";
			this.buttonScreenshot.Size = new System.Drawing.Size(100, 23);
			this.buttonScreenshot.TabIndex = 2;
			this.buttonScreenshot.Text = "Take Screenshot";
			this.buttonScreenshot.UseVisualStyleBackColor = true;
			this.buttonScreenshot.Click += new System.EventHandler(this.buttonScreenshot_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(234, 111);
			this.Controls.Add(this.buttonScreenshot);
			this.Controls.Add(this.buttonStop);
			this.Controls.Add(this.buttonStart);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.Button buttonScreenshot;
	}
}


```

<!-- code block end -->    

<!-- code block begin -->

##### ****Form1.cs:**
    
```
using System.Windows.Forms;
using BytescoutScreenCapturingLib;

// NOTE: if you are getting error like "invalid image" related to loading the SDK's dll then 
// try to do the following:
// 1) remove the reference to the SDK by View - Solution Explorer
// then click on References, select Bytescout... reference name and right-click it and select Remove
// 2) To re-add click on the menu: Project - Add Reference
// 3) In "Add Reference" dialog switch to "COM" tab and find "BytescoutScreenCapturing 1.0 Type Library"
// 4) Select it and click "Add" 
// 5) Recompile the application 
// Note: if you need to run on both x64 and x86 then please make sure you have set "Embed Interop Types" to True for this reference

namespace ScreenCapturingExample
{
	public partial class Form1 : Form
	{
		private Capturer _capturer = null;

		private int _screencastCount = 0;
		private int _screenshotCount = 0;

		public Form1()
		{
			InitializeComponent();

			// Create and setup Capturer object:

			_capturer = new Capturer();

			// Capture the full screen
			_capturer.CapturingType = CaptureAreaType.catScreen;

			// Set movie width and height to the current monitor dimensions
			_capturer.OutputWidth = _capturer.MonitorWidth;
			_capturer.OutputHeight = _capturer.MonitorHeight;

			// Setup screenshots
			_capturer.ScreenshotImageFormat = ScreenshotImageType.ssitPng; // Save images in PNG format
			_capturer.ScreenshotOutputFolder = "\\."; // Save to the current folder
			_capturer.ScreenshotSavingType = ScreenshotSavingType.ssstManual; // Take screenshots manually
		}

		private void buttonStart_Click(object sender, System.EventArgs e)
		{
			string fileName = string.Format("screencast{0}.wmv", ++_screencastCount);

			// Start screen recording
			_capturer.OutputFileName = fileName;
			_capturer.Run();

			buttonStart.Enabled = false;
			buttonStop.Enabled = true;
			buttonScreenshot.Enabled = true;
		}

		private void buttonStop_Click(object sender, System.EventArgs e)
		{
			// Stop recording
			_capturer.Stop();

			buttonStart.Enabled = true;
			buttonStop.Enabled = false;
			buttonScreenshot.Enabled = false;

			MessageBox.Show("Screencast saved to " + _capturer.OutputFileName, ProductName);
		}

		private void buttonScreenshot_Click(object sender, System.EventArgs e)
		{
			string fileName = string.Format("screenshot{0}.png", ++_screenshotCount);

			// Take screenshot during the recording
			_capturer.TakeScreenshot(fileName);

			MessageBox.Show("Screenshot saved to " + fileName, ProductName);
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
using System.Linq;
using System.Windows.Forms;

namespace ScreenCapturingExample
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****TakeScreenshotsDuringRecording.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{F6EFEF11-8ACE-48E6-86CF-728B83E9FB01}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <RootNamespace>TakeScreenshotsDuringRecording</RootNamespace>
    <AssemblyName>TakeScreenshotsDuringRecording</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="System" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Form1.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form1.Designer.cs">
      <DependentUpon>Form1.cs</DependentUpon>
    </Compile>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
    <EmbeddedResource Include="Form1.resx">
      <DependentUpon>Form1.cs</DependentUpon>
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
  </ItemGroup>
  <ItemGroup>
    <COMReference Include="BytescoutScreenCapturingLib">
      <Guid>{8EDAD3BB-AE5F-43B4-A2F1-B04F4130F2E0}</Guid>
      <VersionMajor>1</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>tlbimp</WrapperTool>
      <Isolated>False</Isolated>
      <EmbedInteropTypes>True</EmbedInteropTypes>
    </COMReference>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->