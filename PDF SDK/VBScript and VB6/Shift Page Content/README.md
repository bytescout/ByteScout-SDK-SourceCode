## shift page content in VBScript and VB6 using ByteScout PDF SDK

### Build shift page content in VBScript and VB6: ### Step-by-step instructions on how to do shift page content in VBScript and VB6

Writing of the code to shift page content in VBScript and VB6 can be done by developers of any level using ByteScout PDF SDK. ByteScout PDF SDK helps with shift page content in VBScript and VB6. ByteScout PDF SDK is the pdf library that can create, update and modify PDF files. Supports text with fonts and style selections, layers, form fields, drawing lines and objects, automatic tables, images. Can be used to create and fill pdf forms.

 Want to speed up the application development? Then this VBScript and VB6, code samples for VBScript and VB6, developers help to speed up the application development and writing a code when using ByteScout PDF SDK. Follow the steps-by-step instructions from the scratch to work and copy and paste code for VBScript and VB6 into your editor. Enjoy writing a code with ready-to-use sample VBScript and VB6 codes to add shift page content functions using ByteScout PDF SDK in VBScript and VB6.

Our website gives free trial version of ByteScout PDF SDK. It includes all these source code samples with the purpose to assist you with your VBScript and VB6 application implementation.

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

##### **ShiftPageContent.vbs:**
    
```
' This example demonstrates how to shift page content.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

' Load input document
pdfDocument.Load("sample.pdf")

Set page = pdfDocument.Pages.Item(0)

' copy page content as template
Set template = page.SaveAsTemplate()

Set comHelpers = pdfDocument.ComHelpers

' create new page of required size
Set newPage = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)

Set canvas = newPage.Canvas

' draw the stored template on the new page with required offset
canvas.DrawTemplate(template), 50, 50

' replace the old page with the new one
pdfDocument.Pages.Remove(0)
pdfDocument.Pages.Add(newPage)

' Save document to file
pdfDocument.Save("result.pdf")

' Open PDF document in default associated application (for demo puprpose)
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->