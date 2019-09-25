## wpf barcode control for desktop with barcode sdk in C# with ByteScout Barcode Suite

### Build wpf barcode control for desktop with barcode sdk in C#: ### Step-by-step instructions on how to do wpf barcode control for desktop with barcode sdk in C#

An easy to understand guide to learn how to wpf barcode control for desktop with barcode sdk in C#. ByteScout Barcode Suite was made to help with wpf barcode control for desktop with barcode sdk in C#. ByteScout Barcode Suite is the bundle that privides 3  SDK products to generate barcodes (Barcode SDK), read barcodes (Barcode Reaer SDK) and read and write spreadsheets (Spreadsheet SDK).

C# code snippet like this for ByteScout Barcode Suite works best when you need to quickly implement wpf barcode control for desktop with barcode sdk in your C# application. To use wpf barcode control for desktop with barcode sdk in your C# project or application just copy & paste the code and then run your app! These C# sample examples can be used in one or many applications.

Our website gives free trial version of ByteScout Barcode Suite. It includes all these source code samples with the purpose to assist you with your C# application implementation.

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

namespace Bytescout.BarCode.WPFDemo
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

##### ****Bytescout.BarCode.WPFDemo_VS2010_35.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>8.0.30703</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{B7C8FF33-A8B1-4004-B73D-5C6F952CA181}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>Bytescout.BarCode.WPFDemo</RootNamespace>
    <AssemblyName>Bytescout.BarCode.WPFDemo</AssemblyName>
    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
    <ProjectTypeGuids>{60dc8134-eba5-43b8-bcc9-bb4bc16c2548};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug_DEMO|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\Debug_DEMO_3.5\</OutputPath>
    <DefineConstants>TRACE;DEBUG;DEMO</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>AnyCPU</PlatformTarget>
    <CodeAnalysisLogFile>bin\Debug\Bytescout.BarCode.WPFDemo.exe.CodeAnalysisLog.xml</CodeAnalysisLogFile>
    <CodeAnalysisUseTypeNameInSuppression>true</CodeAnalysisUseTypeNameInSuppression>
    <CodeAnalysisModuleSuppressionsFile>GlobalSuppressions.cs</CodeAnalysisModuleSuppressionsFile>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>MinimumRecommendedRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisRuleSetDirectories>;C:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\\Rule Sets</CodeAnalysisRuleSetDirectories>
    <CodeAnalysisIgnoreBuiltInRuleSets>true</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisRuleDirectories>;C:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\FxCop\\Rules</CodeAnalysisRuleDirectories>
    <CodeAnalysisIgnoreBuiltInRules>true</CodeAnalysisIgnoreBuiltInRules>
    <CodeAnalysisFailOnMissingRules>false</CodeAnalysisFailOnMissingRules>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release_DEMO|AnyCPU' ">
    <OutputPath>bin\Release_DEMO_3.5\</OutputPath>
    <DefineConstants>TRACE;DEMO</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>AnyCPU</PlatformTarget>
    <CodeAnalysisLogFile>bin\Release\Bytescout.BarCode.WPFDemo.exe.CodeAnalysisLog.xml</CodeAnalysisLogFile>
    <CodeAnalysisUseTypeNameInSuppression>true</CodeAnalysisUseTypeNameInSuppression>
    <CodeAnalysisModuleSuppressionsFile>GlobalSuppressions.cs</CodeAnalysisModuleSuppressionsFile>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>MinimumRecommendedRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisRuleSetDirectories>;C:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\\Rule Sets</CodeAnalysisRuleSetDirectories>
    <CodeAnalysisIgnoreBuiltInRuleSets>true</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisRuleDirectories>;C:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\FxCop\\Rules</CodeAnalysisRuleDirectories>
    <CodeAnalysisIgnoreBuiltInRules>true</CodeAnalysisIgnoreBuiltInRules>
    <CodeAnalysisFailOnMissingRules>false</CodeAnalysisFailOnMissingRules>
  </PropertyGroup>
  <PropertyGroup>
    <ApplicationIcon>BarCode_SDK.ico</ApplicationIcon>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Debug_FULL|AnyCPU'">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\Debug_FULL_3.5\</OutputPath>
    <DefineConstants>TRACE;DEBUG;FULL</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>AnyCPU</PlatformTarget>
    <CodeAnalysisLogFile>bin\Debug\Bytescout.BarCode.WPFDemo.exe.CodeAnalysisLog.xml</CodeAnalysisLogFile>
    <CodeAnalysisUseTypeNameInSuppression>true</CodeAnalysisUseTypeNameInSuppression>
    <CodeAnalysisModuleSuppressionsFile>GlobalSuppressions.cs</CodeAnalysisModuleSuppressionsFile>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>MinimumRecommendedRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisRuleSetDirectories>;C:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\\Rule Sets</CodeAnalysisRuleSetDirectories>
    <CodeAnalysisIgnoreBuiltInRuleSets>true</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisRuleDirectories>;C:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\FxCop\\Rules</CodeAnalysisRuleDirectories>
    <CodeAnalysisIgnoreBuiltInRules>true</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Release_FULL|AnyCPU'">
    <OutputPath>bin\Release_FULL_3.5\</OutputPath>
    <DefineConstants>TRACE;FULL</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>AnyCPU</PlatformTarget>
    <CodeAnalysisLogFile>bin\Release\Bytescout.BarCode.WPFDemo.exe.CodeAnalysisLog.xml</CodeAnalysisLogFile>
    <CodeAnalysisUseTypeNameInSuppression>true</CodeAnalysisUseTypeNameInSuppression>
    <CodeAnalysisModuleSuppressionsFile>GlobalSuppressions.cs</CodeAnalysisModuleSuppressionsFile>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>MinimumRecommendedRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisRuleSetDirectories>;C:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\\Rule Sets</CodeAnalysisRuleSetDirectories>
    <CodeAnalysisIgnoreBuiltInRuleSets>true</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisRuleDirectories>;C:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\FxCop\\Rules</CodeAnalysisRuleDirectories>
    <CodeAnalysisIgnoreBuiltInRules>true</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCode">
      <HintPath>C:\Program Files\Bytescout BarCode SDK\net3.50\Bytescout.BarCode.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.BarCode.WPF">
      <HintPath>C:\Program Files\Bytescout BarCode SDK\net3.50\Bytescout.BarCode.WPF.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="WindowsBase" />
    <Reference Include="PresentationCore" />
    <Reference Include="PresentationFramework" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <ApplicationDefinition Include="App.xaml">
      <Generator>MSBuild:Compile</Generator>
      <SubType>Designer</SubType>
    </ApplicationDefinition>
    <Page Include="MainWindow.xaml">
      <Generator>MSBuild:Compile</Generator>
      <SubType>Designer</SubType>
    </Page>
    <Compile Include="App.xaml.cs">
      <DependentUpon>App.xaml</DependentUpon>
      <SubType>Code</SubType>
    </Compile>
    <Compile Include="MainWindow.xaml.cs">
      <DependentUpon>MainWindow.xaml</DependentUpon>
      <SubType>Code</SubType>
    </Compile>
  </ItemGroup>
  <ItemGroup>
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
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.cs</LastGenOutput>
    </None>
    <AppDesigner Include="Properties\" />
  </ItemGroup>
  <ItemGroup>
    <Resource Include="BarCode_SDK.ico" />
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

##### ****Bytescout.BarCode.WPFDemo_VS2010_40.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>8.0.30703</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{B7C8FF33-A8B1-4004-B73D-5C6F952CA181}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>Bytescout.BarCode.WPFDemo</RootNamespace>
    <AssemblyName>Bytescout.BarCode.WPFDemo</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
    <ProjectTypeGuids>{60dc8134-eba5-43b8-bcc9-bb4bc16c2548};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
    <WarningLevel>4</WarningLevel>
    <TargetFrameworkProfile />
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug_DEMO|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\Debug_DEMO_4.0\</OutputPath>
    <DefineConstants>TRACE;DEBUG;DEMO;NET4</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>AnyCPU</PlatformTarget>
    <CodeAnalysisLogFile>bin\Debug\Bytescout.BarCode.WPFDemo.exe.CodeAnalysisLog.xml</CodeAnalysisLogFile>
    <CodeAnalysisUseTypeNameInSuppression>true</CodeAnalysisUseTypeNameInSuppression>
    <CodeAnalysisModuleSuppressionsFile>GlobalSuppressions.cs</CodeAnalysisModuleSuppressionsFile>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>MinimumRecommendedRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisRuleSetDirectories>;C:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\\Rule Sets</CodeAnalysisRuleSetDirectories>
    <CodeAnalysisIgnoreBuiltInRuleSets>true</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisRuleDirectories>;C:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\FxCop\\Rules</CodeAnalysisRuleDirectories>
    <CodeAnalysisIgnoreBuiltInRules>true</CodeAnalysisIgnoreBuiltInRules>
    <CodeAnalysisFailOnMissingRules>false</CodeAnalysisFailOnMissingRules>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release_DEMO|AnyCPU' ">
    <OutputPath>bin\Release_DEMO_4.0\</OutputPath>
    <DefineConstants>TRACE;DEMO;NET4</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>AnyCPU</PlatformTarget>
    <CodeAnalysisLogFile>bin\Release\Bytescout.BarCode.WPFDemo.exe.CodeAnalysisLog.xml</CodeAnalysisLogFile>
    <CodeAnalysisUseTypeNameInSuppression>true</CodeAnalysisUseTypeNameInSuppression>
    <CodeAnalysisModuleSuppressionsFile>GlobalSuppressions.cs</CodeAnalysisModuleSuppressionsFile>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>MinimumRecommendedRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisRuleSetDirectories>;C:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\\Rule Sets</CodeAnalysisRuleSetDirectories>
    <CodeAnalysisIgnoreBuiltInRuleSets>true</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisRuleDirectories>;C:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\FxCop\\Rules</CodeAnalysisRuleDirectories>
    <CodeAnalysisIgnoreBuiltInRules>true</CodeAnalysisIgnoreBuiltInRules>
    <CodeAnalysisFailOnMissingRules>false</CodeAnalysisFailOnMissingRules>
  </PropertyGroup>
  <PropertyGroup>
    <ApplicationIcon>BarCode_SDK.ico</ApplicationIcon>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Debug_FULL|AnyCPU'">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\Debug_FULL_4.0\</OutputPath>
    <DefineConstants>TRACE;DEBUG;FULL;NET4</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>AnyCPU</PlatformTarget>
    <CodeAnalysisLogFile>bin\Debug\Bytescout.BarCode.WPFDemo.exe.CodeAnalysisLog.xml</CodeAnalysisLogFile>
    <CodeAnalysisUseTypeNameInSuppression>true</CodeAnalysisUseTypeNameInSuppression>
    <CodeAnalysisModuleSuppressionsFile>GlobalSuppressions.cs</CodeAnalysisModuleSuppressionsFile>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>MinimumRecommendedRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisRuleSetDirectories>;C:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\\Rule Sets</CodeAnalysisRuleSetDirectories>
    <CodeAnalysisIgnoreBuiltInRuleSets>true</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisRuleDirectories>;C:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\FxCop\\Rules</CodeAnalysisRuleDirectories>
    <CodeAnalysisIgnoreBuiltInRules>true</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Release_FULL|AnyCPU'">
    <OutputPath>bin\Release_FULL_4.0\</OutputPath>
    <DefineConstants>TRACE;FULL;NET4</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>AnyCPU</PlatformTarget>
    <CodeAnalysisLogFile>bin\Release\Bytescout.BarCode.WPFDemo.exe.CodeAnalysisLog.xml</CodeAnalysisLogFile>
    <CodeAnalysisUseTypeNameInSuppression>true</CodeAnalysisUseTypeNameInSuppression>
    <CodeAnalysisModuleSuppressionsFile>GlobalSuppressions.cs</CodeAnalysisModuleSuppressionsFile>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>MinimumRecommendedRules.ruleset</CodeAnalysisRuleSet>
    <CodeAnalysisRuleSetDirectories>;C:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\\Rule Sets</CodeAnalysisRuleSetDirectories>
    <CodeAnalysisIgnoreBuiltInRuleSets>true</CodeAnalysisIgnoreBuiltInRuleSets>
    <CodeAnalysisRuleDirectories>;C:\Program Files\Microsoft Visual Studio 10.0\Team Tools\Static Analysis Tools\FxCop\\Rules</CodeAnalysisRuleDirectories>
    <CodeAnalysisIgnoreBuiltInRules>true</CodeAnalysisIgnoreBuiltInRules>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCode">
      <HintPath>C:\Program Files\Bytescout BarCode SDK\net4.00\Bytescout.BarCode.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.BarCode.WPF">
      <HintPath>C:\Program Files\Bytescout BarCode SDK\net4.00\Bytescout.BarCode.WPF.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xaml" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="WindowsBase" />
    <Reference Include="PresentationCore" />
    <Reference Include="PresentationFramework" />
  </ItemGroup>
  <ItemGroup>
    <ApplicationDefinition Include="App.xaml">
      <Generator>MSBuild:Compile</Generator>
      <SubType>Designer</SubType>
    </ApplicationDefinition>
    <Page Include="MainWindow.xaml">
      <Generator>MSBuild:Compile</Generator>
      <SubType>Designer</SubType>
    </Page>
    <Compile Include="App.xaml.cs">
      <DependentUpon>App.xaml</DependentUpon>
      <SubType>Code</SubType>
    </Compile>
    <Compile Include="MainWindow.xaml.cs">
      <DependentUpon>MainWindow.xaml</DependentUpon>
      <SubType>Code</SubType>
    </Compile>
  </ItemGroup>
  <ItemGroup>
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
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.cs</LastGenOutput>
    </None>
    <AppDesigner Include="Properties\" />
  </ItemGroup>
  <ItemGroup>
    <Resource Include="BarCode_SDK.ico" />
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

##### ****MainWindow.xaml.cs:**
    
```
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Bytescout.BarCode.WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        #region Constants

        private const int BarHeight = 50;
        private const int PdfBarHeight = 6;

        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
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

        #endregion

        #region Menu items event handlers
        /// <summary>
        /// Handles the Click event of the mnuSaveToFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void mnuSaveToFile_Click(object sender, RoutedEventArgs e)
        {
            SaveToFile();
        }

        /// <summary>
        /// Handles the Click event of the mnuExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void mnuExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Handles the Click event of the mnuCopy control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void mnuCopy_Click(object sender, RoutedEventArgs e)
        {
            BitmapSource barcode = ctrlBarcodeControl.GetImage();
            Clipboard.SetImage(barcode);
            barcode = null;
        }

        /// <summary>
        /// Handles the Click event of the mnuBarcodeHome control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void mnuBarcodeHome_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://bytescout.com/bytescoutbarcodesdk.html");
        }

        /// <summary>
        /// Handles the Click event of the mnuHelp control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void mnuHelp_Click(object sender, RoutedEventArgs e)
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

            bool? result = dlg.ShowDialog(this);
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
        private void Window_Loaded(object sender, RoutedEventArgs e)
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