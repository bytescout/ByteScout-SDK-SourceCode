## How to change fore and back color in VBScript and ByteScout Barcode SDK

### The tutorial shows how to change fore and back color in VBScript

Every ByteScout tool contains example VBScript source codes that you can find here or in the folder with installed ByteScout product. ByteScout Barcode SDK is the robost library (Software Development Kit) that is designed for automatic generation of high-quality barcodes for printing, electronic documents and pdf. All popular barcode types are supported from Code 39 and Code 129 to QR Code, UPC, GS1, GS-128, Datamatrix, PDF417, Maxicode and many others. Provides support for full customization of fonts, colors, output and printing sizes. Special tools are included to verify output quality and printing quality. Can add generated barcode into new or existing documents, images and PDF. It can change fore and back color in VBScript.

VBScript code samples for VBScript developers help to speed up coding of your application when using ByteScout Barcode SDK. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Test VBScript sample code examples whether they respond your needs and requirements for the project.

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

##### ****BarCodeWithCustomColor.vbs:**
    
```

Set bc = CreateObject("Bytescout.BarCode.Barcode")

' set symbology to Code39
bc.Symbology = 1 ' 1 = Code39 symbology type

' set barcode value to encode
bc.Value = "012345" 

bc.SetForeColorRGB 255,255,0
bc.SetBackColorRGB 0,0,0

bc.SaveImage "CustomColor.png"

Set bc = Nothing

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "CustomColor.png", 1, false
Set shell = Nothing

```

<!-- code block end -->