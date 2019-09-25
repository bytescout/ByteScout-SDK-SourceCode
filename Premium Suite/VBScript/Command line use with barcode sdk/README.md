## How to command line use with barcode sdk in VBScript with ByteScout Premium Suite

### This code in VBScript shows how to command line use with barcode sdk with this how to tutorial

Quickly learn how to command line use with barcode sdk in VBScript with this sample source code. ByteScout Premium Suite can command line use with barcode sdk. It can be applied from VBScript. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout Premium Suite. Just copy and paste the code into your VBScript application’s code and follow the instructions. Enjoy writing a code with ready-to-use sample VBScript codes.

If you want to try other source code samples then the free trial version of ByteScout Premium Suite is available for download from our website. Just try other source code samples for VBScript.

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