## How to generate xls spreadsheet with spreadsheet sdk in ASP Classic and ByteScout Barcode Suite

### Learn to code in ASP Classic to generate xls spreadsheet with spreadsheet sdk with this step-by-step tutorial

ByteScout simple and easy to understand tutorials are planned to describe the code for both ASP Classic beginners and advanced programmers. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can be applied to generate xls spreadsheet with spreadsheet sdk using ASP Classic.

Want to quickly learn? This fast application programming interfaces of ByteScout Barcode Suite for ASP Classic plus the guidelines and the code below will help you quickly learn how to generate xls spreadsheet with spreadsheet sdk. Just copy and paste the code into your ASP Classic application’s code and follow the instructions. This basic programming language sample code for ASP Classic will do the whole work for you to generate xls spreadsheet with spreadsheet sdk.

Our website gives trial version of ByteScout Barcode Suite for free. It also includes documentation and source code samples.

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