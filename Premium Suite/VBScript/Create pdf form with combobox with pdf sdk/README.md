## How to create pdf form with combobox with pdf sdk in VBScript with ByteScout Premium Suite

### If you want to learn more then this tutorial will show how to create pdf form with combobox with pdf sdk in VBScript

Every ByteScout tool includes simple example VBScript source codes that you can get here or in the folder with installed ByteScout product. Want to create pdf form with combobox with pdf sdk in your VBScript app? ByteScout Premium Suite is designed for it. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout Premium Suite for create pdf form with combobox with pdf sdk below and use it in your application. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. This basic programming language sample code for VBScript will do the whole work for you to create pdf form with combobox with pdf sdk.

ByteScout Premium Suite free trial version is available on our website. VBScript and other programming languages are supported.

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