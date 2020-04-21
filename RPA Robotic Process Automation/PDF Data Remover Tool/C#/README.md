## PDF data remover tool in C# with Multiple ByteScout SDK

### How to use Multiple ByteScout SDK for PDF data remover tool in C#

ByteScout tutorials explain the material for programmers who use C#. Multiple ByteScout SDK was made to help with PDF data remover tool in C#. Multiple ByteScout SDK is the set of few ByteScout SDK libraries that is used in apps performing multi-step workflows like searching for keywords or phrases inside existing documents with highlighting of results, or adding e-signature to existing document pdf based on the analysis of visual content in another document.

C# code snippet like this for Multiple ByteScout SDK works best when you need to quickly implement PDF data remover tool in your C# application. To do PDF data remover tool in your C# project or application you may simply copy & paste the code and then run your app! Enhanced documentation and tutorials are available along with installed Multiple ByteScout SDK if you'd like to dive deeper into the topic and the details of the API.

Multiple ByteScout SDK free trial version is available for download from our website. Free trial also includes programming tutorials along with source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=Multiple%20ByteScout%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=Multiple%20ByteScout%20SDK%20Question) 

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

##### ****Form1.Designer.cs:**
    
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pdfViewerControl1 = new Bytescout.PDFViewer.PDFViewerControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.btnProceed = new System.Windows.Forms.Button();
            this.tbSearchExpression = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRegex = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaskRemovedText = new System.Windows.Forms.CheckBox();
            this.cbMakeUnsearchable = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdfViewerControl1
            // 
            this.pdfViewerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfViewerControl1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pdfViewerControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pdfViewerControl1.CacheVisitedPages = true;
            this.pdfViewerControl1.Location = new System.Drawing.Point(275, 28);
            this.pdfViewerControl1.MouseMode = Bytescout.PDFViewer.MouseMode.Selection;
            this.pdfViewerControl1.Name = "pdfViewerControl1";
            this.pdfViewerControl1.RegistrationKey = null;
            this.pdfViewerControl1.RegistrationName = null;
            this.pdfViewerControl1.ShowToolbarFind = false;
            this.pdfViewerControl1.Size = new System.Drawing.Size(866, 662);
            this.pdfViewerControl1.TabIndex = 0;
            this.pdfViewerControl1.PreProcessKey += new Bytescout.PDFViewer.PreProcessKeyEventHandler(this.PdfViewerControl1_PreProcessKey);
            this.pdfViewerControl1.CurrentPageIndexChanged += new System.EventHandler(this.PdfViewerControl1_CurrentPageIndexChanged);
            this.pdfViewerControl1.SelectionChanged += new Bytescout.PDFViewer.SelectionChangedEventHandler(this.PdfViewerControl1_SelectionChanged);
            this.pdfViewerControl1.ValidateContextMenu += new Bytescout.PDFViewer.ValidateContextMenuEventHandler(this.PdfViewerControl1_ValidateContextMenu);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1153, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(64, 22);
            this.tsbOpen.Text = "&Open PDF";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(140, 207);
            this.btnProceed.Margin = new System.Windows.Forms.Padding(2);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(129, 23);
            this.btnProceed.TabIndex = 4;
            this.btnProceed.Text = "Perform Removal";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.BtnProceed_Click);
            // 
            // tbSearchExpression
            // 
            this.tbSearchExpression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchExpression.Location = new System.Drawing.Point(68, 19);
            this.tbSearchExpression.Name = "tbSearchExpression";
            this.tbSearchExpression.Size = new System.Drawing.Size(183, 20);
            this.tbSearchExpression.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(176, 69);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find All";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.BtnFindAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRegex);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbSearchExpression);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find";
            // 
            // cbRegex
            // 
            this.cbRegex.AutoSize = true;
            this.cbRegex.Location = new System.Drawing.Point(9, 45);
            this.cbRegex.Name = "cbRegex";
            this.cbRegex.Size = new System.Drawing.Size(144, 17);
            this.cbRegex.TabIndex = 1;
            this.cbRegex.Text = "Use Regular Expressions";
            this.cbRegex.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Find what:";
            // 
            // cbMaskRemovedText
            // 
            this.cbMaskRemovedText.AutoSize = true;
            this.cbMaskRemovedText.Location = new System.Drawing.Point(12, 151);
            this.cbMaskRemovedText.Name = "cbMaskRemovedText";
            this.cbMaskRemovedText.Size = new System.Drawing.Size(238, 17);
            this.cbMaskRemovedText.TabIndex = 2;
            this.cbMaskRemovedText.Text = "Draw black rectangles over the removed text";
            this.toolTip1.SetToolTip(this.cbMaskRemovedText, "Mask removed text fragments with black rectangles to make the output document loo" +
        "k like \"censored\".");
            this.cbMaskRemovedText.UseVisualStyleBackColor = true;
            // 
            // cbMakeUnsearchable
            // 
            this.cbMakeUnsearchable.AutoSize = true;
            this.cbMakeUnsearchable.Location = new System.Drawing.Point(12, 174);
            this.cbMakeUnsearchable.Name = "cbMakeUnsearchable";
            this.cbMakeUnsearchable.Size = new System.Drawing.Size(221, 17);
            this.cbMakeUnsearchable.TabIndex = 3;
            this.cbMakeUnsearchable.Text = "Make the output document unsearchable";
            this.toolTip1.SetToolTip(this.cbMakeUnsearchable, "Make the output document unsearchable. If checked, all PDF pages will be replaced" +
        " with rendered images.");
            this.cbMakeUnsearchable.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 702);
            this.Controls.Add(this.cbMakeUnsearchable);
            this.Controls.Add(this.cbMaskRemovedText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.pdfViewerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PDF Data Remover Tool";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bytescout.PDFViewer.PDFViewerControl pdfViewerControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.TextBox tbSearchExpression;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbRegex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbMaskRemovedText;
        private System.Windows.Forms.CheckBox cbMakeUnsearchable;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


```

<!-- code block end -->    

<!-- code block begin -->

##### ****Form1.cs:**
    
```
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bytescout.PDFExtractor;
using Bytescout.PDFViewer;


namespace Sample_UI_Application
{
    public partial class Form1 : Form
    {
        // Keep selected rectangles for all document pages
        Dictionary<int, RectangleF[]> _foundTextRectangles = new Dictionary<int, RectangleF[]>();

        public Form1()
        {
            InitializeComponent();

            // Tune PDF Viewer control
            pdfViewerControl1.MouseMode = MouseMode.Selection;
            pdfViewerControl1.MultiSelectMode = true;
            pdfViewerControl1.AllowResizeSelectionRectangles = true;
            pdfViewerControl1.ShowResizeHandlesForActiveSelectionOnly = true;
            pdfViewerControl1.ClearSelectionOnClick = false;

            // Load document into PDF viewer
            pdfViewerControl1.InputFile = "sample.pdf";
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
                        // Open file in PDF Viewer control
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

        private void PdfViewerControl1_SelectionChanged(object sender, SelectionChange selectionChange, int selectionIndex)
        {
            // Store selection changes 
            if (selectionChange != SelectionChange.Cleared)
            {
                _foundTextRectangles[pdfViewerControl1.CurrentPageIndex] = pdfViewerControl1.SelectionInPoints;
            }
        }

        private void PdfViewerControl1_CurrentPageIndexChanged(object sender, EventArgs e)
        {
            // Show stored selection on page switching
            if (_foundTextRectangles.ContainsKey(pdfViewerControl1.CurrentPageIndex))
            {
                pdfViewerControl1.SelectionInPoints = _foundTextRectangles[pdfViewerControl1.CurrentPageIndex];
            }
        }

        private void PdfViewerControl1_ValidateContextMenu(object source, ContextMenuStrip menu)
        {
            // Add context menu item to delete active selection
            menu.Items.Insert(0, new ToolStripMenuItem("Delete active selection", null, (sender, args) =>
            {
                int activeSelectionIndex = pdfViewerControl1.ActiveSelectionIndex;
                if (activeSelectionIndex != -1)
                    pdfViewerControl1.RemoveSelectionAt(activeSelectionIndex);
            }) { Enabled = pdfViewerControl1.ActiveSelectionIndex != -1 });

            menu.Items.Insert(1, new ToolStripSeparator());
        }

        private void PdfViewerControl1_PreProcessKey(object source, Keys keyData, ref bool handled)
        {
            // `Delete` key will delete active selection
            if (keyData == Keys.Delete)
            {
                int activeSelectionIndex = pdfViewerControl1.ActiveSelectionIndex;
                if (activeSelectionIndex != -1)
                {
                    pdfViewerControl1.RemoveSelectionAt(activeSelectionIndex);
                    handled = true;
                }
            }
        }

        private void BtnFindAll_Click(object sender, EventArgs e)
        {
            if (tbSearchExpression.Text.Length > 1)
            {
                // Prepare TextExtractor
                using (TextExtractor textExtractor = new TextExtractor("demo", "demo"))
                {
                    // Load document into TextExtractor
                    textExtractor.LoadDocumentFromFile(pdfViewerControl1.InputFile);

                    // Set options from UI
                    textExtractor.RegexSearch = cbRegex.Checked;
                    textExtractor.WordMatchingMode = WordMatchingMode.None;
                
                    // Search for text in all pages and store rectangles of found pieces
                    for (int pageIndex = 0; pageIndex < textExtractor.GetPageCount(); pageIndex++)
                    {
                        ISearchResult[] searchResults = textExtractor.FindAll(pageIndex, tbSearchExpression.Text, caseSensitive: true);
                        if (searchResults.Length > 0)
                        {
                            _foundTextRectangles[pageIndex] = searchResults.Select(searchResult => searchResult.Bounds).ToArray();
                        }
                    }
                }

                // Select fount rectangles in PDF Viewer
                if (_foundTextRectangles.ContainsKey(pdfViewerControl1.CurrentPageIndex))
                    pdfViewerControl1.SelectionInPoints = _foundTextRectangles[pdfViewerControl1.CurrentPageIndex];
            }
            else
            {
                MessageBox.Show(@"Try larger search string");
            }
        }

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            var outputFile = "output.pdf";
            MemoryStream tempStream = new MemoryStream();

            // Create `Bytescout.PDFExtractor.Remover2` instance
            using (Remover2 remover = new Remover2("demo", "demo"))
            {
                // Load document into remover
                remover.LoadDocumentFromFile(pdfViewerControl1.InputFile);

                // Set options from UI
                remover.MaskRemovedText = cbMaskRemovedText.Checked;
                remover.MakePDFUnsearchable = cbMakeUnsearchable.Checked;

                // Add fragments to remove
                foreach (KeyValuePair<int, RectangleF[]> keyValuePair in _foundTextRectangles)
                    remover.AddTextToRemove(keyValuePair.Key, keyValuePair.Value);

                // Perform removal and save result document to file
                remover.PerformRemoval(outputFile);
            }
            
            // Open output PDF file in default associated application
            Process.Start(outputFile);
        }
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****PdfDataRemoverTool.csproj:**
    
```
<Project ToolsVersion="14.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{0DB74CC3-1DD8-4A58-94FC-CA9A60E2F8A2}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <RootNamespace>PdfDataRemoverTool</RootNamespace>
    <AssemblyName>PdfDataRemoverTool</AssemblyName>
    <TargetFrameworkVersion>v4.5</TargetFrameworkVersion>
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
    <Reference Include="Bytescout.PDF, Version=1.9.4.317, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\..\Program Files\Bytescout PDF SDK\net4.5\Bytescout.PDF.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.PDFExtractor, Version=10.3.0.3566, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
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
    <EmbeddedResource Include="Form1.resx">
      <DependentUpon>Form1.cs</DependentUpon>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Form1.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form1.Designer.cs">
      <DependentUpon>Form1.cs</DependentUpon>
    </Compile>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <None Include="sample.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
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

##### ****PdfDataRemoverTool.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 16
VisualStudioVersion = 16.0.29025.244
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "PdfDataRemoverTool", "PdfDataRemoverTool.csproj", "{0DB74CC3-1DD8-4A58-94FC-CA9A60E2F8A2}"
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
		SolutionGuid = {6A423F77-480F-401A-9016-BED7CAE557A3}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.cs:**
    
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