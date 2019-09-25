## How to create pdf form with combobox with pdf sdk in VBScript and ByteScout PDF Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to create pdf form with combobox with pdf sdk in VBScript

This sample source code below will display you how to create pdf form with combobox with pdf sdk in VBScript. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can be applied to create pdf form with combobox with pdf sdk using VBScript.

The following code snippet for ByteScout PDF Suite works best when you need to quickly create pdf form with combobox with pdf sdk in your VBScript application. Just copy and paste the code into your VBScript application’s code and follow the instructions. Further improvement of the code will make it more robust.

If you want to try other source code samples then the free trial version of ByteScout PDF Suite is available for download from our website. Just try other source code samples for VBScript.

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

##### ****ComboBoxes.vbs:**
    
```
' This example demonstrates how to create and decorate comboboxes.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Add dropdown box (not editable combobox)
Set comboBox1 = comHelpers.CreateComboBox(20, 20, 150, 25, "comboBox1")
comboBox1.Font.Size = 12
comboBox1.BorderColor = comHelpers.CreateColorRGB(0, 0, 128)
comboBox1.BackgroundColor = comHelpers.CreateColorRGB(220, 220, 255)
comboBox1.BorderWidth = 2
comboBox1.Text = "Select item"
comboBox1.Items.Add("Item 1")
comboBox1.Items.Add("Item 2")
comboBox1.Items.Add("Item 3")
page1.Annotations.Add(comboBox1)

' Add editable combobox
Set comboBox2 = comHelpers.CreateComboBox(20, 50, 150, 25, "comboBox2")
comboBox2.Editable = True
comboBox2.Font.Size = 12
comboBox2.BorderColor = comHelpers.CreateColorRGB(0, 128, 0)
comboBox2.BackgroundColor = comHelpers.CreateColorRGB(220, 255, 220)
comboBox1.BorderWidth = 2
comboBox2.Text = "Editable ComboBox"
comboBox2.Items.Add("Item 1")
comboBox2.Items.Add("Item 2")
comboBox2.Items.Add("Item 3")
page1.Annotations.Add(comboBox2)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->