## How to read barcodes from live video cam (wpf) with barcode reader sdk in C# using ByteScout Barcode Suite

### If you want to learn more then this tutorial will show how to read barcodes from live video cam (wpf) with barcode reader sdk in C#

Read barcodes from live video cam (wpf) with barcode reader sdk is simple to apply in C# if you use these source codes below. ByteScout Barcode Suite: the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can read barcodes from live video cam (wpf) with barcode reader sdk in C#.

Want to quickly learn? This fast application programming interfaces of ByteScout Barcode Suite for C# plus the guidelines and the code below will help you quickly learn how to read barcodes from live video cam (wpf) with barcode reader sdk. This C# sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Enjoy writing a code with ready-to-use sample codes in C#.

The trial version of ByteScout Barcode Suite can be downloaded for free from our website. It also includes source code samples for C# and other programming languages.

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

namespace ReadFromVideoCamera.VS2010.WPF
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

##### ****ReadFromVideoCamera.VS2010.WPF.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>8.0.30703</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{FD0E552B-C6A8-40EB-87FC-5DDADDC12A4A}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <RootNamespace>ReadFromVideoCamera.VS2010.WPF</RootNamespace>
    <AssemblyName>ReadFromVideoCamera.VS2010.WPF</AssemblyName>
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
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
    <Reference Include="Microsoft.CSharp" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="System.Xaml">
      <RequiredTargetFramework>4.0</RequiredTargetFramework>
    </Reference>
    <Reference Include="TouchlessLib, Version=1.0.0.0, Culture=neutral, processorArchitecture=x86">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>.\TouchlessLib.dll</HintPath>
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
    <Page Include="VideoScanForm.xaml">
      <Generator>MSBuild:Compile</Generator>
      <SubType>Designer</SubType>
    </Page>
    <Compile Include="App.xaml.cs">
      <DependentUpon>App.xaml</DependentUpon>
      <SubType>Code</SubType>
    </Compile>
    <Compile Include="VideoScanForm.xaml.cs">
      <DependentUpon>VideoScanForm.xaml</DependentUpon>
      <SubType>Code</SubType>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <Content Include="TouchlessLib.dll" />
    <Content Include="WebCamLib.dll">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
  <PropertyGroup>
    <PreBuildEvent>
    </PreBuildEvent>
  </PropertyGroup>
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

##### ****VideoScanForm.xaml.cs:**
    
```
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Bytescout.BarCodeReader;
using TouchlessLib;

namespace ReadFromVideoCamera.VS2010.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Touchless lib manager object (to use it you should have TouchlessLib.dll and WebCamLib.dll)
        private TouchlessMgr _touchlessMgr;

        // USED IN POPUP MODE ONLY (see ShowScanPopup() method)
        // Close or not on the first barcode found
        // (results are saved in _foundBarcodes)
	    public bool CloseOnFirstBarcodeFound { get; set; }

		// Indicates if the form is closed
		public bool IsClosed { get; set; }

        // Background processing object
        BackgroundWorker _backgroundWorker = new BackgroundWorker();

		// Barcode type to scan
        private BarcodeTypeSelector _barcodeTypeToFind = new BarcodeTypeSelector();

		// Array with decoded barcodes from the last scanning session
		public FoundBarcode[] FoundBarcodes { get; set; }

		// Scanning delay (ms); default is to scan every 800 ms.
		const int ScanDelay = 800;

		// Internal varaible to indicate the status.
        public static bool Status = true;

		public delegate void SimpleDelegate();
		

        /// <summary>
        /// Creates the form.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            lblScanning.Visibility = Visibility.Collapsed;
            
			_backgroundWorker.WorkerSupportsCancellation = true;
			_backgroundWorker.DoWork += BackgroundWorker_DoWork;
			_backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }
		
		// Searches for barcodes in bitmap object
        private FoundBarcode[] FindBarcodes(Bitmap bitmap)
        {
            Reader reader = new Reader();

            try
            {
                reader.RegistrationName = "demo";
                reader.RegistrationKey = "demo";

                this.Dispatcher.Invoke(DispatcherPriority.Normal, (SimpleDelegate) UpdateBarcodeTypeToFindFromCombobox);

                reader.BarcodeTypesToFind = _barcodeTypeToFind;
				
                //reader.MaxNumberOfBarcodesPerPage = 1;

                /* -----------------------------------------------------------------------
                NOTE: We can read barcodes from specific page to increase performance.
                For sample please refer to "Decoding barcodes from PDF by pages" program.
                ----------------------------------------------------------------------- */

                FoundBarcode[] result = reader.ReadFrom(bitmap);
                String timeNow = string.Format("{0:HH:mm:ss:tt}", DateTime.Now);

				this.Dispatcher.Invoke(DispatcherPriority.Normal, (SimpleDelegate) delegate
                      {
                          if (result != null && result.Length > 0)
                          {

                              textAreaBarcodes.SelectAll();
                              textAreaBarcodes.Selection.Text = "\nTime: " + timeNow + "\n";

							  // insert barcodes into text box
                              foreach (FoundBarcode barcode in result)
                              {
								  // make a sound that we found the barcode
                                  Console.Beep();
                                  // form the string with barcode value
                                  String barcodeValue = String.Format("Found: {0} {1}\n", barcode.Type, barcode.Value);
                                  // add barcode to the text area output
                                  textAreaBarcodes.AppendText(barcodeValue + "\n");
                                  // add barcode to the list of saved barcodes
                                  lblFoundBarcodes.Content = String.Format("Found {0} barcodes:", result.Length);
                              }
                          }

						  // make "Scanning..." label flicker
                          lblScanning.Visibility = lblScanning.Visibility == Visibility.Collapsed 
							  ? Visibility.Visible 
							  : Visibility.Collapsed;
                          lblScanning.UpdateLayout();
                      });

				// return found barcodes
                return result;
       
            }
            finally
            {
                reader.Dispose();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Populate barcode types into the combobox
            PopulateBarcodeTypesCombobox();

            InitCamera();

            StartDecoding();
        }

        private void InitCamera()
        {
            try
            {
                // Create Touchless lib manager to work with video camera
                _touchlessMgr = new TouchlessMgr();

                // Iterate through available video camera devices
                foreach (Camera camera in _touchlessMgr.Cameras)
                {
                    // Add to list of available camera devices
                    cbCamera.Items.Add(camera);
                }

                // Select first available camera
                cbCamera.SelectedItem = _touchlessMgr.Cameras[0];


                // Setting default image dimensions; see also camera selection event.
                _touchlessMgr.Cameras[0].CaptureWidth = int.Parse(tbCameraWidth.Text);
                _touchlessMgr.Cameras[0].CaptureHeight = int.Parse(tbCameraHeight.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("No video camera available. Please connect camera.\n" + ex.Message);
            }
        }

        public void StartDecoding()
        {
            UpdateCameraSelection();

            // Clear the text box output
            TextRange txt = new TextRange(textAreaBarcodes.Document.ContentStart, textAreaBarcodes.Document.ContentEnd);
            txt.Text = "";

            // Clean list of barcodes
            FoundBarcodes = null;

            // Check camera selected
            if (cbCamera.SelectedIndex != -1)
            {
                // Set status
                Status = true;

                // Update UI buttons
                btnStart.IsEnabled = false;
                btnStop.IsEnabled = true;
                cbBarCodeType.IsEnabled = false;
                cbCamera.IsEnabled = false;
                tbCameraHeight.IsEnabled = false;
                tbCameraWidth.IsEnabled = false;
                lblScanning.Content = "Scanning...";

                // Start the decoding thread
                _backgroundWorker.RunWorkerAsync(CloseOnFirstBarcodeFound);
            }
            else
            {
                MessageBox.Show("Please select camera");
            }        
        }
		
        // Update picture box with the latest frame from video camera
        void CurrentCamera_OnImageCaptured(object sender, CameraEventArgs e)
        {
            // You can change image dimensions if needed
            //_touchlessMgr.CurrentCamera.CaptureWidth = 320;
            //_touchlessMgr.CurrentCamera.CaptureHeight = 240;
			Dispatcher.Invoke(DispatcherPriority.Normal, (SimpleDelegate) delegate
				{
					if (_touchlessMgr != null)
					{
						pictureVideoPreview.BeginInit();
						BitmapImage imageSource = BitmapToImageSource(_touchlessMgr.CurrentCamera.GetCurrentImage(), ImageFormat.Png);

						ScaleTransform st = new ScaleTransform();
						st.ScaleX = (double)320 / (double)imageSource.PixelWidth;
						st.ScaleY = (double)240 / (double)imageSource.PixelHeight;
						TransformedBitmap tb = new TransformedBitmap(imageSource, st);

						pictureVideoPreview.Source = tb;
						pictureVideoPreview.EndInit();
						pictureVideoPreview.UpdateLayout();
					}
				});

        }

		// Convert System.Drawing.Bitmap to System.Windows.Media.Imaging.BitmapImage
		BitmapImage BitmapToImageSource(Bitmap bitmap, ImageFormat imageFormat)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                bitmap.Save(memoryStream, imageFormat);
                memoryStream.Position = 0;
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memoryStream;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();

                return bitmapImage;
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            StartDecoding();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            StopDecoding();
        }

        private void StopDecoding()
        {
            _backgroundWorker.CancelAsync();

            // Update UI elements
            lblScanning.Visibility = Visibility.Collapsed;

            // Change working status
            Status = false;

            btnStart.IsEnabled = true;
            btnStop.IsEnabled = false;

            cbBarCodeType.IsEnabled = true;
            cbCamera.IsEnabled = true;

            tbCameraHeight.IsEnabled = true;
            tbCameraWidth.IsEnabled = true;

			if (CloseOnFirstBarcodeFound && FoundBarcodes != null && FoundBarcodes.Length > 0)
				Close();
        }

        public void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
			BackgroundWorker worker = (BackgroundWorker) sender;
            bool closeOnFirstBarcode = (bool) e.Argument;

            while (true)
            {
				// Work till user canceled the scan
				if (worker.CancellationPending)
	            {
		            e.Cancel = true;
		            return;
	            }

				// Get current frame bitmap from camera using Touchless lib
	            Bitmap bitmap = _touchlessMgr.CurrentCamera.GetCurrentImage();

	            // Search barcodes
	            FoundBarcode[] result = null;

	            if (bitmap != null)
		            result = FindBarcodes(bitmap);

	            // Check if we need to stop on first barcode found
	            if (closeOnFirstBarcode && result != null && result.Length > 0)
	            {
		            e.Result = result;
		            return; // end processing
	            }

	            // Wait a little to lower CPU load
	            Thread.Sleep(ScanDelay);
            }
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Clear last results
            FoundBarcodes = null;

            if (e.Cancelled)
            {
                lblScanning.Content = "Canceled";
            }
            else if (e.Error != null)
            {
                lblScanning.Content = "Error: " + e.Error.Message;
            }
            else
            {
                lblScanning.Content = "Done.";
                FoundBarcodes = (FoundBarcode[]) e.Result;
            }

            StopDecoding();
        }

        private void cbCamera_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateCameraSelection();
        }

        private void UpdateCameraSelection()
        {
            if (cbCamera.Items.Count > 0 && cbCamera.SelectedIndex >-1)
            {
                if (_touchlessMgr.CurrentCamera != null)
                    _touchlessMgr.CurrentCamera.OnImageCaptured -= CurrentCamera_OnImageCaptured;
                
                _touchlessMgr.CurrentCamera = null;

                Camera currentCamera = _touchlessMgr.Cameras[cbCamera.SelectedIndex];

                // Setting camera output image dimensions
                currentCamera.CaptureWidth = int.Parse(tbCameraWidth.Text);
                currentCamera.CaptureHeight = int.Parse(tbCameraHeight.Text);

                _touchlessMgr.CurrentCamera = currentCamera;
                currentCamera.OnImageCaptured += CurrentCamera_OnImageCaptured;
            }
        }

        // Updates barcode type filter according with combobox selection
        private void UpdateBarcodeTypeToFindFromCombobox()
        {
            string selectedItemText = cbBarCodeType.Text;

            if (string.IsNullOrEmpty(selectedItemText))
                throw new Exception("Empty barcode type selection.");

            _barcodeTypeToFind.Reset();

            // Iterate through BarcodeTypeSelector bool properties 
			// and enable property by barcode name selected in the combobox
			foreach (PropertyInfo propertyInfo in typeof(BarcodeTypeSelector).GetProperties())
            {
                // Skip readonly properties
                if (!propertyInfo.CanWrite)
                    continue;

				if (propertyInfo.Name == selectedItemText)
                    propertyInfo.SetValue(_barcodeTypeToFind, true, null);
            }
        }

        protected void PopulateBarcodeTypesCombobox()
        {
            cbBarCodeType.Items.Clear();
            List <string> items = new List<string>();

			foreach (PropertyInfo propinfo in typeof(BarcodeTypeSelector).GetProperties())
            {
                // Skip readonly properties
                if (!propinfo.CanWrite)
                    continue;

                items.Add(propinfo.Name);
            }
           
			items.Sort();
			cbBarCodeType.ItemsSource = items;

            // Select first item in combobox (first is "Find All")
            cbBarCodeType.SelectedItem = cbBarCodeType.Items[0];
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            Deinitialize();
        }

        private void Deinitialize()
        {
            // cancel decoding thread
            _backgroundWorker.CancelAsync();
            
			// Deinit camera
            DeinitCamera();
            
			// Mark as closed
            IsClosed = true;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void DeinitCamera()
        {
            if (_touchlessMgr != null)
            {
                _touchlessMgr.CurrentCamera.OnImageCaptured -= CurrentCamera_OnImageCaptured;
                _touchlessMgr.CurrentCamera = null;
            }

            if (cbCamera.SelectedItem != null)
                cbCamera.SelectedItem = null;

            cbCamera.Items.Clear();
            _touchlessMgr = null;

            Thread.Sleep(500);
        }

        private void btnTryPopup_Click(object sender, RoutedEventArgs e)
        {
            // Stop scan if any
			StopDecoding();

            // Deinit the current camera
            DeinitCamera();

            ShowScanPopup();

            // Reinit current camera
            InitCamera();
        }

        private void ShowScanPopup()
        {
			// Create another MainWindow instance to scan barcodes
            MainWindow popup = new MainWindow();
            // Set new popup position shifted by 20 pixels
            popup.Left = Left + 20;
            popup.Top = Top + 20;

            // Set the new popup window to close on first found barcode
            popup.CloseOnFirstBarcodeFound = true;

			// Hide btnTryPopup button 
            popup.btnTryPopup.Visibility = Visibility.Hidden;
            popup.btnStop.Visibility = Visibility.Hidden;
            popup.btnStart.Visibility = Visibility.Hidden;

            // Set the popup title
            popup.Title = "POPUP DIALOG - ONE-TIME SCAN";

            // Show the dialog
            popup.Show();

            // Now wait while the popup is closed (it will be closed on barcode found or canceled)
            while (!popup.IsClosed)
            {
                // HACK: Simulate "DoEvents"
                Dispatcher.Invoke(DispatcherPriority.Background, new ThreadStart(delegate { }));
                Thread.Sleep(20);
            }

            // Checking if one-time scan dialog found barcodes 
            if (popup.FoundBarcodes != null && popup.FoundBarcodes.Length > 0)
                MessageBox.Show("Popup scan found the barcode: \n" + popup.FoundBarcodes[0].Value, "POPUP RESULT");
            else
                MessageBox.Show("Popup canceled. Returning to the main window");

            // Close the dialog
            popup.Close();
        }
    }
}

```

<!-- code block end -->