## How to create pdf form with checkbox with pdf sdk in VBScript with ByteScout Premium Suite

### Step-by-step tutorial on how to create pdf form with checkbox with pdf sdk in VBScript

These source code samples are assembled by their programming language and functions they apply. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can be applied to create pdf form with checkbox with pdf sdk using VBScript.

This prolific sample source code in VBScript for ByteScout Premium Suite contains various functions and other necessary options you should do calling the API to create pdf form with checkbox with pdf sdk. Just copy and paste the code into your VBScript application’s code and follow the instructions. Enjoy writing a code with ready-to-use sample codes in VBScript.

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