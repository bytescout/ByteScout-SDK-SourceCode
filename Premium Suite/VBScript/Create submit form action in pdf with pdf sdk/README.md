## How to create submit form action in pdf with pdf sdk in VBScript with ByteScout Premium Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to create submit form action in pdf with pdf sdk in VBScript

The code displayed below will guide you to install an VBScript app to create submit form action in pdf with pdf sdk. Want to create submit form action in pdf with pdf sdk in your VBScript app? ByteScout Premium Suite is designed for it. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout Premium Suite. Follow the instructions from scratch to work and copy the VBScript code. Complete and detailed tutorials and documentation are available along with installed ByteScout Premium Suite if you'd like to learn more about the topic and the details of the API.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

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

##### ****SubmitFormAction.vbs:**
    
```
' This example demonstrates how to submit or reset form.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Create sample form
Set timesFont = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 14)
Set blackBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))
' EditBox
Set editBox1 = comHelpers.CreateEditBox(20, 20, 100, 25, "editBox1")
editBox1.Text = "editBox1"
page1.Annotations.Add(editBox1)
' CheckBox
Set checkBox1 = comHelpers.CreateCheckBox(20, 60, 15, 15, "checkBox1")
page1.Annotations.Add(checkBox1)
page1.Canvas.DrawString "CheckBox", (timesFont), (blackBrush), 45, 60 

' Add Submit button
Set submitButton = comHelpers.CreatePushButton(20, 120, 80, 25, "buttonSubmit")
submitButton.Caption = "Submit"
page1.Annotations.Add(submitButton)
' Add action
Set submitAction = comHelpers.CreateSubmitFormAction("http://login.live.com")
submitAction.SubmitFormat = comHelpers.SUBMITDATAFORMAT_HTML
submitAction.SubmitMethod = comHelpers.SUBMITMETHOD_GET
submitAction.Fields.Add(editBox1)
submitAction.Fields.Add(checkBox1)
submitButton.OnActivated = submitAction

' Add Reset button
Set resetButton = comHelpers.CreatePushButton(120, 120, 80, 25, "butonReset")
resetButton.Caption = "Reset"
page1.Annotations.Add(resetButton)
' Add action
Set resetAction = comHelpers.CreateResetFormAction()
resetAction.Fields.Add(editBox1)
resetAction.Fields.Add(checkBox1)
resetButton.OnActivated = resetAction

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->