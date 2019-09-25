## How to add barcodes to TIFF in VBScript with ByteScout Barcode SDK

### This tutorial will show how to add barcodes to TIFF in VBScript

Sample source code below will show you how to cope with a difficult task like add barcodes to TIFF in VBScript. ByteScout Barcode SDK is the robost SDK that generates high quality barcode images and pdf. Can generate all popular types of barcodes from QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix to more exotic barcode types. Fully customizable fonts, colors, print sizes. Includes special functions to ensure output quality, and tools for adding barcodes to new or existing pdf files and images and you can use it to add barcodes to TIFF with VBScript.

This code snippet below for ByteScout Barcode SDK works best when you need to quickly add barcodes to TIFF in your VBScript application. In your VBScript project or application you may simply copy & paste the code and then run your app! Code testing will allow the function to be tested and work properly with your data.

Free trial version of ByteScout Barcode SDK is available on our website. Documentation and source code samples are included.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=REnj3A-oSPI](https://www.youtube.com/watch?v=REnj3A-oSPI)




<!-- code block begin -->

##### ****AddBarcodeToMultipageTiff.vbs:**
    
```
' Create barcode object and register it
Set barcode = CreateObject("Bytescout.BarCode.Barcode")
barcode.RegistrationName = "demo"
barcode.RegistrationKey = "demo"

' set symbology to PDF417
barcode.Symbology = 13 ' 13 = PDF417 symbology type

' set barcode value to encode
barcode.Value = "Sample barcode" 

' Place barcode at bottom-right corner of the the first TIFF page
barcode.DrawToImage "..\wikipedia.tif", 0, 550, 1100, "result.tif"

' Open the output file in default image viewer.
Set shell = CreateObject("WScript.Shell")
shell.Run "result.tif", 1, false
Set shell = Nothing

Set barcode = Nothing


```

<!-- code block end -->