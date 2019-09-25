## How to create PDF with datamatrix barcode with barcode SDK in ASP Classic with ByteScout Barcode Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to create PDF with datamatrix barcode with barcode SDK in ASP Classic

The sample source code below will teach you how to create PDF with datamatrix barcode with barcode SDK in ASP Classic. What is ByteScout Barcode Suite? It is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can help you to create PDF with datamatrix barcode with barcode SDK in your ASP Classic application.

Want to save time? You will save a lot of time on writing and testing code as you may just take the ASP Classic code from ByteScout Barcode Suite for create PDF with datamatrix barcode with barcode SDK below and use it in your application. Just copy and paste the code into your ASP Classic application’s code and follow the instructions. Enjoy writing a code with ready-to-use sample ASP Classic codes.

The trial version of ByteScout Barcode Suite can be downloaded for free from our website. It also includes source code samples for ASP Classic and other programming languages.

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

##### ****CreatePDFWithBarcode.asp:**
    
```
<%

' In case of "Server.CreateObject Failed", "Server object error "ASP 0177 : 8000ffff" or similar errors:
' Please try the following:
' - Open IIS 
' - Find application pools (DefaultAppPool is used by default)
' - Open its properties and check .NET CLR version selected:
' - if you have  .NET 1.1 then change to .NET CLR 2.00
' - if you have .NET CLR 2.00 then try to change to .NET CLR 4.0


Set bc = Server.CreateObject("Bytescout.BarCode.Barcode")

' set symbology to Datamatrix
bc.Symbology = 15 ' 15 = DataMatrix symbology type

' set barcode value to encode
bc.Value = "http://www.bytescout.com"

' Place barcode at top-left corner of every document page
barcode.DrawToPDF "..\wikipedia.pdf", -1, 10, 10, "result.pdf"

 PDFImage = bc.BinaryImage

 response.ContentType = "application/pdf"

 ' add content type header 
 response.AddHeader "Content-Type", "application/pdf"

 ' set the content disposition
 response.AddHeader "Content-Disposition", "inline;filename=HelloWorld.pdf"

 ' write the binary image to the Response output stream 
 response.BinaryWrite PDFImage
 response.End


' disconnect from libraries
Set bc = Nothing

%>

```

<!-- code block end -->