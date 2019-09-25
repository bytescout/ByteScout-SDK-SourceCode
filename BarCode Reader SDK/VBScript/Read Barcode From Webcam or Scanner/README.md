## How to read barcode from webcam or scanner in VBScript with ByteScout BarCode Reader SDK

### Write code in VBScript to read barcode from webcam or scanner with this step-by-step tutorial

This sample source code below will demonstrate you how to read barcode from webcam or scanner in VBScript. ByteScout BarCode Reader SDK is the SDK for barcode decoding. Can read all popular types from Code 128, GS1, UPC and Code 39 to QR Code, Datamatrix, PDF417. Images, pdf, TIF images and live web camera are supported as input. Designed to handle documents with noise and defects. Includes optional splitter and merger for pdf and tiff based on barcodes. Batch mode is optimized for high performance with multiple threads. Decoded values can be exported to XML, JSON, CSV or into custom data format. It can be used to read barcode from webcam or scanner using VBScript.

VBScript code samples for VBScript developers help to speed up coding of your application when using ByteScout BarCode Reader SDK. Just copy and paste the code into your VBScript application’s code and follow the instruction. Use of ByteScout BarCode Reader SDK in VBScript is also explained in the documentation included along with the product.

Our website provides trial version of ByteScout BarCode Reader SDK for free. It also includes documentation and source code samples.

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

##### ****AcquireImagesFromWebCam.vbs:**
    
```
Set wia = CreateObject("Bytescout.BarCodeReader.WIAImageScanner")

wia.OutputFileNameTemplate = "BarCodeReader-scanned"
wia.OutputFolder = "." ' set output folder to current folder
wia.OutputImageFormat = 1 ' = WiaImageFormatType.PNG
wia.ImageQuality = 131072 ' = 0x00020000 = WiaImageBias.MaximizeQuality
wia.ImageIntent = 0 ' = WiaImageIntent.UnspecifiedIntent
wia.ShowDeviceSelectionDialog = True

If wia.Acquire() Then ' acquire images from device
	
	outputFiles = wia.OutputFilesCOM ' get names of acquire image files
	Msgbox outputFiles(0) ' display first file name 
	
End If

Set wia = Nothing


```

<!-- code block end -->