## How to create list box in PDF form in VBScript and VB6 with ByteScout PDF SDK

### How to create list box in PDF form in VBScript and VB6

The sample shows steps and algorithm of how to create list box in PDF form and how to make it work in your VBScript and VB6 application. ByteScout PDF SDK can create list box in PDF form. It can be used from VBScript and VB6. ByteScout PDF SDK is the pdf library that can create, update and modify PDF files. Supports text with fonts and style selections, layers, form fields, drawing lines and objects, automatic tables, images. Can be used to create and fill pdf forms.

The SDK samples like this one below explain how to quickly make your application do create list box in PDF form in VBScript and VB6 with the help of ByteScout PDF SDK. In your VBScript and VB6 project or application you may simply copy & paste the code and then run your app! Implementing VBScript and VB6 application typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

You can download free trial version of ByteScout PDF SDK from our website to see and try many others source code samples for VBScript and VB6.

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