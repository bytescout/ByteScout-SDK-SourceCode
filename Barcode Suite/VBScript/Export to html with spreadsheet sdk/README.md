## How to export to html with spreadsheet sdk in VBScript and ByteScout Barcode Suite

### Step-by-step tutorial on how to export to html with spreadsheet sdk in VBScript

The sample source code below will teach you how to export to html with spreadsheet sdk in VBScript. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK and you can use it to export to html with spreadsheet sdk with VBScript.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout Barcode Suite. Just copy and paste the code into your VBScript application’s code and follow the instructions. Enjoy writing a code with ready-to-use sample codes in VBScript.

The trial version of ByteScout Barcode Suite can be downloaded for free from our website. It also includes source code samples for VBScript and other programming languages.

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

##### ****ExcelToHtml.vbs:**
    
```
Set document = CreateObject("Bytescout.Spreadsheet.Spreadsheet")

document.RegistrationName = "demo"
document.RegistrationKey = "demo"

document.LoadFromFile("TestForHtmlExport.xls")

' Export whole document to set of HTML files
document.SaveAsHTML "Document.html"

' Export single worksheet
document.Worksheets.Item(0).SaveAsHTML "Worksheet1.html"


```

<!-- code block end -->