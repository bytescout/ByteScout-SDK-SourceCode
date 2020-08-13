## How to convert scanned PDF to excel in VB.NET and ByteScout Robotic Process Automation ByteScout Robotic Process Automation is set of integrated APIs for quick replaccement of manual data processing with robotic process automations.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Robotic%20Process%20Automation%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Robotic%20Process%20Automation%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore Documentation](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Explore Source Code Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://app.pdf.co/signup?utm_source=github-readme)
[Security](https://pdf.co/security)
[Explore Web API Documentation](https://apidocs.pdf.co?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=gEjuZ0zgtHo](https://www.youtube.com/watch?v=gEjuZ0zgtHo)




<!-- code block begin -->

##### **Form1.Designer.vb:**
    
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pdfViewerControl1 = New Bytescout.PDFViewer.PDFViewerControl()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbOpen = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbExportToCSV = New System.Windows.Forms.ToolStripButton()
        Me.tsbExportToXLSX = New System.Windows.Forms.ToolStripButton()
        Me.toolStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'pdfViewerControl1
        '
        Me.pdfViewerControl1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.pdfViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pdfViewerControl1.Location = New System.Drawing.Point(0, 25)
        Me.pdfViewerControl1.MouseMode = Bytescout.PDFViewer.MouseMode.Selection
        Me.pdfViewerControl1.Name = "pdfViewerControl1"
        Me.pdfViewerControl1.RegistrationKey = Nothing
        Me.pdfViewerControl1.RegistrationName = Nothing
        Me.pdfViewerControl1.ResetRotationOnPageChange = false
        Me.pdfViewerControl1.Scale = 100
        Me.pdfViewerControl1.SelectionColor = System.Drawing.Color.Red
        Me.pdfViewerControl1.ShowImageObjects = true
        Me.pdfViewerControl1.ShowTextObjects = true
        Me.pdfViewerControl1.ShowVectorObjects = true
        Me.pdfViewerControl1.Size = New System.Drawing.Size(842, 514)
        Me.pdfViewerControl1.TabIndex = 0
        '
        'toolStrip1
        '
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbOpen, Me.ToolStripSeparator1, Me.tsbExportToCSV, Me.tsbExportToXLSX})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(842, 25)
        Me.toolStrip1.TabIndex = 1
        Me.toolStrip1.Text = "toolStrip1"
        '
        'tsbOpen
        '
        Me.tsbOpen.Image = Global.Sample_UI_Application.My.Resources.Resources.folder_page
        Me.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOpen.Name = "tsbOpen"
        Me.tsbOpen.Size = New System.Drawing.Size(80, 22)
        Me.tsbOpen.Text = "&Open PDF"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbExportToCSV
        '
        Me.tsbExportToCSV.Image = CType(resources.GetObject("tsbExportToCSV.Image"),System.Drawing.Image)
        Me.tsbExportToCSV.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportToCSV.Name = "tsbExportToCSV"
        Me.tsbExportToCSV.Size = New System.Drawing.Size(100, 22)
        Me.tsbExportToCSV.Text = "Export To CSV"
        '
        'tsbExportToXLSX
        '
        Me.tsbExportToXLSX.Image = CType(resources.GetObject("tsbExportToXLSX.Image"),System.Drawing.Image)
        Me.tsbExportToXLSX.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportToXLSX.Name = "tsbExportToXLSX"
        Me.tsbExportToXLSX.Size = New System.Drawing.Size(105, 22)
        Me.tsbExportToXLSX.Text = "Export To XLSX"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 539)
        Me.Controls.Add(Me.pdfViewerControl1)
        Me.Controls.Add(Me.toolStrip1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.toolStrip1.ResumeLayout(false)
        Me.toolStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

	#End Region

	Private pdfViewerControl1 As Bytescout.PDFViewer.PDFViewerControl
	Private toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents tsbOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbExportToCSV As Windows.Forms.ToolStripButton
    Friend WithEvents tsbExportToXLSX As Windows.Forms.ToolStripButton
End Class


```

<!-- code block end -->    

<!-- code block begin -->

##### **Form1.vb:**
    
```
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports Bytescout.PDFExtractor

' This example requires 'PDF Viewer SDK' and 'PDF Extractor SDK' installed.
' Download link: http://cdn.bytescout.com/ByteScoutInstaller.exe

Public Partial Class Form1
    Inherits Form

	Public Sub New()
		InitializeComponent()
	End Sub

	Protected Overrides Sub OnLoad(e As EventArgs)

	    ' Preload document into viewer
	    pdfViewerControl1.InputFile = ".\sample_ocr.pdf"

	    MyBase.OnLoad(e)
	End Sub

	Private Sub tsbOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbOpen.Click

        Using openFileDialog As New OpenFileDialog()

            openFileDialog.Title = "Open PDF Document"
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files|*.*"

            If openFileDialog.ShowDialog() = DialogResult.OK Then

                Me.Text = openFileDialog.FileName

                Cursor = Cursors.WaitCursor

                Try
                    pdfViewerControl1.InputFile = openFileDialog.FileName
                Catch exception As Exception
                    MessageBox.Show(exception.Message)
                Finally
                    Cursor = Cursors.[Default]
                End Try

            End If

        End Using

    End Sub

    Private Sub tsbExportToCSV_Click(sender As Object, e As EventArgs) Handles tsbExportToCSV.Click

        ' Get selections from viewer
        Dim selections As RectangleF() = pdfViewerControl1.SelectionInPoints

        Dim outputFile As String = ".\result.csv"

        Using csvExtractor As CSVExtractor = New CSVExtractor()

            ' Load document into extractor
            csvExtractor.LoadDocumentFromFile(pdfViewerControl1.InputFile)

            ' Enable OCR to recongize text from images
            csvExtractor.OCRMode = OCRMode.Auto
            csvExtractor.OCRResolution = 300
            csvExtractor.OCRLanguage = "eng"
            csvExtractor.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\net4.00\tessdata\"

            
            ' FYI, removing horizontal lines may increase the text recognition quality in some cases
            'csvExtractor.OCRImagePreprocessingFilters.AddHorizontalLinesRemover()
            ' Another filter able to improve the recognition 
            'csvExtractor.OCRImagePreprocessingFilters.AddGammaCorrection()

            ' If selection exists set the extraction area.
            ' Overwise it will extract the whole page.
            If selections.Length > 0 Then
                csvExtractor.SetExtractionArea(selections(0))
            End If

            ' Save extraction results to CSV files
            csvExtractor.SavePageCSVToFile(pdfViewerControl1.CurrentPageIndex, outputFile)

        End Using

        Process.Start(outputFile)

    End Sub

    Private Sub tsbExportToXLSX_Click(sender As Object, e As EventArgs) Handles tsbExportToXLSX.Click

        ' Get selections from viewer
        Dim selections As RectangleF() = pdfViewerControl1.SelectionInPoints

        Dim outputFile As String = ".\result.xlsx"

        Using xlsExtractor As XLSExtractor = New XLSExtractor()

            ' Load document into extractor
            xlsExtractor.LoadDocumentFromFile(pdfViewerControl1.InputFile)

            ' Enable OCR to recongize text from images
            xlsExtractor.OCRMode = OCRMode.Auto
            xlsExtractor.OCRResolution = 300
            xlsExtractor.OCRLanguage = "eng"
            xlsExtractor.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\net4.00\tessdata\"

            xlsExtractor.OutputFormat = SpreadseetOutputFormat.XLSX
            xlsExtractor.RichTextFormatting = false

            ' FYI, removing horizontal lines may increase the text recognition quality in some cases
            'xlsExtractor.OCRImagePreprocessingFilters.AddHorizontalLinesRemover()
            ' Another filter able to improve the recognition 
            'xlsExtractor.OCRImagePreprocessingFilters.AddGammaCorrection()

            ' If selection exists set the extraction area.
            ' Overwise it will extract the whole page.
            If selections.Length > 0 Then
                xlsExtractor.SetExtractionArea(selections(0))
            End If

            ' Save extraction results to CSV files
            xlsExtractor.SavePageToXLSFile(pdfViewerControl1.CurrentPageIndex, outputFile)

        End Using

        Process.Start(outputFile)

    End Sub
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### **Program.vb:**
    
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

<!-- code block begin -->

##### **ScannedPdfToExcel.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27130.2027
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "ScannedPdfToExcel", "ScannedPdfToExcel.vbproj", "{01128D77-6A23-4ADE-B45A-3D5A4CFA7D4D}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{01128D77-6A23-4ADE-B45A-3D5A4CFA7D4D}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{01128D77-6A23-4ADE-B45A-3D5A4CFA7D4D}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{01128D77-6A23-4ADE-B45A-3D5A4CFA7D4D}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{01128D77-6A23-4ADE-B45A-3D5A4CFA7D4D}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {3DC98D31-2FAE-4C39-A08C-531D03F864C8}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### **ScannedPdfToExcel.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="14.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{01128D77-6A23-4ADE-B45A-3D5A4CFA7D4D}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>Sample_UI_Application</RootNamespace>
    <AssemblyName>Sample UI Application</AssemblyName>
    <StartupObject>Sample_UI_Application.Program</StartupObject>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
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
    <Reference Include="Bytescout.PDFExtractor, Version=8.8.0.3017, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF Extractor SDK\net4.00\Bytescout.PDFExtractor.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.PDFExtractor.OCRExtension, Version=8.8.0.3017, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF Extractor SDK\net4.00\Bytescout.PDFExtractor.OCRExtension.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.PDFViewer, Version=2.20.0.543, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
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
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="app.config" />
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
    <None Include="Resources\folder_page.png" />
    <Content Include="sample_ocr.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### **app.config:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<configuration>
    <system.diagnostics>
        <sources>
            <!-- This section defines the logging configuration for My.Application.Log -->
            <source name="DefaultSource" switchName="DefaultSwitch">
                <listeners>
                    <add name="FileLog"/>
                    <!-- Uncomment the below section to write to the Application Event Log -->
                    <!--<add name="EventLog"/>-->
                </listeners>
            </source>
        </sources>
        <switches>
            <add name="DefaultSwitch" value="Information"/>
        </switches>
        <sharedListeners>
            <add name="FileLog" type="Microsoft.VisualBasic.Logging.FileLogTraceListener, Microsoft.VisualBasic, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL" initializeData="FileLogWriter"/>
            <!-- Uncomment the below section and replace APPLICATION_NAME with the name of your application to write to the Application Event Log -->
            <!--<add name="EventLog" type="System.Diagnostics.EventLogTraceListener" initializeData="APPLICATION_NAME"/> -->
        </sharedListeners>
    </system.diagnostics>
<startup><supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.0"/></startup></configuration>

```

<!-- code block end -->