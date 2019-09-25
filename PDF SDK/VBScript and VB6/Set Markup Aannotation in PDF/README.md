## How to set markup aannotation in PDF in VBScript and VB6 using ByteScout PDF SDK

### The tutorial below will demonstrate how to set markup aannotation in PDF in VBScript and VB6

With this source code sample you may quickly learn how to set markup aannotation in PDF in VBScript and VB6. ByteScout PDF SDK is the component to help programmers in generating new pdf files, modifying and updating existing pdf documents or pdf forms. Provides support for auto-filling pdf forms, adding text with adjustable font, style, size, font family, new form fields, vector and raster drawings and you can use it to set markup aannotation in PDF with VBScript and VB6.

The SDK samples like this one below explain how to quickly make your application do set markup aannotation in PDF in VBScript and VB6 with the help of ByteScout PDF SDK. This VBScript and VB6 sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! This basic programming language sample code for VBScript and VB6 will do the whole work for you to set markup aannotation in PDF.

Free trial version of ByteScout PDF SDK is available for download from our website. Get it to try other source code samples for VBScript and VB6.

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