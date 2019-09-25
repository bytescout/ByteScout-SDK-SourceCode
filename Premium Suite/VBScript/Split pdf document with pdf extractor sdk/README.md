## How to split pdf document with pdf extractor sdk in VBScript using ByteScout Premium Suite

### Learn to split pdf document with pdf extractor sdk in VBScript

The documentation is designed for a specific purpose to help you to apply the features on your side. What is ByteScout Premium Suite? It is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can help you to split pdf document with pdf extractor sdk in your VBScript application.

The following code snippet for ByteScout Premium Suite works best when you need to quickly split pdf document with pdf extractor sdk in your VBScript application. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Enjoy writing a code with ready-to-use sample codes in VBScript.

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