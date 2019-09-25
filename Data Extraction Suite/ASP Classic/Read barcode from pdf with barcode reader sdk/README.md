## How to read barcode from pdf with barcode reader sdk in ASP Classic with ByteScout Data Extraction Suite

### Step-by-step tutorial on how to read barcode from pdf with barcode reader sdk in ASP Classic

Every ByteScout tool includes simple example ASP Classic source codes that you can get here or in the folder with installed ByteScout product. ByteScout Data Extraction Suite can read barcode from pdf with barcode reader sdk. It can be applied from ASP Classic. ByteScout Data Extraction Suite is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK.

This prolific sample source code in ASP Classic for ByteScout Data Extraction Suite contains various functions and other necessary options you should do calling the API to read barcode from pdf with barcode reader sdk. Just copy and paste the code into your ASP Classic application’s code and follow the instructions. Applying ASP Classic application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

The trial version of ByteScout Data Extraction Suite can be downloaded for free from our website. It also includes source code samples for ASP Classic and other programming languages.

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