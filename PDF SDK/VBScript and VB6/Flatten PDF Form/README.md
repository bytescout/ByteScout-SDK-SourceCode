## flatten PDF form in VBScript and VB6 and ByteScout PDF SDK

### flatten PDF form in VBScript and VB6

ByteScout tutorials explain the material for programmers who use VBScript and VB6. Flatten PDF form in VBScript and VB6 can be implemented with ByteScout PDF SDK. ByteScout PDF SDK is the library for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings.

This rich sample source code in VBScript and VB6 for ByteScout PDF SDK includes the number of functions and options you should do calling the API to implement flatten PDF form. This VBScript and VB6 sample code should be copied and pasted into your application’s code editor. Then just compile and run it to see how it works. VBScript and VB6 application implementation typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

Trial version can be downloaded from our website. Source code samples for VBScript and VB6 and documentation are included.

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

##### ****Flatten Form.vbs:**
    
```
' This example demonstrates how to submit or reset form.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

' Load filled PDF form
pdfDocument.Load("filled_form.pdf")

' Flatten the form
pdfDocument.FlattenDocument()

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->