## How to read barcode from live video cam (simplified) with barcode reader sdk in VB.NET with ByteScout Barcode Suite

### How to write a robust code in VB.NET to read barcode from live video cam (simplified) with barcode reader sdk with this step-by-step tutorial

The documentation is designed for a specific purpose to help you to apply the features on your side. ByteScout Barcode Suite can read barcode from live video cam (simplified) with barcode reader sdk. It can be applied from VB.NET. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK.

The following code snippet for ByteScout Barcode Suite works best when you need to quickly read barcode from live video cam (simplified) with barcode reader sdk in your VB.NET application.  Simply copy and paste in your VB.NET project or application you and then run your app! Applying VB.NET application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

If you want to try other source code samples then the free trial version of ByteScout Barcode Suite is available for download from our website. Just try other source code samples for VB.NET.

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

##### ****Program.vb:**
    
```
Imports System.Windows.Forms

NotInheritable Class Program
	Private Sub New()
	End Sub
	''' <summary>
	''' The main entry point for the application.
	''' </summary>
	<MTAThread> _
	Friend Shared Sub Main()
		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)

        ' Show barcode decoder dialog and get decoded barcode value
        Dim decodedBarcodeValue As String = WebCamBarcodeDecoder.DecodeBarcode()

        If decodedBarcodeValue IsNot Nothing Then
            MessageBox.Show("Found barcode: " & decodedBarcodeValue)
        Else
            MessageBox.Show("Decoding cancelled")
        End If

    End Sub
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ReadFromVideoCamera.VS2005.vbproj:**
    
```
<Project ToolsVersion="3.5" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{2709B33C-231F-4007-9FCA-A5F1A93F5F8A}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <RootNamespace>ReadFromVideoCamera</RootNamespace>
    <AssemblyName>ReadFromVideoCamera</AssemblyName>
    <FileUpgradeFlags>
    </FileUpgradeFlags>
    <UpgradeBackupLocation>
    </UpgradeBackupLocation>
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
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Debug|x86'">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\x86\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisIgnoreBuiltInRuleSets>false</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisIgnoreBuiltInRules>false</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Release|x86'">
    <OutputPath>bin\x86\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisIgnoreBuiltInRuleSets>false</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisIgnoreBuiltInRules>false</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <PropertyGroup>
    <StartupObject>ReadFromVideoCamera.Program</StartupObject>
  </PropertyGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Reference Include="Bytescout.BarCodeReader, Version=8.20.0.1340, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Reader SDK\net2.00\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
    <Reference Include="TouchlessLib, Version=1.0.0.0, Culture=neutral, processorArchitecture=x86">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Compile Include="Program.vb" />
    <Compile Include="WebCamBarcodeDecoder.Designer.vb">
      <DependentUpon>WebCamBarcodeDecoder.vb</DependentUpon>
    </Compile>
    <Compile Include="WebCamBarcodeDecoder.vb">
      <SubType>Form</SubType>
    </Compile>
    <Content Include="TouchlessLib.dll">
    </Content>
    <Content Include="WebCamLib.dll">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <EmbeddedResource Include="WebCamBarcodeDecoder.resx">
      <DependentUpon>WebCamBarcodeDecoder.vb</DependentUpon>
      <SubType>Designer</SubType>
    </EmbeddedResource>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ReadFromVideoCamera.VS2008.vbproj:**
    
```
<Project ToolsVersion="3.5" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>9.0.30729</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{2709B33C-231F-4007-9FCA-A5F1A93F5F8A}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <RootNamespace>ReadFromVideoCamera</RootNamespace>
    <AssemblyName>ReadFromVideoCamera</AssemblyName>
    <FileUpgradeFlags>
    </FileUpgradeFlags>
    <UpgradeBackupLocation>
    </UpgradeBackupLocation>
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
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Debug|x86'">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\x86\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisIgnoreBuiltInRuleSets>false</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisIgnoreBuiltInRules>false</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Release|x86'">
    <OutputPath>bin\x86\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisIgnoreBuiltInRuleSets>false</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisIgnoreBuiltInRules>false</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <PropertyGroup>
    <StartupObject>ReadFromVideoCamera.Program</StartupObject>
  </PropertyGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Reference Include="Bytescout.BarCodeReader, Version=8.20.0.1340, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Reader SDK\net3.50\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
    <Reference Include="TouchlessLib, Version=1.0.0.0, Culture=neutral, processorArchitecture=x86">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Compile Include="Program.vb" />
    <Compile Include="WebCamBarcodeDecoder.Designer.vb">
      <DependentUpon>WebCamBarcodeDecoder.vb</DependentUpon>
    </Compile>
    <Compile Include="WebCamBarcodeDecoder.vb">
      <SubType>Form</SubType>
    </Compile>
    <Content Include="TouchlessLib.dll">
    </Content>
    <Content Include="WebCamLib.dll">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <EmbeddedResource Include="WebCamBarcodeDecoder.resx">
      <DependentUpon>WebCamBarcodeDecoder.vb</DependentUpon>
      <SubType>Designer</SubType>
    </EmbeddedResource>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ReadFromVideoCamera.VS2010.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{2709B33C-231F-4007-9FCA-A5F1A93F5F8A}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <RootNamespace>ReadFromVideoCamera</RootNamespace>
    <AssemblyName>ReadFromVideoCamera</AssemblyName>
    <FileUpgradeFlags>
    </FileUpgradeFlags>
    <UpgradeBackupLocation>
    </UpgradeBackupLocation>
    <IsWebBootstrapper>false</IsWebBootstrapper>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <OldToolsVersion>3.5</OldToolsVersion>
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
    <UseApplicationTrust>false</UseApplicationTrust>
    <BootstrapperEnabled>true</BootstrapperEnabled>
    <TargetFrameworkProfile />
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Debug|x86'">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\x86\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisIgnoreBuiltInRuleSets>false</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisIgnoreBuiltInRules>false</CodeAnalysisIgnoreBuiltInRules>
    <NoWarn>42353,42354,42355</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Release|x86'">
    <OutputPath>bin\x86\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisIgnoreBuiltInRuleSets>false</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisIgnoreBuiltInRules>false</CodeAnalysisIgnoreBuiltInRules>
    <NoWarn>42353,42354,42355</NoWarn>
  </PropertyGroup>
  <PropertyGroup>
    <StartupObject>ReadFromVideoCamera.Program</StartupObject>
  </PropertyGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Reference Include="Bytescout.BarCodeReader, Version=8.20.0.1340, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Reader SDK\net4.00\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
    <Reference Include="TouchlessLib, Version=1.0.0.0, Culture=neutral, processorArchitecture=x86">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Compile Include="Program.vb" />
    <Compile Include="WebCamBarcodeDecoder.Designer.vb">
      <DependentUpon>WebCamBarcodeDecoder.vb</DependentUpon>
    </Compile>
    <Compile Include="WebCamBarcodeDecoder.vb">
      <SubType>Form</SubType>
    </Compile>
    <Content Include="TouchlessLib.dll">
    </Content>
    <Content Include="WebCamLib.dll">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <EmbeddedResource Include="WebCamBarcodeDecoder.resx">
      <DependentUpon>WebCamBarcodeDecoder.vb</DependentUpon>
      <SubType>Designer</SubType>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <BootstrapperPackage Include="Microsoft.Net.Client.3.5">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1 Client Profile</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Framework.3.5.SP1">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Windows.Installer.3.1">
      <Visible>False</Visible>
      <ProductName>Windows Installer 3.1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****WebCamBarcodeDecoder.Designer.vb:**
    
```
Partial Class WebCamBarcodeDecoder
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
        Me.pictureVideoPreview = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.pictureVideoPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureVideoPreview
        '
        Me.pictureVideoPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureVideoPreview.BackColor = System.Drawing.Color.White
        Me.pictureVideoPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureVideoPreview.Location = New System.Drawing.Point(12, 12)
        Me.pictureVideoPreview.Name = "pictureVideoPreview"
        Me.pictureVideoPreview.Size = New System.Drawing.Size(640, 480)
        Me.pictureVideoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureVideoPreview.TabIndex = 8
        Me.pictureVideoPreview.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(562, 497)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 26)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'WebCamBarcodeDecoder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(664, 536)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.pictureVideoPreview)
        Me.MaximizeBox = False
        Me.Name = "WebCamBarcodeDecoder"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QR Code decoder"
        CType(Me.pictureVideoPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private pictureVideoPreview As System.Windows.Forms.PictureBox
    Private WithEvents btnCancel As System.Windows.Forms.Button
End Class


```

<!-- code block end -->    

<!-- code block begin -->

##### ****WebCamBarcodeDecoder.vb:**
    
```
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Threading
Imports Bytescout.BarCodeReader
Imports TouchlessLib


Partial Public Class WebCamBarcodeDecoder
    Inherits Form

    ' Touchless API library manager (to use it you should have TouchlessLib.dll referenced and WebCamLib.dll copied to the output directory).
    Private _touchlessLibManager As TouchlessMgr

    ' Background barcode decoding thread.
    Private ReadOnly _backgroundWorker As New BackgroundWorker()

    ' Array with all latest barcodes from the last scanning session.
    Public FoundBarcode As String = Nothing

    ' Form initialization.
    Public Sub New()

        InitializeComponent()

        ' Setup background working thread 
        _backgroundWorker.WorkerSupportsCancellation = True
        AddHandler _backgroundWorker.DoWork, New DoWorkEventHandler(AddressOf BackgroundWorker_DoWork)
        AddHandler _backgroundWorker.RunWorkerCompleted, New RunWorkerCompletedEventHandler(AddressOf BackgroundWorker_RunWorkerCompleted)

    End Sub

    ' On form loading.
    Private Sub VideoScanForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Initialize camera and cancel if no camera avalaible
        If InitCamera() = False Then
            DialogResult = New DialogResult()
            Close()
        End If

        StartDecoding()

    End Sub

    ' Camera initialization.
    Private Function InitCamera() As Boolean

        ' Create Touchless API library manager to work with web camera
        _touchlessLibManager = New TouchlessMgr()

        If _touchlessLibManager.Cameras.Count = 0 Then
            MessageBox.Show("No camera devices available.")
            Return False
        End If

        ' Get first available web camera 
        Dim camera As Camera = _touchlessLibManager.Cameras(0)
        ' ... and set it as the current device
        _touchlessLibManager.CurrentCamera = camera

        ' Set camera image dimensions acquired from camera
        camera.CaptureWidth = 640
        camera.CaptureHeight = 480

        ' Handle camera's OnImageCaptured event
        AddHandler camera.OnImageCaptured, New EventHandler(Of CameraEventArgs)(AddressOf CurrentCamera_OnImageCaptured)

        Return True

    End Function

    Public Sub StartDecoding()

        ' Start the background decoding thread
        _backgroundWorker.RunWorkerAsync()

    End Sub

    Private Sub StopDecoding()

        ' Signal the background thread to stop
        _backgroundWorker.CancelAsync()

    End Sub

    Private Sub DeinitCamera()

        If _touchlessLibManager IsNot Nothing Then
            If _touchlessLibManager.CurrentCamera IsNot Nothing Then
                RemoveHandler _touchlessLibManager.CurrentCamera.OnImageCaptured, AddressOf CurrentCamera_OnImageCaptured
                _touchlessLibManager.CurrentCamera = Nothing
            End If
        End If
        _touchlessLibManager.Dispose()
        _touchlessLibManager = Nothing

    End Sub

    ' Barcode decoding procedure executing in the background thread.
    Private Sub BackgroundWorker_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)

        Dim worker As BackgroundWorker = TryCast(sender, BackgroundWorker)

        ' Create barcode reader instance
        Dim reader As New Reader()
        reader.RegistrationName = "demo"
        reader.RegistrationKey = "demo"

        ' Enable QR Code decoding
        reader.BarcodeTypesToFind.QRCode = True

        Try

            ' Get image from camera every 1.5s and try to find a barcode on it
            While True

                ' If the decoding is canceled then exit
                If (worker.CancellationPending = True) Then
                    e.Cancel = True
                    Return
                Else
                    ' get current frame bitmap from camera using Touchless lib
                    Dim bitmap As Bitmap = _touchlessLibManager.CurrentCamera.GetCurrentImage()
                    If bitmap IsNot Nothing Then

                        ' -----------------------------------------------------------------------
                        ' NOTE: We can read barcodes from specific page to increase performance .
                        ' For sample please refer to "Decoding barcodes from PDF by pages" program.
                        ' ----------------------------------------------------------------------- 

                        ' Search barcodes
                        Dim result As FoundBarcode() = reader.ReadFrom(bitmap)
                        If result IsNot Nothing And result.Length > 0 Then
                            ' return value of the first found barcode
                            e.Result = result(0).Value
                            Return
                        End If
                    End If

                    ' Pause the loop for 1.5s
                    Thread.Sleep(1500)
                End If

            End While

        Finally
            reader.Dispose()
        End Try

    End Sub

    ' Background thread procedure is finished
    Private Sub BackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)

        ' If decoding is not canceled then get the decoding result from background thread and close the form
        If Not e.Cancelled Then

            ' Get barcode value for background thread result
            FoundBarcode = DirectCast(e.Result, String)

            ' Close form with OK result
            DialogResult = DialogResult.OK
            Close()

        End If

    End Sub

    ' Update picture box with the last captured frame from web camera.
    Private Sub CurrentCamera_OnImageCaptured(ByVal sender As Object, ByVal e As CameraEventArgs)

        pictureVideoPreview.Image = _touchlessLibManager.CurrentCamera.GetCurrentImage()

    End Sub

    ' Cancel button click.
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click

        DialogResult = DialogResult.Cancel
        Close()

    End Sub

    ' On form closing.
    Private Sub VideoScanForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        StopDecoding()

        DeinitCamera()

    End Sub

    ' Shared (static) function for convenient use. 
    ' It creates the form and returns the decoded barcode value as string.
    ' Returns Nothing if the decoding is canceled.
    Public Shared Function DecodeBarcode() As String

        Dim form As New WebCamBarcodeDecoder()

        If form.ShowDialog() = DialogResult.OK Then

            Return form.FoundBarcode

        End If

        Return Nothing

    End Function

End Class

```

<!-- code block end -->