## How to create pdf form with button with pdf sdk in VBScript and ByteScout Premium Suite

### Step-by-step tutorial on how to create pdf form with button with pdf sdk in VBScript

Create pdf form with button with pdf sdk is simple to apply in VBScript if you use these source codes below. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can create pdf form with button with pdf sdk in VBScript.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout Premium Suite for create pdf form with button with pdf sdk below and use it in your application. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Check VBScript sample code samples to see if they respond to your needs and requirements for the project.

The trial version of ByteScout Premium Suite can be downloaded for free from our website. It also includes source code samples for VBScript and other programming languages.

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

##### ****Buttons.vbs:**
    
```
' This example demonstrates how to create a button and decorate it.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Create a button
Set button1 = comHelpers.CreatePushButton(50, 50, 100, 30, "button1")
button1.Caption = "Button"
' Decorate the button with various styles
button1.BackgroundColor = comHelpers.CreateColorRGB(192, 192, 255)
button1.BorderWidth = 2
button1.BorderStyle = comHelpers.BORDERSTYLE_BEVELED
button1.BorderColor = comHelpers.CreateColorRGB(0, 0, 128)
button1.Font = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 16)
button1.FontColor = comHelpers.CreateColorRGB(0, 0, 0)
button1.HighlightingMode = comHelpers.PUSHBUTTONHIGHLIGHTINGMODE_OUTLINE

' Add button to the page
page1.Annotations.Add(button1)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->