## How to find text in PDF using regex in VBScript with ByteScout PDF Extractor SDK

### This tutorial will show how to find text in PDF using regex in VBScript

The code below will help you to implement an VBScript app to find text in PDF using regex. ByteScout PDF Extractor SDK is the Software Development Kit (SDK) that is designed to help developers with data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker and you can use it to find text in PDF using regex with VBScript.

VBScript code samples for VBScript developers help to speed up coding of your application when using ByteScout PDF Extractor SDK. In your VBScript project or application you may simply copy & paste the code and then run your app! Use of ByteScout PDF Extractor SDK in VBScript is also explained in the documentation included along with the product.

Trial version of ByteScout PDF Extractor SDK is available for free. Source code samples are included to help you with your VBScript app.

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