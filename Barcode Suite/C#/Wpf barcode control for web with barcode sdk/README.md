## wpf barcode control for web with barcode sdk in C# and ByteScout Barcode Suite

### wpf barcode control for web with barcode sdk in C#

Here you may get thousands pre-made source code samples for simple implementation in your own programming C# projects. Wpf barcode control for web with barcode sdk in C# can be applied with ByteScout Barcode Suite. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK.

Save time on writing and testing code by using the code below and use it in your application.  Just copy and paste this C# sample code to your C# application's code editor, add a reference to ByteScout Barcode Suite (if you haven't added yet) and you are ready to go! Updated and detailed documentation and tutorials are available along with installed ByteScout Barcode Suite if you'd like to learn more about the topic and the details of the API.

Visit our website to get a free trial version of ByteScout Barcode Suite. Free trial contains many of source code samples to help you with your C# project.

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

##### ****App.xaml.cs:**
    
```
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Navigation;

namespace Bytescout.BarCode.WebDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Bytescout.BarCode.WebDemo_VS2010_35.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{DB2A5C21-E0BD-41B9-BA44-BA5642A6A387}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>Bytescout.BarCode.WebDemo</RootNamespace>
    <AssemblyName>Bytescout.BarCode.WebDemo</AssemblyName>
    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
    <TargetFrameworkProfile>Client</TargetFrameworkProfile>
    <FileAlignment>512</FileAlignment>
    <ProjectTypeGuids>{60dc8134-eba5-43b8-bcc9-bb4bc16c2548};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
    <WarningLevel>4</WarningLevel>
    <EnableSecurityDebugging>true</EnableSecurityDebugging>
    <Install>False</Install>
    <StartAction>URL</StartAction>
    <HostInBrowser>true</HostInBrowser>
    <BootstrapperEnabled>false</BootstrapperEnabled>
    <TargetZone>Internet</TargetZone>
    <GenerateManifests>true</GenerateManifests>
    <SignManifests>True</SignManifests>
    <StartupObject>Bytescout.BarCode.WebDemo.App</StartupObject>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug_DEMO|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>..\..\Output\Debug_DEMO_3.5_CP\</OutputPath>
    <DefineConstants>TRACE;DEBUG;DEMO</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release_DEMO|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>..\..\Output\Release_DEMO_3.5_CP\</OutputPath>
    <DefineConstants>TRACE;DEMO</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCode">
      <HintPath>C:\Program Files\Bytescout BarCode SDK\net3.50 ClientProfile\Bytescout.BarCode.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.BarCode.WPF">
      <HintPath>C:\Program Files\Bytescout BarCode SDK\net3.50 ClientProfile\Bytescout.BarCode.WPF.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Core">
      <RequiredTargetFramework>3.5</RequiredTargetFramework>
    </Reference>
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="UIAutomationProvider">
      <RequiredTargetFramework>3.0</RequiredTargetFramework>
    </Reference>
    <Reference Include="WindowsBase">
      <RequiredTargetFramework>3.0</RequiredTargetFramework>
    </Reference>
    <Reference Include="PresentationCore">
      <RequiredTargetFramework>3.0</RequiredTargetFramework>
    </Reference>
    <Reference Include="PresentationFramework">
      <RequiredTargetFramework>3.0</RequiredTargetFramework>
    </Reference>
  </ItemGroup>
  <ItemGroup>
    <ApplicationDefinition Include="App.xaml">
      <Generator>MSBuild:Compile</Generator>
      <SubType>Designer</SubType>
    </ApplicationDefinition>
    <Compile Include="App.xaml.cs">
      <DependentUpon>App.xaml</DependentUpon>
      <SubType>Code</SubType>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="MainPage.xaml.cs">
      <DependentUpon>MainPage.xaml</DependentUpon>
    </Compile>
    <Compile Include="Properties\AssemblyInfo.cs">
      <SubType>Code</SubType>
    </Compile>
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
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>ResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.cs</LastGenOutput>
    </EmbeddedResource>
    <None Include="Bytescout.BarCode.WebDemo_TemporaryKey.pfx" />
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.cs</LastGenOutput>
    </None>
    <None Include="Properties\app.manifest" />
  </ItemGroup>
  <ItemGroup>
    <Page Include="MainPage.xaml">
      <SubType>Designer</SubType>
      <Generator>MSBuild:Compile</Generator>
    </Page>
  </ItemGroup>
  <PropertyGroup>
    <StartArguments />
  </PropertyGroup>
  <PropertyGroup>
    <ManifestKeyFile>Bytescout.BarCode.WebDemo_TemporaryKey.pfx</ManifestKeyFile>
  </PropertyGroup>
  <PropertyGroup>
    <ManifestCertificateThumbprint>6D5A476A039A81980F77539E1944CFBB25240E02</ManifestCertificateThumbprint>
  </PropertyGroup>
  <PropertyGroup />
  <PropertyGroup>
    <ApplicationManifest>Properties\app.manifest</ApplicationManifest>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Debug_FULL|AnyCPU'">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>..\..\Output\Debug_FULL_3.5_CP\</OutputPath>
    <DefineConstants>TRACE;DEBUG;FULL</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>AnyCPU</PlatformTarget>
    <CodeAnalysisLogFile>..\..\Output\Debug_FULL_3.5_CP\Bytescout.BarCode.WebDemo.exe.CodeAnalysisLog.xml</CodeAnalysisLogFile>
    <CodeAnalysisUseTypeNameInSuppression>true</CodeAnalysisUseTypeNameInSuppression>
    <CodeAnalysisModuleSuppressionsFile>GlobalSuppressions.cs</CodeAnalysisModuleSuppressionsFile>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>MinimumRecommendedRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisRuleSetDirectories>;c:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\\Rule Sets</CodeAnalysisRuleSetDirectories>
    <CodeAnalysisIgnoreBuiltInRuleSets>true</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisRuleDirectories>;c:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\FxCop\\Rules</CodeAnalysisRuleDirectories>
    <CodeAnalysisIgnoreBuiltInRules>true</CodeAnalysisIgnoreBuiltInRules>
    <CodeAnalysisFailOnMissingRules>false</CodeAnalysisFailOnMissingRules>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Release_FULL|AnyCPU'">
    <OutputPath>..\..\Output\Release_FULL_3.5_CP\</OutputPath>
    <DefineConstants>TRACE;FULL</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>AnyCPU</PlatformTarget>
    <CodeAnalysisLogFile>..\..\Output\Release_FULL_3.5_CP\Bytescout.BarCode.WebDemo.exe.CodeAnalysisLog.xml</CodeAnalysisLogFile>
    <CodeAnalysisUseTypeNameInSuppression>true</CodeAnalysisUseTypeNameInSuppression>
    <CodeAnalysisModuleSuppressionsFile>GlobalSuppressions.cs</CodeAnalysisModuleSuppressionsFile>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>MinimumRecommendedRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisRuleSetDirectories>;c:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\\Rule Sets</CodeAnalysisRuleSetDirectories>
    <CodeAnalysisIgnoreBuiltInRuleSets>true</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisRuleDirectories>;c:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\FxCop\\Rules</CodeAnalysisRuleDirectories>
    <CodeAnalysisIgnoreBuiltInRules>true</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
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

##### ****Bytescout.BarCode.WebDemo_VS2010_40.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{DB2A5C21-E0BD-41B9-BA44-BA5642A6A387}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>Bytescout.BarCode.WebDemo</RootNamespace>
    <AssemblyName>Bytescout.BarCode.WebDemo</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <TargetFrameworkProfile>Client</TargetFrameworkProfile>
    <FileAlignment>512</FileAlignment>
    <ProjectTypeGuids>{60dc8134-eba5-43b8-bcc9-bb4bc16c2548};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
    <WarningLevel>4</WarningLevel>
    <EnableSecurityDebugging>true</EnableSecurityDebugging>
    <Install>False</Install>
    <StartAction>URL</StartAction>
    <HostInBrowser>true</HostInBrowser>
    <BootstrapperEnabled>false</BootstrapperEnabled>
    <TargetZone>Internet</TargetZone>
    <GenerateManifests>true</GenerateManifests>
    <SignManifests>True</SignManifests>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug_DEMO|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug_DEMO_4.0_CP\</OutputPath>
    <DefineConstants>TRACE;DEBUG;DEMO;NET4</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release_DEMO|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release_DEMO_4.0_CP\</OutputPath>
    <DefineConstants>TRACE;DEMO;NET4</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCode">
      <HintPath>C:\Program Files\Bytescout BarCode SDK\net4.00 ClientProfile\Bytescout.BarCode.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.BarCode.WPF">
      <HintPath>C:\Program Files\Bytescout BarCode SDK\net4.00 ClientProfile\Bytescout.BarCode.WPF.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Reference Include="Microsoft.CSharp" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="System.Xaml">
      <RequiredTargetFramework>4.0</RequiredTargetFramework>
    </Reference>
    <Reference Include="WindowsBase" />
    <Reference Include="PresentationCore" />
    <Reference Include="PresentationFramework" />
  </ItemGroup>
  <ItemGroup>
    <ApplicationDefinition Include="App.xaml">
      <Generator>MSBuild:Compile</Generator>
      <SubType>Designer</SubType>
    </ApplicationDefinition>
    <Compile Include="App.xaml.cs">
      <DependentUpon>App.xaml</DependentUpon>
      <SubType>Code</SubType>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="MainPage.xaml.cs">
      <DependentUpon>MainPage.xaml</DependentUpon>
    </Compile>
    <Compile Include="Properties\AssemblyInfo.cs">
      <SubType>Code</SubType>
    </Compile>
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
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>ResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.cs</LastGenOutput>
    </EmbeddedResource>
    <None Include="Bytescout.BarCode.WebDemo_TemporaryKey.pfx" />
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.cs</LastGenOutput>
    </None>
    <None Include="Properties\app.manifest" />
    <AppDesigner Include="Properties\" />
  </ItemGroup>
  <ItemGroup>
    <Page Include="MainPage.xaml">
      <Generator>MSBuild:Compile</Generator>
      <SubType>Designer</SubType>
    </Page>
  </ItemGroup>
  <PropertyGroup>
    <StartArguments />
  </PropertyGroup>
  <PropertyGroup>
    <ManifestKeyFile>Bytescout.BarCode.WebDemo_TemporaryKey.pfx</ManifestKeyFile>
  </PropertyGroup>
  <PropertyGroup>
    <ManifestCertificateThumbprint>6D5A476A039A81980F77539E1944CFBB25240E02</ManifestCertificateThumbprint>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Debug_FULL|AnyCPU'">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>..\..\Output\Debug_FULL_4.0_CP\</OutputPath>
    <DefineConstants>TRACE;DEBUG;FULL;NET4</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>AnyCPU</PlatformTarget>
    <CodeAnalysisLogFile>..\..\Output\WPF Demo Debug 4.0 ClientProfile\Bytescout.BarCode.WebDemo.exe.CodeAnalysisLog.xml</CodeAnalysisLogFile>
    <CodeAnalysisUseTypeNameInSuppression>true</CodeAnalysisUseTypeNameInSuppression>
    <CodeAnalysisModuleSuppressionsFile>GlobalSuppressions.cs</CodeAnalysisModuleSuppressionsFile>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>MinimumRecommendedRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisRuleSetDirectories>;c:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\\Rule Sets</CodeAnalysisRuleSetDirectories>
    <CodeAnalysisIgnoreBuiltInRuleSets>true</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisRuleDirectories>;c:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\FxCop\\Rules</CodeAnalysisRuleDirectories>
    <CodeAnalysisIgnoreBuiltInRules>true</CodeAnalysisIgnoreBuiltInRules>
    <CodeAnalysisFailOnMissingRules>false</CodeAnalysisFailOnMissingRules>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Release_FULL|AnyCPU'">
    <OutputPath>..\..\Output\Release_FULL_4.0_CP\</OutputPath>
    <DefineConstants>TRACE;FULL;NET4</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>AnyCPU</PlatformTarget>
    <CodeAnalysisLogFile>..\..\Output\WPF Demo Release 4.0 ClientProfile\Bytescout.BarCode.WebDemo.exe.CodeAnalysisLog.xml</CodeAnalysisLogFile>
    <CodeAnalysisUseTypeNameInSuppression>true</CodeAnalysisUseTypeNameInSuppression>
    <CodeAnalysisModuleSuppressionsFile>GlobalSuppressions.cs</CodeAnalysisModuleSuppressionsFile>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>MinimumRecommendedRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisRuleSetDirectories>;c:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\\Rule Sets</CodeAnalysisRuleSetDirectories>
    <CodeAnalysisIgnoreBuiltInRuleSets>true</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisRuleDirectories>;c:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\FxCop\\Rules</CodeAnalysisRuleDirectories>
    <CodeAnalysisIgnoreBuiltInRules>true</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
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

##### ****MainPage.xaml.cs:**
    
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Bytescout.BarCode.WPF;
using Bytescout.BarCode;

namespace Bytescout.BarCode.WebDemo
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        #region Constants

        private const int BarHeight = 50;
        private const int PdfBarHeight = 6;

        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }
        #endregion

        #region Controls event handlers
        /// <summary>
        /// Handles the SelectionChanged event of the cmbSymbologyType control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Controls.SelectionChangedEventArgs"/> instance containing the event data.</param>
        private void cmbSymbologyType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateBarcode();
        }

        /// <summary>
        /// Handles the Click event of the btnGenerate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            UpdateBarcode();
        }

        /// <summary>
        /// Handles the Click event of the btnSaveToFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void btnSaveToFile_Click(object sender, RoutedEventArgs e)
        {
            SaveToFile();
        }

        /// <summary>
        /// Handles the Checked event of the chkDrawCaptionFor2D control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void chkDrawCaptionFor2D_Checked(object sender, RoutedEventArgs e)
        {
            ctrlBarcodeControl.DrawCaptionFor2DBarcodes = chkDrawCaptionFor2D.IsChecked.Value;
        }

        /// <summary>
        /// Handles the Checked event of the chkAutoFitToContainer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void chkAutoFitToContainer_Checked(object sender, RoutedEventArgs e)
        {
            ctrlBarcodeControl.AutoFitToControlSize = chkAutoFitToContainer.IsChecked.Value;
        }

        /// <summary>
        /// Handles the Checked event of the chkCutUnusedSpace control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void chkCutUnusedSpace_Checked(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Handles the TextChanged event of the txtValueToEncode control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Controls.TextChangedEventArgs"/> instance containing the event data.</param>
        private void txtValueToEncode_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateBarcode();
        }

        /// <summary>
        /// Handles the TextChanged event of the txtSupplementalValue control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Controls.TextChangedEventArgs"/> instance containing the event data.</param>
        private void txtSupplementalValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateBarcode();
        }
        #endregion

        #region Private implementation

        public object[] GetObjectsFromEnum()
        {
            object[] objArray = new object[Enum.GetValues(typeof(SymbologyType)).Length];
            for (int i = 0; i < objArray.Length; i++)
            {
                objArray[i] = ((SymbologyType)Enum.GetValues(typeof(SymbologyType)).GetValue(i)).ToString();
            }
            return objArray;
        }

        private void UpdateBarcode()
        {
            SymbologyType symbology = (SymbologyType)Enum.GetValues(typeof(SymbologyType)).GetValue(this.cboSymbologyType.SelectedIndex);
            txtSymbologyDescription.Text = ctrlBarcodeControl.GetValueRestrictions(symbology);

            try
            {
                if (symbology == SymbologyType.EAN13 || symbology == SymbologyType.ISBN || symbology == SymbologyType.UPCA)
                {
                    txtSupplementalValue.IsEnabled = true;
                    lblSupplementalValue.IsEnabled = true;
                    txtSymbologyDescription.Text += " " + ctrlBarcodeControl.GetSupplementaryValueRestrictions();
                }
                else
                {
                    txtSupplementalValue.IsEnabled = false;
                    lblSupplementalValue.IsEnabled = false;
                }

                lblErrorMessage.Content = "";
                ctrlBarcodeControl.RegistrationKey = "XXXXXXXXXXXXXXXXXXx";
                ctrlBarcodeControl.RegistrationName = "YYYYYYYYYYYYYYYYYYYY";
                ctrlBarcodeControl.Symbology = symbology;
                ctrlBarcodeControl.SupplementValue = txtSupplementalValue.Text;
                ctrlBarcodeControl.Value = txtValueToEncode.Text;
                ctrlBarcodeControl.DrawCaptionFor2DBarcodes = chkDrawCaptionFor2D.IsChecked.Value;
                ctrlBarcodeControl.AutoFitToControlSize = chkAutoFitToContainer.IsChecked.Value;
                ctrlBarcodeControl.Caption = "";

                if (symbology == SymbologyType.PDF417 || symbology == SymbologyType.PDF417Truncated ||
                    symbology == SymbologyType.MacroPDF417 || symbology == SymbologyType.DataMatrix ||
                    symbology == SymbologyType.GS1_DataMatrix)
                {
                    ctrlBarcodeControl.BarHeight = PdfBarHeight;
                }
                else if (symbology == SymbologyType.MicroPDF417)
                {
                    ctrlBarcodeControl.BarHeight = PdfBarHeight / 2;
                }
                else
                {
                    ctrlBarcodeControl.BarHeight = BarHeight;
                }
            }
            catch (Exception)
            {
                lblErrorMessage.Content = "Value is invalid for current symbology. Please review value restrictions above.";
            }
        }

        private void SaveToFile()
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.Filter = "PNG Image|*.png|TIFF Image|*.tif;*.tiff|JPEG image|*.jpg;*.jpeg|Bitmap Image|*.bmp|GIF Image|*.gif";
            dlg.ValidateNames = true;
            dlg.FilterIndex = 1;
            dlg.OverwritePrompt = true;
            dlg.CheckPathExists = true;
            dlg.AddExtension = true;

            bool? result = dlg.ShowDialog(Application.Current.MainWindow);
            if (result.HasValue && result.Value)
            {
                try
                {
                    if (System.IO.Path.GetExtension(dlg.FileName).ToLowerInvariant() == ".emf")
                        throw new BarcodeException("Saving as EMF is disabled.\nYou should buy Barcode SDK for this.");

                    if (chkCutUnusedSpace.IsChecked.Value)
                    {
                        bool cut = ctrlBarcodeControl.CutUnusedSpace;
                        ctrlBarcodeControl.CutUnusedSpace = true;
                        ctrlBarcodeControl.SaveImage(dlg.FileName);
                        ctrlBarcodeControl.CutUnusedSpace = cut;
                    }
                    else
                    {
                        ctrlBarcodeControl.SaveImage(dlg.FileName);
                    }

                }
                catch (System.Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        #endregion

        #region Main window event handlers
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (object o in GetObjectsFromEnum())
            {
                this.cboSymbologyType.Items.Add(o);
            }
            this.cboSymbologyType.SelectedIndex = 0;
        }
        #endregion
    }
}

```

<!-- code block end -->