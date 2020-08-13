## How to select region and perform OCR in C# with ByteScout Robotic Process Automation ByteScout Robotic Process Automation is components and tools for quick RPA (Robotic Process Automation) implementation.

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
namespace SelectRegionAndPerformOCR
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pdfViewerControl1 = new Bytescout.PDFViewer.PDFViewerControl();
            this.btnRunOCR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(971, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(114, 22);
            this.toolStripButton1.Text = "Load document";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // pdfViewerControl1
            // 
            this.pdfViewerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfViewerControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pdfViewerControl1.Location = new System.Drawing.Point(12, 28);
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
            this.pdfViewerControl1.Size = new System.Drawing.Size(766, 490);
            this.pdfViewerControl1.TabIndex = 1;
            // 
            // btnRunOCR
            // 
            this.btnRunOCR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunOCR.Enabled = false;
            this.btnRunOCR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRunOCR.Location = new System.Drawing.Point(784, 77);
            this.btnRunOCR.Name = "btnRunOCR";
            this.btnRunOCR.Size = new System.Drawing.Size(175, 39);
            this.btnRunOCR.TabIndex = 2;
            this.btnRunOCR.Text = "Run OCR";
            this.btnRunOCR.UseVisualStyleBackColor = true;
            this.btnRunOCR.Click += new System.EventHandler(this.btnRunOCR_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(784, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Load document, select region and press \"Run OCR\" button";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRunOCR);
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

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private Bytescout.PDFViewer.PDFViewerControl pdfViewerControl1;
        private System.Windows.Forms.Button btnRunOCR;
        private System.Windows.Forms.Label label1;
    }
}


```

<!-- code block end -->    

<!-- code block begin -->

##### **Form1.cs:**
    
```
using System;
using System.Drawing;
using System.Windows.Forms;
using Bytescout.PDFExtractor;

namespace SelectRegionAndPerformOCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = @"Open Document";
                openFileDialog.Filter = @"All Supported Formats|*.pdf;*.jpg;*.jpeg;*.png;*.tif;*.tiff;*.bmp|PDF Files (*.pdf)|*.pdf|Image Files (*.jpg;*.png;*.tif;*.tiff;*.bmp)|*.jpg;*.jpeg;*.png;*.tif;*.tiff;*.bmp|All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pdfViewerControl1.InputFile = openFileDialog.FileName;

                    btnRunOCR.Enabled = true;
                }
            }
        }

        private void btnRunOCR_Click(object sender, EventArgs e)
        {
            TextExtractor extractor = new TextExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Load sample PDF document
            extractor.LoadDocumentFromFile(pdfViewerControl1.InputFile);

            // Enable Optical Character Recognition (OCR)
            // in .Auto mode (SDK automatically checks if needs to use OCR or not)
            extractor.OCRMode = OCRMode.Auto;

            // Set the location of "tessdata" folder containing language data files
            extractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\net4.00\tessdata\";

            // Set OCR language
            extractor.OCRLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in /tessdata
            // Find more language files at https://github.com/tesseract-ocr/tessdata/tree/3.04.00

            // Set PDF document rendering resolution
            extractor.OCRResolution = 300;


            // Set the extraction area to the viewer's selection rectangle
            RectangleF[] selection = pdfViewerControl1.SelectionInPoints;
            if (selection.Length > 0)
                extractor.SetExtractionArea(selection[0]);

            // Show wait cursor
            Cursor = Cursors.WaitCursor;

            try
            {
                // Perform OCR and save result to file
                extractor.SavePageTextToFile(pdfViewerControl1.CurrentPageIndex, "result.txt");
            }
            finally
            {
                // Revert cursor to default
                Cursor = Cursors.Default;
            }
            
            // Cleanup
            extractor.Dispose();

            // Open output file in default associated application
            System.Diagnostics.Process.Start("result.txt");
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
using System.Linq;
using System.Windows.Forms;

namespace SelectRegionAndPerformOCR
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

##### **SelectRegionAndPerformOCR.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{6A7F695C-A9C0-4A00-8E07-57DBB26EB5EB}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <RootNamespace>SelectRegionAndPerformOCR</RootNamespace>
    <AssemblyName>SelectRegionAndPerformOCR</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDFExtractor, Version=9.1.0.3170, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\..\Program Files\Bytescout PDF Extractor SDK\net4.00\Bytescout.PDFExtractor.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.PDFExtractor.OCRExtension, Version=9.1.0.3170, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\..\Program Files\Bytescout PDF Extractor SDK\net4.00\Bytescout.PDFExtractor.OCRExtension.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.PDFViewer, Version=9.1.0.3170, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\..\Program Files\Bytescout PDF Viewer SDK\net4.00\Bytescout.PDFViewer.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
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
    </Compile>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.cs</LastGenOutput>
    </None>
    <Compile Include="Properties\Settings.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### **SelectRegionAndPerformOCR.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27703.2047
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "SelectRegionAndPerformOCR", "SelectRegionAndPerformOCR.csproj", "{6A7F695C-A9C0-4A00-8E07-57DBB26EB5EB}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{6A7F695C-A9C0-4A00-8E07-57DBB26EB5EB}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{6A7F695C-A9C0-4A00-8E07-57DBB26EB5EB}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{6A7F695C-A9C0-4A00-8E07-57DBB26EB5EB}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{6A7F695C-A9C0-4A00-8E07-57DBB26EB5EB}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {B4740E27-9001-4E5D-AABF-0EE4D43A2AC8}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->