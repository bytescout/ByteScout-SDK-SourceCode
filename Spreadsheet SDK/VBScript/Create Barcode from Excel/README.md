## How to create barcode from excel in VBScript and ByteScout Spreadsheet SDK

### The tutorial shows how to create barcode from excel in VBScript

This sample source code below will demonstrate you how to create barcode from excel in VBScript. ByteScout Spreadsheet SDK can create barcode from excel. It can be used from VBScript. ByteScout Spreadsheet SDK is the SDK to create, read, modify and calculate spreadsheets. Formula calculations are supported, import and export to and from JSON, CSV, XML, databases, arrays.

This code snippet below for ByteScout Spreadsheet SDK works best when you need to quickly create barcode from excel in your VBScript application. Follow the instructions from the scratch to work and copy the VBScript code. Further enhancement of the code will make it more vigorous.

Free trial version of ByteScout Spreadsheet SDK is available on our website. Documentation and source code samples are included.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Spreadsheet%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Spreadsheet%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=nm_7I0PN1TY](https://www.youtube.com/watch?v=nm_7I0PN1TY)




<!-- code block begin -->

##### ****generate_barcodes.vbs:**
    
```
' This example demonstrates reading values from Excel file and generating PDF417 barcodes.
' Please install Bytescout BarCode Generator SDK before run this example:
' http://bytescout.com/products/developer/barcodesdk/bytescoutbarcodesdk.html

'*** Prepare Spreadsheet object
Set spreadsheet = CreateObject("Bytescout.Spreadsheet.Spreadsheet")
spreadsheet.RegistrationName = "demo"
spreadsheet.RegistrationKey = "demo"
' Load Excel document
spreadsheet.LoadFromFile("test.xlsx")
' Take the first worksheet
Set worksheet = spreadsheet.Worksheet(0)

'*** Prepare Barcode object - requies to download BarCode SDK from ByteScout.com site
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