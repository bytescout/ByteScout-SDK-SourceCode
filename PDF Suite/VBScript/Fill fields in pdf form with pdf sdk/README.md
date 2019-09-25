## fill fields in pdf form with pdf sdk in VBScript and ByteScout PDF Suite

### Build fill fields in pdf form with pdf sdk in VBScript: ### Step-by-step instructions on how to do fill fields in pdf form with pdf sdk in VBScript

These source code samples are assembled by their programming language and functions they use. ByteScout PDF Suite was made to help with fill fields in pdf form with pdf sdk in VBScript. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

If you want to quickly learn then these fast application programming interfaces of ByteScout PDF Suite for VBScript plus the guideline and the VBScript code below will help you quickly learn fill fields in pdf form with pdf sdk. Follow the steps-by-step instructions from the scratch to work and copy and paste code for VBScript into your editor. These VBScript sample examples can be used in one or many applications.

Trial version along with the source code samples for VBScript can be downloaded from our website

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

##### ****Fill Form.vbs:**
    
```
' This example demonstrates how to fill PDF form programmatically.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

' Load PDF form
pdfDocument.Load("form.pdf")

Set page = pdfDocument.Pages.Item(0)

' Get widget by its name and change value
page.Annotations.Item_2("editBox1").Text = "Test 123"
page.Annotations.Item_2("editBox2").Text = "Test 456"
page.Annotations.Item_2("checkBox1").Checked = True

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->