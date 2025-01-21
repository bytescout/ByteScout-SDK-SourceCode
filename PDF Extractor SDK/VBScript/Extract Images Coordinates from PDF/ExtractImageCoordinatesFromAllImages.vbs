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

i = 0

' Initialize image enumeration
If extractor.GetFirstImage() Then
    Do
        ' display coordinates of the image
        MsgBox "Image #" & CStr(i) & vbCRLF & "Coordinates: " & CStr( extractor.GetCurrentImageRectangle_Left()) & ", " & _
            CStr( extractor.GetCurrentImageRectangle_Top()) & ", " & CStr( extractor.GetCurrentImageRectangle_Width()) & ", " & _
            CStr( extractor.GetCurrentImageRectangle_Height())
        i = i + 1
    Loop While extractor.GetNextImage() ' Advance image enumeration
End If

Set extractor = Nothing

