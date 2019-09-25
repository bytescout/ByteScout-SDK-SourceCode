## How to add barcode to PDF in VBScript and ByteScout Barcode SDK

### Write code in VBScript to add barcode to PDF with this step-by-step tutorial

The sample source codes on this page shows how to add barcode to PDF in VBScript. ByteScout Barcode SDK: the fully featured library to generate barcodes. Supports QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix and many other barcode types. Includes various options for barcode generation to ensure output quality, add barcodes to new or existing pdf files and images. It can add barcode to PDF in VBScript.

This code snippet below for ByteScout Barcode SDK works best when you need to quickly add barcode to PDF in your VBScript application. In order to implement the functionality, you should copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Further enhancement of the code will make it more vigorous.

Download free trial version of ByteScout Barcode SDK from our website with this and other source code samples for VBScript.

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

##### ****AddBarcodeToPdfDocument.vbs:**
    
```
' Create barcode object and register it
Set barcode = CreateObject("Bytescout.BarCode.Barcode")
barcode.RegistrationName = "demo"
barcode.RegistrationKey = "demo"

' set symbology to DataMatrix
barcode.Symbology = 15 ' 15 = DataMatrix symbology type

' set barcode value to encode
barcode.Value = "Sample barcode" 

' Place barcode at top-left corner of every document page
barcode.DrawToPDF "..\wikipedia.pdf", -1, 10, 10, "result.pdf"

' Open the output file in default PDF viewer.
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
Set shell = Nothing

Set barcode = Nothing


```

<!-- code block end -->