## How to generate barcode with multiline caption in VBScript using ByteScout Barcode SDK

### Learn to code in VBScript to generate barcode with multiline caption with this step-by-step tutorial

An easy to understand sample source code to learn how to generate barcode with multiline caption in VBScript ByteScout Barcode SDK is the robost SDK that generates high quality barcode images and pdf. Can generate all popular types of barcodes from QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix to more exotic barcode types. Fully customizable fonts, colors, print sizes. Includes special functions to ensure output quality, and tools for adding barcodes to new or existing pdf files and images. It can be applied to generate barcode with multiline caption using VBScript.

Want to quickly learn? This fast application programming interfaces of ByteScout Barcode SDK for VBScript plus the guidelines and the code below will help you quickly learn how to generate barcode with multiline caption.  Simply copy and paste in your VBScript project or application you and then run your app! Enjoy writing a code with ready-to-use sample codes in VBScript.

ByteScout Barcode SDK free trial version is available on our website. VBScript and other programming languages are supported.

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

##### **GenerateBarcode.vbs:**
    
```
Set BC = CreateObject("Bytescout.BarCode.Barcode")

' Set barcode value to encode
BC.Value = "(01)07046261398572(17)130331(10)TEST5632(21)19067811811"

' set symbology to GS1-Datamatrix
BC.Symbology = 37

' Set additional caption and it's position
BC.AdditionalCaption = "(01)07046261398572" & Chr(10) & "(17)130331" & Chr(10) & "(10)TEST5632" & Chr(10) & "(21)19067811811"
BC.AdditionalCaptionPosition = 3

' Set path and save output image
Path = "result.png"
BC.SaveImage (Path)

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run (Path), 1, false
Set shell = Nothing

Set bc = Nothing
```

<!-- code block end -->