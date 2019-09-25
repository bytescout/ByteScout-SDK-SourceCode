## take screenshots during recording in VB.NET using ByteScout Screen Capturing SDK

### How To: tutorial on take screenshots during recording in VB.NET

The documentation is designed to help you to implement the features on your side. Take screenshots during recording in VB.NET can be implemented with ByteScout Screen Capturing SDK. ByteScout Screen Capturing SDK is the tool for developers who want to add screen capturing in their application. Can record screen into video and into single screenshots. Output formats are WMV, AVI, WebM for video and PNG for screenshots. You can adjust output video size, quality, resolution, framerate, video and audio codecs. Includes special privacy features for blacking out sensitive information on screen. Can also capture video from web camera, can add overlays with text or images.

VB.NET, code samples for VB.NET, developers help to speed up the application development and writing a code when using ByteScout Screen Capturing SDK. In order to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Use of ByteScout Screen Capturing SDK in VB.NET is also explained in the documentation included along with the product.

On our website you may get trial version of ByteScout Screen Capturing SDK for free. Source code samples are included to help you with your VB.NET application.

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
		Me.buttonScreenshot = New System.Windows.Forms.Button()
		Me.buttonStop = New System.Windows.Forms.Button()
		Me.buttonStart = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'buttonScreenshot
		'
		Me.buttonScreenshot.Enabled = False
		Me.buttonScreenshot.Location = New System.Drawing.Point(108, 41)
		Me.buttonScreenshot.Name = "buttonScreenshot"
		Me.buttonScreenshot.Size = New System.Drawing.Size(100, 23)
		Me.buttonScreenshot.TabIndex = 5
		Me.buttonScreenshot.Text = "Take Screenshot"
		Me.buttonScreenshot.UseVisualStyleBackColor = True
		'
		'buttonStop
		'
		Me.buttonStop.Enabled = False
		Me.buttonStop.Location = New System.Drawing.Point(27, 58)
		Me.buttonStop.Name = "buttonStop"
		Me.buttonStop.Size = New System.Drawing.Size(75, 23)
		Me.buttonStop.TabIndex = 4
		Me.buttonStop.Text = "Stop"
		Me.buttonStop.UseVisualStyleBackColor = True
		'
		'buttonStart
		'
		Me.buttonStart.Location = New System.Drawing.Point(27, 29)
		Me.buttonStart.Name = "buttonStart"
		Me.buttonStart.Size = New System.Drawing.Size(75, 23)
		Me.buttonStart.TabIndex = 3
		Me.buttonStart.Text = "Start"
		Me.buttonStart.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(234, 111)
		Me.Controls.Add(Me.buttonScreenshot)
		Me.Controls.Add(Me.buttonStop)
		Me.Controls.Add(Me.buttonStart)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form1"
		Me.ResumeLayout(False)

	End Sub
	Private WithEvents buttonScreenshot As System.Windows.Forms.Button
	Private WithEvents buttonStop As System.Windows.Forms.Button
	Private WithEvents buttonStart As System.Windows.Forms.Button

End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Form1.vb:**
    
```
Imports BytescoutScreenCapturingLib

Public Class Form1

	' NOTE: if you are getting error like "invalid image" related to loading the SDK's dll then 
	' try to do the following:
	' 1) remove the reference to the SDK by View - Solution Explorer
	' then click on References, select Bytescout... reference name and right-click it and select Remove
	' 2) To re-add click on the menu: Project - Add Reference
	' 3) In "Add Reference" dialog switch to "COM" tab and find "BytescoutScreenCapturing 1.0 Type Library"
	' 4) Select it and click "Add" 
	' 5) Recompile the application 
	' Note: if you need to run on both x64 and x86 then please make sure you have set "Embed Interop Types" to True for this reference

	Dim _capturer As Capturer = Nothing

	Dim _screencastCount As Integer = 0
	Dim _screenshotCount As Integer = 0

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		' Create and setup Capturer object:

		_capturer = New Capturer()

		' Capture the full screen
		_capturer.CapturingType = CaptureAreaType.catScreen

		' Set movie width and height to the current monitor dimensions
		_capturer.OutputWidth = _capturer.MonitorWidth
		_capturer.OutputHeight = _capturer.MonitorHeight

		' Setup screenshots
		_capturer.ScreenshotImageFormat = ScreenshotImageType.ssitPng ' Save images in PNG format
		_capturer.ScreenshotOutputFolder = "\."	' Save to the current folder
		_capturer.ScreenshotSavingType = ScreenshotSavingType.ssstManual ' Take screenshots manually

	End Sub

	Private Sub buttonStart_Click(sender As Object, e As EventArgs) Handles buttonStart.Click

		_screencastCount = _screencastCount + 1
		Dim fileName As String = String.Format("screencast{0}.wmv", _screencastCount)

		' Start screen recording
		_capturer.OutputFileName = fileName
		_capturer.Run()

		buttonStart.Enabled = False
		buttonStop.Enabled = True
		buttonScreenshot.Enabled = True

	End Sub

	Private Sub buttonStop_Click(sender As Object, e As EventArgs) Handles buttonStop.Click

		' Stop recording
		_capturer.Stop()

		buttonStart.Enabled = True
		buttonStop.Enabled = False
		buttonScreenshot.Enabled = False

		MessageBox.Show("Screencast saved to " + _capturer.OutputFileName, ProductName)

	End Sub

	Private Sub buttonScreenshot_Click(sender As Object, e As EventArgs) Handles buttonScreenshot.Click

		_screenshotCount = _screenshotCount + 1
		Dim fileName As String = String.Format("screenshot{0}.png", _screenshotCount)

		' Take screenshot during the recording
		_capturer.TakeScreenshot(fileName)

		MessageBox.Show("Screenshot saved to " + fileName, ProductName)

	End Sub

End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****TakeScreenshotsDuringRecording.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="12.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{93943AEE-21CD-409C-8ED2-4519C45BEC26}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <StartupObject>TakeScreenshotsDuringRecording.My.MyApplication</StartupObject>
    <RootNamespace>TakeScreenshotsDuringRecording</RootNamespace>
    <AssemblyName>TakeScreenshotsDuringRecording</AssemblyName>
    <FileAlignment>512</FileAlignment>
    <MyType>WindowsForms</MyType>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>TakeScreenshotsDuringRecording.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>TakeScreenshotsDuringRecording.xml</DocumentationFile>
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
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
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
    <Import Include="System.Linq" />
    <Import Include="System.Xml.Linq" />
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