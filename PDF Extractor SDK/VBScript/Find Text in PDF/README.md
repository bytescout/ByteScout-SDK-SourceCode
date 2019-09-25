## How to find text in PDF in VBScript and ByteScout PDF Extractor SDK

### How to find text in PDF in VBScript

These sample source codes on this page below are demonstrating how to find text in PDF in VBScript. ByteScout PDF Extractor SDK is the SDK is designed to help developers with pdf tables and pdf data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker and other utilities. It can be used to find text in PDF using VBScript.

You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout PDF Extractor SDK for find text in PDF below and use it in your application. In your VBScript project or application you may simply copy & paste the code and then run your app! Enjoy writing a code with ready-to-use sample codes in VBScript.

Trial version of ByteScout PDF Extractor SDK can be downloaded for free from our website. It also includes source code samples for VBScript and other programming languages.

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

##### ****FindTextAndGetCoordinates.vbs:**
    
```
' Create Bytescout.PDFExtractor.TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\sample1.pdf")

' Set the matching mode:
' 0 = WordMatchingMode.None - treats the search string as substring;
' 1 = WordMatchingMode.SmartMatch - will find the word in various forms (like Adobe Reader);
' 2 = WordMatchingMode.ExactMatch - treats the search string as separate word.
extractor.WordMatchingMode = 2

' Get page count

pageCount = extractor.GetPageCount()

For i = 0 To PageCount - 1 
 
    If extractor.Find(i, "ipsum", false) Then ' parameters are: page index, string to find, case sensitivity.
        Do
            foundMessage = "Found word 'ipsum' on page #" & CStr(i) & " at { " & _
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