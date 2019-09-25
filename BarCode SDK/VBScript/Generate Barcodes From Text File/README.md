## How to generate barcodes from text file in VBScript and ByteScout Barcode SDK

### Write code in VBScript to generate barcodes from text file with this step-by-step tutorial

The sample shows steps and algorithm of how to generate barcodes from text file and how to make it work in your VBScript application. ByteScout Barcode SDK can generate barcodes from text file. It can be used from VBScript. ByteScout Barcode SDK is the robost library (Software Development Kit) that is designed for automatic generation of high-quality barcodes for printing, electronic documents and pdf. All popular barcode types are supported from Code 39 and Code 129 to QR Code, UPC, GS1, GS-128, Datamatrix, PDF417, Maxicode and many others. Provides support for full customization of fonts, colors, output and printing sizes. Special tools are included to verify output quality and printing quality. Can add generated barcode into new or existing documents, images and PDF.

VBScript code samples for VBScript developers help to speed up coding of your application when using ByteScout Barcode SDK. Just copy and paste the code into your VBScript application’s code and follow the instruction. Enjoy writing a code with ready-to-use sample VBScript codes.

ByteScout free trial version is available for download from our website. It includes all these programming tutorials along with source code samples.

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

##### ****generate_barcodes.vbs:**
    
```
'*** Prepare Barcode object
Set barcode = CreateObject("Bytescout.BarCode.Barcode")
barcode.RegistrationName = "demo"
barcode.RegistrationKey = "demo"
' Set barcode type to PDF417
barcode.Symbology = 16 ' 16 means QR Code
' Set higher resoultion (300 is good for printing)
barcode.ResolutionX = 300
barcode.ResolutionY = 300
' Show barcode caption (remove these lines if you don't need it)
barcode.DrawCaption = True
barcode.DrawCaptionFor2DBarcodes = True

' Open text file containing barcode data and read it line by line
Set fso = CreateObject("Scripting.FileSystemObject")
Set listFile = fso.OpenTextFile("list.txt")
i = 0

do while not listFile.AtEndOfStream 
    ' Set barcode value
    barcode.Value = listFile.ReadLine()
	' Fit barcode into 30x30 mm rectangle
	barcode.FitInto_3 30, 30, 4 ' 4 means millimeter units
	' Save barcode image to file
	barcode.SaveImage("barcode" & i & ".png")
	i = i + 1
loop

Set barcode = Nothing
set fso = Nothing

```

<!-- code block end -->    

<!-- code block begin -->

##### ****list.txt:**
    
```
sample data 1
sample data 2
sample data 3
sample data 4
sample data 5
sample data 6
```

<!-- code block end -->