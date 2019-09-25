## QR code barcode with image inside in VBScript and ByteScout Barcode SDK

### How To: tutorial on QR code barcode with image inside in VBScript

Today you are going to learn how to QR code barcode with image inside in VBScript. ByteScout Barcode SDK was made to help with QR code barcode with image inside in VBScript. ByteScout Barcode SDK is the fully featured library to generate barcodes. Supports QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix and many other barcode types. Includes various options for barcode generation to ensure output quality, add barcodes to new or existing pdf files and images.

You will save a lot of time on writing and testing code as you may just take the code below and use it in your application. To do QR code barcode with image inside in your VBScript project or application you may simply copy & paste the code and then run your app! This basic programming language sample code for VBScript will do the whole work for you in implementing QR code barcode with image inside in your app.

ByteScout Barcode SDK is available as free trial. You may get it from our website along with all other source code samples for VBScript applications.

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

##### ****QRCodeWithImage.vbs:**
    
```
' Create and activate barcode generator instance
Set barcode = CreateObject("Bytescout.BarCode.Barcode")
barcode.RegistrationName = "demo"
barcode.RegistrationKey = "demo"

' Set barcode type
barcode.Symbology = 16 ' 16 = QRCode symbology

' Set high QR Code error correction level
barcode.Options.QRErrorCorrectionLevel = 3 ' 3 = QRErrorCorrectionLevel.High

' Set barcode value
barcode.Value = "1234567890 abcdefghijklmnopqrstuvwxyz 1234567890 abcdefghijklmnopqrstuvwxyz"

' Add decoration image and scale it to 15% of the barcode square
barcode.AddDecorationImage ".\logo.png", 15

barcode.SaveImage "result.png"

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.png", 1, false
Set shell = Nothing

Set barcode = Nothing

```

<!-- code block end -->