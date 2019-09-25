## silent pdf printing with pdf renderer sdk in VBScript with ByteScout Premium Suite

### How to apply ByteScout Premium Suite for silent pdf printing with pdf renderer sdk in VBScript

This page explains the steps and algorithm of implementing silent pdf printing with pdf renderer sdk and how to make it work in your application. ByteScout Premium Suite helps with silent pdf printing with pdf renderer sdk in VBScript. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

VBScript code snippet like this for ByteScout Premium Suite works best when you need to quickly implement silent pdf printing with pdf renderer sdk in your VBScript application. If you want to know how it works, then this VBScript sample code should be copied and pasted into your application’s code editor. Then just compile and run it. Enjoy writing a code with ready-to-use sample VBScript codes to add silent pdf printing with pdf renderer sdk functions using ByteScout Premium Suite in VBScript.

Visit our website to get a free trial version of ByteScout Premium Suite. Free trial contains many of source code samples to help you with your VBScript project.

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

##### ****Silent Printing.vbs:**
    
```
' Create Bytescout.PDFRenderer.DocumentPrinter object
Set documentPrinter = CreateObject("Bytescout.PDFRenderer.DocumentPrinter")
documentPrinter.RegistrationName = "demo"
documentPrinter.RegistrationKey = "demo"

' Load sample PDF document
documentPrinter.LoadDocumentFromFile "../../multipage.pdf"

' Change some printing options for demo purposes 
' (note, some options might be not supported by the printer):

' Change paper orientation
documentPrinter.Landscape = True
' Set number of copies
documentPrinter.Copies = 2
' Set collation
documentPrinter.Collate = True
' Force black and white printing
documentPrinter.Color = false

' Print all document pages to "Microsoft Print to PDF"
documentPrinter.PrintDocument "Microsoft Print to PDF"

' To print specific pages use other procedures with parameters allowing to define pages to print:
' documentPrinter.PrintDocument_2 "Microsoft Print to PDF", "1,3-5,7-"
' documentPrinter.PrintDocument_3 "Microsoft Print to PDF", 2, 4

```

<!-- code block end -->