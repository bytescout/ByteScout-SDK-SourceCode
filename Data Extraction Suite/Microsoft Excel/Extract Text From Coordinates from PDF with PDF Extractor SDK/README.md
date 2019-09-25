## How to extract text from coordinates from PDF with PDF extractor SDK in Microsoft Excel using ByteScout Data Extraction Suite

### Step-by-step tutorial on how to extract text from coordinates from PDF with PDF extractor SDK in Microsoft Excel

This sample source code below will display you how to extract text from coordinates from PDF with PDF extractor SDK in Microsoft Excel. ByteScout Data Extraction Suite: the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK. It can extract text from coordinates from PDF with PDF extractor SDK in Microsoft Excel.

Want to quickly learn? This fast application programming interfaces of ByteScout Data Extraction Suite for Microsoft Excel plus the guidelines and the code below will help you quickly learn how to extract text from coordinates from PDF with PDF extractor SDK. This Microsoft Excel sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Enjoy writing a code with ready-to-use sample Microsoft Excel codes.

You can download free trial version of ByteScout Data Extraction Suite from our website to see and try many others source code samples for Microsoft Excel.

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

##### ****ExtractTextFromPDF_VBA.txt:**
    
```
' IMPORTANT: This demo uses VBA so if you have it disabled please temporary enable
' by going to Tools - Macro - Security.. and changing the security mode to ""Medium""
' to Ask if you want enable macro or not. Then close and reopen this Excel document

' You should have evaluation version of the ByteScout SDK installed to get it working - get it from https://bytescout.com

' If you are getting error message like
' "File or assembly named Bytescout SDK, or one of its dependencies, was not found"
' then please try the following:
'
' - Close Excel
' - (for Office 2003 only) download and install this hotfix from Microsoft:
' http://www.microsoft.com/downloads/details.aspx?FamilyId=1B0BFB35-C252-43CC-8A2A-6A64D6AC4670&displaylang=en
'
' and then try again!
'
' If you have any questions please contact us at http://bytescout.com/support/ or at support@bytescout.com
                            

'==============================================
'References used
'=================
'Bytescout PDF Extractor SDK
'
' IMPORTANT:
' ==============================================================
'1) Add the ActiveX reference in Tools -> References
'
'==================================================================


Private Sub CommandButton1_Click()

' Create TextExtractor object
' Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
Dim extractor As New Bytescout_PDFExtractor.TextExtractor

extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile ("c:\sample1.pdf")

' Get page count
pageCount = extractor.GetPageCount()

Dim wb As Workbook
Dim ws As Worksheet
Dim TxtRng  As Range

Set wb = ActiveWorkbook
Set ws = wb.Sheets("Sheet1")

For i = 0 To pageCount - 1
            RectLeft = 10
            RectTop = 10
            RectWidth = 100
            RectHeight = 100

            ' check the same text is extracted from returned coordinates
            extractor.SetExtractionArea RectLeft, RectTop, RectWidth, RectHeight
            ' extract text from given area
            extractedText = extractor.GetTextFromPage(i)
                    
            ' insert rows
            ' Rows(1).Insert shift:=xlShiftDown
            ' write cell value
             Set TxtRng = ws.Range("A" & CStr(i + 2))
             TxtRng.Value = extractedText
    
Next

Set extractor = Nothing


End Sub

```

<!-- code block end -->