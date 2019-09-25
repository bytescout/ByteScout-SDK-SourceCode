## How to read barcode from pdf with barcode reader sdk in ASP Classic with ByteScout Premium Suite

### How to write a robust code in ASP Classic to read barcode from pdf with barcode reader sdk with this step-by-step tutorial

On this page you will learn from code samples for programming in ASP Classic.Writing of the code to read barcode from pdf with barcode reader sdk in ASP Classic can be executed by programmers of any level using ByteScout Premium Suite. ByteScout Premium Suite: the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can read barcode from pdf with barcode reader sdk in ASP Classic.

Want to quickly learn? This fast application programming interfaces of ByteScout Premium Suite for ASP Classic plus the guidelines and the code below will help you quickly learn how to read barcode from pdf with barcode reader sdk. Just copy and paste the code into your ASP Classic application’s code and follow the instructions. If you want to use these ASP Classic sample examples in one or many applications then they can be used easily.

You can download free trial version of ByteScout Premium Suite from our website to see and try many others source code samples for ASP Classic.

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

##### ****TestBarcodeReadingFromPDF.asp:**
    
```
<%

' In case of "Server.CreateObject Failed", "Server object error "ASP 0177 : 8000ffff" or similar errors:
' Please try the following:
' - Open IIS 
' - Find application pools (DefaultAppPool is used by default)
' - Open its properties and check .NET CLR version selected:
' - if you have  .NET 1.1 then change to .NET CLR 2.00
' - if you have .NET CLR 2.00 then try to change to .NET CLR 4.0


Set bc = Server.CreateObject("Bytescout.BarCodeReader.Reader")

' Limit search to 1D barcodes only (exclude 2D barcodes to speed up the search).
' Change to bc.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcodes 
' or select specific type, e.g. bc.BarcodeTypesToFind.PDF417 = True
bc.BarcodeTypesToFind.SetAll1D()

' now reading barcode from temporary saved image (previously extracted from PDF)
bc.ReadFromFile Server.MapPath("example.pdf")

' iterate throuhg all found barcodes on the image
For i = 0 To bc.FoundCount - 1

Response.Write "<br>"
Response.Write "Found barcode on page #" & CStr(bc.GetFoundBarcodePage(i)) & " with type " & Cstr(bc.GetFoundBarcodeType(i)) & " and value " & bc.GetFoundBarcodeValue(i)
Response.Write "<br>"

Next

' empty barcode reader
Set bc = Nothing

%>

```

<!-- code block end -->