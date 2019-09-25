## enable superscript or subscript for text in pdf with pdf sdk in VBScript with ByteScout Premium Suite

### Simple tutorial on how to do enable superscript or subscript for text in pdf with pdf sdk in VBScript

We regularly create and update our sample code library so you may quickly learn enable superscript or subscript for text in pdf with pdf sdk and the step-by-step process in VBScript. ByteScout Premium Suite helps with enable superscript or subscript for text in pdf with pdf sdk in VBScript. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

VBScript code snippet like this for ByteScout Premium Suite works best when you need to quickly implement enable superscript or subscript for text in pdf with pdf sdk in your VBScript application. If you want to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Enjoy writing a code with ready-to-use sample VBScript codes to add enable superscript or subscript for text in pdf with pdf sdk functions using ByteScout Premium Suite in VBScript.

On our website you may get trial version of ByteScout Premium Suite for free. Source code samples are included to help you with your VBScript application.

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

##### ****SuperscripAndSubscript.vbs:**
    
```
' This example demonstrates how to create a document and save it to file.

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
xPosition = 20

' Draw normal string
page1.Canvas.DrawString_4 "Normal text ", (font), (brush), xPosition, 50, (stringFormat)
xPosition = xPosition + font.GetTextWidth("Normal text ")

' Draw subscript string 
stringFormat.Rise = -5
page1.Canvas.DrawString_4 "Subscript", (font), (brush), xPosition, 50, (stringFormat)
xPosition = xPosition + font.GetTextWidth("Subscript")

' draw superscript string
stringFormat.Rise = +5
page1.Canvas.DrawString_4 "Superscript", (font), (brush), xPosition, 50, (stringFormat)
xPosition = xPosition + font.GetTextWidth("Superscript")

' Draw the baseline
Set pen = comHelpers.CreateSolidPen(comHelpers.CreateColorRGB(0, 0, 255), 1.0)
pen.Opacity = 50
page1.Canvas.DrawLine (pen), 20, 50 + font.Size, xPosition, 50 + font.Size

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->