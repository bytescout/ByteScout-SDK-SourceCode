## How to command line use in VBScript and ByteScout Barcode SDK

### This code in VBScript shows how to command line use with this how to tutorial

These source code samples are listed and grouped by their programming language and functions they use. Want to command line use in your VBScript app? ByteScout Barcode SDK is designed for it. ByteScout Barcode SDK is the robost SDK that generates high quality barcode images and pdf. Can generate all popular types of barcodes from QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix to more exotic barcode types. Fully customizable fonts, colors, print sizes. Includes special functions to ensure output quality, and tools for adding barcodes to new or existing pdf files and images.

This rich sample source code in VBScript for ByteScout Barcode SDK includes the number of functions and options you should do calling the API to command line use. In your VBScript project or application you may simply copy & paste the code and then run your app! Further enhancement of the code will make it more vigorous.

Trial version of ByteScout Barcode SDK is available for free. Source code samples are included to help you with your VBScript app.

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

##### ****GenerateQRCode.vbs:**
    
```
if WScript.Arguments.Count < 1 Then
    WScript.Echo "Set barcode value as command line parameter: " & vbCRLF & vbCRLF & "GenerateQRCode.vbs <value>"
    WScript.Quit 0
End If

' Create and activate QRCode instance
Set barcode = CreateObject("Bytescout.BarCode.Barcode")
barcode.RegistrationName = "demo"
barcode.RegistrationKey = "demo"

' Set barcode type
barcode.Symbology = 16 ' 16 = QRCode symbology

' Set barcode value from the command line parameter
barcode.Value = WScript.Arguments(0)

' Save barcode image to file
barcode.SaveImage("result.png")

Set barcode = Nothing

```

<!-- code block end -->    

<!-- code block begin -->

##### ****run.bat:**
    
```
REM running from the command line
cscript.exe GenerateQRCode.vbs "ABCDEFGHIJKLMNOP1234567890"
pause
```

<!-- code block end -->