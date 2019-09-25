## How to generate xls spreadsheet with spreadsheet sdk in ASP Classic using ByteScout Data Extraction Suite

### If you want to learn more then this tutorial will show how to generate xls spreadsheet with spreadsheet sdk in ASP Classic

An easy to understand guide on how to generate xls spreadsheet with spreadsheet sdk in ASP Classic with this source code sample. ByteScout Data Extraction Suite is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK. It can be applied to generate xls spreadsheet with spreadsheet sdk using ASP Classic.

The following code snippet for ByteScout Data Extraction Suite works best when you need to quickly generate xls spreadsheet with spreadsheet sdk in your ASP Classic application. IF you want to implement the functionality, just copy and paste this code for ASP Classic below into your code editor with your app, compile and run your application. This basic programming language sample code for ASP Classic will do the whole work for you to generate xls spreadsheet with spreadsheet sdk.

ByteScout provides the free trial version of ByteScout Data Extraction Suite along with the documentation and source code samples.

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

##### ****GenerateXLS.asp:**
    
```
<%

' In case of "Server.CreateObject Failed", "Server object error "ASP 0177 : 8000ffff" or similar errors:
' Please try the following:
' - Open IIS 
' - Find application pools (DefaultAppPool is used by default)
' - Open its properties and check .NET CLR version selected:
' - if you have  .NET 1.1 then change to .NET CLR 2.00
' - if you have .NET CLR 2.00 then try to change to .NET CLR 4.0


Set document = Server.CreateObject("Bytescout.Spreadsheet.Spreadsheet")

 ' Add new worksheet
Set worksheet = document.Workbook.Worksheets.Add("HelloWorld")

' Get cell value
Set cell = worksheet.Item(0,0) ' You can also use worksheet.Cell("A1") as well

' Set cell value
cell.Value = "Hello, World!"

' Generate and get XLS document as an array of bytes
XLSDocumentArray = document.GetAsBytesArrayXLS

response.ContentType = "vnd.ms-excel"

' Add content type header 
response.AddHeader "Content-Type", "application/vnd.ms-excel"

' Set the content disposition
response.AddHeader "Content-Disposition", "inline;filename=HelloWorld.xls" 

' Write the binary image to the Response output stream 
response.BinaryWrite XLSDocumentArray
response.End

' Release library
Set document = Nothing

%>

```

<!-- code block end -->