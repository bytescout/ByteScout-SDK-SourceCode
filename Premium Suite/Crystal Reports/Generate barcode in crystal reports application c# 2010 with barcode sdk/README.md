## How to generate barcode in crystal reports application c# 2010 with barcode sdk in Crystal Reports using ByteScout Premium Suite

### If you want to learn more then this tutorial will show how to generate barcode in crystal reports application c# 2010 with barcode sdk in Crystal Reports

Sample source code below will display you how to manage a complex task like generate barcode in crystal reports application c# 2010 with barcode sdk in Crystal Reports. ByteScout Premium Suite: the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can generate barcode in crystal reports application c# 2010 with barcode sdk in Crystal Reports.

 These Crystal Reports code samples for Crystal Reports guide developers to speed up coding of the application when using ByteScout Premium Suite.  Simply copy and paste in your Crystal Reports project or application you and then run your app! Enjoy writing a code with ready-to-use sample Crystal Reports codes.

You can download free trial version of ByteScout Premium Suite from our website with this and other source code samples for Crystal Reports.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Premium%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Premium%20Suite%20Question) 

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

##### ****BarcodeInCrystalReports.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{75AA680D-9434-4C36-AB16-29EB20693F0B}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>BarcodeInCrystalReports</RootNamespace>
    <AssemblyName>BarcodeInCrystalReports</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
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
    <IsWebBootstrapper>false</IsWebBootstrapper>
    <UseApplicationTrust>false</UseApplicationTrust>
    <BootstrapperEnabled>true</BootstrapperEnabled>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Debug|x86'">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\x86\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <CodeAnalysisLogFile>bin\Debug\CrystalReportsApplication1.exe.CodeAnalysisLog.xml</CodeAnalysisLogFile>
    <CodeAnalysisUseTypeNameInSuppression>true</CodeAnalysisUseTypeNameInSuppression>
    <CodeAnalysisModuleSuppressionsFile>GlobalSuppressions.cs</CodeAnalysisModuleSuppressionsFile>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisRuleSetDirectories>;C:\Program Files (x86)\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\\Rule Sets</CodeAnalysisRuleSetDirectories>
    <CodeAnalysisIgnoreBuiltInRuleSets>true</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisRuleDirectories>;C:\Program Files (x86)\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\FxCop\\Rules</CodeAnalysisRuleDirectories>
    <CodeAnalysisIgnoreBuiltInRules>true</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Release|x86'">
    <OutputPath>bin\x86\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <CodeAnalysisLogFile>bin\Release\CrystalReportsApplication1.exe.CodeAnalysisLog.xml</CodeAnalysisLogFile>
    <CodeAnalysisUseTypeNameInSuppression>true</CodeAnalysisUseTypeNameInSuppression>
    <CodeAnalysisModuleSuppressionsFile>GlobalSuppressions.cs</CodeAnalysisModuleSuppressionsFile>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisRuleSetDirectories>;C:\Program Files (x86)\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\\Rule Sets</CodeAnalysisRuleSetDirectories>
    <CodeAnalysisIgnoreBuiltInRuleSets>true</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisRuleDirectories>;C:\Program Files (x86)\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\FxCop\\Rules</CodeAnalysisRuleDirectories>
    <CodeAnalysisIgnoreBuiltInRules>true</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCode, Version=4.20.0.745, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Generator SDK\net4.00\Bytescout.BarCode.dll</HintPath>
    </Reference>
    <Reference Include="CrystalDecisions.CrystalReports.Engine, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304, processorArchitecture=MSIL" />
    <Reference Include="CrystalDecisions.ReportSource, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304, processorArchitecture=MSIL" />
    <Reference Include="CrystalDecisions.Shared, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304, processorArchitecture=MSIL" />
    <Reference Include="CrystalDecisions.Windows.Forms, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304, processorArchitecture=MSIL" />
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="CrystalReport1.cs">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>CrystalReport1.rpt</DependentUpon>
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="Form1.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form1.Designer.cs">
      <DependentUpon>Form1.cs</DependentUpon>
    </Compile>
    <Compile Include="ProductsDataSet1.Designer.cs">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>ProductsDataSet.xsd</DependentUpon>
    </Compile>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
    <EmbeddedResource Include="CrystalReport1.rpt">
      <Generator>CrystalDecisions.VSDesigner.CodeGen.ReportCodeGenerator</Generator>
      <LastGenOutput>CrystalReport1.cs</LastGenOutput>
    </EmbeddedResource>
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
    <None Include="ProductsDataSet.xsc">
      <DependentUpon>ProductsDataSet.xsd</DependentUpon>
    </None>
    <None Include="ProductsDataSet.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>ProductsDataSet1.Designer.cs</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="ProductsDataSet.xss">
      <DependentUpon>ProductsDataSet.xsd</DependentUpon>
    </None>
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
    <Service Include="{C0C07587-41A7-46C8-8FBD-3F9C8EBE2DDC}" />
    <Service Include="{FE73BB80-53F4-4AD0-A5F9-6A0BCE662292}" />
  </ItemGroup>
  <ItemGroup>
    <BootstrapperPackage Include=".NETFramework,Version=v4.0">
      <Visible>False</Visible>
      <ProductName>Microsoft .NET Framework 4 %28x86 and x64%29</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Client.3.5">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1 Client Profile</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Framework.3.5.SP1">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Windows.Installer.3.1">
      <Visible>False</Visible>
      <ProductName>Windows Installer 3.1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
  </ItemGroup>
  <ItemGroup>
    <Content Include="products.mdb">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****CrystalReport1.cs:**
    
```
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BarcodeInCrystalReports {
    using System;
    using System.ComponentModel;
    using CrystalDecisions.Shared;
    using CrystalDecisions.ReportSource;
    using CrystalDecisions.CrystalReports.Engine;
    
    
    public class CrystalReport1 : ReportClass {
        
        public CrystalReport1() {
        }
        
        public override string ResourceName {
            get {
                return "CrystalReport1.rpt";
            }
            set {
                // Do nothing
            }
        }
        
        public override bool NewGenerator {
            get {
                return true;
            }
            set {
                // Do nothing
            }
        }
        
        public override string FullResourceName {
            get {
                return "BarcodeInCrystalReports.CrystalReport1.rpt";
            }
            set {
                // Do nothing
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public CrystalDecisions.CrystalReports.Engine.Section Section1 {
            get {
                return this.ReportDefinition.Sections[0];
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public CrystalDecisions.CrystalReports.Engine.Section Section2 {
            get {
                return this.ReportDefinition.Sections[1];
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public CrystalDecisions.CrystalReports.Engine.Section Section3 {
            get {
                return this.ReportDefinition.Sections[2];
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public CrystalDecisions.CrystalReports.Engine.Section Section4 {
            get {
                return this.ReportDefinition.Sections[3];
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public CrystalDecisions.CrystalReports.Engine.Section Section5 {
            get {
                return this.ReportDefinition.Sections[4];
            }
        }
    }
    
    [System.Drawing.ToolboxBitmapAttribute(typeof(CrystalDecisions.Shared.ExportOptions), "report.bmp")]
    public class CachedCrystalReport1 : Component, ICachedReport {
        
        public CachedCrystalReport1() {
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public virtual bool IsCacheable {
            get {
                return true;
            }
            set {
                // 
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public virtual bool ShareDBLogonInfo {
            get {
                return false;
            }
            set {
                // 
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public virtual System.TimeSpan CacheTimeOut {
            get {
                return CachedReportConstants.DEFAULT_TIMEOUT;
            }
            set {
                // 
            }
        }
        
        public virtual CrystalDecisions.CrystalReports.Engine.ReportDocument CreateReport() {
            CrystalReport1 rpt = new CrystalReport1();
            rpt.Site = this.Site;
            return rpt;
        }
        
        public virtual string GetCustomizedCacheKey(RequestContext request) {
            String key = null;
            // // The following is the code used to generate the default
            // // cache key for caching report jobs in the ASP.NET Cache.
            // // Feel free to modify this code to suit your needs.
            // // Returning key == null causes the default cache key to
            // // be generated.
            // 
            // key = RequestContext.BuildCompleteCacheKey(
            //     request,
            //     null,       // sReportFilename
            //     this.GetType(),
            //     this.ShareDBLogonInfo );
            return key;
        }
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Form1.Designer.cs:**
    
```
namespace BarcodeInCrystalReports
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.CrystalReport11 = new BarcodeInCrystalReports.CrystalReport1();
			this.SuspendLayout();
			// 
			// crystalReportViewer1
			// 
			this.crystalReportViewer1.ActiveViewIndex = 0;
			this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
			this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.ReportSource = this.CrystalReport11;
			this.crystalReportViewer1.Size = new System.Drawing.Size(799, 566);
			this.crystalReportViewer1.TabIndex = 0;
			this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(799, 566);
			this.Controls.Add(this.crystalReportViewer1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
		private CrystalReport1 CrystalReport11;
	}
}


```

<!-- code block end -->    

<!-- code block begin -->

##### ****Form1.cs:**
    
```
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Bytescout.BarCode;

namespace BarcodeInCrystalReports
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void crystalReportViewer1_Load(object sender, EventArgs e)
		{
			try
			{
				OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=products.mdb");
				OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT ID, ProductName, ProductDescription, ProductPrice FROM Products", connection);

				// fill dataset
				DataSet dataSet = new DataSet();
				dataAdapter.Fill(dataSet);

				connection.Close();

				// add virtual column into the result table
				dataSet.Tables[0].Columns.Add(new DataColumn("BarcodeImage", typeof(byte[])));

				// create barcode object
				Barcode barcode = new Barcode(SymbologyType.Code128);
				barcode.DrawCaption = false;

				// Fill BarcodeImage column with generated barcode image bytes
				foreach (DataRow row in dataSet.Tables[0].Rows)
				{
					// set barcode value
					barcode.Value = Convert.ToString(row["ID"]);

					// retrieve generated image bytes
					byte[] barcodeBytes = barcode.GetImageBytesWMF();

					// fill virtual column with generated image bytes
					row["BarcodeImage"] = barcodeBytes;
				}

				// set filled DataSet as report's data source
				CrystalReport11.SetDataSource(dataSet.Tables[0]);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}
	}
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ProductsDataSet.xsc:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<!--<autogenerated>
     This code was generated by a tool.
     Changes to this file may cause incorrect behavior and will be lost if
     the code is regenerated.
</autogenerated>-->
<DataSetUISetting Version="1.00" xmlns="urn:schemas-microsoft-com:xml-msdatasource">
  <TableUISettings />
</DataSetUISetting>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ProductsDataSet.xsd:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<xs:schema id="ProductsDataSet" targetNamespace="http://tempuri.org/ProductsDataSet.xsd" xmlns:mstns="http://tempuri.org/ProductsDataSet.xsd" xmlns="http://tempuri.org/ProductsDataSet.xsd" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:msdata="urn:schemas-microsoft-com:xml-msdata" xmlns:msprop="urn:schemas-microsoft-com:xml-msprop" attributeFormDefault="qualified" elementFormDefault="qualified">
  <xs:annotation>
    <xs:appinfo source="urn:schemas-microsoft-com:xml-msdatasource">
      <DataSource DefaultConnectionIndex="0" FunctionsComponentName="QueriesTableAdapter" Modifier="AutoLayout, AnsiClass, Class, Public" SchemaSerializationMode="IncludeSchema" xmlns="urn:schemas-microsoft-com:xml-msdatasource">
        <Connections>
          <Connection AppSettingsObjectName="Settings" AppSettingsPropertyName="productsConnectionString" ConnectionStringObject="" IsAppSettingsProperty="true" Modifier="Assembly" Name="productsConnectionString (Settings)" PropertyReference="ApplicationSettings.CrystalReportsApplication1.Properties.Settings.GlobalReference.Default.productsConnectionString" Provider="System.Data.OleDb" />
        </Connections>
        <Tables>
          <TableAdapter BaseClass="System.ComponentModel.Component" DataAccessorModifier="AutoLayout, AnsiClass, Class, Public" DataAccessorName="ProductsTableAdapter" GeneratorDataComponentClassName="ProductsTableAdapter" Name="Products" UserDataComponentName="ProductsTableAdapter">
            <MainSource>
              <DbSource ConnectionRef="productsConnectionString (Settings)" DbObjectName="Products" DbObjectType="Table" FillMethodModifier="Public" FillMethodName="Fill" GenerateMethods="Both" GenerateShortCommands="true" GeneratorGetMethodName="GetData" GeneratorSourceName="Fill" GetMethodModifier="Public" GetMethodName="GetData" QueryType="Rowset" ScalarCallRetval="System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" UseOptimisticConcurrency="true" UserGetMethodName="GetData" UserSourceName="Fill">
                <DeleteCommand>
                  <DbCommand CommandType="Text" ModifiedByUser="false">
                    <CommandText>DELETE FROM `Products` WHERE ((`ID` = ?) AND ((? = 1 AND `ProductName` IS NULL) OR (`ProductName` = ?)) AND ((? = 1 AND `ProductDescription` IS NULL) OR (`ProductDescription` = ?)) AND ((? = 1 AND `ProductPrice` IS NULL) OR (`ProductPrice` = ?)))</CommandText>
                    <Parameters>
                      <Parameter AllowDbNull="false" AutogeneratedName="" DataSourceName="" DbType="Int32" Direction="Input" ParameterName="Original_ID" Precision="0" ProviderType="Integer" Scale="0" Size="0" SourceColumn="ID" SourceColumnNullMapping="false" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="Int32" Direction="Input" ParameterName="IsNull_ProductName" Precision="0" ProviderType="Integer" Scale="0" Size="0" SourceColumn="ProductName" SourceColumnNullMapping="true" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="Original_ProductName" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductName" SourceColumnNullMapping="false" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="Int32" Direction="Input" ParameterName="IsNull_ProductDescription" Precision="0" ProviderType="Integer" Scale="0" Size="0" SourceColumn="ProductDescription" SourceColumnNullMapping="true" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="Original_ProductDescription" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductDescription" SourceColumnNullMapping="false" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="Int32" Direction="Input" ParameterName="IsNull_ProductPrice" Precision="0" ProviderType="Integer" Scale="0" Size="0" SourceColumn="ProductPrice" SourceColumnNullMapping="true" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="Original_ProductPrice" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductPrice" SourceColumnNullMapping="false" SourceVersion="Original" />
                    </Parameters>
                  </DbCommand>
                </DeleteCommand>
                <InsertCommand>
                  <DbCommand CommandType="Text" ModifiedByUser="false">
                    <CommandText>INSERT INTO `Products` (`ProductName`, `ProductDescription`, `ProductPrice`) VALUES (?, ?, ?)</CommandText>
                    <Parameters>
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="ProductName" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductName" SourceColumnNullMapping="false" SourceVersion="Current" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="ProductDescription" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductDescription" SourceColumnNullMapping="false" SourceVersion="Current" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="ProductPrice" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductPrice" SourceColumnNullMapping="false" SourceVersion="Current" />
                    </Parameters>
                  </DbCommand>
                </InsertCommand>
                <SelectCommand>
                  <DbCommand CommandType="Text" ModifiedByUser="false">
                    <CommandText>SELECT ID, ProductName, ProductDescription, ProductPrice FROM Products</CommandText>
                    <Parameters />
                  </DbCommand>
                </SelectCommand>
                <UpdateCommand>
                  <DbCommand CommandType="Text" ModifiedByUser="false">
                    <CommandText>UPDATE `Products` SET `ProductName` = ?, `ProductDescription` = ?, `ProductPrice` = ? WHERE ((`ID` = ?) AND ((? = 1 AND `ProductName` IS NULL) OR (`ProductName` = ?)) AND ((? = 1 AND `ProductDescription` IS NULL) OR (`ProductDescription` = ?)) AND ((? = 1 AND `ProductPrice` IS NULL) OR (`ProductPrice` = ?)))</CommandText>
                    <Parameters>
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="ProductName" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductName" SourceColumnNullMapping="false" SourceVersion="Current" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="ProductDescription" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductDescription" SourceColumnNullMapping="false" SourceVersion="Current" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="ProductPrice" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductPrice" SourceColumnNullMapping="false" SourceVersion="Current" />
                      <Parameter AllowDbNull="false" AutogeneratedName="" DataSourceName="" DbType="Int32" Direction="Input" ParameterName="Original_ID" Precision="0" ProviderType="Integer" Scale="0" Size="0" SourceColumn="ID" SourceColumnNullMapping="false" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="Int32" Direction="Input" ParameterName="IsNull_ProductName" Precision="0" ProviderType="Integer" Scale="0" Size="0" SourceColumn="ProductName" SourceColumnNullMapping="true" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="Original_ProductName" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductName" SourceColumnNullMapping="false" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="Int32" Direction="Input" ParameterName="IsNull_ProductDescription" Precision="0" ProviderType="Integer" Scale="0" Size="0" SourceColumn="ProductDescription" SourceColumnNullMapping="true" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="Original_ProductDescription" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductDescription" SourceColumnNullMapping="false" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="Int32" Direction="Input" ParameterName="IsNull_ProductPrice" Precision="0" ProviderType="Integer" Scale="0" Size="0" SourceColumn="ProductPrice" SourceColumnNullMapping="true" SourceVersion="Original" />
                      <Parameter AllowDbNull="true" AutogeneratedName="" DataSourceName="" DbType="String" Direction="Input" ParameterName="Original_ProductPrice" Precision="0" ProviderType="VarWChar" Scale="0" Size="0" SourceColumn="ProductPrice" SourceColumnNullMapping="false" SourceVersion="Original" />
                    </Parameters>
                  </DbCommand>
                </UpdateCommand>
              </DbSource>
            </MainSource>
            <Mappings>
              <Mapping SourceColumn="ID" DataSetColumn="ID" />
              <Mapping SourceColumn="ProductName" DataSetColumn="ProductName" />
              <Mapping SourceColumn="ProductDescription" DataSetColumn="ProductDescription" />
              <Mapping SourceColumn="ProductPrice" DataSetColumn="ProductPrice" />
            </Mappings>
            <Sources />
          </TableAdapter>
        </Tables>
        <Sources />
      </DataSource>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name="ProductsDataSet" msdata:IsDataSet="true" msdata:UseCurrentLocale="true" msprop:EnableTableAdapterManager="True" msprop:Generator_DataSetName="ProductsDataSet" msprop:Generator_UserDSName="ProductsDataSet">
    <xs:complexType>
      <xs:choice minOccurs="0" maxOccurs="unbounded">
        <xs:element name="Products" msprop:Generator_TableClassName="ProductsDataTable" msprop:Generator_TableVarName="tableProducts" msprop:Generator_RowChangedName="ProductsRowChanged" msprop:Generator_TablePropName="Products" msprop:Generator_RowDeletingName="ProductsRowDeleting" msprop:Generator_RowChangingName="ProductsRowChanging" msprop:Generator_RowEvHandlerName="ProductsRowChangeEventHandler" msprop:Generator_RowDeletedName="ProductsRowDeleted" msprop:Generator_RowClassName="ProductsRow" msprop:Generator_UserTableName="Products" msprop:Generator_RowEvArgName="ProductsRowChangeEvent">
          <xs:complexType>
            <xs:sequence>
              <xs:element name="ID" msdata:AutoIncrement="true" msdata:AutoIncrementSeed="-1" msdata:AutoIncrementStep="-1" msprop:Generator_ColumnVarNameInTable="columnID" msprop:Generator_ColumnPropNameInRow="ID" msprop:Generator_ColumnPropNameInTable="IDColumn" msprop:Generator_UserColumnName="ID" type="xs:int" />
              <xs:element name="ProductName" msprop:Generator_ColumnVarNameInTable="columnProductName" msprop:Generator_ColumnPropNameInRow="ProductName" msprop:Generator_ColumnPropNameInTable="ProductNameColumn" msprop:Generator_UserColumnName="ProductName" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="255" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="ProductDescription" msprop:Generator_ColumnVarNameInTable="columnProductDescription" msprop:Generator_ColumnPropNameInRow="ProductDescription" msprop:Generator_ColumnPropNameInTable="ProductDescriptionColumn" msprop:Generator_UserColumnName="ProductDescription" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="255" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="ProductPrice" msprop:Generator_ColumnVarNameInTable="columnProductPrice" msprop:Generator_ColumnPropNameInRow="ProductPrice" msprop:Generator_ColumnPropNameInTable="ProductPriceColumn" msprop:Generator_UserColumnName="ProductPrice" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="255" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="BarcodeImage" msprop:Generator_ColumnVarNameInTable="columnBarcodeImage" msprop:Generator_ColumnPropNameInRow="BarcodeImage" msprop:Generator_ColumnPropNameInTable="BarcodeImageColumn" msprop:Generator_UserColumnName="BarcodeImage" type="xs:base64Binary" minOccurs="0" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:choice>
    </xs:complexType>
    <xs:unique name="Constraint1" msdata:PrimaryKey="true">
      <xs:selector xpath=".//mstns:Products" />
      <xs:field xpath="mstns:ID" />
    </xs:unique>
  </xs:element>
</xs:schema>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ProductsDataSet.xss:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<!--<autogenerated>
     This code was generated by a tool to store the dataset designer's layout information.
     Changes to this file may cause incorrect behavior and will be lost if
     the code is regenerated.
</autogenerated>-->
<DiagramLayout xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" ex:showrelationlabel="False" ViewPortX="-10" ViewPortY="-10" xmlns:ex="urn:schemas-microsoft-com:xml-msdatasource-layout-extended" xmlns="urn:schemas-microsoft-com:xml-msdatasource-layout">
  <Shapes>
    <Shape ID="DesignTable:Products" ZOrder="1" X="70" Y="70" Height="172" Width="196" AdapterExpanded="true" DataTableExpanded="true" OldAdapterHeight="0" OldDataTableHeight="0" SplitterPosition="121" />
  </Shapes>
  <Connectors />
</DiagramLayout>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ProductsDataSet1.Designer.cs:**
    
```
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 1591

namespace BarcodeInCrystalReports {
    
    
    /// <summary>
    ///Represents a strongly typed in-memory cache of data.
    ///</summary>
    [global::System.Serializable()]
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [global::System.Xml.Serialization.XmlRootAttribute("ProductsDataSet")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class ProductsDataSet : global::System.Data.DataSet {
        
        private ProductsDataTable tableProducts;
        
        private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public ProductsDataSet() {
            this.BeginInit();
            this.InitClass();
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected ProductsDataSet(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context, false) {
            if ((this.IsBinarySerialized(info, context) == true)) {
                this.InitVars(false);
                global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                if ((ds.Tables["Products"] != null)) {
                    base.Tables.Add(new ProductsDataTable(ds.Tables["Products"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public ProductsDataTable Products {
            get {
                return this.tableProducts;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.BrowsableAttribute(true)]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override global::System.Data.SchemaSerializationMode SchemaSerializationMode {
            get {
                return this._schemaSerializationMode;
            }
            set {
                this._schemaSerializationMode = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataTableCollection Tables {
            get {
                return base.Tables;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataRelationCollection Relations {
            get {
                return base.Relations;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void InitializeDerivedDataSet() {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override global::System.Data.DataSet Clone() {
            ProductsDataSet cln = ((ProductsDataSet)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader) {
            if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                this.Reset();
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXml(reader);
                if ((ds.Tables["Products"] != null)) {
                    base.Tables.Add(new ProductsDataTable(ds.Tables["Products"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXml(reader);
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars() {
            this.InitVars(true);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars(bool initTable) {
            this.tableProducts = ((ProductsDataTable)(base.Tables["Products"]));
            if ((initTable == true)) {
                if ((this.tableProducts != null)) {
                    this.tableProducts.InitVars();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitClass() {
            this.DataSetName = "ProductsDataSet";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/ProductsDataSet.xsd";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
            this.tableProducts = new ProductsDataTable();
            base.Tables.Add(this.tableProducts);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeProducts() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void SchemaChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == global::System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
            ProductsDataSet ds = new ProductsDataSet();
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace)) {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length)) {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length) 
                                        && (s1.ReadByte() == s2.ReadByte())); ) {
                                ;
                            }
                            if ((s1.Position == s1.Length)) {
                                return type;
                            }
                        }
                    }
                }
                finally {
                    if ((s1 != null)) {
                        s1.Close();
                    }
                    if ((s2 != null)) {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void ProductsRowChangeEventHandler(object sender, ProductsRowChangeEvent e);
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class ProductsDataTable : global::System.Data.DataTable, global::System.Collections.IEnumerable {
            
            private global::System.Data.DataColumn columnID;
            
            private global::System.Data.DataColumn columnProductName;
            
            private global::System.Data.DataColumn columnProductDescription;
            
            private global::System.Data.DataColumn columnProductPrice;
            
            private global::System.Data.DataColumn columnBarcodeImage;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ProductsDataTable() {
                this.TableName = "Products";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal ProductsDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected ProductsDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ProductNameColumn {
                get {
                    return this.columnProductName;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ProductDescriptionColumn {
                get {
                    return this.columnProductDescription;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ProductPriceColumn {
                get {
                    return this.columnProductPrice;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn BarcodeImageColumn {
                get {
                    return this.columnBarcodeImage;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ProductsRow this[int index] {
                get {
                    return ((ProductsRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event ProductsRowChangeEventHandler ProductsRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event ProductsRowChangeEventHandler ProductsRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event ProductsRowChangeEventHandler ProductsRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event ProductsRowChangeEventHandler ProductsRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddProductsRow(ProductsRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ProductsRow AddProductsRow(string ProductName, string ProductDescription, string ProductPrice, byte[] BarcodeImage) {
                ProductsRow rowProductsRow = ((ProductsRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        ProductName,
                        ProductDescription,
                        ProductPrice,
                        BarcodeImage};
                rowProductsRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowProductsRow);
                return rowProductsRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ProductsRow FindByID(int ID) {
                return ((ProductsRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public virtual global::System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                ProductsDataTable cln = ((ProductsDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new ProductsDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnID = base.Columns["ID"];
                this.columnProductName = base.Columns["ProductName"];
                this.columnProductDescription = base.Columns["ProductDescription"];
                this.columnProductPrice = base.Columns["ProductPrice"];
                this.columnBarcodeImage = base.Columns["BarcodeImage"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnID = new global::System.Data.DataColumn("ID", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnID);
                this.columnProductName = new global::System.Data.DataColumn("ProductName", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnProductName);
                this.columnProductDescription = new global::System.Data.DataColumn("ProductDescription", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnProductDescription);
                this.columnProductPrice = new global::System.Data.DataColumn("ProductPrice", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnProductPrice);
                this.columnBarcodeImage = new global::System.Data.DataColumn("BarcodeImage", typeof(byte[]), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnBarcodeImage);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrement = true;
                this.columnID.AutoIncrementSeed = -1;
                this.columnID.AutoIncrementStep = -1;
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
                this.columnProductName.MaxLength = 255;
                this.columnProductDescription.MaxLength = 255;
                this.columnProductPrice.MaxLength = 255;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ProductsRow NewProductsRow() {
                return ((ProductsRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new ProductsRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(ProductsRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.ProductsRowChanged != null)) {
                    this.ProductsRowChanged(this, new ProductsRowChangeEvent(((ProductsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.ProductsRowChanging != null)) {
                    this.ProductsRowChanging(this, new ProductsRowChangeEvent(((ProductsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.ProductsRowDeleted != null)) {
                    this.ProductsRowDeleted(this, new ProductsRowChangeEvent(((ProductsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.ProductsRowDeleting != null)) {
                    this.ProductsRowDeleting(this, new ProductsRowChangeEvent(((ProductsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveProductsRow(ProductsRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                ProductsDataSet ds = new ProductsDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "ProductsDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class ProductsRow : global::System.Data.DataRow {
            
            private ProductsDataTable tableProducts;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal ProductsRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableProducts = ((ProductsDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ID {
                get {
                    return ((int)(this[this.tableProducts.IDColumn]));
                }
                set {
                    this[this.tableProducts.IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string ProductName {
                get {
                    try {
                        return ((string)(this[this.tableProducts.ProductNameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'ProductName\' in table \'Products\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableProducts.ProductNameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string ProductDescription {
                get {
                    try {
                        return ((string)(this[this.tableProducts.ProductDescriptionColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'ProductDescription\' in table \'Products\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableProducts.ProductDescriptionColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string ProductPrice {
                get {
                    try {
                        return ((string)(this[this.tableProducts.ProductPriceColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'ProductPrice\' in table \'Products\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableProducts.ProductPriceColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public byte[] BarcodeImage {
                get {
                    try {
                        return ((byte[])(this[this.tableProducts.BarcodeImageColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'BarcodeImage\' in table \'Products\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableProducts.BarcodeImageColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsProductNameNull() {
                return this.IsNull(this.tableProducts.ProductNameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetProductNameNull() {
                this[this.tableProducts.ProductNameColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsProductDescriptionNull() {
                return this.IsNull(this.tableProducts.ProductDescriptionColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetProductDescriptionNull() {
                this[this.tableProducts.ProductDescriptionColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsProductPriceNull() {
                return this.IsNull(this.tableProducts.ProductPriceColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetProductPriceNull() {
                this[this.tableProducts.ProductPriceColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsBarcodeImageNull() {
                return this.IsNull(this.tableProducts.BarcodeImageColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetBarcodeImageNull() {
                this[this.tableProducts.BarcodeImageColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class ProductsRowChangeEvent : global::System.EventArgs {
            
            private ProductsRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ProductsRowChangeEvent(ProductsRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ProductsRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
namespace BarcodeInCrystalReports.ProductsDataSetTableAdapters {
    
    
    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class ProductsTableAdapter : global::System.ComponentModel.Component {
        
        private global::System.Data.OleDb.OleDbDataAdapter _adapter;
        
        private global::System.Data.OleDb.OleDbConnection _connection;
        
        private global::System.Data.OleDb.OleDbCommand[] _commandCollection;
        
        private bool _clearBeforeFill;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public ProductsTableAdapter() {
            this.ClearBeforeFill = true;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private global::System.Data.OleDb.OleDbDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.OleDb.OleDbConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.OleDb.OleDbCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected global::System.Data.OleDb.OleDbCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.OleDb.OleDbDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Products";
            tableMapping.ColumnMappings.Add("ID", "ID");
            tableMapping.ColumnMappings.Add("ProductName", "ProductName");
            tableMapping.ColumnMappings.Add("ProductDescription", "ProductDescription");
            tableMapping.ColumnMappings.Add("ProductPrice", "ProductPrice");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = "DELETE FROM `Products` WHERE ((`ID` = ?) AND ((? = 1 AND `ProductName` IS NULL) O" +
                "R (`ProductName` = ?)) AND ((? = 1 AND `ProductDescription` IS NULL) OR (`Produc" +
                "tDescription` = ?)) AND ((? = 1 AND `ProductPrice` IS NULL) OR (`ProductPrice` =" +
                " ?)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_ID", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ID", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_ProductName", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProductName", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_ProductName", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProductName", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_ProductDescription", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProductDescription", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_ProductDescription", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProductDescription", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_ProductPrice", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProductPrice", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_ProductPrice", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProductPrice", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.InsertCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO `Products` (`ProductName`, `ProductDescription`, `ProductPrice`) VALU" +
                "ES (?, ?, ?)";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("ProductName", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProductName", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("ProductDescription", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProductDescription", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("ProductPrice", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProductPrice", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE `Products` SET `ProductName` = ?, `ProductDescription` = ?, `ProductPrice` = ? WHERE ((`ID` = ?) AND ((? = 1 AND `ProductName` IS NULL) OR (`ProductName` = ?)) AND ((? = 1 AND `ProductDescription` IS NULL) OR (`ProductDescription` = ?)) AND ((? = 1 AND `ProductPrice` IS NULL) OR (`ProductPrice` = ?)))";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("ProductName", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProductName", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("ProductDescription", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProductDescription", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("ProductPrice", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProductPrice", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_ID", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ID", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_ProductName", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProductName", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_ProductName", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProductName", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_ProductDescription", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProductDescription", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_ProductDescription", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProductDescription", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_ProductPrice", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProductPrice", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_ProductPrice", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProductPrice", global::System.Data.DataRowVersion.Original, false, null));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.OleDb.OleDbConnection();
            this._connection.ConnectionString = global::BarcodeInCrystalReports.Properties.Settings.Default.productsConnectionString;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.OleDb.OleDbCommand[1];
            this._commandCollection[0] = new global::System.Data.OleDb.OleDbCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT ID, ProductName, ProductDescription, ProductPrice FROM Products";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(ProductsDataSet.ProductsDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual ProductsDataSet.ProductsDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            ProductsDataSet.ProductsDataTable dataTable = new ProductsDataSet.ProductsDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(ProductsDataSet.ProductsDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(ProductsDataSet dataSet) {
            return this.Adapter.Update(dataSet, "Products");
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_ID, string Original_ProductName, string Original_ProductDescription, string Original_ProductPrice) {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_ID));
            if ((Original_ProductName == null)) {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[2].Value = ((string)(Original_ProductName));
            }
            if ((Original_ProductDescription == null)) {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[4].Value = ((string)(Original_ProductDescription));
            }
            if ((Original_ProductPrice == null)) {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[6].Value = ((string)(Original_ProductPrice));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string ProductName, string ProductDescription, string ProductPrice) {
            if ((ProductName == null)) {
                this.Adapter.InsertCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(ProductName));
            }
            if ((ProductDescription == null)) {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[1].Value = ((string)(ProductDescription));
            }
            if ((ProductPrice == null)) {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[2].Value = ((string)(ProductPrice));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string ProductName, string ProductDescription, string ProductPrice, int Original_ID, string Original_ProductName, string Original_ProductDescription, string Original_ProductPrice) {
            if ((ProductName == null)) {
                this.Adapter.UpdateCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(ProductName));
            }
            if ((ProductDescription == null)) {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((string)(ProductDescription));
            }
            if ((ProductPrice == null)) {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((string)(ProductPrice));
            }
            this.Adapter.UpdateCommand.Parameters[3].Value = ((int)(Original_ID));
            if ((Original_ProductName == null)) {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[5].Value = ((string)(Original_ProductName));
            }
            if ((Original_ProductDescription == null)) {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[7].Value = ((string)(Original_ProductDescription));
            }
            if ((Original_ProductPrice == null)) {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[9].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[9].Value = ((string)(Original_ProductPrice));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
    }
}

#pragma warning restore 1591

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.cs:**
    
```
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BarcodeInCrystalReports
{
	static class Program
	{
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

##### ****app.config:**
    
```
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <configSections>
    </configSections>
    <connectionStrings>
        <add name="CrystalReportsApplication1.Properties.Settings.productsConnectionString"
            connectionString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\products.mdb;Persist Security Info=True"
            providerName="System.Data.OleDb" />
    </connectionStrings>
    <startup useLegacyV2RuntimeActivationPolicy="true">
      <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.0"/>
    </startup>
</configuration>
```

<!-- code block end -->