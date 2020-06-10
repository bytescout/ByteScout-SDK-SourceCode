## PDF to scanned PDF in VBScript and ByteScout PDF Extractor SDK ByteScout PDF Extractor SDK: the Software Development Kit (SDK) that is designed to help developers with data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Extractor%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Extractor%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=s28W3_KMraU](https://www.youtube.com/watch?v=s28W3_KMraU)




<!-- code block begin -->

##### **PDFtoScannedPDF.vbs:**
    
```
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'' This sample demonstrates convrting PDF to Scanned PDF ''
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

' Create Bytescout.PDFExtractor.UnsearchablePDFMaker object
Set unsearchablePDFMaker = CreateObject("Bytescout.PDFExtractor.UnsearchablePDFMaker")
unsearchablePDFMaker.RegistrationName = "demo"
unsearchablePDFMaker.RegistrationKey = "demo"

' Load sample PDF document
unsearchablePDFMaker.LoadDocumentFromFile("..\..\sample1.pdf")

' Set PDF rendering resolution to 150 DPI. Higher value - better quality, but larger output file.
unsearchablePDFMaker.RenderingResolution = 150

' Set embedded images format
unsearchablePDFMaker.ImageFormat = 0 ' JPEG = 0; PNG = 1

' Set quality factor for JPEG format; from 0 to 100; default is 90.
' Lower quality - smaller the result file.
unsearchablePDFMaker.JPEGQuality = 60

' Process the document
unsearchablePDFMaker.MakePDFUnsearchable("result.pdf")

WScript.Echo "Unsearchable document saved as 'result.pdf'."
```

<!-- code block end -->