## How to print barcodes in VBScript using ByteScout Barcode SDK What is ByteScout Barcode SDK? It is the robost SDK that generates high quality barcode images and pdf. Can generate all popular types of barcodes from QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix to more exotic barcode types. Fully customizable fonts, colors, print sizes. Includes special functions to ensure output quality, and tools for adding barcodes to new or existing pdf files and images.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore Documentation](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Explore Source Code Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://app.pdf.co/signup?utm_source=github-readme)
[Security](https://pdf.co/security)
[Explore Web API Documentation](https://apidocs.pdf.co?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=REnj3A-oSPI](https://www.youtube.com/watch?v=REnj3A-oSPI)




<!-- code block begin -->

##### **PrintBarcodes.vbs:**
    
```
' This example demonstrates generation and printing of multiple barcodes

' Prepare Barcode object that will generate barcodes for printing
Set barcode = CreateObject("Bytescout.BarCode.Barcode")
barcode.RegistrationName = "demo"
barcode.RegistrationKey = "demo"
barcode.Symbology = 9 ' EAN13
barcode.DrawCaption = True
barcode.BarHeight = 50
barcode.DrawQuietZones = False
barcode.SetMargins 20, 20, 20, 20, 0

' Prepare BarcodePrinter object
Set barcodePrinter = CreateObject("Bytescout.BarCode.BarcodePrinter")
' Set printer paper size
barcodePrinter.SetPaperSize "A4" 
' Set number of barcodes on a page: 4 lines of 4 barcodes per line = 16 barcodes per page
barcodePrinter.SetGrid 4, 4
' Fit barcodes into the grid cell size
barcodePrinter.FitBarcodesIntoGrid = True
' Set some optional printing params
'barcodePrinter.SetMargins 20, 0, 0, 20
'barcodePrinter.Copies = 2
'barcodePrinter.Collate = True
'barcodePrinter.Color = False


' Generate 25 barcode values in EAN13 format "5901234NNNNN"
' and add them to the BarcodePrinter
For i = 1 To 25
    value = "5901234" + LeftPadding(CStr(i), "0", 5)
    barcodePrinter.AddBarcodeValue value
Next


' Print barcodes to the specified printer 
barcodePrinter.Print (barcode), "Microsoft Print to PDF"


' Function that returns a new string of a specified length in which the beginning of the current string 
' is padded with a specified character.
Private Function LeftPadding(str, paddingChar, length)
    LeftPadding = String(length - Len(str), paddingChar) & str
End Function

```

<!-- code block end -->