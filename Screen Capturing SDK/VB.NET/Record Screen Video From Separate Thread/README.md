## How to record screen video from separate thread in VB.NET using ByteScout Screen Capturing SDK

### How to record screen video from separate thread in VB.NET

Learn how to record screen video from separate thread in VB.NET with this source code sample. ByteScout Screen Capturing SDK is the screen video recording SDK helps in quick implementation of screen video recording. WMV, AVI, WebM output options are available with adjustable quality, video size, framerate and video and audio codec. Includes special features like live multiple blacking out of selected areas, recording from web cam as main source and as overlay, optional watermarks for output video. It can be used to record screen video from separate thread using VB.NET.

The SDK samples like this one below explain how to quickly make your application do record screen video from separate thread in VB.NET with the help of ByteScout Screen Capturing SDK. Follow the instructions from the scratch to work and copy the VB.NET code. Further enhancement of the code will make it more vigorous.

Free trial version of ByteScout Screen Capturing SDK is available on our website. Documentation and source code samples are included.

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

##### ****CaptureFromSeparateThread.VS2005.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{2D654BAC-2892-42A7-AD8B-289249D4F830}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>CaptureFromSeparateThread</RootNamespace>
    <AssemblyName>CaptureFromSeparateThread</AssemblyName>
    <StartupObject>CaptureFromSeparateThread.Program</StartupObject>
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
    <Compile Include="CapturingThread.vb" />
    <Compile Include="CapturingThreadData.vb" />
    <Compile Include="Form1.Designer.vb">
      <DependentUpon>Form1.vb</DependentUpon>
    </Compile>
    <Compile Include="Form1.vb">
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
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>ResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
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
    </COMReference>
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****CaptureFromSeparateThread.VS2008.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build" ToolsVersion="3.5">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.21022</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{2D654BAC-2892-42A7-AD8B-289249D4F830}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>CaptureFromSeparateThread</RootNamespace>
    <AssemblyName>CaptureFromSeparateThread</AssemblyName>
    <StartupObject>CaptureFromSeparateThread.Program</StartupObject>
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
    <Compile Include="CapturingThread.vb" />
    <Compile Include="CapturingThreadData.vb" />
    <Compile Include="Form1.Designer.vb">
      <DependentUpon>Form1.vb</DependentUpon>
    </Compile>
    <Compile Include="Form1.vb">
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
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>ResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
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
    </COMReference>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****CaptureFromSeparateThread.VS2010.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{2D654BAC-2892-42A7-AD8B-289249D4F830}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>CaptureFromSeparateThread</RootNamespace>
    <AssemblyName>CaptureFromSeparateThread</AssemblyName>
    <StartupObject>CaptureFromSeparateThread.Program</StartupObject>
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
    <Compile Include="CapturingThread.vb" />
    <Compile Include="CapturingThreadData.vb" />
    <Compile Include="Form1.Designer.vb">
      <DependentUpon>Form1.vb</DependentUpon>
    </Compile>
    <Compile Include="Form1.vb">
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
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>ResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
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
    </COMReference>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****CapturingThread.vb:**
    
```
Imports System.Drawing
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Threading
Imports BytescoutScreenCapturingLib

' NOTE: if you are getting error like "invalid image" related to loading the SDK's dll then 
' try to do the following:
' 1) remove the reference to the SDK by View - Solution Explorer
' then click on References, select Bytescout... reference name and right-click it and select Remove
' 2) To re-add click on the menu: Project - Add Reference
' 3) In "Add Reference" dialog switch to "COM" tab and find Bytescout...
' 4) Select it and click "Add" 
' 5) Recompile the application 
' Note: if you need to run on both x64 and x86 then please make sure you have set "Embed Interop Types" to True for this reference

Public Class CapturingThread

    Public Shared Sub ThreadProc(ByVal obj As Object)

        Dim data As CapturingThreadData = DirectCast(obj, CapturingThreadData)
        data.Success = True

        ' Prepare Capturer:

        Dim capturer As New Capturer()
        capturer.RegistrationName = "demo"
        capturer.RegistrationKey = "demo"

        capturer.CaptureRectLeft = data.CaptureRectangle.Left
        capturer.CaptureRectTop = data.CaptureRectangle.Top
        capturer.CaptureRectWidth = data.CaptureRectangle.Width
        capturer.CaptureRectHeight = data.CaptureRectangle.Height

        capturer.OutputWidth = 640
        capturer.OutputHeight = 480

        ' // WMV and WEBM output use WMVVideoBitrate property to control output video bitrate
        ' // so try to increase it by x2 or x3 times if you think the output video are you are getting is laggy
        ' capturer.WMVVideoBitrate = capturer.WMVVideoBitrate * 2
        
        data.TempFile = Path.GetTempFileName()
        data.TempFile = Path.ChangeExtension(data.TempFile, ".wmv")

        capturer.OutputFileName = data.TempFile
        capturer.CapturingType = data.CaptureType

        ' set border around captured area if we are not capturing entire screen
        If capturer.CapturingType <> CaptureAreaType.catScreen And capturer.CapturingType <> CaptureAreaType.catWebcamFullScreen Then

            capturer.CaptureAreaBorderType = CaptureAreaBorderType.cabtDashed
            capturer.CaptureAreaBorderColor = CType(ColorTranslator.ToOle(Color.Red), UInteger)

        End If


        ' Wait for events:

        Dim events As WaitHandle() = New WaitHandle() {data.StartOrResumeEvent, data.PauseEvent, data.StopEvent}

        Try

            While (True)

                Dim i As Integer = WaitHandle.WaitAny(events)

                If events(i) Is data.StartOrResumeEvent Then

                    If Not capturer.IsRunning Then
                        capturer.Run()
                    End If

                ElseIf events(i) Is data.PauseEvent Then

                    If capturer.IsRunning Then
                        capturer.Pause()
                    End If

                ElseIf events(i) Is data.StopEvent Then

                    capturer.Stop()
                    Exit While

                End If
                
            End While

        Catch ex As Exception

            data.ErrorText = ex.Message
            data.Success = False

        Finally

            ' Release resources
            Marshal.ReleaseComObject(capturer)

        End Try

    End Sub

End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****CapturingThreadData.vb:**
    
```
Imports System.Drawing
Imports System.Threading
Imports BytescoutScreenCapturingLib

Public Class CapturingThreadData

    Public CaptureType As CaptureAreaType
    Public TempFile As String
    Public CaptureRectangle As Rectangle = New Rectangle(0, 0, 320, 240)

    Public Success As Boolean
    Public ErrorText As String

    Public StartOrResumeEvent As AutoResetEvent = New AutoResetEvent(False) ' event signalling to start or resume the recodring
    Public PauseEvent As AutoResetEvent = New AutoResetEvent(False) ' event signalling to pause the recodring
    Public StopEvent As AutoResetEvent = New AutoResetEvent(False) ' event signalling to stop the recording 

End Class



```

<!-- code block end -->    

<!-- code block begin -->

##### ****Form1.Designer.vb:**
    
```
Partial Class Form1
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
        Me.cmbCapturingType = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnPauseResume = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbCapturingType
        '
        Me.cmbCapturingType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCapturingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCapturingType.FormattingEnabled = True
        Me.cmbCapturingType.Items.AddRange(New Object() {"Area around the mouse pointer", "Full screen"})
        Me.cmbCapturingType.Location = New System.Drawing.Point(97, 12)
        Me.cmbCapturingType.Name = "cmbCapturingType"
        Me.cmbCapturingType.Size = New System.Drawing.Size(378, 21)
        Me.cmbCapturingType.TabIndex = 0
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(79, 13)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Capturing Type"
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableLayoutPanel1.ColumnCount = 3
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.btnPauseResume, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.btnStart, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.btnStop, 2, 0)
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(12, 52)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 1
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(463, 57)
        Me.tableLayoutPanel1.TabIndex = 6
        '
        'btnPauseResume
        '
        Me.btnPauseResume.Enabled = False
        Me.btnPauseResume.Location = New System.Drawing.Point(155, 3)
        Me.btnPauseResume.Name = "btnPauseResume"
        Me.btnPauseResume.Size = New System.Drawing.Size(143, 44)
        Me.btnPauseResume.TabIndex = 5
        Me.btnPauseResume.Text = "Pause"
        Me.btnPauseResume.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(3, 3)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(143, 44)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(307, 3)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(143, 44)
        Me.btnStop.TabIndex = 4
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 121)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cmbCapturingType)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capture From Separate Thread"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

	#End Region

	Private cmbCapturingType As System.Windows.Forms.ComboBox
    Private label1 As System.Windows.Forms.Label
    Private WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents btnPauseResume As System.Windows.Forms.Button
    Private WithEvents btnStart As System.Windows.Forms.Button
    Private WithEvents btnStop As System.Windows.Forms.Button
End Class


```

<!-- code block end -->    

<!-- code block begin -->

##### ****Form1.vb:**
    
```
Imports System.Diagnostics
Imports System.IO
Imports System.Threading
Imports System.Windows.Forms
Imports BytescoutScreenCapturingLib

' NOTE: if you are getting error like "invalid image" related to loading the SDK's dll then 
' try to do the following:
' 1) remove the reference to the SDK by View - Solution Explorer
' then click on References, select Bytescout... reference name and right-click it and select Remove
' 2) To re-add click on the menu: Project - Add Reference
' 3) In "Add Reference" dialog switch to "COM" tab and find Bytescout...
' 4) Select it and click "Add" 
' 5) Recompile the application 
' Note: if you need to run on both x64 and x86 then please make sure you have set "Embed Interop Types" to True for this reference

Public Partial Class Form1
	Inherits Form

    Private _capturingThread As Thread
    Private _capturingThreadData As CapturingThreadData  ' data to exchange between form and capturing thread

    Public Sub New()

        InitializeComponent()

        _capturingThreadData = New CapturingThreadData()

        cmbCapturingType.SelectedIndex = 0

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim captureType As CaptureAreaType = CaptureAreaType.catMouse

        If cmbCapturingType.SelectedIndex = 1 Then
            captureType = CaptureAreaType.catScreen
        End If

        StartRecording(captureType)

    End Sub

    Private Sub btnPauseResume_Click(sender As System.Object, e As System.EventArgs) Handles btnPauseResume.Click

        PauseOrResumeRecording()

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click

        StopRecording()

    End Sub

    Private Sub StartRecording(ByVal captureType As CaptureAreaType)

        btnStart.Enabled = False
        btnPauseResume.Enabled = True
        btnStop.Enabled = True

        _capturingThreadData.CaptureType = captureType

        ' Start thread
        _capturingThread = New Thread(AddressOf CapturingThread.ThreadProc)
        _capturingThread.Start(_capturingThreadData)

        ' Signal to start the recording
        _capturingThreadData.StartOrResumeEvent.Set()
        
    End Sub

    Private Sub PauseOrResumeRecording()

        btnStart.Enabled = False
        btnPauseResume.Enabled = True
        btnStop.Enabled = True

        If btnPauseResume.Text = "Pause" Then
            ' Signal to pause
            _capturingThreadData.PauseEvent.Set()
            btnPauseResume.Text = "Resume"

        Else
            ' Signal to resume
            _capturingThreadData.StartOrResumeEvent.Set()
            btnPauseResume.Text = "Pause"
        End If

    End Sub

    Private Sub StopRecording()

        Cursor = Cursors.WaitCursor

        ' Signal to stop
        _capturingThreadData.StopEvent.Set()

        Try
            _capturingThread.Join()
        Finally
            Cursor = Cursors.Default
        End Try

        If Not _capturingThreadData.Success Then
            MessageBox.Show("Capturing failed. Error: " & _capturingThreadData.ErrorText)
        Else
            Dim dlg As New SaveFileDialog()
            dlg.DefaultExt = "*.wmv"
            dlg.Filter = "WMV files (*.wmv)|*.wmv|All files (*.*)|*.*"

            dlg.FileName = "Screencast"
            dlg.Title = "Save captured video as"

            If dlg.ShowDialog() = DialogResult.OK Then
                File.Copy(_capturingThreadData.TempFile, dlg.FileName, True)
                ' start the video in default associated application
                Process.Start(dlg.FileName)
            End If

            File.Delete(_capturingThreadData.TempFile)
        End If

        btnStart.Enabled = True
        btnPauseResume.Enabled = False
        btnStop.Enabled = False
        btnPauseResume.Text = "Pause"

    End Sub

    Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        _capturingThreadData.StopEvent.Set()

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
		Application.Run(New Form1())
	End Sub
End Class

```

<!-- code block end -->