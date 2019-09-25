## How to set markup aannotation in pdf with pdf sdk in VBScript and ByteScout Premium Suite

### Learn to set markup aannotation in pdf with pdf sdk in VBScript

The documentation is designed for a specific purpose to help you to apply the features on your side. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can be applied to set markup aannotation in pdf with pdf sdk using VBScript.

The following code snippet for ByteScout Premium Suite works best when you need to quickly set markup aannotation in pdf with pdf sdk in your VBScript application. Just copy and paste the code into your VBScript application’s code and follow the instructions. Complete and detailed tutorials and documentation are available along with installed ByteScout Premium Suite if you'd like to learn more about the topic and the details of the API.

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