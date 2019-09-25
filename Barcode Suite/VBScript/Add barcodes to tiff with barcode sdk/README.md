## How to add barcodes to tiff with barcode sdk in VBScript and ByteScout Barcode Suite

### Step-by-step tutorial on how to add barcodes to tiff with barcode sdk in VBScript

The coding instructions are formulated to help you to try-out the features without the requirement to write your own code. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can be applied to add barcodes to tiff with barcode sdk using VBScript.

This prolific sample source code in VBScript for ByteScout Barcode Suite contains various functions and other necessary options you should do calling the API to add barcodes to tiff with barcode sdk. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Enjoy writing a code with ready-to-use sample codes in VBScript.

Trial version of ByteScout Barcode Suite is available for free. Source code samples are included to help you with your VBScript app.

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