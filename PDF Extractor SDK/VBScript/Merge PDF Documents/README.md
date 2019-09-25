## How to merge PDF documents in VBScript and ByteScout PDF Extractor SDK

### The tutorial shows how to merge PDF documents in VBScript

This sample source code below will demonstrate you how to merge PDF documents in VBScript. ByteScout PDF Extractor SDK can merge PDF documents. It can be used from VBScript. ByteScout PDF Extractor SDK is the Software Development Kit (SDK) that is designed to help developers with data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker.

This code snippet below for ByteScout PDF Extractor SDK works best when you need to quickly merge PDF documents in your VBScript application. Follow the instructions from the scratch to work and copy the VBScript code. Test VBScript sample code examples whether they respond your needs and requirements for the project.

ByteScout free trial version is available for download from our website. It includes all these programming tutorials along with source code samples.

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

##### ****MergeDocuments.vbs:**
    
```
' Create Bytescout.PDFExtractor.DocumentMerger object
Set merger = CreateObject("Bytescout.PDFExtractor.DocumentMerger")
merger.RegistrationName = "demo"
merger.RegistrationKey = "demo"

merger.Merge2 "..\..\sample1.pdf", "..\..\sample2.pdf", "result.pdf"
                
Set merger = Nothing

WScript.Echo "Merged document saved as 'result.pdf'."
```

<!-- code block end -->