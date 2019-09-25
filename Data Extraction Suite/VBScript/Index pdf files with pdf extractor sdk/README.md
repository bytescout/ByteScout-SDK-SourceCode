## How to index pdf files with pdf extractor sdk in VBScript using ByteScout Data Extraction Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to index pdf files with pdf extractor sdk in VBScript

Sample source code below will display you how to manage a complex task like index pdf files with pdf extractor sdk in VBScript. ByteScout Data Extraction Suite is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK. It can be applied to index pdf files with pdf extractor sdk using VBScript.

Want to quickly learn? This fast application programming interfaces of ByteScout Data Extraction Suite for VBScript plus the guidelines and the code below will help you quickly learn how to index pdf files with pdf extractor sdk. Just copy and paste the code into your VBScript application’s code and follow the instructions. Enjoy writing a code with ready-to-use sample VBScript codes.

ByteScout provides the free trial version of ByteScout Data Extraction Suite along with the documentation and source code samples.

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