## How to view spreadsheet with spreadsheet sdk in C# with ByteScout Barcode Suite

### Learn to code in C# to view spreadsheet with spreadsheet sdk with this step-by-step tutorial

An easy to understand guide on how to view spreadsheet with spreadsheet sdk in C# with this source code sample. Want to view spreadsheet with spreadsheet sdk in your C# app? ByteScout Barcode Suite is designed for it. ByteScout Barcode Suite is the bundle that privides 3  SDK products to generate barcodes (Barcode SDK), read barcodes (Barcode Reaer SDK) and read and write spreadsheets (Spreadsheet SDK).

Want to quickly learn? This fast application programming interfaces of ByteScout Barcode Suite for C# plus the guidelines and the code below will help you quickly learn how to view spreadsheet with spreadsheet sdk. This C# sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Complete and detailed tutorials and documentation are available along with installed ByteScout Barcode Suite if you'd like to learn more about the topic and the details of the API.

ByteScout Barcode Suite free trial version is available on our website. C# and other programming languages are supported.

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

##### ****Form1.Designer.cs:**
    
```
namespace ViewSpreadsheet
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
			this.lblStub = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiPrint = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiVisitWebsite = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.tsbOpen = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbPromo = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbVisitWebsite = new System.Windows.Forms.ToolStripButton();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblStub
			// 
			this.lblStub.BackColor = System.Drawing.SystemColors.Window;
			this.lblStub.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblStub.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Italic);
			this.lblStub.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.lblStub.Location = new System.Drawing.Point(0, 49);
			this.lblStub.Name = "lblStub";
			this.lblStub.Size = new System.Drawing.Size(837, 508);
			this.lblStub.TabIndex = 5;
			this.lblStub.Text = "Click here to open spreadsheet files: \r\n\r\nExcel 2003/2007 (*.xls, *.xlsx) \r\nOpen " +
				"Office Calc (*.ods)\r\nCSV Comma Separated Values (*.csv)\r\nTXT tab-delimited value" +
				"s (*.txt)";
			this.lblStub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblStub.Click += new System.EventHandler(this.tsmiOpen_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(837, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// filesToolStripMenuItem
			// 
			this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiPrint,
            this.tsmiPrintPreview,
            this.tsmiExit});
			this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
			this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
			this.filesToolStripMenuItem.Text = "Files";
			// 
			// tsmiOpen
			// 
			this.tsmiOpen.Name = "tsmiOpen";
			this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.tsmiOpen.Size = new System.Drawing.Size(166, 22);
			this.tsmiOpen.Text = "Open";
			this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
			// 
			// tsmiPrint
			// 
			this.tsmiPrint.Enabled = false;
			this.tsmiPrint.Name = "tsmiPrint";
			this.tsmiPrint.Size = new System.Drawing.Size(166, 22);
			this.tsmiPrint.Text = "Print...";
			this.tsmiPrint.Visible = false;
			// 
			// tsmiPrintPreview
			// 
			this.tsmiPrintPreview.Enabled = false;
			this.tsmiPrintPreview.Name = "tsmiPrintPreview";
			this.tsmiPrintPreview.Size = new System.Drawing.Size(166, 22);
			this.tsmiPrintPreview.Text = "Print Preview...";
			this.tsmiPrintPreview.Visible = false;
			// 
			// tsmiExit
			// 
			this.tsmiExit.Name = "tsmiExit";
			this.tsmiExit.Size = new System.Drawing.Size(166, 22);
			this.tsmiExit.Text = "Exit";
			this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVisitWebsite,
            this.tsmiAbout});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// tsmiVisitWebsite
			// 
			this.tsmiVisitWebsite.Name = "tsmiVisitWebsite";
			this.tsmiVisitWebsite.Size = new System.Drawing.Size(152, 22);
			this.tsmiVisitWebsite.Text = "Visit Website";
			this.tsmiVisitWebsite.Click += new System.EventHandler(this.tsmiVisitWebsite_Click);
			// 
			// tsmiAbout
			// 
			this.tsmiAbout.Name = "tsmiAbout";
			this.tsmiAbout.Size = new System.Drawing.Size(152, 22);
			this.tsmiAbout.Text = "About";
			this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
			// 
			// toolStrip
			// 
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.toolStripSeparator1,
            this.tsbPromo,
            this.toolStripSeparator2,
            this.tsbVisitWebsite});
			this.toolStrip.Location = new System.Drawing.Point(0, 24);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(837, 25);
			this.toolStrip.TabIndex = 7;
			this.toolStrip.Text = "toolStrip1";
			// 
			// tsbOpen
			// 
			this.tsbOpen.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Black;
			this.tsbOpen.Name = "tsbOpen";
			this.tsbOpen.Size = new System.Drawing.Size(71, 22);
			this.tsbOpen.Text = "Open File...";
			this.tsbOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbPromo
			// 
			this.tsbPromo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsbPromo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.tsbPromo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPromo.Name = "tsbPromo";
			this.tsbPromo.Size = new System.Drawing.Size(320, 22);
			this.tsbPromo.Text = "Developers: Check Bytescout Spreadsheet SDK for .NET";
			this.tsbPromo.Click += new System.EventHandler(this.tsbPromo_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbVisitWebsite
			// 
			this.tsbVisitWebsite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsbVisitWebsite.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.tsbVisitWebsite.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbVisitWebsite.Name = "tsbVisitWebsite";
			this.tsbVisitWebsite.Size = new System.Drawing.Size(84, 22);
			this.tsbVisitWebsite.Text = "Visit Website";
			this.tsbVisitWebsite.Click += new System.EventHandler(this.tsmiVisitWebsite_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = resources.GetString("openFileDialog.Filter");
			this.openFileDialog.SupportMultiDottedExtensions = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 557);
			this.Controls.Add(this.lblStub);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.menuStrip1);
			this.Name = "Form1";
			this.Text = "Spreadsheet Viewer";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblStub;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
		private System.Windows.Forms.ToolStripMenuItem tsmiPrint;
		private System.Windows.Forms.ToolStripMenuItem tsmiPrintPreview;
		private System.Windows.Forms.ToolStripMenuItem tsmiExit;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiVisitWebsite;
		private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton tsbOpen;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsbPromo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tsbVisitWebsite;
		private System.Windows.Forms.OpenFileDialog openFileDialog;

	}
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Form1.cs:**
    
```
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Bytescout.Spreadsheet;

namespace ViewSpreadsheet
{
	public partial class Form1 : Form
	{
		private SpreadsheetControl _spreadsheetControl = null;

		private string _fileName = null;

		public Form1(string[] args)
		{
			if (args.Length > 0 && File.Exists(args[0]))
			{
				_fileName = args[0];
			}

			if (_fileName != null)
			{
				OpenFile(_fileName);
			}

			InitializeComponent();

			Icon = Properties.Resources.xlsview;
		}

		private void OpenFile(string fileName)
		{
			Text = "Spreadsheet Viewer - " + fileName;
			
			Spreadsheet xls = new Spreadsheet();
			xls.RegistrationName = "demo";
			xls.RegistrationKey = "demo";

			try
			{
				xls.LoadFromFile(fileName);
			}
			catch (SpreadsheetProtectionPasswordRequired)
			{
				PasswordDialog passwordDialog = new PasswordDialog();

				if (passwordDialog.ShowDialog(this) == DialogResult.OK)
				{
					xls.LoadFromFile(fileName, CacheType.Memory, ",", Encoding.Default, passwordDialog.Password);
				}
				else
				{
					return;
				}
			}

			lblStub.Visible = false;

			if (_spreadsheetControl == null)
			{
				_spreadsheetControl = new SpreadsheetControl();
				_spreadsheetControl.Dock = DockStyle.Fill;

				Controls.Add(_spreadsheetControl);
				
				_spreadsheetControl.BringToFront();
				_spreadsheetControl.Focus();
			}

			Cursor = Cursors.WaitCursor;

			try
			{
				_spreadsheetControl.Spreadsheet = xls;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.ToString());
			}
			finally
			{
				Cursor = Cursors.Default;
			}
		}

		private void tsmiOpen_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				OpenFile(openFileDialog.FileName);
			}
		}

		private void tsmiAbout_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Spreadsheet Viewer\n\nwww.bytescout.com\n\nCopyright (c) Bytescout Software 2012", "About...");
		}

		private void tsmiExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void tsmiVisitWebsite_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@"http://www.bytescout.com");
		}

		private void tsbPromo_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@"http://bytescout.com/products/developer/spreadsheetsdk/bytescoutspreadsheetsdk.html");
		}
	}
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****PasswordDialog.Designer.cs:**
    
```
namespace ViewSpreadsheet
{
    partial class PasswordDialog
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
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxHide = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(79, 39);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(168, 22);
            this.textBoxPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // checkBoxHide
            // 
            this.checkBoxHide.AutoSize = true;
            this.checkBoxHide.Location = new System.Drawing.Point(7, 12);
            this.checkBoxHide.Name = "checkBoxHide";
            this.checkBoxHide.Size = new System.Drawing.Size(123, 21);
            this.checkBoxHide.TabIndex = 3;
            this.checkBoxHide.Text = "Hide password";
            this.checkBoxHide.UseVisualStyleBackColor = true;
            this.checkBoxHide.CheckedChanged += new System.EventHandler(this.checkBoxHide_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(91, 67);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(172, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PasswordDialog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(255, 98);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.checkBoxHide);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Please enter a password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxHide;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****PasswordDialog.cs:**
    
```
using System;
using System.Windows.Forms;

namespace ViewSpreadsheet
{
    public partial class PasswordDialog : Form
    {
        public PasswordDialog()
        {
            InitializeComponent();
        }

        public string Password
        {
            get { return textBoxPassword.Text; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.OK;
            //Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHide.Checked)
                textBoxPassword.PasswordChar = '*';
            else
                textBoxPassword.PasswordChar = '\0';
        }
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.cs:**
    
```
using System;
using System.Windows.Forms;

namespace ViewSpreadsheet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form1(args));
        }
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ViewSpreadsheet.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{B7DB6749-7213-410E-990C-21C855CDFC94}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ViewSpreadsheet</RootNamespace>
    <AssemblyName>ViewSpreadsheet</AssemblyName>
    <ApplicationIcon>xlsview.ico</ApplicationIcon>
    <StartupObject>ViewSpreadsheet.Program</StartupObject>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>TRACE;DEBUG;XLSViewer</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>3</WarningLevel>
    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE;DEMO</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.Spreadsheet, Version=2.3.0.1137, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL" />
    <Reference Include="Bytescout.SpreadsheetControl, Version=2.3.0.1137, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL" />
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
    <Compile Include="PasswordDialog.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="PasswordDialog.Designer.cs">
      <DependentUpon>PasswordDialog.cs</DependentUpon>
    </Compile>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="PasswordDialog.resx">
      <SubType>Designer</SubType>
      <DependentUpon>PasswordDialog.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <SubType>Designer</SubType>
      <Generator>ResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.cs</LastGenOutput>
    </EmbeddedResource>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.cs</LastGenOutput>
    </None>
    <Compile Include="Properties\Resources.Designer.cs">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>Resources.resx</DependentUpon>
    </Compile>
    <Compile Include="Properties\Settings.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <None Include="xlsview.ico" />
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