## How to create text annotation in pdf with pdf sdk in VBScript with ByteScout Premium Suite

### Step-by-step tutorial on how to create text annotation in pdf with pdf sdk in VBScript

The coding instructions are formulated to help you to try-out the features without the requirement to write your own code. ByteScout Premium Suite: the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can create text annotation in pdf with pdf sdk in VBScript.

The following code snippet for ByteScout Premium Suite works best when you need to quickly create text annotation in pdf with pdf sdk in your VBScript application. Follow the instructions from scratch to work and copy the VBScript code. If you want to use these VBScript sample examples in one or many applications then they can be used easily.

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

##### ****TextAnnotation.vbs:**
    
```
' This example demonstrates how to add a text annotation.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Add collapsed annotation (shown as a tooltip when mouse is over the icon)
Set collapsedAnnotation = comHelpers.CreateTextAnnotation(20, 20)
collapsedAnnotation.Color = comHelpers.CreateColorRGB(255, 255, 0)
collapsedAnnotation.Icon = comHelpers.TEXTANNOTATIONICON_COMMENT
collapsedAnnotation.Author = "Mr. Important"
collapsedAnnotation.Contents = "The quick brown fox jumps over the lazy dog."
page1.Annotations.Add(collapsedAnnotation)

' Add expanded annotation
Set expandedAnnotation = comHelpers.CreateTextAnnotation(20, 50)
expandedAnnotation.Color = comHelpers.CreateColorRGB(255, 0, 0)
expandedAnnotation.Icon = comHelpers.TEXTANNOTATIONICON_NOTE
expandedAnnotation.Open = True
expandedAnnotation.Author = "John Doe"
expandedAnnotation.Contents = "The quick brown fox jumps over the lazy dog."
page1.Annotations.Add(expandedAnnotation)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->