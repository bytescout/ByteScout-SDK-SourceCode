## How to create barcode from excel with spreadsheet sdk in VBScript using ByteScout Data Extraction Suite

### Learn to create barcode from excel with spreadsheet sdk in VBScript

ByteScout simple and easy to understand tutorials are planned to describe the code for both VBScript beginners and advanced programmers. What is ByteScout Data Extraction Suite? It is the set that includes 3 SDK products for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK. It can help you to create barcode from excel with spreadsheet sdk in your VBScript application.

Want to quickly learn? This fast application programming interfaces of ByteScout Data Extraction Suite for VBScript plus the guidelines and the code below will help you quickly learn how to create barcode from excel with spreadsheet sdk.  Simply copy and paste in your VBScript project or application you and then run your app! Want to see how it works with your data then code testing will allow the function to be tested and work properly.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Data%20Extraction%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Data%20Extraction%20Suite%20Question) 

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