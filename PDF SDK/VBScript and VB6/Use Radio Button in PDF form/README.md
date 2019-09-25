## How to use radio button in PDF form in VBScript and VB6 using ByteScout PDF SDK

### The tutorial below will demonstrate how to use radio button in PDF form in VBScript and VB6

The sample shows steps and algorithm of how to use radio button in PDF form and how to make it work in your VBScript and VB6 application. ByteScout PDF SDK is the component to help programmers in generating new pdf files, modifying and updating existing pdf documents or pdf forms. Provides support for auto-filling pdf forms, adding text with adjustable font, style, size, font family, new form fields, vector and raster drawings. It can use radio button in PDF form in VBScript and VB6.

This code snippet below for ByteScout PDF SDK works best when you need to quickly use radio button in PDF form in your VBScript and VB6 application. This VBScript and VB6 sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Detailed tutorials and documentation are available along with installed ByteScout PDF SDK if you'd like to dive deeper into the topic and the details of the API.

ByteScout PDF SDK free trial version is available on our website. VBScript and VB6 and other programming languages are supported.

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

##### ****RadioButtons.vbs:**
    
```
' This example demonstrates how to create radio buttons.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set timesFont = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 12)
Set blackBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))

' Add a group of radio buttons
Set radioButton1 = comHelpers.CreateRadioButton(20, 20, 15, 15, "group1", "value1")
Set radioButton2 = comHelpers.CreateRadioButton(20, 40, 15, 15, "group1", "value2")
page1.Annotations.Add(radioButton1)
page1.Annotations.Add(radioButton2)
' Add labels
page1.Canvas.DrawString "Value 1.1", (timesFont), (blackBrush), 40, 20
page1.Canvas.DrawString "Value 1.2", (timesFont), (blackBrush), 40, 40

' Add another independent group of radio buttons
Set radioButton3 = comHelpers.CreateRadioButton(120, 20, 15, 15, "group2", "value3")
Set radioButton4 = comHelpers.CreateRadioButton(120, 40, 15, 15, "group2", "value4")
page1.Annotations.Add(radioButton3)
page1.Annotations.Add(radioButton4)
' Add labels
page1.Canvas.DrawString "Value 2.1", (timesFont), (blackBrush), 140, 20
page1.Canvas.DrawString "Value 2.2", (timesFont), (blackBrush), 140, 40

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->