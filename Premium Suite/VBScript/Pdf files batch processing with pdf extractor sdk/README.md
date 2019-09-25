## pdf files batch processing with pdf extractor sdk in VBScript and ByteScout Premium Suite

### pdf files batch processing with pdf extractor sdk in VBScript

These sample source codes given below will show you how to handle a complex task, for example, pdf files batch processing with pdf extractor sdk in VBScript. ByteScout Premium Suite was created to assist pdf files batch processing with pdf extractor sdk in VBScript. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

Save time on writing and testing code by using the code below and use it in your application. If you want to know how it works, then this VBScript sample code should be copied and pasted into your application’s code editor. Then just compile and run it. This basic programming language sample code for VBScript will do the whole work for you in implementing pdf files batch processing with pdf extractor sdk in your app.

Trial version along with the source code samples for VBScript can be downloaded from our website

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