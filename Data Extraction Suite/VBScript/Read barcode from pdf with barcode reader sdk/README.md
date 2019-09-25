## How to read barcode from pdf with barcode reader sdk in VBScript and ByteScout Data Extraction Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to read barcode from pdf with barcode reader sdk in VBScript

We made thousands of pre-made source code pieces for easy implementation in your own programming projects. ByteScout Data Extraction Suite is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK and you can use it to read barcode from pdf with barcode reader sdk with VBScript.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout Data Extraction Suite. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Want to see how it works with your data then code testing will allow the function to be tested and work properly.

If you want to try other source code samples then the free trial version of ByteScout Data Extraction Suite is available for download from our website. Just try other source code samples for VBScript.

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

##### ****TestBarcodeReadingFromPDF.vbs:**
    
```
Set bc = CreateObject("Bytescout.BarCodeReader.Reader")

' Limit search to 1D barcodes only (exclude 2D barcodes to speed up the search).
' Change to bc.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcodes 
' or select specific type, e.g. bc.BarcodeTypesToFind.PDF417 = True
bc.BarcodeTypesToFind.SetAll1D()

' Reading barcode from PDF
bc.ReadFromFile "example.pdf"

' Iterate throuhg all found barcodes
For i = 0 To bc.FoundCount - 1
     Msgbox "Found barcode on page #" & CStr(bc.GetFoundBarcodePage(i)) & " with type " & Cstr(bc.GetFoundBarcodeType(i)) & " and value " & bc.GetFoundBarcodeValue(i)
Next

Set bc = Nothing

```

<!-- code block end -->