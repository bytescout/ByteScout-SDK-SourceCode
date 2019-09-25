## qr code barcode with image inside with barcode sdk in VBScript with ByteScout Premium Suite

### Learn to code in VBScript to make qr code barcode with image inside with barcode sdk with this simple How-To tutorial

These sample source codes given below will show you how to handle a complex task, for example, qr code barcode with image inside with barcode sdk in VBScript. Qr code barcode with image inside with barcode sdk in VBScript can be applied with ByteScout Premium Suite. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

VBScript code snippet like this for ByteScout Premium Suite works best when you need to quickly implement qr code barcode with image inside with barcode sdk in your VBScript application.  Just copy and paste this VBScript sample code to your VBScript application's code editor, add a reference to ByteScout Premium Suite (if you haven't added yet) and you are ready to go! Enjoy writing a code with ready-to-use sample VBScript codes to implement qr code barcode with image inside with barcode sdk using ByteScout Premium Suite.

 If you want to try other samples for VBScript then free trial version of ByteScout Premium Suite is available on our website.

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