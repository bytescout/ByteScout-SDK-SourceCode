## How to read barcode from image with barcode reader SDK in SAP PowerBuilder and ByteScout Data Extraction Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to read barcode from image with barcode reader SDK in SAP PowerBuilder

This sample source code below will display you how to read barcode from image with barcode reader SDK in SAP PowerBuilder. ByteScout Data Extraction Suite is the set that includes 3 SDK products for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK and you can use it to read barcode from image with barcode reader SDK with SAP PowerBuilder.

This prolific sample source code in SAP PowerBuilder for ByteScout Data Extraction Suite contains various functions and other necessary options you should do calling the API to read barcode from image with barcode reader SDK. This SAP PowerBuilder sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Check SAP PowerBuilder sample code samples to see if they respond to your needs and requirements for the project.

Trial version of ByteScout Data Extraction Suite is available for free. Source code samples are included to help you with your SAP PowerBuilder app.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Data%20Extraction%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Data%20Extraction%20Suite%20Question) 

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