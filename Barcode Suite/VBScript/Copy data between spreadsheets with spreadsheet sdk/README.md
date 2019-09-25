## How to copy data between spreadsheets with spreadsheet sdk in VBScript and ByteScout Barcode Suite

### This code in VBScript shows how to copy data between spreadsheets with spreadsheet sdk with this how to tutorial

The sample shows instructions and algorithm of how to copy data between spreadsheets with spreadsheet sdk and how to make it run in your VBScript application. ByteScout Barcode Suite can copy data between spreadsheets with spreadsheet sdk. It can be applied from VBScript. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK.

This prolific sample source code in VBScript for ByteScout Barcode Suite contains various functions and other necessary options you should do calling the API to copy data between spreadsheets with spreadsheet sdk. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Check VBScript sample code samples to see if they respond to your needs and requirements for the project.

Trial version of ByteScout Barcode Suite is available for free. Source code samples are included to help you with your VBScript app.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20Suite%20Question) 

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

##### ****CopyDataBetweenSpreadsheets.vbs:**
    
```
' Create and activate two Spreadsheet objects
Set srcDocument = CreateObject("Bytescout.Spreadsheet.Spreadsheet")
srcDocument.RegistrationName = "demo"
srcDocument.RegistrationKey = "demo"
Set dstDocument = CreateObject("Bytescout.Spreadsheet.Spreadsheet")
dstDocument.RegistrationName = "demo"
dstDocument.RegistrationKey = "demo"

' Load exported data
srcDocument.LoadFromFile ".\sample.csv"
' Load destination document
dstDocument.LoadFromFile ".\destination.xlsx"

' Get worksheets
Set srcWorksheet = srcDocument.Worksheet(0)
Set dstWorksheet = dstDocument.Worksheet(0)

' Copy data from source to destination
For row = 0 To 3
    For column = 0 To 3
        dstWorksheet.Cell(row, column).Value = srcWorksheet.Cell(row, column).Value
    Next
Next

' Recalculate formulas
dstDocument.Workbook.Calculate

' Save modified document as "result.xls"
dstDocument.SaveAs ".\result.xls"


```

<!-- code block end -->