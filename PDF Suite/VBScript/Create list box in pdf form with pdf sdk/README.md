## How to create list box in pdf form with pdf sdk in VBScript with ByteScout PDF Suite

### This code in VBScript shows how to create list box in pdf form with pdf sdk with this how to tutorial

On this page you will learn from code samples for programming in VBScript.Writing of the code to create list box in pdf form with pdf sdk in VBScript can be executed by programmers of any level using ByteScout PDF Suite. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript and you can use it to create list box in pdf form with pdf sdk with VBScript.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout PDF Suite for create list box in pdf form with pdf sdk below and use it in your application.  Simply copy and paste in your VBScript project or application you and then run your app! Use of ByteScout PDF Suite in VBScript is also described in the documentation included along with the product.

You can download free trial version of ByteScout PDF Suite from our website with this and other source code samples for VBScript.

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

##### ****ListBoxes.vbs:**
    
```
' This example demonstrates how to create a listbox.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Add list box, add items and make it multi-selectable
Set listBox1 = comHelpers.CreateListBox(20, 20, 120, 80, "listBox1")
listBox1.Items.Add("Value 1")
listBox1.Items.Add("Value 2")
listBox1.Items.Add("Value 3")
listBox1.Items.Add("Value 4")
listBox1.Items.Add("Value 5")
listBox1.MultiSelect = True
' Decorate listbox
listBox1.Font = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_HELVETICA, 10)
listBox1.FontColor = comHelpers.CreateColorRGB(0, 0, 128)
listBox1.BorderColor = comHelpers.CreateColorRGB(0, 0, 128)
listBox1.BackgroundColor = comHelpers.CreateColorRGB(240, 240, 255)
listBox1.BorderWidth = 2

page1.Annotations.Add(listBox1)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->