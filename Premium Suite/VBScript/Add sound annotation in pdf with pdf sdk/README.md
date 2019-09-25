## How to add sound annotation in pdf with pdf sdk in VBScript using ByteScout Premium Suite

### Learn to add sound annotation in pdf with pdf sdk in VBScript

Quickly learn how to add sound annotation in pdf with pdf sdk in VBScript with this sample source code. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can be applied to add sound annotation in pdf with pdf sdk using VBScript.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout Premium Suite for add sound annotation in pdf with pdf sdk below and use it in your application. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Further improvement of the code will make it more robust.

Our website gives trial version of ByteScout Premium Suite for free. It also includes documentation and source code samples.

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

##### ****AudioAnnotation.vbs:**
    
```
' This example demonstrates how to add an audio annotaion.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Add sound annotation
Set sound = comHelpers.CreateSound("sample.wav")
Set soundAnnotation = comHelpers.CreateSoundAnnotation((sound), 20, 20, 20, 20)
page1.Annotations.Add(soundAnnotation)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->