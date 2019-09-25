## How to use layers in pdf with pdf sdk in VBScript with ByteScout PDF Suite

### Step-by-step tutorial on how to use layers in pdf with pdf sdk in VBScript

ByteScout simple and easy to understand tutorials are planned to describe the code for both VBScript beginners and advanced programmers. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript and you can use it to use layers in pdf with pdf sdk with VBScript.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout PDF Suite for use layers in pdf with pdf sdk below and use it in your application.  Simply copy and paste in your VBScript project or application you and then run your app! This basic programming language sample code for VBScript will do the whole work for you to use layers in pdf with pdf sdk.

ByteScout provides the free trial version of ByteScout PDF Suite along with the documentation and source code samples.

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

##### ****Layers.vbs:**
    
```
' This example demonstrates how to add layers with optional content.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set canvas = page1.Canvas

' Add main layer
Set allContents = comHelpers.CreateLayer("Main Layer")
canvas.BeginMarkedContent(allContents)

' Add sub-layer
Set layer1 = comHelpers.CreateLayer("Square")
canvas.BeginMarkedContent(layer1)
canvas.DrawRectangle_2 comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(0, 255, 0)), 20, 20, 100, 100
canvas.EndMarkedContent()

' Add second sub-layer
Set layer2 = comHelpers.CreateLayer("Circle")
canvas.BeginMarkedContent(layer2)
canvas.DrawCircle_2 comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(255, 0, 0)), 70, 180, 50
canvas.EndMarkedContent()

' Add third sub-layer
Set layer3 = comHelpers.CreateLayer("Triangle")
canvas.BeginMarkedContent(layer3)
Set pointsArray = comHelpers.CreatePointsArray(Array(Array(20, 340), Array(70, 240), Array(120, 340)))
canvas.DrawPolygon_2 comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(0, 0, 255)), (pointsArray)
canvas.EndMarkedContent()

canvas.EndMarkedContent()

pdfDocument.OptionalContents.Layers.Add(layer1)
pdfDocument.OptionalContents.Layers.Add(layer2)
pdfDocument.OptionalContents.Layers.Add(layer3)
pdfDocument.OptionalContents.Layers.Add(allContents)

' Configure layers

' Group sub-layers
Set group = comHelpers.CreateOptionalContentGroup()
group.Add(comHelpers.CreateOptionalContentGroupLayer((layer1)))
group.Add(comHelpers.CreateOptionalContentGroupLayer((layer2)))
group.Add(comHelpers.CreateOptionalContentGroupLayer((layer3)))

' Order sub-layers
pdfDocument.OptionalContents.Configuration.Order.Add(comHelpers.CreateOptionalContentGroupLayer((allContents)))
pdfDocument.OptionalContents.Configuration.Order.Add(group)

' Make the third layer invisible by default (for example)
pdfDocument.OptionalContents.Configuration.OFF.Add(layer3)

' Force the PDF viewer to show the layers panel initially
pdfDocument.PageMode = comHelpers.PAGEMODE_OPTIONALCONTENT

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->