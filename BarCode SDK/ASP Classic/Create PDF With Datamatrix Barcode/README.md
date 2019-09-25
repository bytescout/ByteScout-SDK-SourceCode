## How to create PDF with datamatrix barcode in ASP Classic using ByteScout Barcode SDK

### Tutorial on how to create PDF with datamatrix barcode in ASP Classic

On this page you will learn from code samples for programming in ASP Classic.Writing of the code to create PDF with datamatrix barcode in ASP Classic can be done by developers of any level using ByteScout Barcode SDK. ByteScout Barcode SDK is the fully featured library to generate barcodes. Supports QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix and many other barcode types. Includes various options for barcode generation to ensure output quality, add barcodes to new or existing pdf files and images. It can be used to create PDF with datamatrix barcode using ASP Classic.

Fast application programming interfaces of ByteScout Barcode SDK for ASP Classic plus the instruction and the code below will help you quickly learn how to create PDF with datamatrix barcode. Follow the instructions from the scratch to work and copy the ASP Classic code. Enjoy writing a code with ready-to-use sample codes in ASP Classic.

Free trial version of ByteScout Barcode SDK is available on our website. Documentation and source code samples are included.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=REnj3A-oSPI](https://www.youtube.com/watch?v=REnj3A-oSPI)




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