## How to convert PDF to black and white excluding some page in VBScript with ByteScout PDF Extractor SDK ByteScout PDF Extractor SDK is the Software Development Kit (SDK) that is designed to help developers with data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Extractor%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Extractor%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore Documentation](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Explore Source Code Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://app.pdf.co/signup?utm_source=github-readme)
[Security](https://pdf.co/security)
[Explore Web API Documentation](https://apidocs.pdf.co?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=s28W3_KMraU](https://www.youtube.com/watch?v=s28W3_KMraU)




<!-- code block begin -->

##### **MakePDFBlackAndWhiteExcludingSomePage.vbs:**
    
```
' Create Bytescout.PDFExtractor.UnsearchablePDFMaker object
Set unsearchablePDFMaker = CreateObject("Bytescout.PDFExtractor.UnsearchablePDFMaker")
unsearchablePDFMaker.RegistrationName = "demo"
unsearchablePDFMaker.RegistrationKey = "demo"

' Load sample PDF document
unsearchablePDFMaker.LoadDocumentFromFile("sample1.pdf")

' Larger resolution - longer processing and larger PDF file size
unsearchablePDFMaker.RenderingResolution = 300

' Enable Black and White mode
unsearchablePDFMaker.Grayscale = true

' Enable skipping black and white conversation of pages in range
unsearchablePDFMaker.KeepSkippedPages = true

' Second parameter to metohd prepresents "ranges" parameter
' "ranges" param is comma-separated list of page ranges in form "1-4,5,7,8-15,16-". 
' Pages covered by it will be converted to Black and White.
' Page numbers are 1-based. Ending "-" means "to the last page".
' You can also use inverted page numbers adding '!' before the number. E.g. "!1" means "the last page", 
' "2-!2" means "from the second to the penultimate page", "!2-" - last two pages
unsearchablePDFMaker.MakePDFUnsearchable_2 "result.pdf", "1"

WScript.Echo "Unsearchable document saved as 'result.pdf'."
```

<!-- code block end -->