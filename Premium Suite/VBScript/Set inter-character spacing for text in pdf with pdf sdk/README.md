## How to set inter character spacing for text in pdf with pdf sdk in VBScript and ByteScout Premium Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to set inter character spacing for text in pdf with pdf sdk in VBScript

This sample source code below will display you how to set inter character spacing for text in pdf with pdf sdk in VBScript. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can be applied to set inter character spacing for text in pdf with pdf sdk using VBScript.

This prolific sample source code in VBScript for ByteScout Premium Suite contains various functions and other necessary options you should do calling the API to set inter character spacing for text in pdf with pdf sdk. Follow the instructions from scratch to work and copy the VBScript code. Complete and detailed tutorials and documentation are available along with installed ByteScout Premium Suite if you'd like to learn more about the topic and the details of the API.

ByteScout provides the free trial version of ByteScout Premium Suite along with the documentation and source code samples.

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

##### ****IntercharacterSpacing.vbs:**
    
```
' This example demonstrates how to change the intercharacter spacing.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set canvas = page1.Canvas

Set font = comHelpers.CreateSystemFont("Arial", 16)
Set brush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))
Set stringFormat = comHelpers.CreateStringFormat()

' Standard spacing
stringFormat.CharacterSpacing = 0.0
canvas.DrawString_4 "Standard intercharacter spacing 0.0", (font), (brush), 20, 20, (stringFormat)

' Increased spacing 
stringFormat.CharacterSpacing = 1.0
canvas.DrawString_4 "Increased intercharacter spacing 1.0", (font), (brush), 20, 50, (stringFormat)

' Reduced spacing
stringFormat.CharacterSpacing = -0.75
canvas.DrawString_4 "Reduced intercharacter spacing -0.75", (font), (brush), 20, 80, (stringFormat)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->