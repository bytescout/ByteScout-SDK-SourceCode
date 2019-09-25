## How to find hyphenated text in pdf with pdf extractor sdk in VBScript with ByteScout Data Extraction Suite

### Step-by-step tutorial on how to find hyphenated text in pdf with pdf extractor sdk in VBScript

These sample source codes on this page below are displaying how to find hyphenated text in pdf with pdf extractor sdk in VBScript. ByteScout Data Extraction Suite: the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK. It can find hyphenated text in pdf with pdf extractor sdk in VBScript.

Want to quickly learn? This fast application programming interfaces of ByteScout Data Extraction Suite for VBScript plus the guidelines and the code below will help you quickly learn how to find hyphenated text in pdf with pdf extractor sdk. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Use of ByteScout Data Extraction Suite in VBScript is also described in the documentation included along with the product.

The trial version of ByteScout Data Extraction Suite can be downloaded for free from our website. It also includes source code samples for VBScript and other programming languages.

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

##### ****FindTextAndGetCoordinates.vbs:**
    
```
' Create Bytescout.PDFExtractor.TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\words-with-hyphens.pdf")

' Set the matching mode:
' 0 = WordMatchingMode.None - treats the search string as substring;
' 1 = WordMatchingMode.SmartMatch - will find the word in various forms (like Adobe Reader);
' 2 = WordMatchingMode.ExactMatch - treats the search string as separate word.
extractor.WordMatchingMode = 1

' Get page count

pageCount = extractor.GetPageCount()

For i = 0 To PageCount - 1 
 
    If extractor.Find(i, "hyphen", false) Then ' parameters are: page index, string to find, case sensitivity.
        Do
            foundMessage = "Found substring 'hyphen' on page #" & CStr(i) & " at { " & _
                "x = " & CStr(extractor.FoundText.Left) & "; " & _
                "y = " & CStr(extractor.FoundText.Top) & "; " & _
                "width = " & CStr(extractor.FoundText.Width) & "; " & _
                "height = " & CStr(extractor.FoundText.Height) & " }"

            elementInfo = ""

            ' Iterate through elements of the found text object
            For j = 0 to extractor.FoundText.ElementCount - 1
                Set element = extractor.FoundText.GetElement(j)	
                elementInfo = elementInfo & "Element #" & CStr(j) & " at { x = " & CStr(element.Left) & "; y = " & CStr(element.Top) & "; width = " & CStr(element.Width) & "; height = " & CStr(element.Height) & vbCRLF
                elementInfo = elementInfo & "Text: " & CStr(element.Text) & vbCRLF
                elementInfo = elementInfo & "Font is bold: " & CStr(element.FontIsBold) & vbCRLF
                elementInfo = elementInfo & "Font is italic: " & CStr(element.FontIsItalic) & vbCRLF
                elementInfo = elementInfo & "Font name: " & CStr(element.FontName) & vbCRLF
                elementInfo = elementInfo & "Font size: " & CStr(element.FontSize) & vbCRLF
                elementInfo = elementInfo & "Font color (as OLE_COLOR): " & CStr(element.FontColorAsOleColor) & vbCRLF & vbCRLF
            Next 

            WScript.Echo foundMessage & vbCRLF & vbCRLF & elementInfo

        Loop While extractor.FindNext
        
    End If

Next

WScript.Echo "Done"

Set extractor = Nothing


```

<!-- code block end -->