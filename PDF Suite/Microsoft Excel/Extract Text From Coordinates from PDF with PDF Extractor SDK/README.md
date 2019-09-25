## How to extract text from coordinates from PDF with PDF extractor SDK in Microsoft Excel using ByteScout PDF Suite

### Learn to extract text from coordinates from PDF with PDF extractor SDK in Microsoft Excel

An easy to understand guide on how to extract text from coordinates from PDF with PDF extractor SDK in Microsoft Excel with this source code sample. ByteScout PDF Suite can extract text from coordinates from PDF with PDF extractor SDK. It can be applied from Microsoft Excel. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

Want to quickly learn? This fast application programming interfaces of ByteScout PDF Suite for Microsoft Excel plus the guidelines and the code below will help you quickly learn how to extract text from coordinates from PDF with PDF extractor SDK. Follow the instructions from scratch to work and copy the Microsoft Excel code. Enjoy writing a code with ready-to-use sample Microsoft Excel codes.

The trial version of ByteScout PDF Suite can be downloaded for free from our website. It also includes source code samples for Microsoft Excel and other programming languages.

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