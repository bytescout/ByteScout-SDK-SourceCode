## How to split pdf document with pdf extractor sdk in VBScript and ByteScout PDF Suite

### If you want to learn more then this tutorial will show how to split pdf document with pdf extractor sdk in VBScript

An easy to understand guide on how to split pdf document with pdf extractor sdk in VBScript with this source code sample. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can split pdf document with pdf extractor sdk in VBScript.

The following code snippet for ByteScout PDF Suite works best when you need to quickly split pdf document with pdf extractor sdk in your VBScript application. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Enjoy writing a code with ready-to-use sample codes in VBScript.

If you want to try other source code samples then the free trial version of ByteScout PDF Suite is available for download from our website. Just try other source code samples for VBScript.

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

##### ****SplitPdf.vbs:**
    
```
' Create Bytescout.PDFExtractor.DocumentSplitter object
Set splitter = CreateObject("Bytescout.PDFExtractor.DocumentSplitter")
splitter.RegistrationName = "demo"
splitter.RegistrationKey = "demo"

inputFile = "..\..\sample2.pdf"

' Enable splitted parts optimization (remove unused resources)
splitter.OptimizeSplittedDocuments = true


' Extract a single page:
' ======================

splitter.ExtractPage inputFile, "page3.pdf", 3 ' (!) Note: page number is 1-based.
                
WScript.Echo "Extracted page #3 to file 'page3.pdf'."


' Split in two parts:
' ===================

splitter.Split inputFile, "part1.pdf", "part2.pdf", 3 ' (!) Note: page number is 1-based.

WScript.Echo "Splitted at page #3 to files 'part1.pdf' and 'part2.pdf'."


' Split by ranges:
' ================

' SplitCOM() returns array with file names. Files are saved to the system temporary directory.
Dim outFiles
outFiles = splitter.SplitCOM(inputFile, "1-3,4-") ' (!) Note: page numbers are 1-based; the ending "-" means "to the end".

Dim fileNames
For each of in outFiles
    fileNames = fileNames & of & vbCRLF
Next

WScript.Echo "Splitted by ranges to files: " & vbCRLF & fileNames

```

<!-- code block end -->