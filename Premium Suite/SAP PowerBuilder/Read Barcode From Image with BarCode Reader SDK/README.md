## How to read barcode from image with barcode reader SDK in SAP PowerBuilder and ByteScout Premium Suite

### If you want to learn more then this tutorial will show how to read barcode from image with barcode reader SDK in SAP PowerBuilder

The documentation is designed for a specific purpose to help you to apply the features on your side. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording and you can use it to read barcode from image with barcode reader SDK with SAP PowerBuilder.

The following code snippet for ByteScout Premium Suite works best when you need to quickly read barcode from image with barcode reader SDK in your SAP PowerBuilder application. IF you want to implement the functionality, just copy and paste this code for SAP PowerBuilder below into your code editor with your app, compile and run your application. Applying SAP PowerBuilder application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

Trial version of ByteScout Premium Suite is available for free. Source code samples are included to help you with your SAP PowerBuilder app.

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