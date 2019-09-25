## How to create drawing template for pdf with pdf sdk in VBScript with ByteScout Premium Suite

### Learn to create drawing template for pdf with pdf sdk in VBScript

We made thousands of pre-made source code pieces for easy implementation in your own programming projects. ByteScout Premium Suite: the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can create drawing template for pdf with pdf sdk in VBScript.

The following code snippet for ByteScout Premium Suite works best when you need to quickly create drawing template for pdf with pdf sdk in your VBScript application. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Use of ByteScout Premium Suite in VBScript is also described in the documentation included along with the product.

Trial version of ByteScout Premium Suite is available for free. Source code samples are included to help you with your VBScript app.

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

##### ****Templates.vbs:**
    
```
' This example demonstrates how to use templates.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Prepare simple template (for example, a logo) and draw it on every page:

' Create template of specified size
Set template = comHelpers.CreateGraphicsTemplate(250, 50)
' Draw the logo
Set lightBlueBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(200, 200, 255))
template.DrawRectangle_2 (lightBlueBrush), 0, 0, 250, 50
Set timesFont = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMESBOLDITALIC, 24)
Set blackBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))
template.DrawString "My Company Logo", (timesFont), (blackBrush), 30, 10

' Add few pages and draw the prepared template on each one
For i = 0 To 2
    Set page = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
    page.Canvas.DrawTemplate (template), 10, 10
    pdfDocument.Pages.Add(page)
Next

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->