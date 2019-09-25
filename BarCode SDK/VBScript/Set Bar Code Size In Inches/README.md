## How to set bar code size in inches in VBScript and ByteScout Barcode SDK

### This tutorial will show how to set bar code size in inches in VBScript

Sample source code below will show you how to cope with a difficult task like set bar code size in inches in VBScript. ByteScout Barcode SDK can set bar code size in inches. It can be used from VBScript. ByteScout Barcode SDK is the robost library (Software Development Kit) that is designed for automatic generation of high-quality barcodes for printing, electronic documents and pdf. All popular barcode types are supported from Code 39 and Code 129 to QR Code, UPC, GS1, GS-128, Datamatrix, PDF417, Maxicode and many others. Provides support for full customization of fonts, colors, output and printing sizes. Special tools are included to verify output quality and printing quality. Can add generated barcode into new or existing documents, images and PDF.

VBScript code samples for VBScript developers help to speed up coding of your application when using ByteScout Barcode SDK. In order to implement the functionality, you should copy and paste this code for VBScript below into your code editor with your app, compile and run your application. You can use these VBScript sample examples in one or many applications.

You can download free trial version of ByteScout Barcode SDK from our website to see and try many others source code samples for VBScript.

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

##### ****FitIntoSizeInInches.vbs:**
    
```
Set bc = CreateObject("Bytescout.BarCode.Barcode")

' Set symbology to PDF417
bc.Symbology = 13 ' 13 = PDF417 barcode type

' Set barcode value to encode
bc.Value = "012345"

' Set barcode size by specifying a square the barcode will be fitted into 5x2 inches square
' Last parameter is the Measure Unit: Inch (2) Specifies the inch as the unit of measure. 
bc.FitInto_3 5, 2, 2

bc.CutUnusedSpace = False ' you can set it to True to cut unused space

bc.SaveImage "result.png"

Set bc = Nothing

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.png", 1, false
Set shell = Nothing

```

<!-- code block end -->