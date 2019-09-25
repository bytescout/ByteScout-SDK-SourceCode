## How to set passwords and permissions of pdf file with pdf sdk in VBScript with ByteScout Premium Suite

### This code in VBScript shows how to set passwords and permissions of pdf file with pdf sdk with this how to tutorial

Quickly learn how to set passwords and permissions of pdf file with pdf sdk in VBScript with this sample source code. Want to set passwords and permissions of pdf file with pdf sdk in your VBScript app? ByteScout Premium Suite is designed for it. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

Want to quickly learn? This fast application programming interfaces of ByteScout Premium Suite for VBScript plus the guidelines and the code below will help you quickly learn how to set passwords and permissions of pdf file with pdf sdk. Follow the instructions from scratch to work and copy the VBScript code. Enjoy writing a code with ready-to-use sample VBScript codes.

The trial version of ByteScout Premium Suite can be downloaded for free from our website. It also includes source code samples for VBScript and other programming languages.

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