## pdf files batch processing with pdf extractor sdk in VBScript with ByteScout PDF Suite

### Simple tutorial on how to do pdf files batch processing with pdf extractor sdk in VBScript

The example source codes on this page will display you how to make pdf files batch processing with pdf extractor sdk in VBScript. ByteScout PDF Suite was created to assist pdf files batch processing with pdf extractor sdk in VBScript. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

 Want to speed up the application development? Then this VBScript, code samples for VBScript, developers help to speed up the application development and writing a code when using ByteScout PDF Suite. If you want to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Enjoy writing a code with ready-to-use sample VBScript codes to add pdf files batch processing with pdf extractor sdk functions using ByteScout PDF Suite in VBScript.

Trial version along with the source code samples for VBScript can be downloaded from our website

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

##### ****BatchProcessing.vbs:**
    
```
' Create Bytescout.PDFExtractor.TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Get all files in folder
Set objFSO = CreateObject("Scripting.FileSystemObject")
Set objFolder = objFSO.GetFolder("..\..")
Set colFiles = objFolder.Files

' Convert every PDF file to text 
For Each objFile In colFiles
    if objFSO.GetExtensionName(objFile) = "pdf" Then
        ' Load PDF file
        extractor.LoadDocumentFromFile objFile.Path
        ' Save extracted text to .txt file
        extractor.SaveTextToFile Replace(objFile.Name, "." & objFSO.GetExtensionName(objFile),".txt")
        ' Reset the extractor before load another file
        extractor.Reset
    End If
Next

```

<!-- code block end -->