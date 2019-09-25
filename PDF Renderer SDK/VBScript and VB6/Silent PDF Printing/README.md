## silent PDF printing in VBScript and VB6 and ByteScout PDF Renderer SDK

### Tutorial: how to do silent PDF printing in VBScript and VB6

ByteScout tutorials explain the material for programmers who use VBScript and VB6. ByteScout PDF Renderer SDK was made to help with silent PDF printing in VBScript and VB6. ByteScout PDF Renderer SDK is the software development kit for rendering of PDF files into high quality images or thumbnails. Various functions are included as well: batch processing, PNG, TIFF output, selection area to render, layers management to render text or images or vectors only. Designed for use from web, desktop and middleware applications.

You will save a lot of time on writing and testing code as you may just take the code below and use it in your application. To do silent PDF printing in your VBScript and VB6 project or application you may simply copy & paste the code and then run your app! You can use these VBScript and VB6 sample examples in one or many applications.

ByteScout PDF Renderer SDK free trial version is available for download from our website. Free trial also includes programming tutorials along with source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Renderer%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Renderer%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=eenhl7106lA](https://www.youtube.com/watch?v=eenhl7106lA)




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