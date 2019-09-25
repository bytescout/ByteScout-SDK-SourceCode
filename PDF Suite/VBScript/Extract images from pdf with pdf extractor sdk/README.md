## How to extract images from pdf with pdf extractor sdk in VBScript using ByteScout PDF Suite

### Learn to extract images from pdf with pdf extractor sdk in VBScript

These source code samples are assembled by their programming language and functions they apply. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can extract images from pdf with pdf extractor sdk in VBScript.

The following code snippet for ByteScout PDF Suite works best when you need to quickly extract images from pdf with pdf extractor sdk in your VBScript application. Follow the instructions from scratch to work and copy the VBScript code. Enjoy writing a code with ready-to-use sample VBScript codes.

You can download free trial version of ByteScout PDF Suite from our website to see and try many others source code samples for VBScript.

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

##### ****ExtractAllImages.vbs:**
    
```
' Create Bytescout.PDFExtractor.ImageExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.ImageExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\sample1.pdf")

i = 0

' Initialize image enumeration
If extractor.GetFirstImage() Then
    Do
        outputFileName = "image" & i & ".png"
        ' Save image to file
        extractor.SaveCurrentImageToFile outputFileName
        i = i + 1
    Loop While extractor.GetNextImage() ' Advance image enumeration
End If

' Open first output image in default associated application
Set shell = CreateObject("WScript.Shell")
shell.Run "image0.png", 1, false
Set shell = Nothing

Set extractor = Nothing


```

<!-- code block end -->