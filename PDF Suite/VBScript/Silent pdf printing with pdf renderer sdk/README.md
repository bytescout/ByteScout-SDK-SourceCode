## silent pdf printing with pdf renderer sdk in VBScript with ByteScout PDF Suite

### How to apply ByteScout PDF Suite for silent pdf printing with pdf renderer sdk in VBScript

The samples of source code documentation give a quick and simple method to apply a required functionality into your application. ByteScout PDF Suite was made to help with silent pdf printing with pdf renderer sdk in VBScript. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

This rich and prolific sample source code in VBScript for ByteScout PDF Suite contains various functions and options you should do calling the API to implement silent pdf printing with pdf renderer sdk.  Just copy and paste this VBScript sample code to your VBScript application's code editor, add a reference to ByteScout PDF Suite (if you haven't added yet) and you are ready to go! These VBScript sample examples can be used in one or many applications.

ByteScout PDF Suite free trial version is available for download from our website. Free trial also includes programming tutorials along with source code samples.

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