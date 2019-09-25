## How to create text fields in pdf with pdf sdk in VBScript with ByteScout PDF Suite

### If you want to learn more then this tutorial will show how to create text fields in pdf with pdf sdk in VBScript

The documentation is designed for a specific purpose to help you to apply the features on your side. Want to create text fields in pdf with pdf sdk in your VBScript app? ByteScout PDF Suite is designed for it. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

The SDK samples given below describe how to quickly make your application do create text fields in pdf with pdf sdk in VBScript with the help of ByteScout PDF Suite. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Enjoy writing a code with ready-to-use sample codes in VBScript.

Trial version of ByteScout PDF Suite is available for free. Source code samples are included to help you with your VBScript app.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Suite%20Question) 

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