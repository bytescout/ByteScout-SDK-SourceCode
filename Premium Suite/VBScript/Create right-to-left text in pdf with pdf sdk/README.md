## How to create right to left text in pdf with pdf sdk in VBScript with ByteScout Premium Suite

### If you want to learn more then this tutorial will show how to create right to left text in pdf with pdf sdk in VBScript

Quickly learn how to create right to left text in pdf with pdf sdk in VBScript with this sample source code. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can create right to left text in pdf with pdf sdk in VBScript.

The SDK samples given below describe how to quickly make your application do create right to left text in pdf with pdf sdk in VBScript with the help of ByteScout Premium Suite. Just copy and paste the code into your VBScript application’s code and follow the instructions. Applying VBScript application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

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

##### ****RightToLeftText.vbs:**
    
```
' This example demonstrates how to draw right-to-left text.

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

' Set right to left text direction
Set stringFormat = comHelpers.CreateStringFormat()
stringFormat.DirectionRightToLeft = True

page1.Canvas.DrawString_4 "???? ????? ?????", (font), (brush), page1.Width - 20, 30, (stringFormat)
page1.Canvas.DrawString_4 "???, ?????, ????", (font), (brush), page1.Width - 20, 50, (stringFormat)
page1.Canvas.DrawString_4 "?? ?? ??", (font), (brush), page1.Width - 20, 70, (stringFormat)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->