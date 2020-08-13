## How to convert scanned PDF to excel in C# and ByteScout Robotic Process Automation What is ByteScout Robotic Process Automation? It is components and tools for quick RPA (Robotic Process Automation) implementation.

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

##### **Form1.Designer.cs:**
    
```
namespace Sample_UI_Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pdfViewerControl1 = new Bytescout.PDFViewer.PDFViewerControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExportToCSV = new System.Windows.Forms.ToolStripButton();
            this.tsbExportToXLSX = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdfViewerControl1
            // 
            this.pdfViewerControl1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pdfViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewerControl1.Location = new System.Drawing.Point(0, 25);
            this.pdfViewerControl1.MouseMode = Bytescout.PDFViewer.MouseMode.Selection;
            this.pdfViewerControl1.Name = "pdfViewerControl1";
            this.pdfViewerControl1.RegistrationKey = null;
            this.pdfViewerControl1.RegistrationName = null;
            this.pdfViewerControl1.ResetRotationOnPageChange = false;
            this.pdfViewerControl1.Scale = 100;
            this.pdfViewerControl1.SelectionColor = System.Drawing.Color.Red;
            this.pdfViewerControl1.ShowImageObjects = true;
            this.pdfViewerControl1.ShowTextObjects = true;
            this.pdfViewerControl1.ShowVectorObjects = true;
            this.pdfViewerControl1.Size = new System.Drawing.Size(842, 514);
            this.pdfViewerControl1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.toolStripSeparator1,
            this.tsbExportToCSV,
            this.tsbExportToXLSX});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(842, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = global::Sample_UI_Application.Properties.Resources.folder_page;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(80, 22);
            this.tsbOpen.Text = "&Open PDF";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExportToCSV
            // 
            this.tsbExportToCSV.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportToCSV.Image")));
            this.tsbExportToCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportToCSV.Name = "tsbExportToCSV";
            this.tsbExportToCSV.Size = new System.Drawing.Size(100, 22);
            this.tsbExportToCSV.Text = "Export To CSV";
            this.tsbExportToCSV.Click += new System.EventHandler(this.tsbExportToCSV_Click);
            // 
            // tsbExportToXLSX
            // 
            this.tsbExportToXLSX.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportToXLSX.Image")));
            this.tsbExportToXLSX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportToXLSX.Name = "tsbExportToXLSX";
            this.tsbExportToXLSX.Size = new System.Drawing.Size(105, 22);
            this.tsbExportToXLSX.Text = "Export To XLSX";
            this.tsbExportToXLSX.Click += new System.EventHandler(this.tsbExportToXLSX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 539);
            this.Controls.Add(this.pdfViewerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Bytescout.PDFViewer.PDFViewerControl pdfViewerControl1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbExportToCSV;
        private System.Windows.Forms.ToolStripButton tsbExportToXLSX;
    }
}


```

<!-- code block end -->    

<!-- code block begin -->

##### **Form1.cs:**
    
```
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bytescout.PDFExtractor;

namespace Sample_UI_Application
{
    // This example requires 'PDF Viewer SDK' and 'PDF Extractor SDK' installed.
    // Download link: http://cdn.bytescout.com/ByteScoutInstaller.exe

    public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

	    protected override void OnLoad(EventArgs e)
	    {
            // Preload document into viewer
	        pdfViewerControl1.InputFile = @".\sample_ocr.pdf";

            base.OnLoad(e);
	    }

	    private void tsbOpen_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Title = @"Open PDF Document";
				openFileDialog.Filter = @"PDF Files (*.pdf)|*.pdf|All Files|*.*";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.Text = openFileDialog.FileName;

					Cursor = Cursors.WaitCursor;

					try
					{
						pdfViewerControl1.InputFile = openFileDialog.FileName;
					}
					catch (Exception exception)
					{
						MessageBox.Show(exception.Message);
					}
					finally
					{
						Cursor = Cursors.Default;
					}
				}
			}
		}

        private void tsbExportToCSV_Click(object sender, EventArgs e)
        {
            // Get selections from viewer
            RectangleF[] selections = pdfViewerControl1.SelectionInPoints;
            
            string outputFile = @".\result.csv";

            using (CSVExtractor csvExtractor = new CSVExtractor("demo", "demo"))
            {
                // Load document into extractor
                csvExtractor.LoadDocumentFromFile(pdfViewerControl1.InputFile);

                // Enable OCR to recongize text from images
                csvExtractor.OCRMode = OCRMode.Auto;
                csvExtractor.OCRResolution = 300;
                csvExtractor.OCRLanguage = "eng";
                csvExtractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\net4.00\tessdata\";

                // There are double spaces between some words in your document.
                // To avoid such words break column structure increase the space ratio to 2.
                csvExtractor.DetectNewColumnBySpacesRatio = 2;

                // FYI, removing horizontal lines may increase the text recognition quality in some cases
                csvExtractor.OCRImagePreprocessingFilters.AddHorizontalLinesRemover();
                // Another filter able to improve the recognition 
                //csvExtractor.OCRImagePreprocessingFilters.AddGammaCorrection();

                // If selection exists set the extraction area.
                // Overwise it will extract the whole page.
                if (selections.Length > 0)
                    csvExtractor.SetExtractionArea(selections[0]);

                // Save extraction results to CSV files
                csvExtractor.SavePageCSVToFile(pdfViewerControl1.CurrentPageIndex, outputFile);
            }

            Process.Start(outputFile);
        }

        private void tsbExportToXLSX_Click(object sender, EventArgs e)
        {
            // Get selections from viewer
            RectangleF[] selections = pdfViewerControl1.SelectionInPoints;

            string outputFile = @".\result.xlsx";

            using (XLSExtractor xlsExtractor = new XLSExtractor("demo", "demo"))
            {
                // Load document into extractor
                xlsExtractor.LoadDocumentFromFile(pdfViewerControl1.InputFile);

                xlsExtractor.OCRMode = OCRMode.Auto;
                xlsExtractor.OCRResolution = 300;
                xlsExtractor.OCRLanguage = "eng";
                xlsExtractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\net4.00\tessdata\";

                xlsExtractor.OutputFormat = SpreadseetOutputFormat.XLSX;
                xlsExtractor.RichTextFormatting = false;

                // There are double spaces between some words in your document.
                // To avoid such words break column structure increase the space ratio to 2.
                xlsExtractor.DetectNewColumnBySpacesRatio = 2;

                // FYI, removing horizontal lines may increase the text recognition quality in some cases
                //xlsExtractor.OCRImagePreprocessingFilters.AddHorizontalLinesRemover();
                // Another filter able to improve the recognition 
                //xlsExtractor.OCRImagePreprocessingFilters.AddGammaCorrection();

                // If selection exists set the extraction area.
                // Overwise it will extract the whole page.
                if (selections.Length > 0)
                    xlsExtractor.SetExtractionArea(selections[0]);

                // Save extraction results to XLSX files
                xlsExtractor.SavePageToXLSFile(pdfViewerControl1.CurrentPageIndex, outputFile);
            }

            Process.Start(outputFile);
        }
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### **Program.cs:**
    
```
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sample_UI_Application
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

##### **ScannedPdfToExcel.csproj:**
    
```
<Project ToolsVersion="14.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{0DB74CC3-1DD8-4A58-94FC-CA9A60E2F8A2}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>Sample_UI_Application</RootNamespace>
    <AssemblyName>Sample UI Application</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <TargetFrameworkProfile />
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
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
    <Reference Include="Bytescout.PDFExtractor, Version=8.8.0.3017, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\..\Program Files\Bytescout PDF Extractor SDK\net4.00\Bytescout.PDFExtractor.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.PDFExtractor.OCRExtension, Version=8.8.0.3017, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\..\Program Files\Bytescout PDF Extractor SDK\net4.00\Bytescout.PDFExtractor.OCRExtension.dll</HintPath>
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
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Form1.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form1.Designer.cs">
      <DependentUpon>Form1.cs</DependentUpon>
    </Compile>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>ResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.cs</LastGenOutput>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <Compile Include="Properties\Resources.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
      <DesignTime>True</DesignTime>
    </Compile>
    <None Include="app.config" />
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.cs</LastGenOutput>
    </None>
    <Compile Include="Properties\Settings.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
    <Content Include="sample_ocr.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <None Include="Resources\folder_page.png" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
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

##### **ScannedPdfToExcel.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27130.2027
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "ScannedPdfToExcel", "ScannedPdfToExcel.csproj", "{0DB74CC3-1DD8-4A58-94FC-CA9A60E2F8A2}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{0DB74CC3-1DD8-4A58-94FC-CA9A60E2F8A2}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{0DB74CC3-1DD8-4A58-94FC-CA9A60E2F8A2}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{0DB74CC3-1DD8-4A58-94FC-CA9A60E2F8A2}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{0DB74CC3-1DD8-4A58-94FC-CA9A60E2F8A2}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {4701A661-4DCD-4CAC-9E81-162B4D0AB70B}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### **app.config:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<configuration>
<startup><supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.0"/></startup></configuration>

```

<!-- code block end -->