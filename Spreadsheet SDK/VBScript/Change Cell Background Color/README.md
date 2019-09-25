## How to change cell background color in VBScript and ByteScout Spreadsheet SDK

### Write code in VBScript to change cell background color with this step-by-step tutorial

The coding tutorials are designed to help you test the features without need to write your own code. ByteScout Spreadsheet SDK is the SDK to create, read, modify and calculate spreadsheets. Formula calculations are supported, import and export to and from JSON, CSV, XML, databases, arrays. It can be used to change cell background color using VBScript.

VBScript code samples for VBScript developers help to speed up coding of your application when using ByteScout Spreadsheet SDK. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! This basic programming language sample code for VBScript will do the whole work for you to change cell background color.

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

##### ****ChangeCellBackgroundColor.vbs:**
    
```
Set document = CreateObject("Bytescout.Spreadsheet.Spreadsheet")

document.RegistrationName = "demo"
document.RegistrationKey = "demo"

 ' Add new worksheet
Set worksheet = document.Workbook.Worksheets.Add("HelloWorld")

' add cell with HTML formatted text
Set cell = worksheet.Cell(1, 1)
cell.Value = "One Two Three"

cell.FillPattern = 1 ' Solid color
cell.FillPatternForeColorOLE = vbMagenta ' use standard VB color constants or hex values &HFFFF00

' save document
document.SaveAs "Output.xls"

' close Spreadsheet
Set document = Nothing

```

<!-- code block end -->