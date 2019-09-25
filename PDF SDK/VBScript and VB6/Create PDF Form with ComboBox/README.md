## How to create PDF form with combobox in VBScript and VB6 using ByteScout PDF SDK

### The tutorial shows how to create PDF form with combobox in VBScript and VB6

We made thousands of pre-made source code pieces for easy implementation in your own programming projects. ByteScout PDF SDK can create PDF form with combobox. It can be used from VBScript and VB6. ByteScout PDF SDK is the pdf library that can create, update and modify PDF files. Supports text with fonts and style selections, layers, form fields, drawing lines and objects, automatic tables, images. Can be used to create and fill pdf forms.

This code snippet below for ByteScout PDF SDK works best when you need to quickly create PDF form with combobox in your VBScript and VB6 application. In your VBScript and VB6 project or application you may simply copy & paste the code and then run your app! Use of ByteScout PDF SDK in VBScript and VB6 is also explained in the documentation included along with the product.

Download free trial version of ByteScout PDF SDK from our website with this and other source code samples for VBScript and VB6.

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