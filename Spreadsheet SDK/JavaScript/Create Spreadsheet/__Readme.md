## How to create spreadsheet in JavaScript and ByteScout Spreadsheet SDK

### Tutorial on how to create spreadsheet in JavaScript

This sample source code below will demonstrate you how to create spreadsheet in JavaScript. Want to create spreadsheet in your JavaScript app? ByteScout Spreadsheet SDK is designed for it. ByteScout Spreadsheet SDK is the SDK to create, read, modify and calculate spreadsheets. Formula calculations are supported, import and export to and from JSON, CSV, XML, databases, arrays.

This code snippet below for ByteScout Spreadsheet SDK works best when you need to quickly create spreadsheet in your JavaScript application. In order to implement the functionality, you should copy and paste this code for JavaScript below into your code editor with your app, compile and run your application. Code testing will allow the function to be tested and work properly with your data.

You can download free trial version of ByteScout Spreadsheet SDK from our website to see and try many others source code samples for JavaScript.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Spreadsheet%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Spreadsheet%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=nm_7I0PN1TY](https://www.youtube.com/watch?v=nm_7I0PN1TY)




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