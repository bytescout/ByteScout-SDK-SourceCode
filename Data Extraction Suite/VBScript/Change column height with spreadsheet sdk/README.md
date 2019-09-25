## How to change column height with spreadsheet sdk in VBScript and ByteScout Data Extraction Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to change column height with spreadsheet sdk in VBScript

An easy to understand guide on how to change column height with spreadsheet sdk in VBScript with this source code sample. ByteScout Data Extraction Suite is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK. It can change column height with spreadsheet sdk in VBScript.

The SDK samples given below describe how to quickly make your application do change column height with spreadsheet sdk in VBScript with the help of ByteScout Data Extraction Suite. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! If you want to use these VBScript sample examples in one or many applications then they can be used easily.

The trial version of ByteScout Data Extraction Suite can be downloaded for free from our website. It also includes source code samples for VBScript and other programming languages.

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

##### ****ChangeColumn.vbs:**
    
```
' IMPORTANT NOTE: you need to have .NET Framework 1.10 installed to use Spreadsheet SDK from Visual Basic
' to download and install .NET Framework 1.10 please use this link: http://www.microsoft.com/downloads/details.aspx?familyid=262D25E3-F589-4842-8157-034D1E7CF3A3

Set document = CreateObject("Bytescout.Spreadsheet.Spreadsheet")

document.RegistrationName = "demo"
document.RegistrationKey = "demo"

 ' Add new worksheet
Set worksheet = document.Workbook.Worksheets.Add("HelloWorld")

' add cell with HTML formatted text
Set cell = worksheet.Cell(2,2)
cell.ValueAsHTML = "test resizing"

set column = worksheet.columns.Item(1)

column.Width = 200

' delete output file if exists already
Set fso = CreateObject("Scripting.FileSystemObject")
If (fso.FileExists("Output.xls")) Then fso.DeleteFile("Output.xls")
Set fso = nothing

' save document
document.SaveAs "Output.xls"

' close Spreadsheet
Set document = Nothing


```

<!-- code block end -->