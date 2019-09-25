## How to create spreadsheet with spreadsheet sdk in JavaScript using ByteScout Barcode Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to create spreadsheet with spreadsheet sdk in JavaScript

This sample source code below will display you how to create spreadsheet with spreadsheet sdk in JavaScript. ByteScout Barcode Suite can create spreadsheet with spreadsheet sdk. It can be applied from JavaScript. ByteScout Barcode Suite is the bundle that privides 3  SDK products to generate barcodes (Barcode SDK), read barcodes (Barcode Reaer SDK) and read and write spreadsheets (Spreadsheet SDK).

The following code snippet for ByteScout Barcode Suite works best when you need to quickly create spreadsheet with spreadsheet sdk in your JavaScript application. Just copy and paste the code into your JavaScript application’s code and follow the instructions. Want to see how it works with your data then code testing will allow the function to be tested and work properly.

Trial version of ByteScout Barcode Suite is available for free. Source code samples are included to help you with your JavaScript app.

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

##### ****HelloWorld.js:**
    
```
var document = WScript.CreateObject('Bytescout.Spreadsheet.Spreadsheet');

// Add new worksheet
var worksheet = document.Workbook.Worksheets.Add("HelloWorld");

// get cell value
var cell = worksheet.Item(0,0); // you can also use worksheet.Cell("A1") as well

// set cell value
cell.Value = "Hello, World!";

// delete output file if exists already
var fso = WScript.CreateObject('Scripting.FileSystemObject');
if (fso.FileExists('Output.xls')) { fso.DeleteFile('Output.xls'); }
fso = null;

// save document
document.SaveAs ('Output.xls');

// close Spreadsheet
document = null

```

<!-- code block end -->