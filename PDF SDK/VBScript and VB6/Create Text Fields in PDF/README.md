## How to create text fields in PDF in VBScript and VB6 with ByteScout PDF SDK

### Write code in VBScript and VB6 to create text fields in PDF with this step-by-step tutorial

The code below will help you to implement an VBScript and VB6 app to create text fields in PDF. ByteScout PDF SDK is the library for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings. It can create text fields in PDF in VBScript and VB6.

The SDK samples like this one below explain how to quickly make your application do create text fields in PDF in VBScript and VB6 with the help of ByteScout PDF SDK. In your VBScript and VB6 project or application you may simply copy & paste the code and then run your app! Further enhancement of the code will make it more vigorous.

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

##### ****TextFields.vbs:**
    
```
' This example demonstrates how text fields and theirs variations.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Add simple text field with default properties
Set edit1 = comHelpers.CreateEditBox(20, 20, 120, 25, "editBox1")
edit1.Text = "One two three"
page1.Annotations.Add(edit1)

' Add password box
Set edit2 = comHelpers.CreateEditBox(20, 50, 120, 25, "editBox2")
edit2.Text = "password"
edit2.Password = True
page1.Annotations.Add(edit2)

' Add multiline text field
Set edit3 = comHelpers.CreateEditBox(20, 80, 120, 50, "editBox3")
edit3.Multiline = True
edit3.Text = "The quick brown fox jumps over, the lazy dog."
page1.Annotations.Add(edit3)

' Demonstrate various decoration properties 
Set edit4 = comHelpers.CreateEditBox(20, 135, 120, 30, "editBox4")
edit4.Text = "Decorated text field"
edit4.TextAlign = comHelpers.TEXTALIGN_RIGHT
edit4.BackgroundColor = comHelpers.CreateColorRGB(255, 240, 240)
edit4.BorderWidth = 2
edit4.BorderStyle = comHelpers.BORDERSTYLE_DASHED
edit4.BorderColor = comHelpers.CreateColorRGB(128, 0, 0)
edit4.FontColor = comHelpers.CreateColorRGB(128, 0, 0)
edit4.Font.Size = 9
page1.Annotations.Add(edit4)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->