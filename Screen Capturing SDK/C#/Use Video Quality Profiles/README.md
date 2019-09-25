## How to use video quality profiles in C# and ByteScout Screen Capturing SDK

### Tutorial on how to use video quality profiles in C#

These sample source codes on this page below are demonstrating how to use video quality profiles in C#. Want to use video quality profiles in your C# app? ByteScout Screen Capturing SDK is designed for it. ByteScout Screen Capturing SDK is the tool for developers who want to add screen capturing in their application. Can record screen into video and into single screenshots. Output formats are WMV, AVI, WebM for video and PNG for screenshots. You can adjust output video size, quality, resolution, framerate, video and audio codecs. Includes special privacy features for blacking out sensitive information on screen. Can also capture video from web camera, can add overlays with text or images.

C# code samples for C# developers help to speed up coding of your application when using ByteScout Screen Capturing SDK. In your C# project or application you may simply copy & paste the code and then run your app! Further enhancement of the code will make it more vigorous.

Download free trial version of ByteScout Screen Capturing SDK from our website with this and other source code samples for C#.

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
namespace ScreenCapture
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
            this._txtOutputFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._numWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._numHeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this._numFramerate = new System.Windows.Forms.NumericUpDown();
            this._cmbQuality = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this._lblBitrate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._numEncodingThreads = new System.Windows.Forms.NumericUpDown();
            this._btnScreenCapture = new System.Windows.Forms.Button();
            this._btnPauseScreenCapture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numFramerate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numEncodingThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // _txtOutputFile
            // 
            this._txtOutputFile.Location = new System.Drawing.Point(16, 31);
            this._txtOutputFile.Margin = new System.Windows.Forms.Padding(4);
            this._txtOutputFile.Name = "_txtOutputFile";
            this._txtOutputFile.Size = new System.Drawing.Size(300, 22);
            this._txtOutputFile.TabIndex = 0;
            this._txtOutputFile.Text = "output.wmv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Output file";
            // 
            // _numWidth
            // 
            this._numWidth.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._numWidth.Location = new System.Drawing.Point(16, 96);
            this._numWidth.Margin = new System.Windows.Forms.Padding(4);
            this._numWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._numWidth.Name = "_numWidth";
            this._numWidth.Size = new System.Drawing.Size(160, 22);
            this._numWidth.TabIndex = 2;
            this._numWidth.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Height";
            // 
            // _numHeight
            // 
            this._numHeight.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._numHeight.Location = new System.Drawing.Point(184, 96);
            this._numHeight.Margin = new System.Windows.Forms.Padding(4);
            this._numHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._numHeight.Name = "_numHeight";
            this._numHeight.Size = new System.Drawing.Size(160, 22);
            this._numHeight.TabIndex = 4;
            this._numHeight.Value = new decimal(new int[] {
            768,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Framerate";
            // 
            // _numFramerate
            // 
            this._numFramerate.DecimalPlaces = 2;
            this._numFramerate.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._numFramerate.Location = new System.Drawing.Point(352, 96);
            this._numFramerate.Margin = new System.Windows.Forms.Padding(4);
            this._numFramerate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._numFramerate.Name = "_numFramerate";
            this._numFramerate.Size = new System.Drawing.Size(160, 22);
            this._numFramerate.TabIndex = 6;
            this._numFramerate.ThousandsSeparator = true;
            this._numFramerate.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // _cmbQuality
            // 
            this._cmbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbQuality.FormattingEnabled = true;
            this._cmbQuality.Location = new System.Drawing.Point(520, 96);
            this._cmbQuality.Margin = new System.Windows.Forms.Padding(4);
            this._cmbQuality.Name = "_cmbQuality";
            this._cmbQuality.Size = new System.Drawing.Size(240, 24);
            this._cmbQuality.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quality";
            // 
            // _lblBitrate
            // 
            this._lblBitrate.Location = new System.Drawing.Point(352, 145);
            this._lblBitrate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblBitrate.Name = "_lblBitrate";
            this._lblBitrate.Size = new System.Drawing.Size(408, 51);
            this._lblBitrate.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Number of encoding threads:";
            // 
            // _numEncodingThreads
            // 
            this._numEncodingThreads.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._numEncodingThreads.Location = new System.Drawing.Point(217, 142);
            this._numEncodingThreads.Margin = new System.Windows.Forms.Padding(4);
            this._numEncodingThreads.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this._numEncodingThreads.Name = "_numEncodingThreads";
            this._numEncodingThreads.Size = new System.Drawing.Size(127, 22);
            this._numEncodingThreads.TabIndex = 14;
            this._numEncodingThreads.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // _btnScreenCapture
            // 
            this._btnScreenCapture.Location = new System.Drawing.Point(19, 200);
            this._btnScreenCapture.Margin = new System.Windows.Forms.Padding(4);
            this._btnScreenCapture.Name = "_btnScreenCapture";
            this._btnScreenCapture.Size = new System.Drawing.Size(163, 28);
            this._btnScreenCapture.TabIndex = 16;
            this._btnScreenCapture.Text = "Screen capture video";
            this._btnScreenCapture.UseVisualStyleBackColor = true;
            this._btnScreenCapture.Click += new System.EventHandler(this._btnScreenCapture_Click);
            // 
            // _btnPauseScreenCapture
            // 
            this._btnPauseScreenCapture.Location = new System.Drawing.Point(205, 200);
            this._btnPauseScreenCapture.Margin = new System.Windows.Forms.Padding(4);
            this._btnPauseScreenCapture.Name = "_btnPauseScreenCapture";
            this._btnPauseScreenCapture.Size = new System.Drawing.Size(163, 28);
            this._btnPauseScreenCapture.TabIndex = 19;
            this._btnPauseScreenCapture.Text = "Pause Screen Capture";
            this._btnPauseScreenCapture.UseVisualStyleBackColor = true;
            this._btnPauseScreenCapture.Visible = false;
            this._btnPauseScreenCapture.Click += new System.EventHandler(this._btnPauseScreenCapture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 241);
            this.Controls.Add(this._btnPauseScreenCapture);
            this.Controls.Add(this._btnScreenCapture);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._numEncodingThreads);
            this.Controls.Add(this._lblBitrate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._cmbQuality);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._numFramerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._numHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._numWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtOutputFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Screen Capture Video";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numFramerate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numEncodingThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtOutputFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown _numWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown _numHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown _numFramerate;
        private System.Windows.Forms.ComboBox _cmbQuality;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _lblBitrate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown _numEncodingThreads;
        private System.Windows.Forms.Button _btnScreenCapture;
        private System.Windows.Forms.Button _btnPauseScreenCapture;
    }
}


```

<!-- code block end -->    

<!-- code block begin -->

##### ****Form1.cs:**
    
```
using BytescoutScreenCapturingLib;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ScreenCapture
{
    public partial class Form1 : Form
    {
        #region Fields

        private BytescoutScreenCapturingLib.Capturer _capturer;
        private bool _converting = false;
        private bool _paused = false;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Load Event Hanlde
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                _cmbQuality.DataSource = Enum.GetValues(typeof(VideoQualityProfileType));
                _cmbQuality.SelectedIndex = 0;

                _capturer = new BytescoutScreenCapturingLib.Capturer();
                _capturer.RegistrationName = "demo";
                _capturer.RegistrationKey = "demo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handle screen capture button click
        /// </summary>
        private void _btnScreenCapture_Click(object sender, EventArgs e)
        {
            try
            {
                if (_converting)
                {
                    if (_capturer.IsRunning)
                    {
                        _capturer.Stop();
                    }

                    StopCapturer();

                    _btnPauseScreenCapture.Visible = false;
                }
                else
                {
                    _capturer.OutputWidth = (int)_numWidth.Value;
                    _capturer.OutputHeight = (int)_numHeight.Value;
                    _capturer.FPS = (float)_numFramerate.Value;

                    _capturer.SetVideoQualityProfile((BytescoutScreenCapturingLib.VideoQualityProfileType)_cmbQuality.SelectedItem);

                    _lblBitrate.Text = string.Format("Bitrate: {0}[kbps], Wmv Quality: {1}, MinQuantizer: {2}, MaxQuantizer: {3}",
                                            _capturer.WMVVideoBitrate / 1000, _capturer.WmvVideoQuality,
                                            _capturer.WebmMinQuantizer, _capturer.WebmMaxQuantizer);

                    _capturer.AnimateMouseClicks = true;
                    _capturer.AnimateMouseButtons = true;
                    _capturer.CapturingType = BytescoutScreenCapturingLib.CaptureAreaType.catScreen;

                    _capturer.OutputFileName = _txtOutputFile.Text;

                    _capturer.EncoderThreadsCount = (int)_numEncodingThreads.Value;

                    _capturer.AudioEnabled = false;

                    _capturer.Run();

                    _converting = true;
                    _btnScreenCapture.Text = "Stop screen capture";

                    _btnPauseScreenCapture.Visible = true;
                    _paused = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Pause screen capture
        /// </summary>
        private void _btnPauseScreenCapture_Click(object sender, EventArgs e)
        {
            if (_paused)
            {
                _capturer.Run();
                _btnPauseScreenCapture.Text = "Pause Screen Capture";
                _paused = false;
            }
            else
            {
                _capturer.Pause();
                _btnPauseScreenCapture.Text = "Resume Screen Capture";
                _paused = true;
            }
        }

        /// <summary>
        /// Stop Capture
        /// </summary>
        private void StopCapturer()
        {
            _converting = false;
            _btnScreenCapture.Text = "Screen capture video";

            // Open captured video
            Process.Start(_txtOutputFile.Text);
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
using System.Windows.Forms;

namespace ScreenCapture
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

##### ****ScreenCapture.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="15.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{70591ABB-7738-41A5-B1F5-AF2A5BA88570}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ScreenCapture</RootNamespace>
    <AssemblyName>ScreenCapture</AssemblyName>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
    <FileUpgradeFlags>
    </FileUpgradeFlags>
    <UpgradeBackupLocation>
    </UpgradeBackupLocation>
    <OldToolsVersion>2.0</OldToolsVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <PlatformTarget>x86</PlatformTarget>
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
    <Reference Include="System.Deployment" />
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
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.cs</DependentUpon>
    </EmbeddedResource>
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
    <Folder Include="Properties\" />
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

##### ****ScreenCapture.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.28010.2003
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "ScreenCapture", "ScreenCapture.csproj", "{70591ABB-7738-41A5-B1F5-AF2A5BA88570}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{70591ABB-7738-41A5-B1F5-AF2A5BA88570}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{70591ABB-7738-41A5-B1F5-AF2A5BA88570}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{70591ABB-7738-41A5-B1F5-AF2A5BA88570}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{70591ABB-7738-41A5-B1F5-AF2A5BA88570}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {B68F8AC8-F24A-4270-AE61-D22F0566FB87}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->