## How to view spreadsheet with spreadsheet sdk in VB.NET with ByteScout Barcode Suite

### Learn to code in VB.NET to view spreadsheet with spreadsheet sdk with this step-by-step tutorial

Quickly learn how to view spreadsheet with spreadsheet sdk in VB.NET with this sample source code. ByteScout Barcode Suite: the bundle that privides 3  SDK products to generate barcodes (Barcode SDK), read barcodes (Barcode Reaer SDK) and read and write spreadsheets (Spreadsheet SDK). It can view spreadsheet with spreadsheet sdk in VB.NET.

Want to quickly learn? This fast application programming interfaces of ByteScout Barcode Suite for VB.NET plus the guidelines and the code below will help you quickly learn how to view spreadsheet with spreadsheet sdk. This VB.NET sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Check VB.NET sample code samples to see if they respond to your needs and requirements for the project.

You can download free trial version of ByteScout Barcode Suite from our website to see and try many others source code samples for VB.NET.

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
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.lblStub = New System.Windows.Forms.Label()
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.filesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsmiOpen = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsmiPrint = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsmiPrintPreview = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
		Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsmiVisitWebsite = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsmiAbout = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStrip = New System.Windows.Forms.ToolStrip()
		Me.tsbOpen = New System.Windows.Forms.ToolStripButton()
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.tsbPromo = New System.Windows.Forms.ToolStripButton()
		Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.tsbVisitWebsite = New System.Windows.Forms.ToolStripButton()
		Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
		Me.menuStrip1.SuspendLayout()
		Me.toolStrip.SuspendLayout()
		Me.SuspendLayout()
		' 
		' lblStub
		' 
		Me.lblStub.BackColor = System.Drawing.SystemColors.Window
		Me.lblStub.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lblStub.Font = New System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Italic)
		Me.lblStub.ForeColor = System.Drawing.SystemColors.AppWorkspace
		Me.lblStub.Location = New System.Drawing.Point(0, 49)
		Me.lblStub.Name = "lblStub"
		Me.lblStub.Size = New System.Drawing.Size(837, 508)
		Me.lblStub.TabIndex = 5
		Me.lblStub.Text = "Click here to open spreadsheet files: " & vbCr & vbLf & vbCr & vbLf & "Excel 2003/2007 (*.xls, *.xlsx) " & vbCr & vbLf & "Open " & "Office Calc (*.ods)" & vbCr & vbLf & "CSV Comma Separated Values (*.csv)" & vbCr & vbLf & "TXT tab-delimited value" & "s (*.txt)"
		Me.lblStub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.lblStub.Click, New System.EventHandler(AddressOf Me.tsmiOpen_Click)
		' 
		' menuStrip1
		' 
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.filesToolStripMenuItem, Me.helpToolStripMenuItem})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
		Me.menuStrip1.Size = New System.Drawing.Size(837, 24)
		Me.menuStrip1.TabIndex = 6
		Me.menuStrip1.Text = "menuStrip1"
		' 
		' filesToolStripMenuItem
		' 
		Me.filesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiOpen, Me.tsmiPrint, Me.tsmiPrintPreview, Me.tsmiExit})
		Me.filesToolStripMenuItem.Name = "filesToolStripMenuItem"
		Me.filesToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
		Me.filesToolStripMenuItem.Text = "Files"
		' 
		' tsmiOpen
		' 
		Me.tsmiOpen.Name = "tsmiOpen"
		Me.tsmiOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
		Me.tsmiOpen.Size = New System.Drawing.Size(166, 22)
		Me.tsmiOpen.Text = "Open"
		AddHandler Me.tsmiOpen.Click, New System.EventHandler(AddressOf Me.tsmiOpen_Click)
		' 
		' tsmiPrint
		' 
		Me.tsmiPrint.Enabled = False
		Me.tsmiPrint.Name = "tsmiPrint"
		Me.tsmiPrint.Size = New System.Drawing.Size(166, 22)
		Me.tsmiPrint.Text = "Print..."
		Me.tsmiPrint.Visible = False
		' 
		' tsmiPrintPreview
		' 
		Me.tsmiPrintPreview.Enabled = False
		Me.tsmiPrintPreview.Name = "tsmiPrintPreview"
		Me.tsmiPrintPreview.Size = New System.Drawing.Size(166, 22)
		Me.tsmiPrintPreview.Text = "Print Preview..."
		Me.tsmiPrintPreview.Visible = False
		' 
		' tsmiExit
		' 
		Me.tsmiExit.Name = "tsmiExit"
		Me.tsmiExit.Size = New System.Drawing.Size(166, 22)
		Me.tsmiExit.Text = "Exit"
		AddHandler Me.tsmiExit.Click, New System.EventHandler(AddressOf Me.tsmiExit_Click)
		' 
		' helpToolStripMenuItem
		' 
		Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiVisitWebsite, Me.tsmiAbout})
		Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
		Me.helpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
		Me.helpToolStripMenuItem.Text = "Help"
		' 
		' tsmiVisitWebsite
		' 
		Me.tsmiVisitWebsite.Name = "tsmiVisitWebsite"
		Me.tsmiVisitWebsite.Size = New System.Drawing.Size(152, 22)
		Me.tsmiVisitWebsite.Text = "Visit Website"
		AddHandler Me.tsmiVisitWebsite.Click, New System.EventHandler(AddressOf Me.tsmiVisitWebsite_Click)
		' 
		' tsmiAbout
		' 
		Me.tsmiAbout.Name = "tsmiAbout"
		Me.tsmiAbout.Size = New System.Drawing.Size(152, 22)
		Me.tsmiAbout.Text = "About"
		AddHandler Me.tsmiAbout.Click, New System.EventHandler(AddressOf Me.tsmiAbout_Click)
		' 
		' toolStrip
		' 
		Me.toolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbOpen, Me.toolStripSeparator1, Me.tsbPromo, Me.toolStripSeparator2, Me.tsbVisitWebsite})
		Me.toolStrip.Location = New System.Drawing.Point(0, 24)
		Me.toolStrip.Name = "toolStrip"
		Me.toolStrip.Size = New System.Drawing.Size(837, 25)
		Me.toolStrip.TabIndex = 7
		Me.toolStrip.Text = "toolStrip1"
		' 
		' tsbOpen
		' 
		Me.tsbOpen.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
		Me.tsbOpen.ImageTransparentColor = System.Drawing.Color.Black
		Me.tsbOpen.Name = "tsbOpen"
		Me.tsbOpen.Size = New System.Drawing.Size(71, 22)
		Me.tsbOpen.Text = "Open File..."
		AddHandler Me.tsbOpen.Click, New System.EventHandler(AddressOf Me.tsmiOpen_Click)
		' 
		' toolStripSeparator1
		' 
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
		' 
		' tsbPromo
		' 
		Me.tsbPromo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.tsbPromo.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
		Me.tsbPromo.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbPromo.Name = "tsbPromo"
		Me.tsbPromo.Size = New System.Drawing.Size(320, 22)
		Me.tsbPromo.Text = "Developers: Check Bytescout Spreadsheet SDK for .NET"
		AddHandler Me.tsbPromo.Click, New System.EventHandler(AddressOf Me.tsbPromo_Click)
		' 
		' toolStripSeparator2
		' 
		Me.toolStripSeparator2.Name = "toolStripSeparator2"
		Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
		' 
		' tsbVisitWebsite
		' 
		Me.tsbVisitWebsite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.tsbVisitWebsite.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
		Me.tsbVisitWebsite.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbVisitWebsite.Name = "tsbVisitWebsite"
		Me.tsbVisitWebsite.Size = New System.Drawing.Size(84, 22)
		Me.tsbVisitWebsite.Text = "Visit Website"
		AddHandler Me.tsbVisitWebsite.Click, New System.EventHandler(AddressOf Me.tsmiVisitWebsite_Click)
		' 
		' openFileDialog
		' 
		Me.openFileDialog.Filter = resources.GetString("openFileDialog.Filter")
		Me.openFileDialog.SupportMultiDottedExtensions = True
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(837, 557)
		Me.Controls.Add(Me.lblStub)
		Me.Controls.Add(Me.toolStrip)
		Me.Controls.Add(Me.menuStrip1)
		Me.Name = "Form1"
		Me.Text = "Spreadsheet Viewer"
		Me.menuStrip1.ResumeLayout(False)
		Me.menuStrip1.PerformLayout()
		Me.toolStrip.ResumeLayout(False)
		Me.toolStrip.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private lblStub As System.Windows.Forms.Label
	Private menuStrip1 As System.Windows.Forms.MenuStrip
	Private filesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private tsmiOpen As System.Windows.Forms.ToolStripMenuItem
	Private tsmiPrint As System.Windows.Forms.ToolStripMenuItem
	Private tsmiPrintPreview As System.Windows.Forms.ToolStripMenuItem
	Private tsmiExit As System.Windows.Forms.ToolStripMenuItem
	Private helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private tsmiVisitWebsite As System.Windows.Forms.ToolStripMenuItem
	Private tsmiAbout As System.Windows.Forms.ToolStripMenuItem
	Private toolStrip As System.Windows.Forms.ToolStrip
	Private tsbOpen As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private tsbPromo As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Private tsbVisitWebsite As System.Windows.Forms.ToolStripButton
	Private openFileDialog As System.Windows.Forms.OpenFileDialog

End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Form1.vb:**
    
```
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports Bytescout.Spreadsheet

Public Partial Class Form1
	Inherits Form
	Private _spreadsheetControl As SpreadsheetControl = Nothing

	Private _fileName As String = Nothing

	Public Sub New(args As String())
		If args.Length > 0 AndAlso File.Exists(args(0)) Then
			_fileName = args(0)
		End If

		If _fileName IsNot Nothing Then
			OpenFile(_fileName)
		End If

		InitializeComponent()
	End Sub

	Private Sub OpenFile(fileName As String)
		Text = "Spreadsheet Viewer - " & fileName

		Dim xls As New Spreadsheet()
		xls.RegistrationName = "demo"
		xls.RegistrationKey = "demo"

		Try
			xls.LoadFromFile(fileName)
		Catch generatedExceptionName As SpreadsheetProtectionPasswordRequired
			Dim passwordDialog As New PasswordDialog()

			If passwordDialog.ShowDialog(Me) = DialogResult.OK Then
				xls.LoadFromFile(fileName, CacheType.Memory, ",", Encoding.[Default], passwordDialog.Password)
			Else
				Return
			End If
		End Try

		lblStub.Visible = False

		If _spreadsheetControl Is Nothing Then
			_spreadsheetControl = New SpreadsheetControl()
			_spreadsheetControl.Dock = DockStyle.Fill

			Controls.Add(_spreadsheetControl)

			_spreadsheetControl.BringToFront()
			_spreadsheetControl.Focus()
		End If

		Cursor = Cursors.WaitCursor

		Try
			_spreadsheetControl.Spreadsheet = xls
		Catch e As Exception
			MessageBox.Show(e.ToString())
		Finally
			Cursor = Cursors.[Default]
		End Try
	End Sub

	Private Sub tsmiOpen_Click(sender As Object, e As EventArgs)
		If openFileDialog.ShowDialog() = DialogResult.OK Then
			OpenFile(openFileDialog.FileName)
		End If
	End Sub

	Private Sub tsmiAbout_Click(sender As Object, e As EventArgs)
		MessageBox.Show("Spreadsheet Viewer" & vbLf & vbLf & "www.bytescout.com" & vbLf & vbLf & "Copyright (c) Bytescout Software 2012", "About...")
	End Sub

	Private Sub tsmiExit_Click(sender As Object, e As EventArgs)
		Close()
	End Sub

	Private Sub tsmiVisitWebsite_Click(sender As Object, e As EventArgs)
		System.Diagnostics.Process.Start("http://www.bytescout.com")
	End Sub

	Private Sub tsbPromo_Click(sender As Object, e As EventArgs)
		System.Diagnostics.Process.Start("http://bytescout.com/products/developer/spreadsheetsdk/bytescoutspreadsheetsdk.html")
	End Sub
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****PasswordDialog.Designer.vb:**
    
```
Partial Class PasswordDialog
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
		Me.textBoxPassword = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.checkBoxHide = New System.Windows.Forms.CheckBox()
		Me.btnOk = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		' 
		' textBoxPassword
		' 
		Me.textBoxPassword.Location = New System.Drawing.Point(79, 39)
		Me.textBoxPassword.Name = "textBoxPassword"
		Me.textBoxPassword.Size = New System.Drawing.Size(168, 22)
		Me.textBoxPassword.TabIndex = 1
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(4, 42)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(73, 17)
		Me.label2.TabIndex = 2
		Me.label2.Text = "Password:"
		' 
		' checkBoxHide
		' 
		Me.checkBoxHide.AutoSize = True
		Me.checkBoxHide.Location = New System.Drawing.Point(7, 12)
		Me.checkBoxHide.Name = "checkBoxHide"
		Me.checkBoxHide.Size = New System.Drawing.Size(123, 21)
		Me.checkBoxHide.TabIndex = 3
		Me.checkBoxHide.Text = "Hide password"
		Me.checkBoxHide.UseVisualStyleBackColor = True
		AddHandler Me.checkBoxHide.CheckedChanged, New System.EventHandler(AddressOf Me.checkBoxHide_CheckedChanged)
		' 
		' btnOk
		' 
		Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btnOk.Location = New System.Drawing.Point(91, 67)
		Me.btnOk.Name = "btnOk"
		Me.btnOk.Size = New System.Drawing.Size(75, 23)
		Me.btnOk.TabIndex = 4
		Me.btnOk.Text = "Ok"
		Me.btnOk.UseVisualStyleBackColor = True
		AddHandler Me.btnOk.Click, New System.EventHandler(AddressOf Me.btnOk_Click)
		' 
		' btnCancel
		' 
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(172, 67)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 5
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		AddHandler Me.btnCancel.Click, New System.EventHandler(AddressOf Me.btnCancel_Click)
		' 
		' PasswordDialog
		' 
		Me.AcceptButton = Me.btnOk
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnCancel
		Me.ClientSize = New System.Drawing.Size(255, 98)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnOk)
		Me.Controls.Add(Me.checkBoxHide)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.textBoxPassword)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "PasswordDialog"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Please enter a password"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private textBoxPassword As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private checkBoxHide As System.Windows.Forms.CheckBox
	Private btnOk As System.Windows.Forms.Button
	Private btnCancel As System.Windows.Forms.Button
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****PasswordDialog.vb:**
    
```
Imports System.Windows.Forms

Public Partial Class PasswordDialog
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

	Public ReadOnly Property Password() As String
		Get
			Return textBoxPassword.Text
		End Get
	End Property

	Private Sub btnOk_Click(sender As Object, e As EventArgs)
		'DialogResult = DialogResult.OK;
		'Close();
	End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub checkBoxHide_CheckedChanged(sender As Object, e As EventArgs)
		If checkBoxHide.Checked Then
			textBoxPassword.PasswordChar = "*"C
		Else
			textBoxPassword.PasswordChar = ControlChars.NullChar
		End If
	End Sub
End Class

```

<!-- code block end -->    

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
	<STAThread> _
	Friend Shared Sub Main(args As String())
		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)

		Application.Run(New Form1(args))
	End Sub
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ViewSpreadsheet.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{B00856E0-D1AC-4BEE-8E71-BBF29BFB5509}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ViewSpreadsheet</RootNamespace>
    <AssemblyName>ViewSpreadsheet</AssemblyName>
    <ApplicationIcon>
    </ApplicationIcon>
    <StartupObject>ViewSpreadsheet.Program</StartupObject>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>TRACE,DEBUG,XLSViewer</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>3</WarningLevel>
    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE,DEMO</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
  </PropertyGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.Spreadsheet, Version=2.2.0.307, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="Bytescout.SpreadsheetControl, Version=2.2.0.307, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Form1.Designer.vb">
      <DependentUpon>Form1.vb</DependentUpon>
    </Compile>
    <Compile Include="Form1.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="PasswordDialog.Designer.vb">
      <DependentUpon>PasswordDialog.vb</DependentUpon>
    </Compile>
    <Compile Include="PasswordDialog.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Program.vb" />
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="PasswordDialog.resx">
      <SubType>Designer</SubType>
      <DependentUpon>PasswordDialog.vb</DependentUpon>
    </EmbeddedResource>
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->