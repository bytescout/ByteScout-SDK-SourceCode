## How to add barcodes to new pdf with barcode sdk in VBScript with ByteScout Barcode Suite

### How to write a robust code in VBScript to add barcodes to new pdf with barcode sdk with this step-by-step tutorial

These source code samples are assembled by their programming language and functions they apply. ByteScout Barcode Suite can add barcodes to new pdf with barcode sdk. It can be applied from VBScript. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK.

The SDK samples given below describe how to quickly make your application do add barcodes to new pdf with barcode sdk in VBScript with the help of ByteScout Barcode Suite.  Simply copy and paste in your VBScript project or application you and then run your app! Enjoy writing a code with ready-to-use sample VBScript codes.

ByteScout provides the free trial version of ByteScout Barcode Suite along with the documentation and source code samples.

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

' Place barcode at top-right corner of every document page
barcode.DrawToNewPDF "barcode.pdf", 595,842, 500, 50

' Open the output file in default PDF viewer.
Set shell = CreateObject("WScript.Shell")
shell.Run "barcode.pdf", 1, false
Set shell = Nothing

Set barcode = Nothing


```

<!-- code block end -->