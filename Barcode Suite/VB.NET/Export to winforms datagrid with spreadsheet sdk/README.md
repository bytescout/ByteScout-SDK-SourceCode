## How to export to winforms datagrid with spreadsheet sdk in VB.NET with ByteScout Barcode Suite

### How to write a robust code in VB.NET to export to winforms datagrid with spreadsheet sdk with this step-by-step tutorial

The sample source codes on this page shows how to export to winforms datagrid with spreadsheet sdk in VB.NET. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can be applied to export to winforms datagrid with spreadsheet sdk using VB.NET.

The SDK samples given below describe how to quickly make your application do export to winforms datagrid with spreadsheet sdk in VB.NET with the help of ByteScout Barcode Suite. IF you want to implement the functionality, just copy and paste this code for VB.NET below into your code editor with your app, compile and run your application. Further improvement of the code will make it more robust.

Our website gives trial version of ByteScout Barcode Suite for free. It also includes documentation and source code samples.

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
		Me.dataGrid1 = New System.Windows.Forms.DataGrid()
		Me.dataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
		Me.dataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.btnImport = New System.Windows.Forms.Button()
		Me.btnExport = New System.Windows.Forms.Button()
		Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		DirectCast(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' dataGrid1
		' 
		Me.dataGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dataGrid1.DataMember = ""
		Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
		Me.dataGrid1.Location = New System.Drawing.Point(12, 12)
		Me.dataGrid1.Name = "dataGrid1"
		Me.dataGrid1.Size = New System.Drawing.Size(438, 308)
		Me.dataGrid1.TabIndex = 0
		Me.dataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.dataGridTableStyle1})
		' 
		' dataGridTableStyle1
		' 
		Me.dataGridTableStyle1.DataGrid = Me.dataGrid1
		Me.dataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dataGridTextBoxColumn1})
		Me.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
		' 
		' dataGridTextBoxColumn1
		' 
		Me.dataGridTextBoxColumn1.Format = ""
		Me.dataGridTextBoxColumn1.FormatInfo = Nothing
		Me.dataGridTextBoxColumn1.NullText = ""
		Me.dataGridTextBoxColumn1.Width = 75
		' 
		' btnImport
		' 
		Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnImport.Location = New System.Drawing.Point(238, 326)
		Me.btnImport.Name = "btnImport"
		Me.btnImport.Size = New System.Drawing.Size(212, 23)
		Me.btnImport.TabIndex = 1
		Me.btnImport.Text = "Import from DataGrid to spreadsheet"
		Me.btnImport.UseVisualStyleBackColor = True
		AddHandler Me.btnImport.Click, New System.EventHandler(AddressOf Me.btnImport_Click)
		' 
		' btnExport
		' 
		Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnExport.Location = New System.Drawing.Point(238, 355)
		Me.btnExport.Name = "btnExport"
		Me.btnExport.Size = New System.Drawing.Size(212, 23)
		Me.btnExport.TabIndex = 2
		Me.btnExport.Text = "Export from spreadsheet to DataGrid"
		Me.btnExport.UseVisualStyleBackColor = True
		AddHandler Me.btnExport.Click, New System.EventHandler(AddressOf Me.btnExport_Click)
		' 
		' openFileDialog1
		' 
		Me.openFileDialog1.FileName = "openFileDialog1"
		Me.openFileDialog1.Filter = "Excel files (*.xls;*.xlsx)|*.xls;*.xlsx|All files|*.*"
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(462, 390)
		Me.Controls.Add(Me.btnExport)
		Me.Controls.Add(Me.btnImport)
		Me.Controls.Add(Me.dataGrid1)
		Me.Name = "Form1"
		Me.Text = "ImportFromWinFormsDataGrid"
		DirectCast(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private dataGrid1 As System.Windows.Forms.DataGrid
	Private btnImport As System.Windows.Forms.Button
	Private btnExport As System.Windows.Forms.Button
	Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
	Private dataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
	Private dataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn

End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Form1.vb:**
    
```
Imports System.Data
Imports System.Diagnostics
Imports System.IO
Imports System.Windows.Forms
Imports Bytescout.Spreadsheet

Public Partial Class Form1
	Inherits Form
	Public Sub New()
		InitializeComponent()

		dataGrid1.DataSource = GetDemoDataTable()
	End Sub

	Private Sub btnImport_Click(sender As Object, e As EventArgs)
		Cursor = Cursors.WaitCursor

		Try
			Const  fileName As String = "CSharpImportFromDataTable.xls"

			' retrieve DataTable from DataGrid
			Dim dataTable As DataTable = DirectCast(dataGrid1.DataSource, DataTable)

			' Create spreadsheet
			Dim spreadsheet As New Spreadsheet()

			' Import data from DataTable into spreadheet
			spreadsheet.ImportFromDataTable(dataTable)

			' Insert row with column captions
			Dim worksheet As Worksheet = spreadsheet.Worksheets(0)
			worksheet.Rows.Insert(0)
			For colIndex As Integer = 0 To dataTable.Columns.Count - 1
				worksheet.Cell(0, colIndex).Value = dataTable.Columns(colIndex).Caption
			Next

			' Save the spreadsheet
			If File.Exists(fileName) Then
				File.Delete(fileName)
			End If
			spreadsheet.SaveAs(fileName)

			' Close spreadsheet
			spreadsheet.Close()

			' Open the spreadsheet
			Process.Start(fileName)
		Finally
			Cursor = Cursors.[Default]
		End Try
	End Sub

	Private Sub btnExport_Click(sender As Object, e As EventArgs)
		If openFileDialog1.ShowDialog() = DialogResult.OK Then
			Cursor = Cursors.WaitCursor

			Try
				' Create spreadsheet
				Dim spreadsheet As New Spreadsheet()

				' Load spreadsheet from file
				spreadsheet.LoadFromFile(openFileDialog1.FileName)

				' Export to DataGrid
				Dim dataTable As DataTable = spreadsheet.ExportToDataTable()
				dataGrid1.DataSource = dataTable
			Finally
				Cursor = Cursors.[Default]
			End Try
		End If
	End Sub

	''' <summary>
	''' Fills a data table of the periodic table of elements.
	''' </summary>
	Private Function GetDemoDataTable() As DataTable
		Dim periodicTable As New DataTable("PeriodicTable")

		periodicTable.Columns.Add("Name", GetType(String))
		periodicTable.Columns.Add("Symbol", GetType(String))
		periodicTable.Columns.Add("AtomicNumber", GetType(Integer))

		Dim dr As DataRow = periodicTable.Rows.Add()
		dr(0) = "Hydrogen"
		dr(1) = "H"
		dr(2) = "1"

		dr = periodicTable.Rows.Add()
		dr(0) = "Helium"
		dr(1) = "He"
		dr(2) = "2"

		dr = periodicTable.Rows.Add()
		dr(0) = "Lithium"
		dr(1) = "Li"
		dr(2) = "3"

		dr = periodicTable.Rows.Add()
		dr(0) = "Beryllium"
		dr(1) = "Be"
		dr(2) = "4"

		dr = periodicTable.Rows.Add()
		dr(0) = "Boron"
		dr(1) = "B"
		dr(2) = "5"

		dr = periodicTable.Rows.Add()
		dr(0) = "Carbon"
		dr(1) = "C"
		dr(2) = "6"

		Return periodicTable
	End Function
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ImportExportFromWinFormsDataGrid.VS2005.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{93818257-A704-49CA-9CD1-A8826FC57F02}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ImportExportFromWinFormsDataGrid.CSharp</RootNamespace>
    <AssemblyName>ImportExportFromWinFormsDataGrid.CSharp</AssemblyName>
    <TargetFrameworkProfile />
    <FileAlignment>512</FileAlignment>
    <StartupObject>ImportExportFromWinFormsDataGrid.CSharp.Program</StartupObject>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86' ">
    <PlatformTarget>x86</PlatformTarget>
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
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.Spreadsheet, Version=2.3.0.750, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\lib\Bytescout.Spreadsheet.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
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
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ImportExportFromWinFormsDataGrid.VS2008.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="3.5" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>9.0.30729</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{93818257-A704-49CA-9CD1-A8826FC57F02}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ImportExportFromWinFormsDataGrid.CSharp</RootNamespace>
    <AssemblyName>ImportExportFromWinFormsDataGrid.CSharp</AssemblyName>
    <TargetFrameworkProfile />
    <FileAlignment>512</FileAlignment>
    <StartupObject>ImportExportFromWinFormsDataGrid.CSharp.Program</StartupObject>
    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86' ">
    <PlatformTarget>x86</PlatformTarget>
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
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.Spreadsheet, Version=2.3.0.750, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\lib\Bytescout.Spreadsheet.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
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
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ImportExportFromWinFormsDataGrid.VS2010.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{93818257-A704-49CA-9CD1-A8826FC57F02}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ImportExportFromWinFormsDataGrid.CSharp</RootNamespace>
    <AssemblyName>ImportExportFromWinFormsDataGrid.CSharp</AssemblyName>
    <TargetFrameworkProfile />
    <FileAlignment>512</FileAlignment>
    <StartupObject>ImportExportFromWinFormsDataGrid.CSharp.Program</StartupObject>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86' ">
    <PlatformTarget>x86</PlatformTarget>
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
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.Spreadsheet, Version=2.3.0.750, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\lib\Bytescout.Spreadsheet.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
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
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ImportExportFromWinFormsDataGrid.VS2012.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{93818257-A704-49CA-9CD1-A8826FC57F02}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ImportExportFromWinFormsDataGrid.CSharp</RootNamespace>
    <AssemblyName>ImportExportFromWinFormsDataGrid.CSharp</AssemblyName>
    <TargetFrameworkProfile />
    <FileAlignment>512</FileAlignment>
    <StartupObject>ImportExportFromWinFormsDataGrid.CSharp.Program</StartupObject>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86' ">
    <PlatformTarget>x86</PlatformTarget>
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
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.Spreadsheet, Version=2.3.0.750, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\lib\Bytescout.Spreadsheet.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
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
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ImportExportFromWinFormsDataGrid.VS2013.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="12.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{93818257-A704-49CA-9CD1-A8826FC57F02}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ImportExportFromWinFormsDataGrid.CSharp</RootNamespace>
    <AssemblyName>ImportExportFromWinFormsDataGrid.CSharp</AssemblyName>
    <TargetFrameworkProfile />
    <FileAlignment>512</FileAlignment>
    <StartupObject>ImportExportFromWinFormsDataGrid.CSharp.Program</StartupObject>
    <TargetFrameworkVersion>v4.5</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86' ">
    <PlatformTarget>x86</PlatformTarget>
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
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.Spreadsheet, Version=2.3.0.750, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\lib\Bytescout.Spreadsheet.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
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
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ImportExportFromWinFormsDataGrid.VS2015.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="14.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{93818257-A704-49CA-9CD1-A8826FC57F02}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ImportExportFromWinFormsDataGrid.CSharp</RootNamespace>
    <AssemblyName>ImportExportFromWinFormsDataGrid.CSharp</AssemblyName>
    <TargetFrameworkProfile />
    <FileAlignment>512</FileAlignment>
    <StartupObject>ImportExportFromWinFormsDataGrid.CSharp.Program</StartupObject>
    <TargetFrameworkVersion>v4.5</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86' ">
    <PlatformTarget>x86</PlatformTarget>
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
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.Spreadsheet, Version=2.3.0.750, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\lib\Bytescout.Spreadsheet.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
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
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.vb:**
    
```
Imports System.Windows.Forms

Class Program
	<STAThread> _
	Friend Shared Sub Main(args As String())
		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)
		Application.Run(New Form1())
	End Sub
End Class

```

<!-- code block end -->