## How to create submit form action in PDF in VBScript and VB6 and ByteScout PDF SDK

### How to create submit form action in PDF in VBScript and VB6

We made thousands of pre-made source code pieces for easy implementation in your own programming projects. ByteScout PDF SDK is the SDK for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings. It can create submit form action in PDF in VBScript and VB6.

The SDK samples like this one below explain how to quickly make your application do create submit form action in PDF in VBScript and VB6 with the help of ByteScout PDF SDK. This VBScript and VB6 sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! You can use these VBScript and VB6 sample examples in one or many applications.

Our website provides trial version of ByteScout PDF SDK for free. It also includes documentation and source code samples.

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