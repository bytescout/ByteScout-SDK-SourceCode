## How to use rich text formatting in VBScript with ByteScout Spreadsheet SDK

### Tutorial on how to use rich text formatting in VBScript

The sample shows steps and algorithm of how to use rich text formatting and how to make it work in your VBScript application. Want to use rich text formatting in your VBScript app? ByteScout Spreadsheet SDK is designed for it. ByteScout Spreadsheet SDK is the SDK to create, read, modify and calculate spreadsheets. Formula calculations are supported, import and export to and from JSON, CSV, XML, databases, arrays.

The SDK samples like this one below explain how to quickly make your application do use rich text formatting in VBScript with the help of ByteScout Spreadsheet SDK. Just copy and paste the code into your VBScript application’s code and follow the instruction. This basic programming language sample code for VBScript will do the whole work for you to use rich text formatting.

Download free trial version of ByteScout Spreadsheet SDK from our website with this and other source code samples for VBScript.

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

##### ****RichTextFormatting.vbs:**
    
```
Set document = CreateObject("Bytescout.Spreadsheet.Spreadsheet")

document.RegistrationName = "demo"
document.RegistrationKey = "demo"

 ' Add new worksheet
Set worksheet = document.Workbook.Worksheets.Add("HelloWorld")

' add cell with HTML formatted text
Set cell = worksheet.Cell(1, 1)
cell.ValueAsHTML = "<b>Bold text</b> and <i>Italic text</i>"


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