## How to make QR code with embedded image in VBScript and VB6 using ByteScout QR Code

### Tutorial on how to make QR code with embedded image in VBScript and VB6

Learn how to make QR code with embedded image in VBScript and VB6 with this source code sample. ByteScout QR Code is QR Code barcode generator SDK with tunnable quality and features like QR Code embedded logo or images. Supports batch generation and specialized features like encoding of vCard and other structures inside QR Code barcodes. It can make QR code with embedded image in VBScript and VB6.

The SDK samples like this one below explain how to quickly make your application do make QR code with embedded image in VBScript and VB6 with the help of ByteScout QR Code. Just copy and paste the code into your VBScript and VB6 application’s code and follow the instruction. Detailed tutorials and documentation are available along with installed ByteScout QR Code if you'd like to dive deeper into the topic and the details of the API.

Trial version of ByteScout QR Code can be downloaded for free from our website. It also includes source code samples for VBScript and VB6 and other programming languages.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20QR%20Code%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20QR%20Code%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=A5hB9ul3tX0](https://www.youtube.com/watch?v=A5hB9ul3tX0)




<!-- code block begin -->

##### ****QRCodeWithImage.vbs:**
    
```
' Create and activate QRCode instance
Set barcode = CreateObject("Bytescout.BarCode.QRCode")
barcode.RegistrationName = "demo"
barcode.RegistrationKey = "demo"

' Set high QR Code error correction level
barcode.QROption_ErrorCorrectionLevel = 3 ' 3 = QRErrorCorrectionLevel.High

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