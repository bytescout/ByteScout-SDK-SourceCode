## How to create barcode from excel in VBScript using ByteScout Barcode SDK

### This tutorial will show how to create barcode from excel in VBScript

This sample source code below will demonstrate you how to create barcode from excel in VBScript. What is ByteScout Barcode SDK? It is the robost SDK that generates high quality barcode images and pdf. Can generate all popular types of barcodes from QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix to more exotic barcode types. Fully customizable fonts, colors, print sizes. Includes special functions to ensure output quality, and tools for adding barcodes to new or existing pdf files and images. It can help you to create barcode from excel in your VBScript application.

This rich sample source code in VBScript for ByteScout Barcode SDK includes the number of functions and options you should do calling the API to create barcode from excel. In order to implement the functionality, you should copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Code testing will allow the function to be tested and work properly with your data.

Free trial version of ByteScout Barcode SDK is available on our website. Documentation and source code samples are included.

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
' This example demonstrates reading values from Excel file and generating PDF417 barcodes.
' Please install Bytescout Spreadsheet SDK before run this example:
' http://bytescout.com/products/developer/spreadsheetsdk/bytescoutspreadsheetsdk.html

'*** Prepare Spreadsheet object
Set spreadsheet = CreateObject("Bytescout.Spreadsheet.Spreadsheet")
spreadsheet.RegistrationName = "demo"
spreadsheet.RegistrationKey = "demo"
' Load Excel document
spreadsheet.LoadFromFile("18_Oct_2012.xlsx")
' Take the first worksheet
Set worksheet = spreadsheet.Worksheet(0)

'*** Prepare Barcode object
Set barcode = CreateObject("Bytescout.BarCode.Barcode")
barcode.RegistrationName = "demo"
barcode.RegistrationKey = "demo"
' Set barcode type to PDF417
barcode.Symbology = 13 ' 13 means PDF417 barcode
' Set higher resoultion (300 is good for printing)
barcode.ResolutionX = 300
barcode.ResolutionY = 300
' Show barcode caption (remove these lines if you don't need it)
barcode.DrawCaption = True
barcode.DrawCaptionFor2DBarcodes = True

' Run through worksheet rows
For i = 0 To worksheet.NotEmptyRowMax - 1
	' Get barcode value from first worksheet column 
	barcode.Value = worksheet.Item(i, 0).ValueAsString
	' Fit barcode into 40x15 mm rectangle
	barcode.FitInto_3 40, 15, 4 ' 4 means millimeter units
	' Save barcode image to file
	barcode.SaveImage("barcode" & i & ".png")
Next

' Release objects
Set spreadsheet = Nothing
Set barcode = Nothing

```

<!-- code block end -->