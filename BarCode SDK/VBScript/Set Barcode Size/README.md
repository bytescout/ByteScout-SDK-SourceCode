## How to set barcode size in VBScript and ByteScout Barcode SDK

### This tutorial will show how to set barcode size in VBScript

On this page you will learn from code samples for programming in VBScript.Writing of the code to set barcode size in VBScript can be done by developers of any level using ByteScout Barcode SDK. ByteScout Barcode SDK: the robost library (Software Development Kit) that is designed for automatic generation of high-quality barcodes for printing, electronic documents and pdf. All popular barcode types are supported from Code 39 and Code 129 to QR Code, UPC, GS1, GS-128, Datamatrix, PDF417, Maxicode and many others. Provides support for full customization of fonts, colors, output and printing sizes. Special tools are included to verify output quality and printing quality. Can add generated barcode into new or existing documents, images and PDF. It can set barcode size in VBScript.

This code snippet below for ByteScout Barcode SDK works best when you need to quickly set barcode size in your VBScript application. Just copy and paste the code into your VBScript application’s code and follow the instruction. This basic programming language sample code for VBScript will do the whole work for you to set barcode size.

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

##### ****FitInto.vbs:**
    
```
Set bc = CreateObject("Bytescout.BarCode.Barcode")

' Display information about Code39 symbology

msgbox "Easiest way to specify barcode size is to use FitInto_3(width, height, unitOfMeasure) method." & vbCRLF & "Let's generate barcode of 500x300 pixels."

' Set symbology to Code39
bc.Symbology = 1 ' 1 = Code39 symbology type

' Set barcode value to encode
bc.Value = "012345"

' Set barcode size by specifying dimensions the barcode will be fit into.
' 3rd parameter is the unit of measure: 0 - Pixel, 1 - Point (1/72 inch), 2 - Inch, 3 - document unit (1/300 inch), 4 - Millimeter, 5 - Centimeter, 6 - Twip(1/20 inch).
' We use 3rd parameter as 0 (Pixel).
bc.FitInto_3 500, 300, 0

msgbox "Generated barcode is saved into 'result.png' file"

bc.SaveImage "result.png"

Set bc = Nothing


' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.png", 1, false
Set shell = Nothing

```

<!-- code block end -->