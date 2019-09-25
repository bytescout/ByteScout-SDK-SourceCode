## How to create PDF form with checkbox in VBScript and VB6 and ByteScout PDF SDK

### This tutorial will show how to create PDF form with checkbox in VBScript and VB6

Learn how to create PDF form with checkbox in VBScript and VB6 with this source code sample. ByteScout PDF SDK can create PDF form with checkbox. It can be used from VBScript and VB6. ByteScout PDF SDK is the SDK for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings.

This code snippet below for ByteScout PDF SDK works best when you need to quickly create PDF form with checkbox in your VBScript and VB6 application. Just copy and paste the code into your VBScript and VB6 application’s code and follow the instruction. Implementing VBScript and VB6 application typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

Free trial version of ByteScout PDF SDK is available for download from our website. Get it to try other source code samples for VBScript and VB6.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=gdsQ0EAqwGQ](https://www.youtube.com/watch?v=gdsQ0EAqwGQ)




<!-- code block begin -->

##### ****CheckBoxes.vbs:**
    
```
' This example demonstrates how to create checkboxes.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Add unchecked checkbox
Set checkBox1 = comHelpers.CreateCheckBox(20, 20, 15, 15, "checkBox1")
page1.Annotations.Add(checkBox1)

' Add checked checkbox
Set checkBox2 = comHelpers.CreateCheckBox(20, 40, 15, 15, "checkBox2")
checkBox2.Checked = True
page1.Annotations.Add(checkBox2)

' Add readonly checkbox
Set checkBox3 = comHelpers.CreateCheckBox(20, 60, 15, 15, "checkBox3")
checkBox3.Checked = True
checkBox3.ReadOnly = True
page1.Annotations.Add(checkBox3)

' Draw text labels
Set timesFont = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 12)
Set blackBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))
page1.Canvas.DrawString "Unchecked box", (timesFont), (blackBrush), 45, 20
page1.Canvas.DrawString "Checked box", (timesFont), (blackBrush), 45, 40
page1.Canvas.DrawString "Read-only checked box", (timesFont), (blackBrush), 45, 60

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->