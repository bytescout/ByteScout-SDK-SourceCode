'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' Create Bytescout.PDFExtractor.ImageExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.ImageExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("sample1.pdf")

' Get page count
pageCount = extractor.GetPageCount()
        
' Extract images from each page
For i = 0 To pageCount - 1
    j = 0
    ' Initialize page images enumeration
    If extractor.GetFirstPageImage(i) Then
        Do
            outputFileName = "page" & i & "image" & j & ".png"
            ' display coordinates of the image
            MsgBox "Image #" & CStr(j) & " on page #" & CStr(i) & vbCRLF & "Coordinates: " & _
                CStr( extractor.GetCurrentImageRectangle_Left()) & ", " & CStr( extractor.GetCurrentImageRectangle_Top()) & ", " & _
                CStr( extractor.GetCurrentImageRectangle_Width()) & ", " & CStr( extractor.GetCurrentImageRectangle_Height())
            j = j + 1
        Loop While extractor.GetNextImage() ' Advance image enumeration
    End If
Next

Set extractor = Nothing

