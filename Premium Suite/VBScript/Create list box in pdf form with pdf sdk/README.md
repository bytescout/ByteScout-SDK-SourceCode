## How to create list box in pdf form with pdf sdk in VBScript and ByteScout Premium Suite

### If you want to learn more then this tutorial will show how to create list box in pdf form with pdf sdk in VBScript

The coding instructions are formulated to help you to try-out the features without the requirement to write your own code. ByteScout Premium Suite can create list box in pdf form with pdf sdk. It can be applied from VBScript. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

This prolific sample source code in VBScript for ByteScout Premium Suite contains various functions and other necessary options you should do calling the API to create list box in pdf form with pdf sdk. Just copy and paste the code into your VBScript application’s code and follow the instructions. If you want to use these VBScript sample examples in one or many applications then they can be used easily.

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