## human assisted invoice parsing in C# with Multiple ByteScout SDK

### human assisted invoice parsing in C#

The documentation is designed to help you to implement the features on your side. Multiple ByteScout SDK helps with human assisted invoice parsing in C#. Multiple ByteScout SDK is the combination of one or more ByteScout SDK components to perform complex workflows like searching for text inside documents and highlighting found results and saving as new document or splitting pdf based on visually detected horizontal lines.

You will save a lot of time on writing and testing code as you may just take the code below and use it in your application. In order to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Enjoy writing a code with ready-to-use sample C# codes to add human assisted invoice parsing functions using Multiple ByteScout SDK in C#.

Our website provides free trial version of Multiple ByteScout SDK. It comes along with all these source code samples with the goal to help you with your C# application implementation.

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
namespace SampleApplication
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
			this.pdfViewerControl1 = new Bytescout.PDFViewer.PDFViewerControl();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbOpen = new System.Windows.Forms.ToolStripButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnGetData = new System.Windows.Forms.Button();
			this.rbSelectTotal = new System.Windows.Forms.RadioButton();
			this.rbSelectCustomerInfo = new System.Windows.Forms.RadioButton();
			this.rbSelectInvoiceNumber = new System.Windows.Forms.RadioButton();
			this.toolStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pdfViewerControl1
			// 
			this.pdfViewerControl1.AllowResizeSelectionRectangles = true;
			this.pdfViewerControl1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.pdfViewerControl1.ClearSelectionOnClick = false;
			this.pdfViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pdfViewerControl1.Location = new System.Drawing.Point(179, 25);
			this.pdfViewerControl1.MouseMode = Bytescout.PDFViewer.MouseMode.Selection;
			this.pdfViewerControl1.MultiSelectMode = true;
			this.pdfViewerControl1.Name = "pdfViewerControl1";
			this.pdfViewerControl1.RegistrationKey = null;
			this.pdfViewerControl1.RegistrationName = null;
			this.pdfViewerControl1.SelectionColor = System.Drawing.Color.Red;
			this.pdfViewerControl1.SelectionModifierKey = Bytescout.PDFViewer.SelectionModifierKeys.None;
			this.pdfViewerControl1.Size = new System.Drawing.Size(829, 708);
			this.pdfViewerControl1.TabIndex = 0;
			this.pdfViewerControl1.CurrentPageIndexChanged += new System.EventHandler(this.pdfViewerControl1_CurrentPageIndexChanged);
			this.pdfViewerControl1.SelectionChanged += new System.EventHandler(this.pdfViewerControl1_SelectionChanged);
			this.pdfViewerControl1.CustomPaint += new System.Windows.Forms.PaintEventHandler(this.pdfViewerControl1_CustomPaint);
			this.pdfViewerControl1.DocumentChanged += new System.EventHandler(this.pdfViewerControl1_DocumentChanged);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbOpen
			// 
			this.tsbOpen.Image = global::SampleApplication.Properties.Resources.folder_page;
			this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbOpen.Name = "tsbOpen";
			this.tsbOpen.Size = new System.Drawing.Size(80, 22);
			this.tsbOpen.Text = "&Open PDF";
			this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.btnGetData);
			this.panel1.Controls.Add(this.rbSelectTotal);
			this.panel1.Controls.Add(this.rbSelectCustomerInfo);
			this.panel1.Controls.Add(this.rbSelectInvoiceNumber);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(179, 708);
			this.panel1.TabIndex = 2;
			// 
			// btnClear
			// 
			this.btnClear.Enabled = false;
			this.btnClear.Location = new System.Drawing.Point(93, 126);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 4;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnGetData
			// 
			this.btnGetData.Enabled = false;
			this.btnGetData.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnGetData.Location = new System.Drawing.Point(12, 97);
			this.btnGetData.Name = "btnGetData";
			this.btnGetData.Size = new System.Drawing.Size(156, 23);
			this.btnGetData.TabIndex = 3;
			this.btnGetData.Text = "Get Data";
			this.btnGetData.UseVisualStyleBackColor = true;
			this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
			// 
			// rbSelectTotal
			// 
			this.rbSelectTotal.AutoSize = true;
			this.rbSelectTotal.Enabled = false;
			this.rbSelectTotal.Location = new System.Drawing.Point(12, 66);
			this.rbSelectTotal.Name = "rbSelectTotal";
			this.rbSelectTotal.Size = new System.Drawing.Size(93, 17);
			this.rbSelectTotal.TabIndex = 2;
			this.rbSelectTotal.Text = "Select TOTAL";
			this.rbSelectTotal.UseVisualStyleBackColor = true;
			// 
			// rbSelectCustomerInfo
			// 
			this.rbSelectCustomerInfo.AutoSize = true;
			this.rbSelectCustomerInfo.Enabled = false;
			this.rbSelectCustomerInfo.Location = new System.Drawing.Point(12, 43);
			this.rbSelectCustomerInfo.Name = "rbSelectCustomerInfo";
			this.rbSelectCustomerInfo.Size = new System.Drawing.Size(123, 17);
			this.rbSelectCustomerInfo.TabIndex = 1;
			this.rbSelectCustomerInfo.Text = "Select Customer Info";
			this.rbSelectCustomerInfo.UseVisualStyleBackColor = true;
			// 
			// rbSelectInvoiceNumber
			// 
			this.rbSelectInvoiceNumber.AutoSize = true;
			this.rbSelectInvoiceNumber.Checked = true;
			this.rbSelectInvoiceNumber.Enabled = false;
			this.rbSelectInvoiceNumber.Location = new System.Drawing.Point(12, 20);
			this.rbSelectInvoiceNumber.Name = "rbSelectInvoiceNumber";
			this.rbSelectInvoiceNumber.Size = new System.Drawing.Size(133, 17);
			this.rbSelectInvoiceNumber.TabIndex = 0;
			this.rbSelectInvoiceNumber.TabStop = true;
			this.rbSelectInvoiceNumber.Text = "Select Invoice Number";
			this.rbSelectInvoiceNumber.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 733);
			this.Controls.Add(this.pdfViewerControl1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bytescout.PDFViewer.PDFViewerControl pdfViewerControl1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbOpen;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnGetData;
		private System.Windows.Forms.RadioButton rbSelectTotal;
		private System.Windows.Forms.RadioButton rbSelectCustomerInfo;
		private System.Windows.Forms.RadioButton rbSelectInvoiceNumber;
		private System.Windows.Forms.Button btnClear;
	}
}


```

<!-- code block end -->    

<!-- code block begin -->

##### ****Form1.cs:**
    
```
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bytescout.PDFExtractor;

namespace SampleApplication
{
	public partial class Form1 : Form
	{
		List<String> _dataLabels = new List<string>();

		public Form1()
		{
			InitializeComponent();

			pdfViewerControl1.RegistrationName = "demo";
			pdfViewerControl1.RegistrationKey = "demo";
		}

		protected override void OnLoad(EventArgs e)
		{
			OpenDocument(@"Invoice.pdf");

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
					OpenDocument(openFileDialog.FileName);
				}
			}
		}

		private void OpenDocument(string filePath)
		{
			Text = filePath;

			Cursor = Cursors.WaitCursor;

			try
			{
				pdfViewerControl1.InputFile = filePath;
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

		private void pdfViewerControl1_DocumentChanged(object sender, EventArgs e)
		{
			ClearSelections();
			UpdateControls();
		}

		private void pdfViewerControl1_CurrentPageIndexChanged(object sender, EventArgs e)
		{
			ClearSelections();
			UpdateControls();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearSelections();
			UpdateControls();
		}

		void ClearSelections()
		{
			_dataLabels.Clear();
			pdfViewerControl1.ClearSelection();
			UpdateControls();
		}

		void UpdateControls()
		{
			rbSelectInvoiceNumber.Enabled = pdfViewerControl1.IsDocumentLoaded;
			rbSelectCustomerInfo.Enabled = pdfViewerControl1.IsDocumentLoaded;
			rbSelectTotal.Enabled = pdfViewerControl1.IsDocumentLoaded;
			btnGetData.Enabled = pdfViewerControl1.IsDocumentLoaded && pdfViewerControl1.Selection.Length > 0;
			btnClear.Enabled = pdfViewerControl1.IsDocumentLoaded && pdfViewerControl1.Selection.Length > 0;
		}

		private void pdfViewerControl1_SelectionChanged(object sender, EventArgs e)
		{
			UpdateControls();

			if (pdfViewerControl1.Selection.Length > _dataLabels.Count)
			{
				for (int i = _dataLabels.Count; i < pdfViewerControl1.Selection.Length; i++)
				{
					string dataLabel;

					if (rbSelectInvoiceNumber.Checked)
						dataLabel = "Invoice Number:";
					else if (rbSelectCustomerInfo.Checked)
						dataLabel = "Customer Info:";
					else
						dataLabel = "TOTAL:";

					_dataLabels.Add(dataLabel);
				}
			}
		}

		private void pdfViewerControl1_CustomPaint(object sender, PaintEventArgs e)
		{
			Rectangle[] selection = pdfViewerControl1.Selection;

			// Paint labels
			for (int i = 0; i < selection.Length; i++)
			{
				Rectangle r = Rectangle.Round(selection[i]);
				r = pdfViewerControl1.TranslateRectangleToViewport(r);

				Size textSize = TextRenderer.MeasureText(_dataLabels[i], Font);
				Rectangle textRectangle = new Rectangle(r.Left, r.Top - textSize.Height - 6, textSize.Width + 2, textSize.Height + 2);

				e.Graphics.FillRectangle(Brushes.DarkBlue, textRectangle);
				TextRenderer.DrawText(e.Graphics, _dataLabels[i], Font, textRectangle, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
			}

		}

		private void btnGetData_Click(object sender, EventArgs e)
		{
			StringBuilder result = new StringBuilder();
			RectangleF[] selection = pdfViewerControl1.SelectionInPoints;

			using (TextExtractor extractor = new TextExtractor())
			{
				extractor.RegistrationName = "demo";
				extractor.RegistrationKey = "demo";

				extractor.LoadDocumentFromFile(pdfViewerControl1.InputFile);
				extractor.OCRMode = OCRMode.Auto;
				extractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\net4.00\tessdata\";
				extractor.OCRResolution = 300;

				for (int i = 0; i < selection.Length; i++)
				{
					extractor.SetExtractionArea(selection[i]);
					result.AppendLine(_dataLabels[i]);
					result.AppendLine(extractor.GetText(pdfViewerControl1.CurrentPageIndex, pdfViewerControl1.CurrentPageIndex));
					result.AppendLine();
				}		
			}

			MessageBox.Show(result.ToString());
		}
	}
}
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.cs:**
    
```
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SampleApplication
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

##### ****SampleApplication.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="12.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{0DB74CC3-1DD8-4A58-94FC-CA9A60E2F8A2}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>SampleApplication</RootNamespace>
    <AssemblyName>SampleApplication</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <FileUpgradeFlags>
    </FileUpgradeFlags>
    <UpgradeBackupLocation>
    </UpgradeBackupLocation>
    <OldToolsVersion>2.0</OldToolsVersion>
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
    <Reference Include="Bytescout.PDFExtractor, Version=8.6.0.2917, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\..\..\Program Files\Bytescout PDF Extractor SDK\net4.00\Bytescout.PDFExtractor.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.PDFExtractor.OCRExtension, Version=8.6.0.2917, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\..\..\Program Files\Bytescout PDF Extractor SDK\net4.00\Bytescout.PDFExtractor.OCRExtension.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.PDFViewer, Version=8.5.0.2860, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\..\..\Program Files\Bytescout PDF Viewer SDK\net4.00\Bytescout.PDFViewer.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
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
    <Content Include="Invoice.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
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
  <ItemGroup>
    <None Include="Resources\folder_page.png" />
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.CSharp.targets" />
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

##### ****SampleApplication.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 2013
VisualStudioVersion = 12.0.31101.0
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "SampleApplication", "SampleApplication.csproj", "{0DB74CC3-1DD8-4A58-94FC-CA9A60E2F8A2}"
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
EndGlobal

```

<!-- code block end -->