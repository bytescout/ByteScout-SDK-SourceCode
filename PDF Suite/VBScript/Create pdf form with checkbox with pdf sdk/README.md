## How to create pdf form with checkbox with pdf sdk in VBScript with ByteScout PDF Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to create pdf form with checkbox with pdf sdk in VBScript

Every ByteScout tool includes simple example VBScript source codes that you can get here or in the folder with installed ByteScout product. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript and you can use it to create pdf form with checkbox with pdf sdk with VBScript.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout PDF Suite. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! This basic programming language sample code for VBScript will do the whole work for you to create pdf form with checkbox with pdf sdk.

ByteScout provides the free trial version of ByteScout PDF Suite along with the documentation and source code samples.

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