## How to save as PDF in VBScript and ByteScout Spreadsheet SDK

### How to save as PDF in VBScript

ByteScout tutorials are designed to explain the code for both VBScript beginners and advanced programmers. ByteScout Spreadsheet SDK can save as PDF. It can be used from VBScript. ByteScout Spreadsheet SDK is the library (SDK) that is capable of writing, reading, modifying and calculating Excel and CSV spreadsheets. Most popular formulas can be calculated and reculculated with Excel installed. You may import or export data to and from CSV, XML, JSON as well as to and from databases, arrays.

The SDK samples like this one below explain how to quickly make your application do save as PDF in VBScript with the help of ByteScout Spreadsheet SDK. Just copy and paste the code into your VBScript application’s code and follow the instruction. Implementing VBScript application typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

Trial version of ByteScout Spreadsheet SDK can be downloaded for free from our website. It also includes source code samples for VBScript and other programming languages.

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