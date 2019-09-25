## fill fields in PDF form in VBScript and VB6 and ByteScout PDF SDK

### Make fill fields in PDF form in VBScript and VB6: ### Tutorial on how to do fill fields in PDF form in VBScript and VB6

Writing of the code to fill fields in PDF form in VBScript and VB6 can be done by developers of any level using ByteScout PDF SDK. ByteScout PDF SDK was made to help with fill fields in PDF form in VBScript and VB6. ByteScout PDF SDK is the SDK for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings.

Fast application programming interfaces of ByteScout PDF SDK for VBScript and VB6 plus the instruction and the VBScript and VB6 code below will help you quickly learn fill fields in PDF form. VBScript and VB6 sample code is all you need: copy and paste the code to your VBScript and VB6 application's code editor, add a reference to ByteScout PDF SDK (if you haven't added yet) and you are ready to go! VBScript and VB6 application implementation typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

ByteScout PDF SDK is available as free trial. You may get it from our website along with all other source code samples for VBScript and VB6 applications.

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