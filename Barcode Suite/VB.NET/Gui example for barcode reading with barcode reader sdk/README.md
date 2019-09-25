## gui example for barcode reading with barcode reader sdk in VB.NET with ByteScout Barcode Suite

### Simple tutorial on how to do gui example for barcode reading with barcode reader sdk in VB.NET

The example source codes on this page will display you how to make gui example for barcode reading with barcode reader sdk in VB.NET. ByteScout Barcode Suite was created to assist gui example for barcode reading with barcode reader sdk in VB.NET. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK.

If you want to quickly learn then these fast application programming interfaces of ByteScout Barcode Suite for VB.NET plus the guideline and the VB.NET code below will help you quickly learn gui example for barcode reading with barcode reader sdk.  Just copy and paste this VB.NET sample code to your VB.NET application's code editor, add a reference to ByteScout Barcode Suite (if you haven't added yet) and you are ready to go! Updated and detailed documentation and tutorials are available along with installed ByteScout Barcode Suite if you'd like to learn more about the topic and the details of the API.

On our website you may get trial version of ByteScout Barcode Suite for free. Source code samples are included to help you with your VB.NET application.

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
		Me.label1 = New System.Windows.Forms.Label()
		Me.buttonBrowse = New System.Windows.Forms.Button()
		Me.pictureBoxBarcode = New System.Windows.Forms.PictureBox()
		Me.textBoxFileName = New System.Windows.Forms.TextBox()
		Me.textBoxResults = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
		Me.checkBoxAll1D = New System.Windows.Forms.CheckBox()
		Me.checkBoxAll2D = New System.Windows.Forms.CheckBox()
		Me.buttonSearch = New System.Windows.Forms.Button()
		Me.panel1 = New System.Windows.Forms.Panel()
		DirectCast(Me.pictureBoxBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.panel1.SuspendLayout()
		Me.SuspendLayout()
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(9, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(120, 13)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Image or PDF file name:"
		' 
		' buttonBrowse
		' 
		Me.buttonBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonBrowse.Location = New System.Drawing.Point(792, 23)
		Me.buttonBrowse.Name = "buttonBrowse"
		Me.buttonBrowse.Size = New System.Drawing.Size(78, 23)
		Me.buttonBrowse.TabIndex = 0
		Me.buttonBrowse.Text = "Browse..."
		Me.buttonBrowse.UseVisualStyleBackColor = True
		AddHandler Me.buttonBrowse.Click, New System.EventHandler(AddressOf Me.buttonBrowse_Click)
		' 
		' pictureBoxBarcode
		' 
		Me.pictureBoxBarcode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pictureBoxBarcode.Location = New System.Drawing.Point(0, 0)
		Me.pictureBoxBarcode.Name = "pictureBoxBarcode"
		Me.pictureBoxBarcode.Size = New System.Drawing.Size(138, 113)
		Me.pictureBoxBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.pictureBoxBarcode.TabIndex = 2
		Me.pictureBoxBarcode.TabStop = False
		' 
		' textBoxFileName
		' 
		Me.textBoxFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxFileName.Location = New System.Drawing.Point(12, 25)
		Me.textBoxFileName.Name = "textBoxFileName"
		Me.textBoxFileName.[ReadOnly] = True
		Me.textBoxFileName.Size = New System.Drawing.Size(774, 20)
		Me.textBoxFileName.TabIndex = 0
		' 
		' textBoxResults
		' 
		Me.textBoxResults.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxResults.Location = New System.Drawing.Point(12, 486)
		Me.textBoxResults.Multiline = True
		Me.textBoxResults.Name = "textBoxResults"
		Me.textBoxResults.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.textBoxResults.Size = New System.Drawing.Size(858, 102)
		Me.textBoxResults.TabIndex = 4
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(12, 470)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(87, 13)
		Me.label2.TabIndex = 5
		Me.label2.Text = "Found barcodes:"
		' 
		' openFileDialog
		' 
		Me.openFileDialog.Filter = "Image and PDF files|*.bmp;*.gif;*.tif;*.tiff;*.png;*.jpg;*.jpeg;*.pdf|All files|*" & ".*"
		' 
		' checkBoxAll1D
		' 
		Me.checkBoxAll1D.AutoSize = True
		Me.checkBoxAll1D.Checked = True
		Me.checkBoxAll1D.CheckState = System.Windows.Forms.CheckState.Checked
		Me.checkBoxAll1D.Location = New System.Drawing.Point(12, 51)
		Me.checkBoxAll1D.Name = "checkBoxAll1D"
		Me.checkBoxAll1D.Size = New System.Drawing.Size(359, 17)
		Me.checkBoxAll1D.TabIndex = 1
		Me.checkBoxAll1D.Text = "One-dimensional (linear) barcodes (Code39, Code128, GS1, EAN, etc.)"
		Me.checkBoxAll1D.UseVisualStyleBackColor = True
		' 
		' checkBoxAll2D
		' 
		Me.checkBoxAll2D.AutoSize = True
		Me.checkBoxAll2D.Checked = True
		Me.checkBoxAll2D.CheckState = System.Windows.Forms.CheckState.Checked
		Me.checkBoxAll2D.Location = New System.Drawing.Point(12, 74)
		Me.checkBoxAll2D.Name = "checkBoxAll2D"
		Me.checkBoxAll2D.Size = New System.Drawing.Size(363, 17)
		Me.checkBoxAll2D.TabIndex = 2
		Me.checkBoxAll2D.Text = "Two-dimensional barcodes (Aztec, PDF417, QR Code, Datamatrix, etc.)"
		Me.checkBoxAll2D.UseVisualStyleBackColor = True
		' 
		' buttonSearch
		' 
		Me.buttonSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonSearch.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.buttonSearch.Location = New System.Drawing.Point(742, 51)
		Me.buttonSearch.Name = "buttonSearch"
		Me.buttonSearch.Size = New System.Drawing.Size(128, 40)
		Me.buttonSearch.TabIndex = 3
		Me.buttonSearch.Text = "Search Barcodes"
		Me.buttonSearch.UseVisualStyleBackColor = True
		AddHandler Me.buttonSearch.Click, New System.EventHandler(AddressOf Me.buttonSearchBarcodes_Click)
		' 
		' panel1
		' 
		Me.panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panel1.AutoScroll = True
		Me.panel1.BackColor = System.Drawing.SystemColors.ControlDark
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.pictureBoxBarcode)
		Me.panel1.Location = New System.Drawing.Point(12, 97)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(858, 370)
		Me.panel1.TabIndex = 9
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(882, 600)
		Me.Controls.Add(Me.panel1)
		Me.Controls.Add(Me.buttonSearch)
		Me.Controls.Add(Me.checkBoxAll2D)
		Me.Controls.Add(Me.checkBoxAll1D)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.textBoxResults)
		Me.Controls.Add(Me.textBoxFileName)
		Me.Controls.Add(Me.buttonBrowse)
		Me.Controls.Add(Me.label1)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Barcode Reader"
		DirectCast(Me.pictureBoxBarcode, System.ComponentModel.ISupportInitialize).EndInit()
		Me.panel1.ResumeLayout(False)
		Me.panel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private label1 As System.Windows.Forms.Label
	Private buttonBrowse As System.Windows.Forms.Button
	Private pictureBoxBarcode As System.Windows.Forms.PictureBox
	Private textBoxFileName As System.Windows.Forms.TextBox
	Private textBoxResults As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private openFileDialog As System.Windows.Forms.OpenFileDialog
	Private checkBoxAll1D As System.Windows.Forms.CheckBox
	Private checkBoxAll2D As System.Windows.Forms.CheckBox
	Private buttonSearch As System.Windows.Forms.Button
	Private panel1 As System.Windows.Forms.Panel
End Class


```

<!-- code block end -->    

<!-- code block begin -->

##### ****Form1.vb:**
    
```
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports Bytescout.BarCodeReader

Public Partial Class Form1
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

    Private _fileName As String = ""

	Private Sub buttonBrowse_Click(sender As Object, e As EventArgs)
		Dim result As DialogResult = openFileDialog.ShowDialog()

		If result = DialogResult.OK Then
			_fileName = openFileDialog.FileName
			textBoxFileName.Text = _fileName

			Try
				Dim bmp As New Bitmap(_fileName)
				pictureBoxBarcode.Image = bmp
			Catch generatedExceptionName As Exception
				pictureBoxBarcode.Image = Nothing
			End Try
		End If
	End Sub

	Private Sub buttonSearchBarcodes_Click(sender As Object, e As EventArgs)
		FindBarcodes()
	End Sub

	Private Sub FindBarcodes()
        If String.IsNullOrEmpty(_fileName) Then
            Return
        End If

		Dim reader As New Reader()
		reader.RegistrationName = "demo"
		reader.RegistrationKey = "demo"

		If checkBoxAll1D.Checked Then
			reader.BarcodeTypesToFind.All1D = True
		End If
		If checkBoxAll2D.Checked Then
			reader.BarcodeTypesToFind.All2D = True
		End If

		Cursor = Cursors.WaitCursor

        ' -----------------------------------------------------------------------
        ' NOTE: We can read barcodes from specific page to increase performance .
        ' For sample please refer to "Decoding barcodes from PDF by pages" program.
        ' ----------------------------------------------------------------------- 

		Dim foundBarcodes As FoundBarcode() = reader.ReadFrom(_fileName)
		ResetCursor()

		Dim data As New List(Of String)()

		If foundBarcodes.Length = 0 Then
			data.Add("No barcodes found")
		Else
			For Each barcode As FoundBarcode In foundBarcodes
                data.Add(String.Format("Type ""{0}"" and value ""{1}""", barcode.Type, barcode.Value))
			Next
		End If

        ' Cleanup
        reader.Dispose()

        textBoxResults.Lines = data.ToArray()
	End Sub
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****GuiExample.VS2005.vbproj:**
    
```
<Project ToolsVersion="3.5" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{8F45A1DA-493D-4FC6-86C6-F1F297EB3C6C}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <RootNamespace>GuiExample</RootNamespace>
    <AssemblyName>GuiExample</AssemblyName>
    <StartupObject>GuiExample.Program</StartupObject>
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
    <Compile Include="Form1.Designer.vb">
      <DependentUpon>Form1.vb</DependentUpon>
    </Compile>
    <Compile Include="Form1.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Program.vb" />
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****GuiExample.VS2008.vbproj:**
    
```
<Project ToolsVersion="3.5" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.21022</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{8F45A1DA-493D-4FC6-86C6-F1F297EB3C6C}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <RootNamespace>GuiExample</RootNamespace>
    <AssemblyName>GuiExample</AssemblyName>
    <StartupObject>GuiExample.Program</StartupObject>
    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
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
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Linq" />
    <Reference Include="Bytescout.BarCodeReader, Version=8.20.0.1340, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Reader SDK\net3.50\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Core">
      <RequiredTargetFramework>3.5</RequiredTargetFramework>
    </Reference>
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
    <Compile Include="Form1.Designer.vb">
      <DependentUpon>Form1.vb</DependentUpon>
    </Compile>
    <Compile Include="Form1.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Program.vb" />
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <BootstrapperPackage Include="Microsoft.Net.Framework.2.0">
      <Visible>False</Visible>
      <ProductName>.NET Framework 2.0 %28x86%29</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Framework.3.0">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.0 %28x86%29</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Framework.3.5">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****GuiExample.VS2010.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.21022</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{8F45A1DA-493D-4FC6-86C6-F1F297EB3C6C}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <RootNamespace>GuiExample</RootNamespace>
    <AssemblyName>GuiExample</AssemblyName>
    <StartupObject>GuiExample.Program</StartupObject>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <IsWebBootstrapper>false</IsWebBootstrapper>
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
    <UseApplicationTrust>false</UseApplicationTrust>
    <BootstrapperEnabled>true</BootstrapperEnabled>
    <TargetFrameworkProfile />
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <NoWarn>42353,42354,42355</NoWarn>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <NoWarn>42353,42354,42355</NoWarn>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
  </PropertyGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Linq" />
    <Reference Include="Bytescout.BarCodeReader, Version=8.20.0.1340, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Reader SDK\net4.00\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Core">
      <RequiredTargetFramework>3.5</RequiredTargetFramework>
    </Reference>
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
    <Compile Include="Form1.Designer.vb">
      <DependentUpon>Form1.vb</DependentUpon>
    </Compile>
    <Compile Include="Form1.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Program.vb" />
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <BootstrapperPackage Include="Microsoft.Net.Client.3.5">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1 Client Profile</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Framework.2.0">
      <Visible>False</Visible>
      <ProductName>.NET Framework 2.0 %28x86%29</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Framework.3.0">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.0 %28x86%29</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Framework.3.5">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Framework.3.5.SP1">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
  </ItemGroup>
</Project>
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