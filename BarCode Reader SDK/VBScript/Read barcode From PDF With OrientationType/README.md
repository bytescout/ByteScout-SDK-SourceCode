## How to read barcode from PDF with orientationtype in VBScript with ByteScout BarCode Reader SDK

### If you want to learn more then this tutorial will show how to read barcode from PDF with orientationtype in VBScript

An easy to understand sample source code to learn how to read barcode from PDF with orientationtype in VBScript ByteScout BarCode Reader SDK can read barcode from PDF with orientationtype. It can be applied from VBScript. ByteScout BarCode Reader SDK is the SDK for barcode decoding. Can read all popular types from Code 128, GS1, UPC and Code 39 to QR Code, Datamatrix, PDF417. Images, pdf, TIF images and live web camera are supported as input. Designed to handle documents with noise and defects. Includes optional splitter and merger for pdf and tiff based on barcodes. Batch mode is optimized for high performance with multiple threads. Decoded values can be exported to XML, JSON, CSV or into custom data format.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout BarCode Reader SDK. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Applying VBScript application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

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

##### **TestBarcodeReadingFromPDF.vbs:**
    
```
Set bc = CreateObject("Bytescout.BarCodeReader.Reader")

' Set Barcode Types to Find
bc.BarcodeTypesToFind.PatchCode = True

' Add vertical orientations to analysis
bc.Orientation = 17 Or 2 Or 32768

' Reading barcode from image file
bc.ReadFromFile "PatchCode.png"

' Iterate throuhg all found barcodes
For i = 0 To bc.FoundCount - 1
     Msgbox "Found barcode with type " & Cstr(bc.GetFoundBarcodeType(i)) & " and value " & bc.GetFoundBarcodeValue(i)
Next

Set bc = Nothing

```

<!-- code block end -->