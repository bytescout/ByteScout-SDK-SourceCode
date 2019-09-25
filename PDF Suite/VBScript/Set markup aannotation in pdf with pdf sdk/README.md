## How to set markup aannotation in pdf with pdf sdk in VBScript using ByteScout PDF Suite

### Step-by-step tutorial on how to set markup aannotation in pdf with pdf sdk in VBScript

The sample shows instructions and algorithm of how to set markup aannotation in pdf with pdf sdk and how to make it run in your VBScript application. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript and you can use it to set markup aannotation in pdf with pdf sdk with VBScript.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout PDF Suite for set markup aannotation in pdf with pdf sdk below and use it in your application. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Complete and detailed tutorials and documentation are available along with installed ByteScout PDF Suite if you'd like to learn more about the topic and the details of the API.

Trial version of ByteScout PDF Suite is available for free. Source code samples are included to help you with your VBScript app.

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

##### ****MarkupAnnotation.vbs:**
    
```
' This example demonstrates how to add markup annotations.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Draw sample markup annotations

Set squareAnnotation = comHelpers.CreateSquareAnnotation(20, 20, 80, 80)
squareAnnotation.BackgroundColor = comHelpers.CreateColorRGB(255, 240, 240)
squareAnnotation.BorderStyle.Style = comHelpers.BORDERSTYLE_DASHED
squareAnnotation.BorderStyle.DashPattern = comHelpers.CreateDashPattern(Array(3.0, 1.0, 3.0), 0)
page1.Annotations.Add(squareAnnotation)

Set circleAnnotation = comHelpers.CreateCircleAnnotation(120, 20, 80, 80)
circleAnnotation.BackgroundColor = comHelpers.CreateColorRGB(240, 250, 240)
circleAnnotation.Color = comHelpers.CreateColorRGB(128, 0, 128)
circleAnnotation.BorderEffect.Effect = comHelpers.BORDEREFFECT_CLOUDY
circleAnnotation.BorderEffect.Intensity = 2
page1.Annotations.Add(circleAnnotation)

Set lineAnnotation = comHelpers.CreateLineAnnotation(20, 180, 100, 120)
lineAnnotation.Color = comHelpers.CreateColorRGB(255, 0, 0)
lineAnnotation.StartLineStyle = comHelpers.LINEENDINGSTYLE_BUTT
lineAnnotation.EndLineStyle = comHelpers.LINEENDINGSTYLE_OPENARROW
page1.Annotations.Add(lineAnnotation)

Set pointsArray = comHelpers.CreatePointsArray(Array(Array(120, 120), Array(130, 130), Array(140, 120), Array(150, 130), Array(160, 120), Array(170, 130)))
Set polylineAnnotation = comHelpers.CreatePolylineAnnotation((pointsArray))
polylineAnnotation.BorderStyle.Width = 2
page1.Annotations.Add(polylineAnnotation)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->