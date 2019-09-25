## How to create submit form action in pdf with pdf sdk in VBScript with ByteScout PDF Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to create submit form action in pdf with pdf sdk in VBScript

Every ByteScout tool includes simple example VBScript source codes that you can get here or in the folder with installed ByteScout product. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can be applied to create submit form action in pdf with pdf sdk using VBScript.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout PDF Suite for create submit form action in pdf with pdf sdk below and use it in your application. Just copy and paste the code into your VBScript application’s code and follow the instructions. Further improvement of the code will make it more robust.

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