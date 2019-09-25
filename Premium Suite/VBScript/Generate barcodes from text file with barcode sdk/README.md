## How to generate barcodes from text file with barcode sdk in VBScript using ByteScout Premium Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to generate barcodes from text file with barcode sdk in VBScript

The sample shows instructions and algorithm of how to generate barcodes from text file with barcode sdk and how to make it run in your VBScript application. What is ByteScout Premium Suite? It is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can help you to generate barcodes from text file with barcode sdk in your VBScript application.

The following code snippet for ByteScout Premium Suite works best when you need to quickly generate barcodes from text file with barcode sdk in your VBScript application. Follow the instructions from scratch to work and copy the VBScript code. Check VBScript sample code samples to see if they respond to your needs and requirements for the project.

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