## How to generate barcode image in ASP Classic using ByteScout Barcode SDK

### The tutorial shows how to generate barcode image in ASP Classic

The coding tutorials are designed to help you test the features without need to write your own code. ByteScout Barcode SDK is the fully featured library to generate barcodes. Supports QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix and many other barcode types. Includes various options for barcode generation to ensure output quality, add barcodes to new or existing pdf files and images and you can use it to generate barcode image with ASP Classic.

You will save a lot of time on writing and testing code as you may just take the ASP Classic code from ByteScout Barcode SDK for generate barcode image below and use it in your application. Follow the instructions from the scratch to work and copy the ASP Classic code. You can use these ASP Classic sample examples in one or many applications.

Download free trial version of ByteScout Barcode SDK from our website with this and other source code samples for ASP Classic.

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

##### ****GenerateBarcode.asp:**
    
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
bc.RegistrationName="demo"
bc.RegistrationKey="demo"

' set barcode type to Datamatrix
bc.Symbology = 15 ' 15 = DataMatrix

' set barcode value to encode
bc.Value = "http://www.bytescout.com"

' generate and get barcode image as PNG image array of bytes
 BarCodeImage = bc.GetImageBytesPNG

 response.ContentType = "image/png"

 ' add content type header 
 response.AddHeader "Content-Type", "image/png"

 ' set the content disposition
 response.AddHeader "Content-Disposition", "inline;filename=BarCode.png" 

 ' write the binary image to the Response output stream 
 response.BinaryWrite BarCodeImage
 response.End

' disconnect from libraries
Set bc = Nothing

%>

```

<!-- code block end -->