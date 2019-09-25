## How to print pdf with pdf renderer sdk in VB.NET and ByteScout PDF Suite

### This code in VB.NET shows how to print pdf with pdf renderer sdk with this how to tutorial

The sample source code below will teach you how to print pdf with pdf renderer sdk in VB.NET. ByteScout PDF Suite can print pdf with pdf renderer sdk. It can be applied from VB.NET. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VB.NET code from ByteScout PDF Suite for print pdf with pdf renderer sdk below and use it in your application.  Simply copy and paste in your VB.NET project or application you and then run your app! Complete and detailed tutorials and documentation are available along with installed ByteScout PDF Suite if you'd like to learn more about the topic and the details of the API.

The trial version of ByteScout PDF Suite can be downloaded for free from our website. It also includes source code samples for VB.NET and other programming languages.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Suite%20Question) 

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
		Me.printDocument1 = New System.Drawing.Printing.PrintDocument()
		Me.printPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
		Me.pageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
		Me.printDialog1 = New System.Windows.Forms.PrintDialog()
		Me.buttonPageSetup = New System.Windows.Forms.Button()
		Me.buttonPrintPreview = New System.Windows.Forms.Button()
		Me.buttonPrint = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		' 
		' printDocument1
		' 
		AddHandler Me.printDocument1.PrintPage, New System.Drawing.Printing.PrintPageEventHandler(AddressOf Me.printDocument1_PrintPage)
		' 
		' printPreviewDialog1
		' 
		Me.printPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
		Me.printPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
		Me.printPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
		Me.printPreviewDialog1.Document = Me.printDocument1
		Me.printPreviewDialog1.Enabled = True
		Me.printPreviewDialog1.Icon = DirectCast(resources.GetObject("printPreviewDialog1.Icon"), System.Drawing.Icon)
		Me.printPreviewDialog1.Name = "printPreviewDialog1"
		Me.printPreviewDialog1.UseAntiAlias = True
		Me.printPreviewDialog1.Visible = False
		' 
		' pageSetupDialog1
		' 
		Me.pageSetupDialog1.Document = Me.printDocument1
		' 
		' printDialog1
		' 
		Me.printDialog1.Document = Me.printDocument1
		Me.printDialog1.UseEXDialog = True
		' 
		' buttonPageSetup
		' 
		Me.buttonPageSetup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonPageSetup.Location = New System.Drawing.Point(12, 12)
		Me.buttonPageSetup.Name = "buttonPageSetup"
		Me.buttonPageSetup.Size = New System.Drawing.Size(253, 41)
		Me.buttonPageSetup.TabIndex = 0
		Me.buttonPageSetup.Text = "Page Setup"
		Me.buttonPageSetup.UseVisualStyleBackColor = True
		AddHandler Me.buttonPageSetup.Click, New System.EventHandler(AddressOf Me.buttonPageSetup_Click)
		' 
		' buttonPrintPreview
		' 
		Me.buttonPrintPreview.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonPrintPreview.Location = New System.Drawing.Point(12, 59)
		Me.buttonPrintPreview.Name = "buttonPrintPreview"
		Me.buttonPrintPreview.Size = New System.Drawing.Size(253, 41)
		Me.buttonPrintPreview.TabIndex = 1
		Me.buttonPrintPreview.Text = "Print Preview"
		Me.buttonPrintPreview.UseVisualStyleBackColor = True
		AddHandler Me.buttonPrintPreview.Click, New System.EventHandler(AddressOf Me.buttonPrintPreview_Click)
		' 
		' buttonPrint
		' 
		Me.buttonPrint.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonPrint.Location = New System.Drawing.Point(12, 106)
		Me.buttonPrint.Name = "buttonPrint"
		Me.buttonPrint.Size = New System.Drawing.Size(253, 41)
		Me.buttonPrint.TabIndex = 2
		Me.buttonPrint.Text = "Print"
		Me.buttonPrint.UseVisualStyleBackColor = True
		AddHandler Me.buttonPrint.Click, New System.EventHandler(AddressOf Me.buttonPrint_Click)
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(277, 161)
		Me.Controls.Add(Me.buttonPrint)
		Me.Controls.Add(Me.buttonPrintPreview)
		Me.Controls.Add(Me.buttonPageSetup)
		Me.Name = "Form1"
		Me.Text = "Print PDF"
		AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private printDocument1 As System.Drawing.Printing.PrintDocument
	Private printPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
	Private pageSetupDialog1 As System.Windows.Forms.PageSetupDialog
	Private printDialog1 As System.Windows.Forms.PrintDialog
	Private buttonPageSetup As System.Windows.Forms.Button
	Private buttonPrintPreview As System.Windows.Forms.Button
	Private buttonPrint As System.Windows.Forms.Button
End Class


```

<!-- code block end -->    

<!-- code block begin -->

##### ****Form1.vb:**
    
```
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Windows.Forms

Imports Bytescout.PDFRenderer


Public Partial Class Form1
	Inherits Form
	Private _document As String = "multipage.pdf"
	Private _rasterRenderer As RasterRenderer = Nothing
	Private _page As Integer = 0


	Public Sub New()
		InitializeComponent()

		' Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.
		_rasterRenderer = New RasterRenderer()
		_rasterRenderer.RegistrationName = "demo"
		_rasterRenderer.RegistrationKey = "demo"
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs)
		Cursor = Cursors.WaitCursor

		Try
            ' Load PDF document
			_rasterRenderer.LoadDocumentFromFile(_document)
		Catch exception As Exception
            MessageBox.Show("Could not open PDF document." & vbLf & vbLf & exception.Message)
		Finally
			Cursor = Cursors.[Default]
		End Try
	End Sub

    Private Sub buttonPageSetup_Click(ByVal sender As Object, ByVal e As EventArgs)

        ' Set landscape orientation if needed
        Dim pageRectangle As RectangleF = _rasterRenderer.GetPageRectangle(0)
        If (pageRectangle.Width > pageRectangle.Height) Then
            pageSetupDialog1.PageSettings.Landscape = True
        End If

        pageSetupDialog1.ShowDialog()

    End Sub

	Private Sub buttonPrintPreview_Click(sender As Object, e As EventArgs)
		_page = 0
		printPreviewDialog1.Width = 800
		printPreviewDialog1.Height = 600
		printPreviewDialog1.ShowDialog()
	End Sub

	Private Sub buttonPrint_Click(sender As Object, e As EventArgs)
		If printDialog1.ShowDialog() = DialogResult.OK Then
			printDocument1.Print()
		End If
	End Sub

    Private Sub printDocument1_PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs)

        Cursor = Cursors.WaitCursor

        Try
            ' For the best quality set the rendering resolution equal to the printer resolution
            Dim renderingResolution As Single = e.PageSettings.PrinterResolution.X

            ' Render page to image
            Using image As Image = _rasterRenderer.GetImage(_page, renderingResolution)

                ' Fit image into the print rectangle keeping the aspect ratio

                Dim printRect As Rectangle = e.MarginBounds

                Dim ratio As Single = printRect.Width / CSng(image.Width)
                Dim width As Integer = printRect.Width
                Dim height As Integer = CInt(Math.Round(image.Height * ratio))

                If height > printRect.Height Then
                    ratio = printRect.Height / CSng(image.Height)
                    width = CInt(Math.Round(image.Width * ratio))
                    height = printRect.Height
                End If

                ' Draw image on device
                e.Graphics.DrawImage(image, New Rectangle(printRect.X, printRect.Y, width, height), New Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel)

            End Using

            If _page < _rasterRenderer.GetPageCount() - 1 Then
                _page += 1
                e.HasMorePages = True
            End If
        Catch exception As Exception
            MessageBox.Show(exception.Message)
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****PrintPDF.VS2005.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{068B4967-3562-41B6-9C3A-813E0DAD3859}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>PrintPDF</RootNamespace>
    <AssemblyName>PrintPDF</AssemblyName>
    <StartupObject>PrintPDF.Program</StartupObject>
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
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDFRenderer, Version=1.10.0.98, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
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
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
    <Compile Include="Properties\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
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
    <Content Include="..\..\multipage.pdf">
      <Link>multipage.pdf</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****PrintPDF.VS2008.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build" ToolsVersion="3.5">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.21022</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{068B4967-3562-41B6-9C3A-813E0DAD3859}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>PrintPDF</RootNamespace>
    <AssemblyName>PrintPDF</AssemblyName>
    <StartupObject>PrintPDF.Program</StartupObject>
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
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDFRenderer, Version=1.10.0.98, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
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
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
    <Compile Include="Properties\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
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
    <Content Include="..\..\multipage.pdf">
      <Link>multipage.pdf</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****PrintPDF.VS2010.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{068B4967-3562-41B6-9C3A-813E0DAD3859}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>PrintPDF</RootNamespace>
    <AssemblyName>PrintPDF</AssemblyName>
    <StartupObject>PrintPDF.Program</StartupObject>
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
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDFRenderer, Version=1.10.0.98, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
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
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
    <Compile Include="Properties\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
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
    <Content Include="..\..\multipage.pdf">
      <Link>multipage.pdf</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
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