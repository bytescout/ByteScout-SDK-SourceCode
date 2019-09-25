## How to extract text by columns from pdf with pdf extractor sdk in VBScript with ByteScout Premium Suite

### How to write a robust code in VBScript to extract text by columns from pdf with pdf extractor sdk with this step-by-step tutorial

An easy to understand sample source code to learn how to extract text by columns from pdf with pdf extractor sdk in VBScript ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can be applied to extract text by columns from pdf with pdf extractor sdk using VBScript.

Want to quickly learn? This fast application programming interfaces of ByteScout Premium Suite for VBScript plus the guidelines and the code below will help you quickly learn how to extract text by columns from pdf with pdf extractor sdk. Follow the instructions from scratch to work and copy the VBScript code. If you want to use these VBScript sample examples in one or many applications then they can be used easily.

You can download free trial version of ByteScout Premium Suite from our website with this and other source code samples for VBScript.

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

##### ****ExtractTextByColumns.vbs:**
    
```
' Create Bytescout.PDFExtractor.TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\columns.pdf")

' Set the column layout mode
extractor.ExtractColumnByColumn = true

' Save extracted text to file
extractor.SaveTextToFile("result.txt")

' Open output file in default associated application
Set shell = CreateObject("WScript.Shell")
shell.Run "result.txt", 1, false
Set shell = Nothing

Set extractor = Nothing


```

<!-- code block end -->