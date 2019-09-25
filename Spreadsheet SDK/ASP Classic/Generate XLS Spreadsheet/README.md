## How to generate XLS spreadsheet in ASP Classic with ByteScout Spreadsheet SDK

### How to code in ASP Classic to generate XLS spreadsheet with this step-by-step tutorial

The sample source codes on this page shows how to generate XLS spreadsheet in ASP Classic. ByteScout Spreadsheet SDK is the SDK to create, read, modify and calculate spreadsheets. Formula calculations are supported, import and export to and from JSON, CSV, XML, databases, arrays. It can generate XLS spreadsheet in ASP Classic.

You will save a lot of time on writing and testing code as you may just take the ASP Classic code from ByteScout Spreadsheet SDK for generate XLS spreadsheet below and use it in your application. Follow the instructions from the scratch to work and copy the ASP Classic code. This basic programming language sample code for ASP Classic will do the whole work for you to generate XLS spreadsheet.

Free trial version of ByteScout Spreadsheet SDK is available on our website. Documentation and source code samples are included.

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