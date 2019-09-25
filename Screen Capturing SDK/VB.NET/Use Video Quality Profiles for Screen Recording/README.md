## How to use video quality profiles for screen recording in VB.NET using ByteScout Screen Capturing SDK

### How to code in VB.NET to use video quality profiles for screen recording with this step-by-step tutorial

These sample source codes on this page below are demonstrating how to use video quality profiles for screen recording in VB.NET. ByteScout Screen Capturing SDK is the SDK for developers for quick implementation of screen video recording. The SDK records screen into video or into a series of screenshots. Can also record audio. Saves video into AVI,WMV and Google's WebM. Output video quality, size, resolution or framerate can be adjusted easily. Provides additional tools for privacy features like blacking out on scren areas with sensitive information on screen right during recording. Supports web camera as input and can add instant text and images into video output. It can be used to use video quality profiles for screen recording using VB.NET.

VB.NET code samples for VB.NET developers help to speed up coding of your application when using ByteScout Screen Capturing SDK. Follow the instructions from the scratch to work and copy the VB.NET code. Enjoy writing a code with ready-to-use sample VB.NET codes.

You can download free trial version of ByteScout Screen Capturing SDK from our website to see and try many others source code samples for VB.NET.

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
        Me._btnPauseScreenCapture = New System.Windows.Forms.Button()
        Me._btnScreenCapture = New System.Windows.Forms.Button()
        Me.label6 = New System.Windows.Forms.Label()
        Me._numEncodingThreads = New System.Windows.Forms.NumericUpDown()
        Me._lblBitrate = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me._cmbQuality = New System.Windows.Forms.ComboBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me._numFramerate = New System.Windows.Forms.NumericUpDown()
        Me.label3 = New System.Windows.Forms.Label()
        Me._numHeight = New System.Windows.Forms.NumericUpDown()
        Me.label2 = New System.Windows.Forms.Label()
        Me._numWidth = New System.Windows.Forms.NumericUpDown()
        Me.label1 = New System.Windows.Forms.Label()
        Me._txtOutputFile = New System.Windows.Forms.TextBox()
        CType(Me._numEncodingThreads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._numFramerate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._numHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._numWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_btnPauseScreenCapture
        '
        Me._btnPauseScreenCapture.Location = New System.Drawing.Point(201, 202)
        Me._btnPauseScreenCapture.Margin = New System.Windows.Forms.Padding(4)
        Me._btnPauseScreenCapture.Name = "_btnPauseScreenCapture"
        Me._btnPauseScreenCapture.Size = New System.Drawing.Size(163, 28)
        Me._btnPauseScreenCapture.TabIndex = 34
        Me._btnPauseScreenCapture.Text = "Pause Screen Capture"
        Me._btnPauseScreenCapture.UseVisualStyleBackColor = True
        Me._btnPauseScreenCapture.Visible = False
        '
        '_btnScreenCapture
        '
        Me._btnScreenCapture.Location = New System.Drawing.Point(15, 202)
        Me._btnScreenCapture.Margin = New System.Windows.Forms.Padding(4)
        Me._btnScreenCapture.Name = "_btnScreenCapture"
        Me._btnScreenCapture.Size = New System.Drawing.Size(163, 28)
        Me._btnScreenCapture.TabIndex = 33
        Me._btnScreenCapture.Text = "Screen capture video"
        Me._btnScreenCapture.UseVisualStyleBackColor = True
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(13, 147)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(192, 17)
        Me.label6.TabIndex = 32
        Me.label6.Text = "Number of encoding threads:"
        '
        '_numEncodingThreads
        '
        Me._numEncodingThreads.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me._numEncodingThreads.Location = New System.Drawing.Point(213, 144)
        Me._numEncodingThreads.Margin = New System.Windows.Forms.Padding(4)
        Me._numEncodingThreads.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me._numEncodingThreads.Name = "_numEncodingThreads"
        Me._numEncodingThreads.Size = New System.Drawing.Size(127, 22)
        Me._numEncodingThreads.TabIndex = 31
        Me._numEncodingThreads.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        '_lblBitrate
        '
        Me._lblBitrate.Location = New System.Drawing.Point(348, 147)
        Me._lblBitrate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me._lblBitrate.Name = "_lblBitrate"
        Me._lblBitrate.Size = New System.Drawing.Size(408, 51)
        Me._lblBitrate.TabIndex = 30
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(512, 78)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(52, 17)
        Me.label5.TabIndex = 29
        Me.label5.Text = "Quality"
        '
        '_cmbQuality
        '
        Me._cmbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbQuality.FormattingEnabled = True
        Me._cmbQuality.Location = New System.Drawing.Point(516, 98)
        Me._cmbQuality.Margin = New System.Windows.Forms.Padding(4)
        Me._cmbQuality.Name = "_cmbQuality"
        Me._cmbQuality.Size = New System.Drawing.Size(240, 24)
        Me._cmbQuality.TabIndex = 28
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(348, 78)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(73, 17)
        Me.label4.TabIndex = 27
        Me.label4.Text = "Framerate"
        '
        '_numFramerate
        '
        Me._numFramerate.DecimalPlaces = 2
        Me._numFramerate.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me._numFramerate.Location = New System.Drawing.Point(348, 98)
        Me._numFramerate.Margin = New System.Windows.Forms.Padding(4)
        Me._numFramerate.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me._numFramerate.Name = "_numFramerate"
        Me._numFramerate.Size = New System.Drawing.Size(160, 22)
        Me._numFramerate.TabIndex = 26
        Me._numFramerate.ThousandsSeparator = True
        Me._numFramerate.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(180, 78)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(49, 17)
        Me.label3.TabIndex = 25
        Me.label3.Text = "Height"
        '
        '_numHeight
        '
        Me._numHeight.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me._numHeight.Location = New System.Drawing.Point(180, 98)
        Me._numHeight.Margin = New System.Windows.Forms.Padding(4)
        Me._numHeight.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me._numHeight.Name = "_numHeight"
        Me._numHeight.Size = New System.Drawing.Size(160, 22)
        Me._numHeight.TabIndex = 24
        Me._numHeight.Value = New Decimal(New Integer() {768, 0, 0, 0})
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 78)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(44, 17)
        Me.label2.TabIndex = 23
        Me.label2.Text = "Width"
        '
        '_numWidth
        '
        Me._numWidth.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me._numWidth.Location = New System.Drawing.Point(12, 98)
        Me._numWidth.Margin = New System.Windows.Forms.Padding(4)
        Me._numWidth.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me._numWidth.Name = "_numWidth"
        Me._numWidth.Size = New System.Drawing.Size(160, 22)
        Me._numWidth.TabIndex = 22
        Me._numWidth.Value = New Decimal(New Integer() {1024, 0, 0, 0})
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 9)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(73, 17)
        Me.label1.TabIndex = 21
        Me.label1.Text = "Output file"
        '
        '_txtOutputFile
        '
        Me._txtOutputFile.Location = New System.Drawing.Point(12, 33)
        Me._txtOutputFile.Margin = New System.Windows.Forms.Padding(4)
        Me._txtOutputFile.Name = "_txtOutputFile"
        Me._txtOutputFile.Size = New System.Drawing.Size(300, 22)
        Me._txtOutputFile.TabIndex = 20
        Me._txtOutputFile.Text = "output.wmv"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 251)
        Me.Controls.Add(Me._btnPauseScreenCapture)
        Me.Controls.Add(Me._btnScreenCapture)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me._numEncodingThreads)
        Me.Controls.Add(Me._lblBitrate)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me._cmbQuality)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me._numFramerate)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me._numHeight)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me._numWidth)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me._txtOutputFile)
        Me.Name = "Form1"
        Me.Text = "Screen Capture Video"
        CType(Me._numEncodingThreads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._numFramerate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._numHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._numWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents _btnPauseScreenCapture As Button
    Private WithEvents _btnScreenCapture As Button
    Private WithEvents label6 As Label
    Private WithEvents _numEncodingThreads As NumericUpDown
    Private WithEvents _lblBitrate As Label
    Private WithEvents label5 As Label
    Private WithEvents _cmbQuality As ComboBox
    Private WithEvents label4 As Label
    Private WithEvents _numFramerate As NumericUpDown
    Private WithEvents label3 As Label
    Private WithEvents _numHeight As NumericUpDown
    Private WithEvents label2 As Label
    Private WithEvents _numWidth As NumericUpDown
    Private WithEvents label1 As Label
    Private WithEvents _txtOutputFile As TextBox
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Form1.vb:**
    
```
Imports BytescoutScreenCapturingLib

Public Class Form1

#Region "Fields"

    Private _capturer As BytescoutScreenCapturingLib.Capturer
    Private _converting As Boolean = False
    Private _paused As Boolean = False

#End Region

    ''' <summary>
    ''' Form load event handler
    ''' </summary>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _cmbQuality.DataSource = [Enum].GetValues(GetType(VideoQualityProfileType))
            _cmbQuality.SelectedIndex = 0

            _capturer = New BytescoutScreenCapturingLib.Capturer()
            _capturer.RegistrationName = "demo"
            _capturer.RegistrationKey = "demo"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Handle screen capture button click
    ''' </summary>
    Private Sub _btnScreenCapture_Click(sender As Object, e As EventArgs) Handles _btnScreenCapture.Click
        Try

            If _converting Then

                If _capturer.IsRunning Then
                    _capturer.[Stop]()
                End If

                StopCapturer()

                _btnPauseScreenCapture.Visible = False

            Else

                _capturer.OutputWidth = CInt(_numWidth.Value)
                _capturer.OutputHeight = CInt(_numHeight.Value)
                _capturer.FPS = CSng(_numFramerate.Value)

                _capturer.SetVideoQualityProfile(CType(_cmbQuality.SelectedItem, BytescoutScreenCapturingLib.VideoQualityProfileType))

                _lblBitrate.Text = String.Format("Bitrate: {0}[kbps], Wmv Quality: {1}, MinQuantizer: {2}, MaxQuantizer: {3}", _capturer.WMVVideoBitrate / 1000, _capturer.WmvVideoQuality, _capturer.WebmMinQuantizer, _capturer.WebmMaxQuantizer)

                _capturer.AnimateMouseClicks = True
                _capturer.AnimateMouseButtons = True
                _capturer.CapturingType = BytescoutScreenCapturingLib.CaptureAreaType.catScreen

                _capturer.OutputFileName = _txtOutputFile.Text

                _capturer.EncoderThreadsCount = CInt(_numEncodingThreads.Value)

                _capturer.AudioEnabled = False

                _capturer.Run()

                _converting = True
                _btnScreenCapture.Text = "Stop screen capture"

                _btnPauseScreenCapture.Visible = True
                _paused = False

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub _btnPauseScreenCapture_Click(sender As Object, e As EventArgs) Handles _btnPauseScreenCapture.Click
        If _paused Then
            _capturer.Run()
            _btnPauseScreenCapture.Text = "Pause Screen Capture"
            _paused = False
        Else
            _capturer.Pause()
            _btnPauseScreenCapture.Text = "Resume Screen Capture"
            _paused = True
        End If
    End Sub

    Private Sub StopCapturer()
        _converting = False
        _btnScreenCapture.Text = "Screen capture video"

        Process.Start(_txtOutputFile.Text)
    End Sub

End Class
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ScreenCapture.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27703.2026
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "ScreenCapture", "ScreenCapture.vbproj", "{9B1BAFE7-3C07-4273-9C07-CF74236B7CD8}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{9B1BAFE7-3C07-4273-9C07-CF74236B7CD8}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{9B1BAFE7-3C07-4273-9C07-CF74236B7CD8}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{9B1BAFE7-3C07-4273-9C07-CF74236B7CD8}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{9B1BAFE7-3C07-4273-9C07-CF74236B7CD8}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {9FD4245F-8A26-446D-A1EE-6D0D909F4A99}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ScreenCapture.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{9B1BAFE7-3C07-4273-9C07-CF74236B7CD8}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <StartupObject>ScreenCapture.Form1</StartupObject>
    <RootNamespace>ScreenCapture</RootNamespace>
    <AssemblyName>ScreenCapture</AssemblyName>
    <FileAlignment>512</FileAlignment>
    <MyType>WindowsForms</MyType>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>ScreenCapture.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>ScreenCapture.xml</DocumentationFile>
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
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
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
    <Compile Include="Form1.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form1.Designer.vb">
      <DependentUpon>Form1.vb</DependentUpon>
      <SubType>Form</SubType>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="Form1.resx">
      <DependentUpon>Form1.vb</DependentUpon>
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
      <EmbedInteropTypes>True</EmbedInteropTypes>
    </COMReference>
  </ItemGroup>
  <ItemGroup>
    <Folder Include="My Project\" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->