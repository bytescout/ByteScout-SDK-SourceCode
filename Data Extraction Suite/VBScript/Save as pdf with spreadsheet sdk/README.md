## How to save as pdf with spreadsheet sdk in VBScript using ByteScout Data Extraction Suite

### This code in VBScript shows how to save as pdf with spreadsheet sdk with this how to tutorial

On this page you will learn from code samples for programming in VBScript.Writing of the code to save as pdf with spreadsheet sdk in VBScript can be executed by programmers of any level using ByteScout Data Extraction Suite. ByteScout Data Extraction Suite is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK. It can be applied to save as pdf with spreadsheet sdk using VBScript.

Want to quickly learn? This fast application programming interfaces of ByteScout Data Extraction Suite for VBScript plus the guidelines and the code below will help you quickly learn how to save as pdf with spreadsheet sdk. Just copy and paste the code into your VBScript application’s code and follow the instructions. Check VBScript sample code samples to see if they respond to your needs and requirements for the project.

You can download free trial version of ByteScout Data Extraction Suite from our website to see and try many others source code samples for VBScript.

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

##### ****Save As PDF.vbs:**
    
```
Set document = CreateObject("Bytescout.Spreadsheet.Spreadsheet")

document.RegistrationName = "demo"
document.RegistrationKey = "demo"

 ' Add new worksheet
Set worksheet = document.Workbook.Worksheets.Add("HelloWorld")

' add a cell 
Set cell = worksheet.Cell(1, 1)
cell.Value = "Testing, Testing, Testing, Testing..."

' Save spreadsheet as PDF file:

' Save PDF with automatic page size...
document.SaveAsPDF "autosized.pdf"
' ... or save PDF with fixed page size
document.SaveAsPDF_2 "fixedsize.pdf", False ' the second parameter disables autosizing 

' close Spreadsheet
Set document = Nothing


```

<!-- code block end -->