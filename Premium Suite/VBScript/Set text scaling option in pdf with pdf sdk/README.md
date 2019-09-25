## How to set text scaling option in pdf with pdf sdk in VBScript using ByteScout Premium Suite

### Step-by-step tutorial on how to set text scaling option in pdf with pdf sdk in VBScript

The sample source codes on this page shows how to set text scaling option in pdf with pdf sdk in VBScript. ByteScout Premium Suite: the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can set text scaling option in pdf with pdf sdk in VBScript.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout Premium Suite.  Simply copy and paste in your VBScript project or application you and then run your app! Enjoy writing a code with ready-to-use sample VBScript codes.

ByteScout Premium Suite free trial version is available on our website. VBScript and other programming languages are supported.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Premium%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Premium%20Suite%20Question) 

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

##### ****StringScaling.vbs:**
    
```
' This example demonstrates how to use the font scaling to expand a string.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set font = comHelpers.CreateSystemFont("Arial", 16)
Set brush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))
Set stringFormat = comHelpers.CreateStringFormat()

stringFormat.Scaling = 100.0
page1.Canvas.DrawString_4 "Normal string 100.0%", (font), (brush), 20, 20, (stringFormat)

stringFormat.Scaling = 50.0
page1.Canvas.DrawString_4 "Squeezed string 50.0%", (font), (brush), 20, 50, (stringFormat)

stringFormat.Scaling = 150.0
page1.Canvas.DrawString_4 "Expanded string 150.0%", (font), (brush), 20, 80, (stringFormat)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->