## How to read barcode from image in SAP PowerBuilder and ByteScout BarCode Reader SDK

### This code in SAP PowerBuilder shows how to read barcode from image with this how to tutorial

Learn how to read barcode from image in SAP PowerBuilder with this source code sample. ByteScout BarCode Reader SDK is the SDK for barcode decoding. Can read all popular types from Code 128, GS1, UPC and Code 39 to QR Code, Datamatrix, PDF417. Images, pdf, TIF images and live web camera are supported as input. Designed to handle documents with noise and defects. Includes optional splitter and merger for pdf and tiff based on barcodes. Batch mode is optimized for high performance with multiple threads. Decoded values can be exported to XML, JSON, CSV or into custom data format and you can use it to read barcode from image with SAP PowerBuilder.

This code snippet below for ByteScout BarCode Reader SDK works best when you need to quickly read barcode from image in your SAP PowerBuilder application. This SAP PowerBuilder sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! You can use these SAP PowerBuilder sample examples in one or many applications.

ByteScout free trial version is available for download from our website. It includes all these programming tutorials along with source code samples.

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

##### ****Sample.txt:**
    
```
//Creating the Instance of the OLE object as barcodeReader
OLEObject barcodeReader
barcodeReader = Create OLEObject

//Connecting to the Barcode Reader object
If barcodeReader.ConnectToNewObject("Bytescout.BarCodeReader.Reader") < 0 Then  
    Destroy barcodeReader
    MessageBox("Error", "Can't create Bytescout.BarCodeReader.Reader ActiveX/COM object")
    Return
End If

// Enable barcode types to find:
barcodeReader.BarcodeTypesToFind.Code39 = True
barcodeReader.BarcodeTypesToFind.Code128 = True

// Read barcode from image file
barcodeReader.ReadFromFile("barcode.png")

For i = 0 To barcodeReader.FoundCount - 1
    // Use barcodeReader.GetFoundBarcodePage(i), barcodeReader.GetFoundBarcodeType(i) and barcodeReader.GetFoundBarcodeValue(i)
    // to get the found barcode information
Next

Destroy barcodeReader
```

<!-- code block end -->