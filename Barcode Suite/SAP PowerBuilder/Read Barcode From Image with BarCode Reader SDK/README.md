## How to read barcode from image with barcode reader SDK in SAP PowerBuilder using ByteScout Barcode Suite

### How to write a robust code in SAP PowerBuilder to read barcode from image with barcode reader SDK with this step-by-step tutorial

ByteScout simple and easy to understand tutorials are planned to describe the code for both SAP PowerBuilder beginners and advanced programmers. ByteScout Barcode Suite is the bundle that privides 3  SDK products to generate barcodes (Barcode SDK), read barcodes (Barcode Reaer SDK) and read and write spreadsheets (Spreadsheet SDK). It can be applied to read barcode from image with barcode reader SDK using SAP PowerBuilder.

The SDK samples given below describe how to quickly make your application do read barcode from image with barcode reader SDK in SAP PowerBuilder with the help of ByteScout Barcode Suite.  Simply copy and paste in your SAP PowerBuilder project or application you and then run your app! Applying SAP PowerBuilder application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

You can download free trial version of ByteScout Barcode Suite from our website to see and try many others source code samples for SAP PowerBuilder.

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