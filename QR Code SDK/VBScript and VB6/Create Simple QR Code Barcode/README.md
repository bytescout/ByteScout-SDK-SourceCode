## How to create simple QR code barcode in VBScript and VB6 and ByteScout QR Code

### Write code in VBScript and VB6 to create simple QR code barcode with this step-by-step tutorial

The code below will help you to implement an VBScript and VB6 app to create simple QR code barcode. ByteScout QR Code can create simple QR code barcode. It can be used from VBScript and VB6. ByteScout QR Code is QR Code barcode generator SDK with tunnable quality and features like QR Code embedded logo or images. Supports batch generation and specialized features like encoding of vCard and other structures inside QR Code barcodes.

The SDK samples like this one below explain how to quickly make your application do create simple QR code barcode in VBScript and VB6 with the help of ByteScout QR Code. This VBScript and VB6 sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Further enhancement of the code will make it more vigorous.

You can download free trial version of ByteScout QR Code from our website to see and try many others source code samples for VBScript and VB6.

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

##### ****GeneralExample.vbs:**
    
```
' Create and activate QRCode instance
Set barcode = CreateObject("Bytescout.BarCode.QRCode")
barcode.RegistrationName = "demo"
barcode.RegistrationKey = "demo"

' Set barcode value
barcode.Value = "ABCDEFGHIJKLMNOPQRSTUVWXYZ abcdefghijklmnopqrstuvwxyz 1234567890"

' Uncomment if you don't need margins
'barcode.SetMargins 0, 0, 0, 0
'barcode.DrawQuietZones = False

' Save barcode image to file
barcode.SaveImage("result.png")

' Open the image in default image viewer (for demo purpose)
Set shell = CreateObject("WScript.Shell")
shell.Run "result.png", 1, false
Set shell = Nothing

Set barcode = Nothing

```

<!-- code block end -->