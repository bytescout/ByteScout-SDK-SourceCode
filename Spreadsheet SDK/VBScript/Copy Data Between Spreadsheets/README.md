## How to copy data between spreadsheets in VBScript using ByteScout Spreadsheet SDK

### How to copy data between spreadsheets in VBScript

These sample source codes on this page below are demonstrating how to copy data between spreadsheets in VBScript. ByteScout Spreadsheet SDK can copy data between spreadsheets. It can be used from VBScript. ByteScout Spreadsheet SDK is the SDK that can write and read, modify and calculate Excel and CSV spreadsheets. Most popular formulas are supported. You may import or export data to and from CSV, XML, JSON as well as to and from databases, arrays.

You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout Spreadsheet SDK for copy data between spreadsheets below and use it in your application. In your VBScript project or application you may simply copy & paste the code and then run your app! Implementing VBScript application typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

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