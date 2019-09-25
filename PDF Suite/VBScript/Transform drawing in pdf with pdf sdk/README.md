## transform drawing in pdf with pdf sdk in VBScript and ByteScout PDF Suite

### transform drawing in pdf with pdf sdk in VBScript

These sample source codes given below will show you how to handle a complex task, for example, transform drawing in pdf with pdf sdk in VBScript. Transform drawing in pdf with pdf sdk in VBScript can be applied with ByteScout PDF Suite. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

Save time on writing and testing code by using the code below and use it in your application.  Just copy and paste this VBScript sample code to your VBScript application's code editor, add a reference to ByteScout PDF Suite (if you haven't added yet) and you are ready to go! Enjoy writing a code with ready-to-use sample VBScript codes to add transform drawing in pdf with pdf sdk functions using ByteScout PDF Suite in VBScript.

Visit our website to get a free trial version of ByteScout PDF Suite. Free trial contains many of source code samples to help you with your VBScript project.

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

##### ****Transformations.vbs:**
    
```
' This example demonstrates how to use coordinate space transformations.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set canvas = page1.Canvas

' Prepare pens
Set blackPen = comHelpers.CreateSolidPen(comHelpers.CreateColorRGB(0, 0, 0), 2.0)
blackPen.Opacity = 50
Set bluePen = comHelpers.CreateSolidPen(comHelpers.CreateColorRGB(0, 0, 255), 2.0)
bluePen.Opacity = 50
Set greenPen = comHelpers.CreateSolidPen(comHelpers.CreateColorRGB(0, 255, 0), 2.0)
greenPen.Opacity = 50

' Move coordinate space zero point to (200, 200) and draw a rectangle of 50x50 dize
canvas.TranslateTransform 200, 200
canvas.DrawRectangle (blackPen), 0, 0, 50, 50

' Now zoom the coordinate space in twice and draw the same rectangle in green
canvas.ScaleTransform 2, 2
canvas.DrawRectangle (greenPen), 0, 0, 50, 50

' Now rotate the coordinate space by 30 degrees and draw the same rectangle in blue
canvas.RotateTransform 30
canvas.DrawRectangle (bluePen), 0, 0, 50, 50

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->