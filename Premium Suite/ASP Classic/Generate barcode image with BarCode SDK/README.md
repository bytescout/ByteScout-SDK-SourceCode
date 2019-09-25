## How to generate barcode image with barcode SDK in ASP Classic with ByteScout Premium Suite

### Step-by-step tutorial on how to generate barcode image with barcode SDK in ASP Classic

The coding instructions are formulated to help you to try-out the features without the requirement to write your own code. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can generate barcode image with barcode SDK in ASP Classic.

 These ASP Classic code samples for ASP Classic guide developers to speed up coding of the application when using ByteScout Premium Suite. IF you want to implement the functionality, just copy and paste this code for ASP Classic below into your code editor with your app, compile and run your application. Enjoy writing a code with ready-to-use sample ASP Classic codes.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

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