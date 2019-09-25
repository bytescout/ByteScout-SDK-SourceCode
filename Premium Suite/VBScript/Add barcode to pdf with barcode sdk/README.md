## How to add barcode to pdf with barcode sdk in VBScript and ByteScout Premium Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to add barcode to pdf with barcode sdk in VBScript

The sample source codes on this page shows how to add barcode to pdf with barcode sdk in VBScript. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can be applied to add barcode to pdf with barcode sdk using VBScript.

Want to quickly learn? This fast application programming interfaces of ByteScout Premium Suite for VBScript plus the guidelines and the code below will help you quickly learn how to add barcode to pdf with barcode sdk. Just copy and paste the code into your VBScript application’s code and follow the instructions. Enjoy writing a code with ready-to-use sample VBScript codes.

The trial version of ByteScout Premium Suite can be downloaded for free from our website. It also includes source code samples for VBScript and other programming languages.

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