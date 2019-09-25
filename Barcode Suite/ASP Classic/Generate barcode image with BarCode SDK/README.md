## How to generate barcode image with barcode SDK in ASP Classic using ByteScout Barcode Suite

### This code in ASP Classic shows how to generate barcode image with barcode SDK with this how to tutorial

Generate barcode image with barcode SDK is simple to apply in ASP Classic if you use these source codes below. ByteScout Barcode Suite: the bundle that privides 3  SDK products to generate barcodes (Barcode SDK), read barcodes (Barcode Reaer SDK) and read and write spreadsheets (Spreadsheet SDK). It can generate barcode image with barcode SDK in ASP Classic.

The SDK samples given below describe how to quickly make your application do generate barcode image with barcode SDK in ASP Classic with the help of ByteScout Barcode Suite. This ASP Classic sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Further improvement of the code will make it more robust.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

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