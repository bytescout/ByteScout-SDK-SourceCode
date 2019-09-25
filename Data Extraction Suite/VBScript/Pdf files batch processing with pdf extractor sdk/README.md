## pdf files batch processing with pdf extractor sdk in VBScript using ByteScout Data Extraction Suite

### Learn pdf files batch processing with pdf extractor sdk in VBScript

Writing of the code to pdf files batch processing with pdf extractor sdk in VBScript can be done by developers of any level using ByteScout Data Extraction Suite. ByteScout Data Extraction Suite was made to help with pdf files batch processing with pdf extractor sdk in VBScript. ByteScout Data Extraction Suite is the set that includes 3 SDK products for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK.

The below SDK samples describe how to quickly make your application do pdf files batch processing with pdf extractor sdk in VBScript with the help of ByteScout Data Extraction Suite. Follow the steps-by-step instructions from the scratch to work and copy and paste code for VBScript into your editor. Updated and detailed documentation and tutorials are available along with installed ByteScout Data Extraction Suite if you'd like to learn more about the topic and the details of the API.

On our website you may get trial version of ByteScout Data Extraction Suite for free. Source code samples are included to help you with your VBScript application.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Data%20Extraction%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Data%20Extraction%20Suite%20Question) 

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