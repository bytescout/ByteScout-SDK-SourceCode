## How to remove text from pdf with pdf extractor sdk in VBScript using ByteScout PDF Suite

### If you want to learn more then this tutorial will show how to remove text from pdf with pdf extractor sdk in VBScript

ByteScout simple and easy to understand tutorials are planned to describe the code for both VBScript beginners and advanced programmers. ByteScout PDF Suite can remove text from pdf with pdf extractor sdk. It can be applied from VBScript. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

The following code snippet for ByteScout PDF Suite works best when you need to quickly remove text from pdf with pdf extractor sdk in your VBScript application. Just copy and paste the code into your VBScript application’s code and follow the instructions. Complete and detailed tutorials and documentation are available along with installed ByteScout PDF Suite if you'd like to learn more about the topic and the details of the API.

ByteScout PDF Suite free trial version is available on our website. VBScript and other programming languages are supported.

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

##### ****RemoveText.vbs:**
    
```
' Create Bytescout.PDFExtractor.CSVExtractor object
Set remover = CreateObject("Bytescout.PDFExtractor.Remover")
remover.RegistrationName = "demo"
remover.RegistrationKey = "demo"

' Load sample PDF document
remover.LoadDocumentFromFile "../../sample1.pdf"

' Remove text "LOREM IPSUM" and save edited document as "result1.pdf".
' NOTE: The removed text might be larger than the search string. Currently the Remover deletes 
' the whole PDF text object containing the search string.
remover.RemoveText 0, "LOREM IPSUM", True, "result.pdf"
        
WScript.Echo "Modified document saved as 'result.pdf' file."
```

<!-- code block end -->