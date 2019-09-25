## How to index pdf files with pdf extractor sdk in VBScript with ByteScout PDF Suite

### Learn to index pdf files with pdf extractor sdk in VBScript

Source code documentation samples give simple and easy method to install a needed feature into your application. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can be applied to index pdf files with pdf extractor sdk using VBScript.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout PDF Suite for index pdf files with pdf extractor sdk below and use it in your application. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Want to see how it works with your data then code testing will allow the function to be tested and work properly.

Our website gives trial version of ByteScout PDF Suite for free. It also includes documentation and source code samples.

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