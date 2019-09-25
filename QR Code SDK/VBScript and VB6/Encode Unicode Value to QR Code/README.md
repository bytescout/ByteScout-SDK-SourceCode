## encode unicode value to QR code in VBScript and VB6 and ByteScout QR Code

### How to code encode unicode value to QR code in VBScript and VB6: How-To tutorial

Every ByteScout tool contains example VBScript and VB6 source codes that you can find here or in the folder with installed ByteScout product. ByteScout QR Code was made to help with encode unicode value to QR code in VBScript and VB6. ByteScout QR Code is QR Code barcode generator SDK with tunnable quality and features like QR Code embedded logo or images. Supports batch generation and specialized features like encoding of vCard and other structures inside QR Code barcodes.

VBScript and VB6 code snippet like this for ByteScout QR Code works best when you need to quickly implement encode unicode value to QR code in your VBScript and VB6 application. This VBScript and VB6 sample code should be copied and pasted into your application’s code editor. Then just compile and run it to see how it works. Enjoy writing a code with ready-to-use sample VBScript and VB6 codes to implement encode unicode value to QR code using ByteScout QR Code.

ByteScout QR Code free trial version is available for download from our website. Free trial also includes programming tutorials along with source code samples.

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

##### ****UnicodeValue.vbs:**
    
```
' Create and activate QRCode instance
Set barcode = CreateObject("Bytescout.BarCode.QRCode")
barcode.RegistrationName = "demo"
barcode.RegistrationKey = "demo"

' Set barcode value
barcode.Value = "ABCDEFGHIJKLMNOPQRSTUVWXYZ abcdefghijklmnopqrstuvwxyz 1234567890"

' Set the character encoding to UTF-16
barcode.SetCharacterEncoding "utf-16"

' Set Unicode barcode value
barcode.Value = "日本"

' Show barcode caption (optional)
barcode.DrawCaption = True

' Save barcode image to file
barcode.SaveImage("result.png")

' Open the image in default image viewer (for demo purpose)
Set shell = CreateObject("WScript.Shell")
shell.Run "result.png", 1, false
Set shell = Nothing

Set barcode = Nothing

```

<!-- code block end -->