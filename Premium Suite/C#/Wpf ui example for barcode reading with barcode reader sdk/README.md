## wpf ui example for barcode reading with barcode reader sdk in C# using ByteScout Premium Suite

### Learn wpf ui example for barcode reading with barcode reader sdk in C#

Here you may get thousands pre-made source code samples for simple implementation in your own programming C# projects. Wpf ui example for barcode reading with barcode reader sdk in C# can be applied with ByteScout Premium Suite. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

Save time on writing and testing code by using the code below and use it in your application. If you want to know how it works, then this C# sample code should be copied and pasted into your application’s code editor. Then just compile and run it. C# application implementation mostly involves various stages of the software development so even if the functionality works please check it with your data and the production environment.

Trial version can be downloaded from our website for free. It contains this and other source code samples for C#.

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

##### ****App.xaml.cs:**
    
```
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows;

namespace ReadBarcodeFromImage
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

##### ****MainWindow.xaml.cs:**
    
```
using System;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Bytescout.BarCodeReader;

namespace ReadBarcodeFromImage
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Select image file
        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog
            {
                Filter = "Supported formats (*.bmp;*.gif;*.tif;*.png;*.jpg;*.pdf)|*.bmp;*.gif;*.tif;*.tiff;*.png;*.jpg;*.jpeg;*.pdf|All Files|*.*"
            };

            if (dlg.ShowDialog() == true)
            {
                tbFileName.Text = dlg.FileName;
                tbFoundBarcodes.Text = "";
                imageContainer.Source = null;

                try
                {
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.UriSource = new Uri(dlg.FileName, UriKind.Absolute);
                    bitmapImage.EndInit();

                    imageContainer.Source = bitmapImage;
                }
                catch (Exception)
                {
                }
            }
        }

        private void btnDecode_Click(object sender, RoutedEventArgs e)
        {
            // Create barcode reader instance
            Reader reader = new Reader();
            reader.RegistrationName = "demo";
            reader.RegistrationKey = "demo";
        
            // Specify barcode types to find
            reader.BarcodeTypesToFind.All = true;
            // Select specific barcode types to speed up the decoding process and avoid false positives.

            // Show wait cursor
            Mouse.OverrideCursor = Cursors.Wait;
            
            /* -----------------------------------------------------------------------
            NOTE: We can read barcodes from specific page to increase performance.
            For sample please refer to "Decoding barcodes from PDF by pages" program.
            ----------------------------------------------------------------------- */

            try
            {
                // Search for barcodes
                reader.ReadFrom(tbFileName.Text);
            }
            finally
            {
                Mouse.OverrideCursor = null;
            }

            // Display found barcode inforamtion:

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < reader.FoundBarcodes.Length; i++)
            {
                FoundBarcode barcode = reader.FoundBarcodes[i];
                stringBuilder.AppendFormat("{0}) Type: {1}; Value: {2}.\r\n", i + 1, barcode.Type, barcode.Value);
            }
			
            tbFoundBarcodes.Text = stringBuilder.ToString();
			
			// Cleanup
			reader.Dispose();
        }
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ReadBarcodeFromImage.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>8.0.30703</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{E76BA4E7-70FF-4E53-9A0F-6B0AC743696C}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <RootNamespace>ReadBarcodeFromImage</RootNamespace>
    <AssemblyName>ReadBarcodeFromImage</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <TargetFrameworkProfile>
    </TargetFrameworkProfile>
    <FileAlignment>512</FileAlignment>
    <ProjectTypeGuids>{60dc8134-eba5-43b8-bcc9-bb4bc16c2548};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCodeReader">
      <HintPath>C:\Program Files\Bytescout BarCode Reader SDK\net4.00\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Core" />
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
    <None Include="app.config" />
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

##### ****app.config:**
    
```
<?xml version="1.0"?>
<configuration>
<startup><supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.0"/></startup></configuration>

```

<!-- code block end -->