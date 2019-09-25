## How to create gs1 QR code in VBScript and VB6 with ByteScout QR Code

### This code in VBScript and VB6 shows how to create gs1 QR code with this how to tutorial

The code below will help you to implement an VBScript and VB6 app to create gs1 QR code. ByteScout QR Code is QR Code generation library. It provides full control on the quality, features and encoding. Can embed logo image right into QR Code itself. Batch barcode generation, and many special features like vCard or URL encoding are also supported. It can be used to create gs1 QR code using VBScript and VB6.

Fast application programming interfaces of ByteScout QR Code for VBScript and VB6 plus the instruction and the code below will help you quickly learn how to create gs1 QR code. Follow the instructions from the scratch to work and copy the VBScript and VB6 code. Implementing VBScript and VB6 application typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

Free trial version of ByteScout QR Code is available for download from our website. Get it to try other source code samples for VBScript and VB6.

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

##### ****GS1QRCode.vbs:**
    
```
' Create and activate QRCode instance
Set barcode = CreateObject("Bytescout.BarCode.QRCode")
barcode.RegistrationName = "demo"
barcode.RegistrationKey = "demo"

' Enable generation of GS1 version of QR Code
barcode.IsGS1 = True

' Set value that is formatted according to GS1 specification
barcode.Value = "(01)07046261398572(17)130331(10)TEST5632(21)19067811811"

' Save barcode image to file
barcode.SaveImage("result.png")

' Open the image in default image viewer (for demo purpose)
Set shell = CreateObject("WScript.Shell")
shell.Run "result.png", 1, false
Set shell = Nothing

Set barcode = Nothing

```

<!-- code block end -->