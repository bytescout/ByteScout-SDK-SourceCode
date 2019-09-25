## How to index PDF files in VBScript using ByteScout PDF Extractor SDK

### This code in VBScript shows how to index PDF files with this how to tutorial

Every ByteScout tool contains example VBScript source codes that you can find here or in the folder with installed ByteScout product. ByteScout PDF Extractor SDK can index PDF files. It can be used from VBScript. ByteScout PDF Extractor SDK is the Software Development Kit (SDK) that is designed to help developers with data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker.

VBScript code samples for VBScript developers help to speed up coding of your application when using ByteScout PDF Extractor SDK. In order to implement the functionality, you should copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Detailed tutorials and documentation are available along with installed ByteScout PDF Extractor SDK if you'd like to dive deeper into the topic and the details of the API.

Free trial version of ByteScout PDF Extractor SDK is available for download from our website. Get it to try other source code samples for VBScript.

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

##### ****Index PDF Files.vbs:**
    
```
' Create Bytescout.PDFExtractor.InfoExtractor object
Set infoExtractor = CreateObject("Bytescout.PDFExtractor.InfoExtractor")
infoExtractor.RegistrationName = "demo"
infoExtractor.RegistrationKey = "demo"

' Create Bytescout.PDFExtractor.TextExtractor object
Set textExtractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
textExtractor.RegistrationName = "demo"
textExtractor.RegistrationKey = "demo"

' Create File System object
Set FSO = CreateObject("Scripting.FileSystemObject")

' Get folder object
Set objFolder = FSO.GetFolder("..\..")
' Get file list
Set files = objFolder.Files

' Create output file
Set textFile = FSO.CreateTextFile("output.txt", True, True)

For Each file in files
    
    ext = UCase(FSO.GetExtensionName(file))	
    If ext = "PDF" Then
        
        infoExtractor.LoadDocumentFromFile(file)    
        textFile.WriteLine("File Name:    " & FSO.GetFileName(file))
        textFile.WriteLine("Page Count:   " & infoExtractor.GetPageCount())
        textFile.WriteLine("Author:       " & infoExtractor.Author)
        textFile.WriteLine("Title:        " & infoExtractor.Title)
        textFile.WriteLine("Producer:     " & infoExtractor.Producer)
        textFile.WriteLine("Subject:      " & infoExtractor.Subject)
        textFile.WriteLine("CreationDate: " & infoExtractor.CreationDate)
                
        textExtractor.LoadDocumentFromFile(file)
        text = textExtractor.GetTextFromPage(0)
        
        If len(text) > 0 Then
            textFile.WriteLine("Text (first 200 chars): ")
            textFile.WriteLine(Mid(text, 1, 200))
        End If
        
        textFile.WriteBlankLines(2)
    End If 
    
Next

textFile.Close

Set infoExtractor = Nothing
Set textExtractor = Nothing
Set FSO = Nothing

WScript.Echo "Done."
```

<!-- code block end -->