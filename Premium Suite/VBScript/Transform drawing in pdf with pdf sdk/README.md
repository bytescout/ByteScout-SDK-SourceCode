## transform drawing in pdf with pdf sdk in VBScript with ByteScout Premium Suite

### Learn transform drawing in pdf with pdf sdk in VBScript

ByteScout tutorials describe the stuff for programmers who use VBScript. ByteScout Premium Suite was created to assist transform drawing in pdf with pdf sdk in VBScript. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

 Want to speed up the application development? Then this VBScript, code samples for VBScript, developers help to speed up the application development and writing a code when using ByteScout Premium Suite. If you want to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. These VBScript sample examples can be used in one or many applications.

Trial version along with the source code samples for VBScript can be downloaded from our website

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