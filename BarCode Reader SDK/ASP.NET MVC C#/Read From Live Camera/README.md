## How to read from live camera in ASP.NET MVC C# using ByteScout BarCode Reader SDK

### Tutorial on how to read from live camera in ASP.NET MVC C#

The documentation is designed to help you to implement the features on your side. ByteScout BarCode Reader SDK is the SDK for barcode decoding. Can read all popular types from Code 128, GS1, UPC and Code 39 to QR Code, Datamatrix, PDF417. Images, pdf, TIF images and live web camera are supported as input. Designed to handle documents with noise and defects. Includes optional splitter and merger for pdf and tiff based on barcodes. Batch mode is optimized for high performance with multiple threads. Decoded values can be exported to XML, JSON, CSV or into custom data format. It can read from live camera in ASP.NET MVC C#.

You will save a lot of time on writing and testing code as you may just take the ASP.NET MVC C# code from ByteScout BarCode Reader SDK for read from live camera below and use it in your application. In order to implement the functionality, you should copy and paste this code for ASP.NET MVC C# below into your code editor with your app, compile and run your application. Test ASP.NET MVC C# sample code examples whether they respond your needs and requirements for the project.

Free trial version of ByteScout BarCode Reader SDK is available on our website. Documentation and source code samples are included.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20BarCode%20Reader%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20BarCode%20Reader%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=EARSPJFIJMU](https://www.youtube.com/watch?v=EARSPJFIJMU)




<!-- code block begin -->

##### ****!!!ReadmeFIRST.txt:**
    
```
This sample supports all browsers by using 2 modes: 

(required mode is automatically detected by the javascript)
- HTML5 based web camera capture (supported by Google Chrome, Firefox, Safari, Safari on iOS browsers)
- Flash based web camera capture (supported by Internet Explorer 9+ and any browser with flash support)

IMPORTANT about HTML5 webcamera support (Chrome, Firefox, Safari on desktop and iOS): it is required to run your website (even test website) via SSL connection. Otherwise, web camera won't initialize at all as it requies SSL connection. 

Visual Studio 2008/2010 or higher is required for this sample to run!

1) Install evaluation copy of BarCode Reader SDK from www.bytescout.com
2) in Visual Studio use File - Open - Web-Site.. and open the folder with this sample
3) Add a reference to ByteScout BarCode Reader dll using the menu: Website - Add Reference (find Bytescout Barcode Reader SDK on .NET tab, select and click OK to add a reference)
4) Right-click on "Default.aspx" file and select "Set As Start Page"
5) Run the project in debug mode
6) Visual Studio will run your project in Internet Explorer or another browser
If it run Internet Explorer then better copy the link from the IE and copy-and-paste to another browser with HTML5 web cam support like Google Chrome, Firefox or Safari
7) When browser asks for permission to access web-cam click "Allow" to allow access to web cam 
8) click "START BARCODE SCAN.." button so the page will start automatically to grab frames from video and sending it to server-side code to read barcodes using Barcode Reader SDK
9) IMPORTANT: barcode should be in focus. Some webcams are not focusing on small barcodes, you may need to adjust the focus on your webcam so it will work OK with small images like barcodes

10) Click Stop to stop barcode scanning
Select barcode type to scan if need to scan a particular barcode type (by default scans for all known types)


TESTING:
- we recommend to use the Conveyor plugin to test your web app from local net or public url: https://marketplace.visualstudio.com/items?itemName=vs-publisher-1448185.ConveyorbyKeyoti

```

<!-- code block end -->    

<!-- code block begin -->

##### ****BarcodeReader.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 14
VisualStudioVersion = 14.0.25420.1
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "app", "app\BarcodeReader.csproj", "{A6EE57E5-62C7-4567-9BC0-E573686BF043}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{A6EE57E5-62C7-4567-9BC0-E573686BF043}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{A6EE57E5-62C7-4567-9BC0-E573686BF043}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{A6EE57E5-62C7-4567-9BC0-E573686BF043}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{A6EE57E5-62C7-4567-9BC0-E573686BF043}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
EndGlobal

```

<!-- code block end -->