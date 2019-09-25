## How to use radio button in pdf form with pdf sdk in VBScript with ByteScout Premium Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to use radio button in pdf form with pdf sdk in VBScript

The code displayed below will guide you to install an VBScript app to use radio button in pdf form with pdf sdk. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can use radio button in pdf form with pdf sdk in VBScript.

The SDK samples given below describe how to quickly make your application do use radio button in pdf form with pdf sdk in VBScript with the help of ByteScout Premium Suite. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. If you want to use these VBScript sample examples in one or many applications then they can be used easily.

If you want to try other source code samples then the free trial version of ByteScout Premium Suite is available for download from our website. Just try other source code samples for VBScript.

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