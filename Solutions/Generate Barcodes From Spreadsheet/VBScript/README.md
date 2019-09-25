## How to generate barcodes from spreadsheet in VBScript with Multiple ByteScout SDK

### The tutorial below will demonstrate how to generate barcodes from spreadsheet in VBScript

These source code samples are listed and grouped by their programming language and functions they use. Multiple ByteScout SDK is the combination of one or more ByteScout SDK components to perform complex workflows like searching for text inside documents and highlighting found results and saving as new document or splitting pdf based on visually detected horizontal lines. It can be used to generate barcodes from spreadsheet using VBScript.

This code snippet below for Multiple ByteScout SDK works best when you need to quickly generate barcodes from spreadsheet in your VBScript application. Follow the instructions from the scratch to work and copy the VBScript code. Detailed tutorials and documentation are available along with installed Multiple ByteScout SDK if you'd like to dive deeper into the topic and the details of the API.

You can download free trial version of Multiple ByteScout SDK from our website to see and try many others source code samples for VBScript.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=Multiple%20ByteScout%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=Multiple%20ByteScout%20SDK%20Question) 

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
'*** Prepare Spreadsheet object
Set spreadsheet = CreateObject("Bytescout.Spreadsheet.Spreadsheet")
spreadsheet.RegistrationName = "demo"
spreadsheet.RegistrationKey = "demo"
' Load Excel document
spreadsheet.LoadFromFile("test.xlsx")
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