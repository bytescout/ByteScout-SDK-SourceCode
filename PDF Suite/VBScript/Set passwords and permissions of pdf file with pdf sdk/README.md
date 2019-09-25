## How to set passwords and permissions of pdf file with pdf sdk in VBScript and ByteScout PDF Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to set passwords and permissions of pdf file with pdf sdk in VBScript

Source code documentation samples give simple and easy method to install a needed feature into your application. What is ByteScout PDF Suite? It is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can help you to set passwords and permissions of pdf file with pdf sdk in your VBScript application.

The SDK samples given below describe how to quickly make your application do set passwords and permissions of pdf file with pdf sdk in VBScript with the help of ByteScout PDF Suite. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Check VBScript sample code samples to see if they respond to your needs and requirements for the project.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

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