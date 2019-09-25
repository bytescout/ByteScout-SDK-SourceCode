## How to set passwords and permissions of PDF file in VBScript and VB6 using ByteScout PDF SDK

### Write code in VBScript and VB6 to set passwords and permissions of PDF file with this step-by-step tutorial

Every ByteScout tool contains example VBScript and VB6 source codes that you can find here or in the folder with installed ByteScout product. ByteScout PDF SDK: the component to help programmers in generating new pdf files, modifying and updating existing pdf documents or pdf forms. Provides support for auto-filling pdf forms, adding text with adjustable font, style, size, font family, new form fields, vector and raster drawings. It can set passwords and permissions of PDF file in VBScript and VB6.

This rich sample source code in VBScript and VB6 for ByteScout PDF SDK includes the number of functions and options you should do calling the API to set passwords and permissions of PDF file. In order to implement the functionality, you should copy and paste this code for VBScript and VB6 below into your code editor with your app, compile and run your application. Code testing will allow the function to be tested and work properly with your data.

You can download free trial version of ByteScout PDF SDK from our website to see and try many others source code samples for VBScript and VB6.

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

##### ****PasswordsAndPermissions.vbs:**
    
```
' This example demonstrates how to lock the document with a password. 
' PDF format supports two kinds of passwords: owner and user password.
' User password allows to view document and perform allowed actions.
' Owner password allows everything, including changing passwords and permissions.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Create document
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)
' or load existing one:
'pdfDocument.Load "c:\test\some-document.pdf"


' Set document encryption algorythm
pdfDocument.Security.EncryptionAlgorithm = comHelpers.ENCRYPTIONALGORITHM_RC4_40BIT
' Set various user permissions
pdfDocument.Security.AllowPrintDocument = False
pdfDocument.Security.AllowContentExtraction = False
pdfDocument.Security.AllowModifyAnnotations = False
pdfDocument.Security.PrintQuality = comHelpers.PRINTQUALITY_LOWRESOLUTION

' Set owner password
pdfDocument.Security.OwnerPassword = "ownerpassword"

' Set user password
pdfDocument.Security.UserPassword = "userpassword"

' Save protected document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->