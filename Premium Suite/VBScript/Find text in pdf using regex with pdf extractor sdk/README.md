## How to find text in pdf using regex with pdf extractor sdk in VBScript and ByteScout Premium Suite

### If you want to learn more then this tutorial will show how to find text in pdf using regex with pdf extractor sdk in VBScript

The code displayed below will guide you to install an VBScript app to find text in pdf using regex with pdf extractor sdk. ByteScout Premium Suite can find text in pdf using regex with pdf extractor sdk. It can be applied from VBScript. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

Want to quickly learn? This fast application programming interfaces of ByteScout Premium Suite for VBScript plus the guidelines and the code below will help you quickly learn how to find text in pdf using regex with pdf extractor sdk.  Simply copy and paste in your VBScript project or application you and then run your app! Applying VBScript application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

The trial version of ByteScout Premium Suite can be downloaded for free from our website. It also includes source code samples for VBScript and other programming languages.

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

##### ****FindTextUsingRegex.vbs:**
    
```
' Create Bytescout.PDFExtractor.TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\Invoice.pdf")

extractor.RegexSearch = True ' Turn on the regex search
pattern = "[0-9]{2}/[0-9]{2}/[0-9]{4}" ' Search dates in format 'mm/dd/yyyy'

' Get page count
pageCount = extractor.GetPageCount()

For i = 0 to PageCount - 1 
    If extractor.Find(i, pattern, false) Then ' Parameters are: page index, string to find, case sensitivity
        Do
            extractedString = extractor.FoundText.Text
            MsgBox "Found match on page #" & CStr(i) & ": " & extractedString
            extractor.ResetExtractionArea()
        Loop While extractor.FindNext
    End If
Next

MsgBox "Done"

Set extractor = Nothing

```

<!-- code block end -->